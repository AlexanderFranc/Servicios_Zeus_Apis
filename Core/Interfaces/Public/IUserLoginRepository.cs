
using Core.Dtos.Public;

namespace Core.Interfaces.Public
{
    public interface IUserLoginRepository
    {
        Task<UserLoginDto> GetAccessUser(UserNameDto userNameDto);

        Task<UserLoginDto> GetRefreshTokenAsync(string refreshtoken, string nombreaplicacion);
    }
}
