using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Core.Entidades.Public;
using Servicios_Zeus.Dtos;
using Core.Interfaces.Public;
using System.Security.Cryptography;
using Core.Dtos.Public;

namespace Infraestructure.Repository.Public
{

    public class UserLoginRepository : IUserLoginRepository
    {

        private readonly JWT _JWTSettings;
        private readonly IUserRepository _userRepository;
        private readonly IRolesUserRepository _rolesuser;
        private readonly IRefreshTokenRepository _irefrehtokenrepository;

        public UserLoginRepository(IOptions<JWT> options, IUserRepository userRepository, IRefreshTokenRepository irefrehtokenrepository, IRolesUserRepository rolesuser)
        {
            _JWTSettings = options.Value;
            _userRepository = userRepository;
            _rolesuser = rolesuser;
            _irefrehtokenrepository = irefrehtokenrepository;

        }
        public async Task<UserLoginDto> GetAccessUser(UserNameDto userNameDto)
        {
            string nombreusuario = GetEmailToken(userNameDto.AccessTokenUser);
            string nombreaplicacion = userNameDto.NameAplication;
            ICollection<UsuarioPerfilDto> usuarioperfil = new List<UsuarioPerfilDto>();
            UserLoginDto userLoginDto = new UserLoginDto();
            var usuario = await _userRepository
                        .GetByUsernameAsync(nombreusuario);

            usuarioperfil = await _rolesuser.GetRolesUsuario(nombreusuario, nombreaplicacion);
            if (usuario == null)
            {
                userLoginDto.EstaAutenticado = false;
                userLoginDto.Mensaje = $"No existe usuario con el username {nombreusuario}.";
            }
            else
            {
                if (usuario.ActivoUsuario == true)
                {
                    userLoginDto.EstaAutenticado = true;
                    JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);

                    JWT seguridad = new()
                    {
                        Key = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                    };

                    userLoginDto.Seguridad = seguridad;
                    userLoginDto.Email = usuario.Email;
                    userLoginDto.NombreUsuario = usuario.NombreUsuario;
                    userLoginDto.NombresUsuario = usuario.NombresUsuario;
                    userLoginDto.ApellidosUsuario = usuario.ApellidosUsuario;
                    userLoginDto.DniUsuario = usuario.DniUsuario;
                    userLoginDto.ActivoUsuario = usuario.ActivoUsuario;
                    userLoginDto.usuarioperfil = usuarioperfil;
                    userLoginDto.NombreAplicacion = nombreaplicacion;
                    if (usuario.RefreshTokens.Any(x => x.Expira > DateTime.UtcNow))
                    {
                        var refreshtoken = usuario.RefreshTokens.Where(x => x.Expira > DateTime.UtcNow).OrderByDescending(x=>x.Expira).FirstOrDefault();
                        userLoginDto.RefreshToken = refreshtoken.Token;
                        userLoginDto.RefreshTokenExpiration = refreshtoken.Expira;
                    }
                    else
                    {
                        var refreshToken = CreateRefreshToken();
                        userLoginDto.RefreshToken = refreshToken.Token;
                        userLoginDto.RefreshTokenExpiration = refreshToken.Expira;
                        usuario.RefreshTokens.Add(refreshToken);
                        _userRepository.Update(usuario);
                        await _userRepository.SaveAsync();
                    }
                }
                else
                {
                    userLoginDto.EstaAutenticado = false;
                    userLoginDto.Mensaje = $"El usuario: {nombreusuario} no se encuentra activo.";
                }
                //return userLoginDto;
            }
            //var resultado = _passwordHasher.VerifyHashedPassword(usuario, usuario.Password, model.Password);
            //userLoginDto.EstaAutenticado = false;
            //userLoginDto.Mensaje = $"Credenciales incorrectas para el usuario {nombreusuario}.";
            return userLoginDto;
        }

        public async Task<UserLoginDto> GetRefreshTokenAsync(string refreshToken,string nombreaplicacion)
        {
            var datosUsuarioDto = new UserLoginDto();

            var usuario = await _userRepository
                            .GetByRefreshTokenAsync(refreshToken);
            var usuarioperfil = await _rolesuser.GetRolesUsuario(usuario.NombreUsuario, nombreaplicacion);
            if (usuario == null)
            {
                datosUsuarioDto.EstaAutenticado = false;
                datosUsuarioDto.Mensaje = $"El token no pertenece a ningún usuario.";
                return datosUsuarioDto;
            }

            var refreshTokenBd = usuario.RefreshTokens.Single(x => x.Token == refreshToken);

            if (!(refreshTokenBd.Expira>DateTime.UtcNow))
            {
                datosUsuarioDto.EstaAutenticado = false;
                datosUsuarioDto.Mensaje = $"El token no está activo.";
                return datosUsuarioDto;
            }
            var newRefreshToken = CreateRefreshToken();
            usuario.RefreshTokens.Add(newRefreshToken);
            _userRepository.Update(usuario);
            await _userRepository.SaveAsync();
            datosUsuarioDto.EstaAutenticado = true;
            JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);
            JWT seguridad = new()
            {
                Key = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
            };
            datosUsuarioDto.Seguridad = seguridad;
            datosUsuarioDto.Email = usuario.Email;
            datosUsuarioDto.NombreUsuario = usuario.NombreUsuario;
            datosUsuarioDto.NombresUsuario = usuario.NombresUsuario;
            datosUsuarioDto.ApellidosUsuario = usuario.ApellidosUsuario;
            datosUsuarioDto.DniUsuario= usuario.DniUsuario;
            datosUsuarioDto.RefreshToken = newRefreshToken.Token;
            datosUsuarioDto.RefreshTokenExpiration = newRefreshToken.Expira;
            datosUsuarioDto.usuarioperfil = usuarioperfil;
            datosUsuarioDto.NombreAplicacion = nombreaplicacion;
            return datosUsuarioDto;
        }





        private RefreshToken CreateRefreshToken()
        {
            var radomNumeric = new byte[32];
            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(radomNumeric);
                return new RefreshToken()
                {
                    Token = Convert.ToBase64String(radomNumeric),
                    Expira = DateTime.UtcNow.AddDays(1),
                };
            }

        }

        private string GetEmailToken(string _token)
        {
            string response_ = "";
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(_token);
                response_ = jwtSecurityToken.Claims.First(claim => claim.Type == "email").Value;
            }
            catch (Exception ex)
            {
               return "Ocurrió un error con su usuario.";
            }

            return response_;
        }



        private JwtSecurityToken CreateJwtToken(Usuario usuario)
        {
            var perfil = usuario.UsuarioPerfils;
            var perfilclaim = new List<Claim>();
            var claims = new[]
            {
                                new Claim(JwtRegisteredClaimNames.Sub, usuario.NombreUsuario),
                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                

            };
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JWTSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _JWTSettings.Issuer,
                audience: _JWTSettings.Audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(_JWTSettings.DurationInMinutes),
                
                
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }
    }
}
