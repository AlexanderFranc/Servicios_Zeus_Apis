using AspNetCoreRateLimit;
using Core.Dtos.Ftp;
using Core.Dtos.Public;
using Core.Entidades.Core;
using Core.Entidades.Public;
using Core.Interfaces.Core;
using Core.Interfaces.Ftp;
using Core.Interfaces.Generico;
using Core.Interfaces.Public;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Configuration.Zeus.Public;
using Infraestructure.Repository.Core;
using Infraestructure.Repository.Ftp;
using Infraestructure.Repository.Generico;
using Infraestructure.Repository.Public;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Servicios_Zeus.Helpers.Errors;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;


namespace Servicios_Zeus.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyOrigin()
            //builder.WithOrigins("https://zeustest3.uisek.edu.ec", "http://zeustest3.uisek.edu.ec", "https://evaluacionestest.uisek.edu.ec", "https://eidtest3.uisek.edu.ec", "https://evaluacionestest.uisek.edu.ec", "http://eidtest3.uisek.edu.ec", "http://evaluacionestest.uisek.edu.ec")
             //builder.WithOrigins("http://localhost:4200", "https://localhost:7157")
             //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "zeustest.uisek.edu.ec")
            // builder.WithOrigins("https://evaluaciones.uisek.edu.ec", "http://evaluaciones.uisek.edu.ec", "https://zeus.uisek.edu.ec", "http://zeus.uisek.edu.ec","https://silabo.uisek.edu.ec","http://silabo.uisek.edu.ec", "https://localhost:9007", "http://localhost:9007","http://silabotest.uisek.edu.ec")
            .AllowAnyHeader()
            .AllowAnyMethod());
        });

        public static void AddAplicationService(this IServiceCollection services)
        {
            services.AddTransient<Infraestructure.Configuration.Zeus.Public.ZeusPublicContext, Infraestructure.Configuration.Zeus.Public.ZeusPublicContext>();
            services.AddTransient<Infraestructure.Configuration.Zeus.Core.ZeusCoreContext, Infraestructure.Configuration.Zeus.Core.ZeusCoreContext>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericCoreRepository<>));
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericPublicRepository<>));
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IUserLoginRepository,UserLoginRepository>();
            services.AddTransient<IUserRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioPerfilRepository, UsuarioPerfilRepository>();
            services.AddTransient<IRolesUserRepository,RolesRepository>();
            services.AddTransient<IMenuRepository, MenuReposiory>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient<IMateriaprincipalRepository, MateriaPrincipalRepository>();
            services.AddTransient<ITipoMateriaCatalogoRepository, TipoMateriaCatalogoRepository>();
            services.AddTransient<ITipoComponenteRepository, TipoComponenteRepository>();
            services.AddTransient<IUnidadOrganizacionalCurricularRepository, UnidadOrganizacionalCurricularRepository>();
            services.AddTransient<IComponenteRepository, ComponenteRepository>();
            services.AddTransient<IPeriodicidadRepository,PeriodicidadRepository>();
            services.AddTransient<IEstadoPeRepository, EstadoPeRepository>();
            services.AddTransient<INivelEstudioRepository, NivelEstudioRepository>();
            services.AddTransient<IFacultadRepository, FacultadRepository>();
            services.AddTransient<ICarreraRepository, CarreraRepository>();
            services.AddTransient<ISubtipoComponenteRepository, SubtipoComponenteRepository>();
            services.AddTransient<IPlanEstudioRepository, PlanEstudioRepository>();
            services.AddTransient<IMallaRepository,MallaRepository>();
            services.AddTransient<IModalidadPE, ModalidadPERepository>();
            services.AddTransient<IMateriaComponenteRepository, MateriaComponenteRepository>();
            services.AddTransient<IHorasFranjaHoraria, HorasFranjaHorariaRepository>();
            services.AddTransient<IPlanificacionRepository, PlanificacionRepository>();
            services.AddTransient<ITipoInfraestructuraRepository, TipoInfraestructuraRepository>();
            services.AddTransient<IInfraestructuraRepository, InfraestructuraRepository>();
            services.AddTransient<INivelInfraestructuraRepository, NivelInfraestructuraRepository>();
            services.AddTransient<IEspaciosFisicosRepository, EspaciosFisicosRepository>();
            services.AddTransient<IPeriodoRepository, PeriodoRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
            services.AddTransient<IPlanificacionRepository, PlanificacionRepository>();
            services.AddTransient<IPlanificacionRepository1, PlanificacionRepository1>();
            services.AddTransient<IHorarioRepository, HorarioFechaRepository>();
            services.AddTransient<IHorario, HorarioRepository>();
            services.AddTransient<IComponentePlanificacionRepository, ComponentePlanificacionRepository>();
            services.AddTransient<IHorariosPlanificacionRepository, HorariosPlanificacionRepository>();
            services.AddTransient<IHorarioSemestralRepository, HorarioSemetralRepository>();
            services.AddTransient<IPlanificacionComponentRepository, PlanificacionComponentRepository>();
            services.AddTransient<IHorariosSemestralRepository, HorariosSemestralRepository>();
            services.AddTransient<ITipoEmpleadoRepository, TipoEmpleadoRepository>();
            services.AddTransient<IEstadoEmpleadoRepository, EstadoEmpleadoRepository>();
            services.AddTransient<IUnidadOrganizativaRepository, UnidadOrganizativaRepository>();
            services.AddTransient<ITipoDocumentoRepository, TipoDocumentoRepository>();
            services.AddTransient<IProvinciaRepository, ProvinciaRepository>();
            services.AddTransient<ICantonRepository, CantonRepository>();
            services.AddTransient<IParroquiaRepository, ParroquiaRepository>();
            services.AddTransient<IInfoAcademicaRepository, InfoAcademicaRepository>();
            services.AddTransient<INivelAcademicoRepository, NivelAcademicoRepository>();
            services.AddTransient<IExperienciaLaboralRepository, ExperienciaLaboralRepository>();
            services.AddTransient<IExperienciaDocenteRepository, ExperienciaDocenteRepository>();
            services.AddTransient<ICapacitacionRepository, CapacitacionRepository>();
            services.AddTransient<IIdiomaRepository, IdiomaRepository>();
            services.AddTransient<ITipoActividadRepository, TipoActividadRepository>();
            services.AddTransient<ITipoAprobacionRepository, TipoAprobacionRepository>();
            services.AddTransient<IPublicacionRepository, PublicacionRepository>();
            services.AddTransient<IEtniaRepository, EtniaRepository>();
            services.AddTransient<ITipoDiscapacidadRepository, TipoDiscapacidadRepository>();
            services.AddTransient<IContactoEmergenciaRepository, ContactoEmergenciaRepository>();
            services.AddTransient<IUnidadEducativaRepository, UnidadEducativaRepository>();
            services.AddTransient<IInfoAcademicaNewRepository, InfoAcademicaNewRepository>();
            services.AddTransient<ICampoAmplioRepository, CampoAmplioRepository>();
            services.AddTransient<ICampoEspecificoRepository, CampoEspecificoRepository>();
            services.AddTransient<IProyectoInvestigacionRepository, ProyectoInvestigacionRepository>();
            services.AddScoped<IFtpRepository, FTPRepository>();
            services.AddScoped<IHorarioSemestralPlanificadoRepository, HorarioSemestralPlanificadoRepository>();
            services.AddScoped<IDatosGeneralesSilaboRepository, DatosGeneralesSilaboRepository>();
            services.AddScoped<IUsuarioPaRepository, UsuarioPaRepository>();
            services.AddScoped<IAprobadorPlanAnaliticoRepository, AprobadorPlanAnaliticoRepository>();
            services.AddScoped<ISilaboMateriasUsuarioRepository, SilaboMateriasUsuarioRepository>();
            services.AddScoped<IPlanificacionTempRepository, PlanificacionTempRepository>();
            services.AddScoped<ISolicitudRepository, SolicitudRepository>();
            services.AddScoped<IHorarioTempRepository, HorarioTempRepository>();
            services.AddScoped<IHorarioFechaTempRepository, HorarioFechaTempRepository>();
            services.AddScoped<IPlanificacionCruceRepository, PlanificacionCruceRepository>();
            services.AddScoped<IEmpleadoTempNuevoRepository, EmpleadoTempNuevoRepository>();
            services.AddScoped<IEmpleadoTempArchivoRepository, EmpleadoTempArchivoRepository>();
            services.AddScoped<IDedicacionNRepository, DedicacionNRepository>();
            services.AddScoped<ITipoContratoNRepository, TipoContratoNRepository>();
            services.AddScoped<ITitularidadEmpRepository, TitularidadEmpRepository>();
            services.AddScoped<IFormaPagoEmpRepository, FormaPagoEmpRepository>();
            services.AddScoped<ICategoriaEmpRepository, CategoriaEmpRepository>();
            services.AddScoped<IEmailReporsitory, EmailReporsitory>();
            services.AddScoped<ITitulosAcademicosRepository, TitulosAcademicosRepository>();

        }
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddJsonOptions(x =>
             x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        }


        public static void ConfigureJWT(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<JWT>(configuration.GetSection("JWT"));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = true;
                o.SaveToken = false;
                o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JWT:Issuer"],
                    ValidAudience = configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]))
                };
            });
        }
        public static void ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("v"),
                    new HeaderApiVersionReader("X-Version"));
                options.ReportApiVersions = true;
            });
        }

        public static void ConfigureRateLimitiong(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddInMemoryRateLimiting();

            services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                
                options.GeneralRules = new List<RateLimitRule>
                {
                    new RateLimitRule
                    {
                        Endpoint ="*",
                        Period = "10s",
                        Limit = 20    

                    }
                };
            });


        }

        public static void ConfigureFtp(this IServiceCollection services, IConfiguration configuration)
        {
            var ftpConfiguration = new FtpConfiguration();
            configuration.GetSection("SFtpSettings").Bind(ftpConfiguration);
            services.AddSingleton(ftpConfiguration);

        }

        public static void AddValidationErrors(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {

                    var errors = actionContext.ModelState.Where(u => u.Value.Errors.Count > 0)
                                                    .SelectMany(u => u.Value.Errors)
                                                    .Select(u => u.ErrorMessage).ToArray();

                    var errorResponse = new ApiValidation()
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });
        }
    }
}
