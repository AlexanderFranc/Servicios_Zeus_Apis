using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Core.Entidades.Public;
using Microsoft.Extensions.Configuration;

namespace Infraestructure.Configuration.Zeus.Public;
public partial class ZeusPublicContext : DbContext
{
    public ZeusPublicContext()
    {
    }

    public ZeusPublicContext(DbContextOptions<ZeusPublicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aplicacion> Aplicacions { get; set; }

    public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }

    public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }

    public virtual DbSet<FactoresAutenticacion> FactoresAutenticacions { get; set; }

    public virtual DbSet<LogsAcceso> LogsAccesos { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuPerfil> MenuPerfils { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioFa> UsuarioFas { get; set; }

    public virtual DbSet<UsuarioPerfil> UsuarioPerfils { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ZEUS_PUBLIC"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<Aplicacion>(entity =>
        {
            entity.HasKey(e => e.IdAplicacion).IsClustered(false);

            entity.ToTable("APLICACION");

            entity.Property(e => e.IdAplicacion).HasColumnName("ID_APLICACION");
            entity.Property(e => e.ActivoAplicacion).HasColumnName("ACTIVO_APLICACION");
            entity.Property(e => e.BannerAplicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANNER_APLICACION");
            entity.Property(e => e.DescripcionAplicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_APLICACION");
            entity.Property(e => e.IconoAplicacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ICONO_APLICACION");
            entity.Property(e => e.NombreAplicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_APLICACION");
            entity.Property(e => e.UrlAplicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL_APLICACION");
        });

        modelBuilder.Entity<Databasechangelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DATABASECHANGELOG");

            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .HasColumnName("AUTHOR");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Contexts)
                .HasMaxLength(255)
                .HasColumnName("CONTEXTS");
            entity.Property(e => e.Dateexecuted)
                .HasPrecision(3)
                .HasColumnName("DATEEXECUTED");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(10)
                .HasColumnName("DEPLOYMENT_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Exectype)
                .HasMaxLength(10)
                .HasColumnName("EXECTYPE");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.Labels)
                .HasMaxLength(255)
                .HasColumnName("LABELS");
            entity.Property(e => e.Liquibase)
                .HasMaxLength(20)
                .HasColumnName("LIQUIBASE");
            entity.Property(e => e.Md5sum)
                .HasMaxLength(35)
                .HasColumnName("MD5SUM");
            entity.Property(e => e.Orderexecuted).HasColumnName("ORDEREXECUTED");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<Databasechangeloglock>(entity =>
        {
            entity.ToTable("DATABASECHANGELOGLOCK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Lockedby)
                .HasMaxLength(255)
                .HasColumnName("LOCKEDBY");
            entity.Property(e => e.Lockgranted)
                .HasPrecision(3)
                .HasColumnName("LOCKGRANTED");
        });

        modelBuilder.Entity<FactoresAutenticacion>(entity =>
        {
            entity.HasKey(e => e.IdFa).IsClustered(false);

            entity.ToTable("FACTORES_AUTENTICACION");

            entity.Property(e => e.IdFa).HasColumnName("ID_FA");
            entity.Property(e => e.CodigoappFa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGOAPP_FA");
            entity.Property(e => e.EstadoFa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO_FA");
            entity.Property(e => e.ExpiraFa)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRA_FA");
            entity.Property(e => e.FechaFa)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FA");
            entity.Property(e => e.TipoFa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_FA");
        });

        modelBuilder.Entity<LogsAcceso>(entity =>
        {
            entity.HasKey(e => e.IdLogAcceso);

            entity.ToTable("LOGS_ACCESO");

            entity.Property(e => e.IdLogAcceso).HasColumnName("ID_LOG_ACCESO");
            entity.Property(e => e.CambioPasswordLogAcceso).HasColumnName("CAMBIO_PASSWORD_LOG_ACCESO");
            entity.Property(e => e.FechaLogAcceso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_LOG_ACCESO");
            entity.Property(e => e.IdAplicaciones).HasColumnName("ID_APLICACIONES");
            entity.Property(e => e.IdPerfiles).HasColumnName("ID_PERFILES");
            entity.Property(e => e.IdUsuarios).HasColumnName("ID_USUARIOS");
            entity.Property(e => e.IntentosFallidosLogAcceso).HasColumnName("INTENTOS_FALLIDOS_LOG_ACCESO");
            entity.Property(e => e.IntentosLogAcceso).HasColumnName("INTENTOS_LOG_ACCESO");
            entity.Property(e => e.IpLogAcceso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP_LOG_ACCESO");
            entity.Property(e => e.MacLogAcceso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAC_LOG_ACCESO");
            entity.Property(e => e.NavegadorLogAcceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAVEGADOR_LOG_ACCESO");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.UrlLogAcceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL_LOG_ACCESO");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithMany(p => p.LogsAccesos)
                .HasForeignKey(d => d.NombreUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOGS_ACCESO_USUARIO");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).IsClustered(false);

            entity.ToTable("MENU");

            entity.HasIndex(e => e.IdAplicacion, "RELATIONSHIP_3_FK");

            entity.HasIndex(e => e.MenIdMenu, "RELATIONSHIP_4_FK");

            entity.Property(e => e.IdMenu).HasColumnName("ID_MENU");
            entity.Property(e => e.ActivoMenu).HasColumnName("ACTIVO_MENU");
            entity.Property(e => e.AperturadoMenu).HasColumnName("APERTURADO_MENU");
            entity.Property(e => e.DescripcionMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MENU");
            entity.Property(e => e.FechaAperturaMenu)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_APERTURA_MENU");
            entity.Property(e => e.FechaCierreMenu)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CIERRE_MENU");
            entity.Property(e => e.IconoMenu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ICONO_MENU");
            entity.Property(e => e.IconoposMenu)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ICONOPOS_MENU");
            entity.Property(e => e.IdAplicacion).HasColumnName("ID_APLICACION");
            entity.Property(e => e.IdAplicaciones).HasColumnName("ID_APLICACIONES");
            entity.Property(e => e.IdMenuPadre).HasColumnName("ID_MENU_PADRE");
            entity.Property(e => e.LabelMenu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LABEL_MENU");
            entity.Property(e => e.MenIdMenu).HasColumnName("MEN_ID_MENU");
            entity.Property(e => e.NombreMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MENU");
            entity.Property(e => e.OrdenMenu).HasColumnName("ORDEN_MENU");
            entity.Property(e => e.TipoMenu)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TIPO_MENU");
            entity.Property(e => e.UrlMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL_MENU");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.Menus)
                .HasForeignKey(d => d.IdAplicacion)
                .HasConstraintName("FK_MENU_APLICACION");
        });

        modelBuilder.Entity<MenuPerfil>(entity =>
        {
            entity.ToTable("MENU_PERFIL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdAplicacion).HasColumnName("ID_APLICACION");
            entity.Property(e => e.IdMenu).HasColumnName("ID_MENU");
            entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");
            entity.Property(e => e.PermisosAutorizacion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PERMISOS_AUTORIZACION");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.MenuPerfils)
                .HasForeignKey(d => d.IdAplicacion)
                .HasConstraintName("FK_MENU_PERFIL_APLICACION");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuPerfils)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK_MENU_PERFIL_MENU");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.MenuPerfils)
                .HasForeignKey(d => d.IdPerfil)
                .HasConstraintName("FK_MENU_PERFIL_PERFIL");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.IdPerfil).IsClustered(false);

            entity.ToTable("PERFIL");

            entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");
            entity.Property(e => e.ActivoPerfil).HasColumnName("ACTIVO_PERFIL");
            entity.Property(e => e.DescripcionPerfil)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PERFIL");
            entity.Property(e => e.IdAplicacion).HasColumnName("ID_APLICACION");
            entity.Property(e => e.NombrePerfil)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERFIL");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.Perfils)
                .HasForeignKey(d => d.IdAplicacion)
                .HasConstraintName("FK_PERFIL_APLICACION");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("REFRESH_TOKEN_PK");

            entity.ToTable("REFRESH_TOKEN");

            entity.HasIndex(e => e.Token, "UK_e26kibx5a46b64b5hjat29hwp").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Expira).HasColumnName("EXPIRA");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TOKEN");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithMany(p => p.RefreshTokens)
                .HasForeignKey(d => d.NombreUsuario)
                .HasConstraintName("FKlwgsruqqt0d9q6eakn3eqgre3");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.NombreUsuario).IsClustered(false);

            entity.ToTable("USUARIO");

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.ActivoUsuario).HasColumnName("ACTIVO_USUARIO");
            entity.Property(e => e.ApellidosUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS_USUARIO");
            entity.Property(e => e.DniUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_USUARIO");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailPersonalUsuario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL_PERSONAL_USUARIO");
            entity.Property(e => e.FaUsuario).HasColumnName("FA_USUARIO");
            entity.Property(e => e.FechaActualizacionUsuario)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACTUALIZACION_USUARIO");
            entity.Property(e => e.FechaCreacionUsuario)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION_USUARIO");
            entity.Property(e => e.FotoUsuario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FOTO_USUARIO");
            entity.Property(e => e.IntentosUsuario)
                .HasDefaultValueSql("((0))")
                .HasColumnName("INTENTOS_USUARIO");
            entity.Property(e => e.NombresUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_USUARIO");
            entity.Property(e => e.Password)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Tipo2faUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO2FA_USUARIO");
            entity.Property(e => e.TipoDniUsuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_DNI_USUARIO");
        });

        modelBuilder.Entity<UsuarioFa>(entity =>
        {
            entity.HasKey(e => new { e.IdFa, e.NombreUsuario });

            entity.ToTable("USUARIO_FA");

            entity.HasIndex(e => e.IdFa, "RELATIONSHIP_8_FK");

            entity.HasIndex(e => e.NombreUsuario, "RELATIONSHIP_9_FK");

            entity.Property(e => e.IdFa).HasColumnName("ID_FA");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.ActivoFa).HasColumnName("ACTIVO_FA");

            entity.HasOne(d => d.IdFaNavigation).WithMany(p => p.UsuarioFas)
                .HasForeignKey(d => d.IdFa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__RELATIONS_FACTORES");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithMany(p => p.UsuarioFas)
                .HasForeignKey(d => d.NombreUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__RELATIONS_USUARIO");
        });

        modelBuilder.Entity<UsuarioPerfil>(entity =>
        {
            entity.HasKey(e => new { e.NombreUsuario, e.IdPerfil, e.IdAplicacion });

            entity.ToTable("USUARIO_PERFIL");

            entity.HasIndex(e => e.NombreUsuario, "RELATIONSHIP_1_FK");

            entity.HasIndex(e => e.IdPerfil, "RELATIONSHIP_2_FK");

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");
            entity.Property(e => e.IdAplicacion).HasColumnName("ID_APLICACION");
            entity.Property(e => e.ActivoPerfilUsuario).HasColumnName("ACTIVO_PERFIL_USUARIO");

            entity.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.UsuarioPerfils)
                .HasForeignKey(d => d.IdAplicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_PERFIL_APLICACION");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.UsuarioPerfils)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__RELATIONS_PERFIL");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithMany(p => p.UsuarioPerfils)
                .HasForeignKey(d => d.NombreUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO__REL_PERFI_USUARIO");
        });
        modelBuilder.HasSequence("hibernate_sequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
