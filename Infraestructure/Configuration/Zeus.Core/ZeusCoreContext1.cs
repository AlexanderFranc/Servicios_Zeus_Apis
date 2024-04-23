using System;
using System.Collections.Generic;
using Core.Entidades.Core;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Configuration.Zeus.Core;

public partial class ZeusCoreContext : DbContext
{
    public ZeusCoreContext()
    {
    }

    public ZeusCoreContext(DbContextOptions<ZeusCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acreditacione> Acreditaciones { get; set; }

    public virtual DbSet<ActAcademicasAutoridadCarrera> ActAcademicasAutoridadCarreras { get; set; }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<AutoridadesCarrera> AutoridadesCarreras { get; set; }

    public virtual DbSet<AutoridadesFacultad> AutoridadesFacultads { get; set; }

    public virtual DbSet<AutoridadesInstitucionEducativa> AutoridadesInstitucionEducativas { get; set; }

    public virtual DbSet<Campus> Campuses { get; set; }

    public virtual DbSet<Canton> Cantons { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<CatalogoDocumentosContratoDocente> CatalogoDocumentosContratoDocentes { get; set; }

    public virtual DbSet<CatalogoMateria> CatalogoMaterias { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Componente> Componentes { get; set; }

    public virtual DbSet<ComponenteCatalogo> ComponenteCatalogos { get; set; }

    public virtual DbSet<ConceptoCalificacione> ConceptoCalificaciones { get; set; }

    public virtual DbSet<ConceptoMateriaConfiguracion> ConceptoMateriaConfiguracions { get; set; }

    public virtual DbSet<ConceptoPrecio> ConceptoPrecios { get; set; }

    public virtual DbSet<ConceptosAdicionalesMaterium> ConceptosAdicionalesMateria { get; set; }

    public virtual DbSet<ConceptosGeneralesDescuento> ConceptosGeneralesDescuentos { get; set; }

    public virtual DbSet<ConceptosGeneralesPrecio> ConceptosGeneralesPrecios { get; set; }

    public virtual DbSet<ConfiguracionesGenerale> ConfiguracionesGenerales { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<ControlesPeriodo> ControlesPeriodos { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<Correquisito> Correquisitos { get; set; }

    public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }

    public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }

    public virtual DbSet<Dedicacion> Dedicacions { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<DesignacionesCarrera> DesignacionesCarreras { get; set; }

    public virtual DbSet<DesignacionesFacultad> DesignacionesFacultads { get; set; }

    public virtual DbSet<DesignacionesInstitucionEducativa> DesignacionesInstitucionEducativas { get; set; }

    public virtual DbSet<DetalleItem> DetalleItems { get; set; }

    public virtual DbSet<DetalleOcupanteHorario> DetalleOcupanteHorarios { get; set; }

    public virtual DbSet<DetallesEspacio> DetallesEspacios { get; set; }

    public virtual DbSet<DistributivoDocente> DistributivoDocentes { get; set; }

    public virtual DbSet<Dium> Dia { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EspaciosFisico> EspaciosFisicos { get; set; }

    public virtual DbSet<EstadoCarrera> EstadoCarreras { get; set; }

    public virtual DbSet<EstadoContrato> EstadoContratos { get; set; }

    public virtual DbSet<EstadoDescuento> EstadoDescuentos { get; set; }

    public virtual DbSet<EstadoEmpleado> EstadoEmpleados { get; set; }

    public virtual DbSet<EstadoEspacio> EstadoEspacios { get; set; }

    public virtual DbSet<EstadoFacultad> EstadoFacultads { get; set; }

    public virtual DbSet<EstadoFechasHorario> EstadoFechasHorarios { get; set; }

    public virtual DbSet<EstadoFranjaHorario> EstadoFranjaHorarios { get; set; }

    public virtual DbSet<EstadoItem> EstadoItems { get; set; }

    public virtual DbSet<EstadoOcupanteHorario> EstadoOcupanteHorarios { get; set; }

    public virtual DbSet<EstadoPe> EstadoPes { get; set; }

    public virtual DbSet<EstadoPeriodo> EstadoPeriodos { get; set; }

    public virtual DbSet<EstadoRequisito> EstadoRequisitos { get; set; }

    public virtual DbSet<Facultad> Facultads { get; set; }

    public virtual DbSet<FechasConceptocalif> FechasConceptocalifs { get; set; }

    public virtual DbSet<FechasHorario> FechasHorarios { get; set; }

    public virtual DbSet<FranjaHorario> FranjaHorarios { get; set; }

    public virtual DbSet<FranjaHorarium> FranjaHoraria { get; set; }

    public virtual DbSet<GestionDocumental> GestionDocumentals { get; set; }

    public virtual DbSet<HistorialContrato> HistorialContratos { get; set; }

    public virtual DbSet<HistorialPrecio> HistorialPrecios { get; set; }

    public virtual DbSet<HistoricoCarrera> HistoricoCarreras { get; set; }

    public virtual DbSet<HistoricoFacultad> HistoricoFacultads { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<HorarioFecha> HorarioFechas { get; set; }

    public virtual DbSet<HorasModalidadMalla> HorasModalidadMallas { get; set; }

    public virtual DbSet<InfoAcademica> InfoAcademicas { get; set; }

    public virtual DbSet<InfoExperiencium> InfoExperiencia { get; set; }

    public virtual DbSet<InfoPersonal> InfoPersonals { get; set; }

    public virtual DbSet<InfoTitulo> InfoTitulos { get; set; }

    public virtual DbSet<Infraestructura> Infraestructuras { get; set; }

    public virtual DbSet<InstitucionEducativa> InstitucionEducativas { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Malla> Mallas { get; set; }

    public virtual DbSet<MateriaCompartidum> MateriaCompartida { get; set; }

    public virtual DbSet<MateriaEquivalente> MateriaEquivalentes { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<ModalidadContrato> ModalidadContratos { get; set; }

    public virtual DbSet<ModalidadPe> ModalidadPes { get; set; }

    public virtual DbSet<ModalidadPeriodo> ModalidadPeriodos { get; set; }

    public virtual DbSet<ModalidadTitulacionPe> ModalidadTitulacionPes { get; set; }

    public virtual DbSet<NivelEstudio> NivelEstudios { get; set; }

    public virtual DbSet<NivelInfraestructura> NivelInfraestructuras { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<NotificacionesCorreo> NotificacionesCorreos { get; set; }

    public virtual DbSet<OcupanteHorario> OcupanteHorarios { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Parroquium> Parroquia { get; set; }

    public virtual DbSet<PartidaPresupuestarium> PartidaPresupuestaria { get; set; }

    public virtual DbSet<Periodicidad> Periodicidads { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PermisosCarrera> PermisosCarreras { get; set; }

    public virtual DbSet<PlanEstudio> PlanEstudios { get; set; }

    public virtual DbSet<Planificacion> Planificacions { get; set; }

    public virtual DbSet<PlanoNivel> PlanoNivels { get; set; }

    public virtual DbSet<Premio> Premios { get; set; }

    public virtual DbSet<Prerrequisito> Prerrequisitos { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RelacionContrato> RelacionContratos { get; set; }

    public virtual DbSet<RequisitosEgresamientoPe> RequisitosEgresamientoPes { get; set; }

    public virtual DbSet<RequisitosTipoContrato> RequisitosTipoContratos { get; set; }

    public virtual DbSet<SedeInstitucion> SedeInstitucions { get; set; }

    public virtual DbSet<SubnivelEstudio> SubnivelEstudios { get; set; }

    public virtual DbSet<SubtipoTitulacion> SubtipoTitulacions { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TipoActividade> TipoActividades { get; set; }

    public virtual DbSet<TipoAprobacion> TipoAprobacions { get; set; }

    public virtual DbSet<TipoAutoridadCarrera> TipoAutoridadCarreras { get; set; }

    public virtual DbSet<TipoAutoridadInstitucionEducativa> TipoAutoridadInstitucionEducativas { get; set; }

    public virtual DbSet<TipoAutoridadfacultad> TipoAutoridadfacultads { get; set; }

    public virtual DbSet<TipoComponente> TipoComponentes { get; set; }

    public virtual DbSet<TipoConceptocalif> TipoConceptocalifs { get; set; }

    public virtual DbSet<TipoContrato> TipoContratos { get; set; }

    public virtual DbSet<TipoConvenio> TipoConvenios { get; set; }

    public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }

    public virtual DbSet<TipoEspacio> TipoEspacios { get; set; }

    public virtual DbSet<TipoInfraestructura> TipoInfraestructuras { get; set; }

    public virtual DbSet<TipoInstitucionEducativa> TipoInstitucionEducativas { get; set; }

    public virtual DbSet<TipoItem> TipoItems { get; set; }

    public virtual DbSet<TipoMateriaCatalogo> TipoMateriaCatalogos { get; set; }

    public virtual DbSet<TipoPeriodo> TipoPeriodos { get; set; }

    public virtual DbSet<TipoPermiso> TipoPermisos { get; set; }

    public virtual DbSet<TipoPermisoCarrera> TipoPermisoCarreras { get; set; }

    public virtual DbSet<TipoPrecorequisito> TipoPrecorequisitos { get; set; }

    public virtual DbSet<TipoRequisitoEgresamiento> TipoRequisitoEgresamientos { get; set; }

    public virtual DbSet<TipoTitulacion> TipoTitulacions { get; set; }

    public virtual DbSet<UnidadOrganizacionCurricular> UnidadOrganizacionCurriculars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.16.32.191;Database=ZEUS_NEW;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acreditacione>(entity =>
        {
            entity.HasKey(e => e.IdAcreditaciones).IsClustered(false);

            entity.ToTable("ACREDITACIONES");

            entity.Property(e => e.IdAcreditaciones).HasColumnName("ID_ACREDITACIONES");
            entity.Property(e => e.ActivoAcreditaciones).HasColumnName("ACTIVO_ACREDITACIONES");
            entity.Property(e => e.AniosAcreditaciones).HasColumnName("ANIOS_ACREDITACIONES");
            entity.Property(e => e.FechacreaAcreditaciones)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_ACREDITACIONES");
            entity.Property(e => e.FechafinAcreditaciones)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_ACREDITACIONES");
            entity.Property(e => e.FechainicioAcreditaciones)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_ACREDITACIONES");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.NombreAcreditaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ACREDITACIONES");
            entity.Property(e => e.UsuariocreaAcreditaciones)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOCREA_ACREDITACIONES");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.Acreditaciones)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_ACREDITA_FK_ACREDI_INSTITUC");
        });

        modelBuilder.Entity<ActAcademicasAutoridadCarrera>(entity =>
        {
            entity.HasKey(e => e.IdAaAutoridadCarrera)
                .HasName("PK_ACT_ACADEMICAS_AUTORIDAD_CA")
                .IsClustered(false);

            entity.ToTable("ACT_ACADEMICAS_AUTORIDAD_CARRERA");

            entity.Property(e => e.IdAaAutoridadCarrera).HasColumnName("ID_AA_AUTORIDAD_CARRERA");
            entity.Property(e => e.ActivoAaAutoridadCarrera).HasColumnName("ACTIVO_AA_AUTORIDAD_CARRERA");
            entity.Property(e => e.DescripcionAaAutoridadCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_AA_AUTORIDAD_CARRERA");
            entity.Property(e => e.IdAutoridadc).HasColumnName("ID_AUTORIDADC");
            entity.Property(e => e.NombreAaAutoridadCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_AA_AUTORIDAD_CARRERA");

            entity.HasOne(d => d.IdAutoridadcNavigation).WithMany(p => p.ActAcademicasAutoridadCarreras)
                .HasForeignKey(d => d.IdAutoridadc)
                .HasConstraintName("FK_ACT_ACAD_FK_ACT_AC_AUTORIDA");
        });

        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.IdActividades).IsClustered(false);

            entity.ToTable("ACTIVIDADES");

            entity.Property(e => e.IdActividades).HasColumnName("ID_ACTIVIDADES");
            entity.Property(e => e.IdDistributivo).HasColumnName("ID_DISTRIBUTIVO");

            entity.HasOne(d => d.IdDistributivoNavigation).WithMany(p => p.Actividades)
                .HasForeignKey(d => d.IdDistributivo)
                .HasConstraintName("FK_ACTIVIDA_FK_ACTIVI_DISTRIBU");
        });

        modelBuilder.Entity<AutoridadesCarrera>(entity =>
        {
            entity.HasKey(e => e.IdAutoridadc).IsClustered(false);

            entity.ToTable("AUTORIDADES_CARRERA");

            entity.Property(e => e.IdAutoridadc).HasColumnName("ID_AUTORIDADC");
            entity.Property(e => e.ActivoAutoridadc).HasColumnName("ACTIVO_AUTORIDADC");
            entity.Property(e => e.ApellidosAutoridadc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS_AUTORIDADC");
            entity.Property(e => e.ClavefirmaeAutoridadc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLAVEFIRMAE_AUTORIDADC");
            entity.Property(e => e.DniAutoridadc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_AUTORIDADC");
            entity.Property(e => e.EmailAutoridadc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_AUTORIDADC");
            entity.Property(e => e.FechaactAutoridadc)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("FECHAACT_AUTORIDADC");
            entity.Property(e => e.FechafAutoridadc)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_AUTORIDADC");
            entity.Property(e => e.FechaiAutoridadc)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_AUTORIDADC");
            entity.Property(e => e.FecharegAutoridadc)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_AUTORIDADC");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.IdTipoAutoridadc).HasColumnName("ID_TIPO_AUTORIDADC");
            entity.Property(e => e.NombramientoAutoridadc).HasColumnName("NOMBRAMIENTO_AUTORIDADC");
            entity.Property(e => e.NombredAutoridadc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRED_AUTORIDADC");
            entity.Property(e => e.PathfirmadAutoridadc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAD_AUTORIDADC");
            entity.Property(e => e.PathfirmaeAutoridadc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAE_AUTORIDADC");
            entity.Property(e => e.PathnombramientoAutoridadc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATHNOMBRAMIENTO_AUTORIDADC");
            entity.Property(e => e.SemestresAutoridadc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMESTRES_AUTORIDADC");
            entity.Property(e => e.TelefonoAutoridadc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_AUTORIDADC");
            entity.Property(e => e.TipoDniAutoridadc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_DNI_AUTORIDADC");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.AutoridadesCarreras)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_AUTORIDA_FK_AUTORI_CARRERA");

            entity.HasOne(d => d.IdTipoAutoridadcNavigation).WithMany(p => p.AutoridadesCarreras)
                .HasForeignKey(d => d.IdTipoAutoridadc)
                .HasConstraintName("FK_AUTORIDADCARR_RELATIONS_TIPO_AUTCARR");
        });

        modelBuilder.Entity<AutoridadesFacultad>(entity =>
        {
            entity.HasKey(e => e.IdAutoridadf).IsClustered(false);

            entity.ToTable("AUTORIDADES_FACULTAD");

            entity.Property(e => e.IdAutoridadf).HasColumnName("ID_AUTORIDADF");
            entity.Property(e => e.ActivoAutoridadf).HasColumnName("ACTIVO_AUTORIDADF");
            entity.Property(e => e.ApellidosAutoridadf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS_AUTORIDADF");
            entity.Property(e => e.ClavefirmaeAutoridadf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLAVEFIRMAE_AUTORIDADF");
            entity.Property(e => e.DniAutoridadf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_AUTORIDADF");
            entity.Property(e => e.EmailAutoridadf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_AUTORIDADF");
            entity.Property(e => e.FechaactAutoridadf)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_AUTORIDADF");
            entity.Property(e => e.FechafAutoridadf)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_AUTORIDADF");
            entity.Property(e => e.FechaiAutoridadf)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_AUTORIDADF");
            entity.Property(e => e.FecharegAutoridadf)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_AUTORIDADF");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.IdTipoautoridadf).HasColumnName("ID_TIPOAUTORIDADF");
            entity.Property(e => e.NombramientoAutoridadf).HasColumnName("NOMBRAMIENTO_AUTORIDADF");
            entity.Property(e => e.NombresAutoridadc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_AUTORIDADC");
            entity.Property(e => e.PathfirmadAutoridadf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAD_AUTORIDADF");
            entity.Property(e => e.PathfirmaeAutoridadf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAE_AUTORIDADF");
            entity.Property(e => e.PathnombramientoAutoridadf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATHNOMBRAMIENTO_AUTORIDADF");
            entity.Property(e => e.SemestresAutoridadf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEMESTRES_AUTORIDADF");
            entity.Property(e => e.TelefonoAutoridadf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_AUTORIDADF");
            entity.Property(e => e.TipoDniAutoridadf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_DNI_AUTORIDADF");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.AutoridadesFacultads)
                .HasForeignKey(d => d.IdFacultad)
                .HasConstraintName("FK_AUTORIDA_FK_AUTORI_FACULTAD");

            entity.HasOne(d => d.IdTipoautoridadfNavigation).WithMany(p => p.AutoridadesFacultads)
                .HasForeignKey(d => d.IdTipoautoridadf)
                .HasConstraintName("FK_AUTORIDADFAC_RELATIONS_TIPO_AUTFAC");
        });

        modelBuilder.Entity<AutoridadesInstitucionEducativa>(entity =>
        {
            entity.HasKey(e => e.IdAutoridadesue)
                .HasName("PK_AUTORIDADES_INSTITUCION_EDU")
                .IsClustered(false);

            entity.ToTable("AUTORIDADES_INSTITUCION_EDUCATIVA");

            entity.Property(e => e.IdAutoridadesue).HasColumnName("ID_AUTORIDADESUE");
            entity.Property(e => e.ActivoAutoridadesue).HasColumnName("ACTIVO_AUTORIDADESUE");
            entity.Property(e => e.ApellidoAutoridadesue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_AUTORIDADESUE");
            entity.Property(e => e.ClavefirmaeAutoridadesue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLAVEFIRMAE_AUTORIDADESUE");
            entity.Property(e => e.DniAutoridadesue)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_AUTORIDADESUE");
            entity.Property(e => e.GuardaclavefirmaeAutoridadesue).HasColumnName("GUARDACLAVEFIRMAE_AUTORIDADESUE");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.IdTipoAie).HasColumnName("ID_TIPO_AIE");
            entity.Property(e => e.NombresAutoridadesue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_AUTORIDADESUE");
            entity.Property(e => e.PathfirmadAutoridadesue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAD_AUTORIDADESUE");
            entity.Property(e => e.PathfirmaeAutoridadesue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMAE_AUTORIDADESUE");
            entity.Property(e => e.TipodocAutoridadesue)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPODOC_AUTORIDADESUE");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.AutoridadesInstitucionEducativas)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_AUTORIDA_FK_AUTORI_INSTITUC");

            entity.HasOne(d => d.IdTipoAieNavigation).WithMany(p => p.AutoridadesInstitucionEducativas)
                .HasForeignKey(d => d.IdTipoAie)
                .HasConstraintName("FK_AUTORIDADINST_RELATIONS_TIPO_AUTINST");
        });

        modelBuilder.Entity<Campus>(entity =>
        {
            entity.HasKey(e => e.IdCampus).IsClustered(false);

            entity.ToTable("CAMPUS");

            entity.Property(e => e.IdCampus).HasColumnName("ID_CAMPUS");
            entity.Property(e => e.ActivoCampus).HasColumnName("ACTIVO_CAMPUS");
            entity.Property(e => e.CallePrincipalCampus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CALLE_PRINCIPAL_CAMPUS");
            entity.Property(e => e.CalleSecundariaCampus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CALLE_SECUNDARIA_CAMPUS");
            entity.Property(e => e.CodPostalCampus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_POSTAL_CAMPUS");
            entity.Property(e => e.CodigoCampus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CAMPUS");
            entity.Property(e => e.EmailCampus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CAMPUS");
            entity.Property(e => e.FaxCampus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX_CAMPUS");
            entity.Property(e => e.IdParroquia).HasColumnName("ID_PARROQUIA");
            entity.Property(e => e.IdSedeInstitucion).HasColumnName("ID_SEDE_INSTITUCION");
            entity.Property(e => e.NombreCampus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CAMPUS");
            entity.Property(e => e.NumeroCampus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CAMPUS");
            entity.Property(e => e.ReferenciaCampus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA_CAMPUS");
            entity.Property(e => e.TelefonoCampus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_CAMPUS");

            entity.HasOne(d => d.IdParroquiaNavigation).WithMany(p => p.Campuses)
                .HasForeignKey(d => d.IdParroquia)
                .HasConstraintName("FK_CAMPUS_FK_CAMPUS_PARROQUI");

            entity.HasOne(d => d.IdSedeInstitucionNavigation).WithMany(p => p.Campuses)
                .HasForeignKey(d => d.IdSedeInstitucion)
                .HasConstraintName("FK_CAMPUS_FK_CAMPUS_SEDE_INS");
        });

        modelBuilder.Entity<Canton>(entity =>
        {
            entity.HasKey(e => e.IdCanton).IsClustered(false);

            entity.ToTable("CANTON");

            entity.Property(e => e.IdCanton).HasColumnName("ID_CANTON");
            entity.Property(e => e.ActivoCanton).HasColumnName("ACTIVO_CANTON");
            entity.Property(e => e.CodigoCanton)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CANTON");
            entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");
            entity.Property(e => e.NombreCanton)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CANTON");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Cantons)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_CANTON_FK_CANTON_PROVINCI");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.IdCarrera).IsClustered(false);

            entity.ToTable("CARRERA");

            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.ActivoCarrera).HasColumnName("ACTIVO_CARRERA");
            entity.Property(e => e.CodigoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CARRERA");
            entity.Property(e => e.FechaactCarrera)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_CARRERA");
            entity.Property(e => e.FechacierraCarrera)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRA_CARRERA");
            entity.Property(e => e.FechacreaCarrera)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_CARRERA");
            entity.Property(e => e.IdEstadoCarrera).HasColumnName("ID_ESTADO_CARRERA");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.MencionCarrera)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MENCION_CARRERA");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CARRERA");
            entity.Property(e => e.PathdecretoAprobacionCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHDECRETO_APROBACION_CARRERA");
            entity.Property(e => e.SiglasCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIGLAS_CARRERA");
            entity.Property(e => e.TituloCarrera)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TITULO_CARRERA");

            entity.HasOne(d => d.IdEstadoCarreraNavigation).WithMany(p => p.Carreras)
                .HasForeignKey(d => d.IdEstadoCarrera)
                .HasConstraintName("FK_CARRERA_FK_CARRER_ESTADO_C");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.Carreras)
                .HasForeignKey(d => d.IdFacultad)
                .HasConstraintName("FK_CARRERA_FK_CARRER_FACULTAD");
        });

        modelBuilder.Entity<CatalogoDocumentosContratoDocente>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoDocumentosContratoDocente)
                .HasName("PK_CATALOGO_DOCUMENTOS_CONTRAT")
                .IsClustered(false);

            entity.ToTable("CATALOGO_DOCUMENTOS_CONTRATO_DOCENTE");

            entity.Property(e => e.IdCatalogoDocumentosContratoDocente).HasColumnName("ID_CATALOGO_DOCUMENTOS_CONTRATO_DOCENTE");
            entity.Property(e => e.ActivoCatalogoDocumentosContratoDocente).HasColumnName("ACTIVO_CATALOGO_DOCUMENTOS_CONTRATO_DOCENTE");
            entity.Property(e => e.DescripcionCatalogoDocumentosContratoDocente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_CATALOGO_DOCUMENTOS_CONTRATO_DOCENTE");
            entity.Property(e => e.NombreCatalogoDocumentosContratoDocente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE__CATALOGO_DOCUMENTOS_CONTRATO_DOCENTE");
        });

        modelBuilder.Entity<CatalogoMateria>(entity =>
        {
            entity.HasKey(e => e.CodigoMateriac).IsClustered(false);

            entity.ToTable("CATALOGO_MATERIAS");

            entity.Property(e => e.CodigoMateriac)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIAC");
            entity.Property(e => e.ActivoMateriac).HasColumnName("ACTIVO_MATERIAC");
            entity.Property(e => e.CreditosMateriac).HasColumnName("CREDITOS_MATERIAC");
            entity.Property(e => e.CuposMateriac).HasColumnName("CUPOS_MATERIAC");
            entity.Property(e => e.HorasSemestralesMateriac).HasColumnName("HORAS_SEMESTRALES_MATERIAC");
            entity.Property(e => e.IdTipoMateriaCatalogo).HasColumnName("ID_TIPO_MATERIA_CATALOGO");
            entity.Property(e => e.NombreMateriac)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIAC");
            entity.Property(e => e.UnescoMateriac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNESCO_MATERIAC");

            entity.HasOne(d => d.IdTipoMateriaCatalogoNavigation).WithMany(p => p.CatalogoMateria)
                .HasForeignKey(d => d.IdTipoMateriaCatalogo)
                .HasConstraintName("FK_CATALOGO_FK_CATALO_TIPO_MAT");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).IsClustered(false);

            entity.ToTable("CATEGORIA");

            entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.ActivoCategoria).HasColumnName("ACTIVO_CATEGORIA");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_CATEGORIA");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CATEGORIA");
        });

        modelBuilder.Entity<Componente>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoComponente, e.IdMateria }).IsClustered(false);

            entity.ToTable("COMPONENTE");

            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.ActivoComponente).HasColumnName("ACTIVO_COMPONENTE");
            entity.Property(e => e.CodigoComponente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_COMPONENTE");
            entity.Property(e => e.IdComponente)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_COMPONENTE");
            entity.Property(e => e.PesoComponente).HasColumnName("PESO_COMPONENTE");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Componentes)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPONEN_FK_MATERI_MATERIA");

            entity.HasOne(d => d.IdTipoComponenteNavigation).WithMany(p => p.Componentes)
                .HasForeignKey(d => d.IdTipoComponente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPONEN_FK_COMPON_TIPO_COM");
        });

        modelBuilder.Entity<ComponenteCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdComponentec).IsClustered(false);

            entity.ToTable("COMPONENTE_CATALOGO");

            entity.Property(e => e.IdComponentec).HasColumnName("ID_COMPONENTEC");
            entity.Property(e => e.CodigoComponentec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_COMPONENTEC");
            entity.Property(e => e.CodigoMateriac)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIAC");
            entity.Property(e => e.CreditosComponentec).HasColumnName("CREDITOS_COMPONENTEC");
            entity.Property(e => e.CuposComponentec).HasColumnName("CUPOS_COMPONENTEC");
            entity.Property(e => e.HorassemestreComponentec).HasColumnName("HORASSEMESTRE_COMPONENTEC");
            entity.Property(e => e.MinimoComponentec).HasColumnName("MINIMO_COMPONENTEC");
            entity.Property(e => e.NombreComponentec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_COMPONENTEC");
            entity.Property(e => e.NumprofesorComponentc).HasColumnName("NUMPROFESOR_COMPONENTC");
            entity.Property(e => e.PesoComponentec).HasColumnName("PESO_COMPONENTEC");

            entity.HasOne(d => d.CodigoMateriacNavigation).WithMany(p => p.ComponenteCatalogos)
                .HasForeignKey(d => d.CodigoMateriac)
                .HasConstraintName("FK_COMPONEN_FK_COMPON_CATALOGO");
        });

        modelBuilder.Entity<ConceptoCalificacione>(entity =>
        {
            entity.HasKey(e => e.IdConceptocalif).IsClustered(false);

            entity.ToTable("CONCEPTO_CALIFICACIONES");

            entity.Property(e => e.IdConceptocalif).HasColumnName("ID_CONCEPTOCALIF");
            entity.Property(e => e.ActivoConceptocalif).HasColumnName("ACTIVO_CONCEPTOCALIF");
            entity.Property(e => e.IdConfgen).HasColumnName("ID_CONFGEN");
            entity.Property(e => e.IdTipoConceptocalif).HasColumnName("ID_TIPO_CONCEPTOCALIF");
            entity.Property(e => e.NombreConceptocalif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONCEPTOCALIF");
            entity.Property(e => e.PorcentajeConceptocalif).HasColumnName("PORCENTAJE_CONCEPTOCALIF");
            entity.Property(e => e.SiglaConceptocalif)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SIGLA_CONCEPTOCALIF");
            entity.Property(e => e.ValorConceptocalif).HasColumnName("VALOR_CONCEPTOCALIF");

            entity.HasOne(d => d.IdConfgenNavigation).WithMany(p => p.ConceptoCalificaciones)
                .HasForeignKey(d => d.IdConfgen)
                .HasConstraintName("FK_CONCEPTOCALIF_RELATIONS_CONFGEN");

            entity.HasOne(d => d.IdTipoConceptocalifNavigation).WithMany(p => p.ConceptoCalificaciones)
                .HasForeignKey(d => d.IdTipoConceptocalif)
                .HasConstraintName("FK_CONCEPTO_FK_CONCEP_TIPO_CON");
        });

        modelBuilder.Entity<ConceptoMateriaConfiguracion>(entity =>
        {
            entity.HasKey(e => new { e.IdConceptosAdicionalesMateria, e.IdConfgen })
                .HasName("PK_CONCEPTO_MATERIA_CONFIGURAC")
                .IsClustered(false);

            entity.ToTable("CONCEPTO_MATERIA_CONFIGURACION");

            entity.Property(e => e.IdConceptosAdicionalesMateria)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_CONCEPTOS_ADICIONALES_MATERIA");
            entity.Property(e => e.IdConfgen).HasColumnName("ID_CONFGEN");
            entity.Property(e => e.ActivoConceptoAdicionalMateria).HasColumnName("ACTIVO_CONCEPTO_ADICIONAL_MATERIA");

            entity.HasOne(d => d.IdConceptosAdicionalesMateriaNavigation).WithMany(p => p.ConceptoMateriaConfiguracions)
                .HasForeignKey(d => d.IdConceptosAdicionalesMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONCEPTO_FK_CONCEP_CONCEPTO");

            entity.HasOne(d => d.IdConfgenNavigation).WithMany(p => p.ConceptoMateriaConfiguracions)
                .HasForeignKey(d => d.IdConfgen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONCEPTOMAT_RELATIONS_CONFGEN");
        });

        modelBuilder.Entity<ConceptoPrecio>(entity =>
        {
            entity.HasKey(e => e.IdPrecio).IsClustered(false);

            entity.ToTable("CONCEPTO_PRECIOS");

            entity.Property(e => e.IdPrecio).HasColumnName("ID_PRECIO");
            entity.Property(e => e.ActivoPrecio).HasColumnName("ACTIVO_PRECIO");
            entity.Property(e => e.DescripcionPrecio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PRECIO");
            entity.Property(e => e.FechafPrecio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_PRECIO");
            entity.Property(e => e.FechaiPrecio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_PRECIO");
            entity.Property(e => e.FecharegPrecio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_PRECIO");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.NombrePrecio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PRECIO");
            entity.Property(e => e.ObservacionPrecio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_PRECIO");
            entity.Property(e => e.UsuariomodPrecio)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOMOD_PRECIO");
            entity.Property(e => e.UsuarioregPrecio)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOREG_PRECIO");
            entity.Property(e => e.ValorPrecio).HasColumnName("VALOR_PRECIO");

            entity.HasOne(d => d.Malla).WithMany(p => p.ConceptoPrecios)
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio })
                .HasConstraintName("FK_CONCEPTO_FK_CONCEP_MALLA");
        });

        modelBuilder.Entity<ConceptosAdicionalesMaterium>(entity =>
        {
            entity.HasKey(e => e.IdConceptosAdicionalesMateria)
                .HasName("PK_CONCEPTOS_ADICIONALES_MATER")
                .IsClustered(false);

            entity.ToTable("CONCEPTOS_ADICIONALES_MATERIA");

            entity.Property(e => e.IdConceptosAdicionalesMateria).HasColumnName("ID_CONCEPTOS_ADICIONALES_MATERIA");
            entity.Property(e => e.ActivoConceptosAdicionalesMateria).HasColumnName("ACTIVO_CONCEPTOS_ADICIONALES_MATERIA");
            entity.Property(e => e.DescripcionConceptosAdicionalesMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_CONCEPTOS_ADICIONALES_MATERIA");
            entity.Property(e => e.NombreConceptosAdicionalesMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONCEPTOS_ADICIONALES_MATERIA");
        });

        modelBuilder.Entity<ConceptosGeneralesDescuento>(entity =>
        {
            entity.HasKey(e => e.IdConceptosDescuentos)
                .HasName("PK_CONCEPTOS_GENERALES_DESCUEN")
                .IsClustered(false);

            entity.ToTable("CONCEPTOS_GENERALES_DESCUENTOS");

            entity.Property(e => e.IdConceptosDescuentos).HasColumnName("ID_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.ActivoConceptosDescuentos).HasColumnName("ACTIVO_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.DescripcionConceptosDescuentos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.FechamodConceptosDescuentos)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMOD_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.FecharegConceptosDescuentos)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.NombreConceptosDescuentos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.UsuariocreaConceptosDescuentos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOCREA_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.UsuarioelimConceptosDescuentos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOELIM_CONCEPTOS_DESCUENTOS");
            entity.Property(e => e.UsuariomodConceptosDescuentos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOMOD_CONCEPTOS_DESCUENTOS");
        });

        modelBuilder.Entity<ConceptosGeneralesPrecio>(entity =>
        {
            entity.HasKey(e => e.IdConceptoGeneral).IsClustered(false);

            entity.ToTable("CONCEPTOS_GENERALES_PRECIOS");

            entity.Property(e => e.IdConceptoGeneral).HasColumnName("ID_CONCEPTO_GENERAL");
            entity.Property(e => e.ActivoConceptoGeneral).HasColumnName("ACTIVO_CONCEPTO_GENERAL");
            entity.Property(e => e.DescripcionConceptoGeneral)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_CONCEPTO_GENERAL");
            entity.Property(e => e.FecahregConceptoGeneral)
                .HasColumnType("datetime")
                .HasColumnName("FECAHREG_CONCEPTO_GENERAL");
            entity.Property(e => e.FechamodConceptoGeneral)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMOD_CONCEPTO_GENERAL");
            entity.Property(e => e.NombreConceptoGeneral)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONCEPTO_GENERAL");
            entity.Property(e => e.UsuariocreaConceptoGeneral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOCREA_CONCEPTO_GENERAL");
            entity.Property(e => e.UsuarioelimConceptoGeneral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOELIM_CONCEPTO_GENERAL");
            entity.Property(e => e.UsuariomodConceptoGeneral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOMOD_CONCEPTO_GENERAL");
        });

        modelBuilder.Entity<ConfiguracionesGenerale>(entity =>
        {
            entity.HasKey(e => e.IdConfgen).IsClustered(false);

            entity.ToTable("CONFIGURACIONES_GENERALES");

            entity.Property(e => e.IdConfgen).HasColumnName("ID_CONFGEN");
            entity.Property(e => e.ActivoConfgen).HasColumnName("ACTIVO_CONFGEN");
            entity.Property(e => e.AprobacionConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("APROBACION_CONFGEN");
            entity.Property(e => e.AsistecniasConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ASISTECNIAS_CONFGEN");
            entity.Property(e => e.ExamenFinalConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EXAMEN_FINAL_CONFGEN");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.NotaFinalConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NOTA_FINAL_CONFGEN");
            entity.Property(e => e.NotaminConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NOTAMIN_CONFGEN");
            entity.Property(e => e.NumParcialesConfgen).HasColumnName("NUM_PARCIALES_CONFGEN");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.ParcialConfgen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PARCIAL_CONFGEN");
            entity.Property(e => e.PorcentajeAprobacionConfgen).HasColumnName("PORCENTAJE_APROBACION_CONFGEN");
            entity.Property(e => e.PorcentajeAsistenciasConfgen).HasColumnName("PORCENTAJE_ASISTENCIAS_CONFGEN");
            entity.Property(e => e.PorcentajeExamenFinalConfgen).HasColumnName("PORCENTAJE_EXAMEN_FINAL_CONFGEN");
            entity.Property(e => e.PorcentajeNotaFinalConfgen).HasColumnName("PORCENTAJE_NOTA_FINAL_CONFGEN");
            entity.Property(e => e.PorcentajeNotaminConfgen).HasColumnName("PORCENTAJE_NOTAMIN_CONFGEN");
            entity.Property(e => e.PorcentajeParcialConfgen).HasColumnName("PORCENTAJE_PARCIAL_CONFGEN");

            entity.HasOne(d => d.Planificacion).WithMany(p => p.ConfiguracionesGenerales)
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio, d.IdPeriodo, d.IdPeriodicidad, d.IdTipoPeriodo, d.IdModalidad, d.IdEstadoPeriodo, d.IdModalidadPlanificacion, d.IdPeriodicidadPlanificacion, d.IdTipoComponente, d.Paralelo })
                .HasConstraintName("FK_CONFIGUR_FK_CONFIG_PLANIFIC");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.IdContrato).IsClustered(false);

            entity.ToTable("CONTRATO");

            entity.Property(e => e.IdContrato).HasColumnName("ID_CONTRATO");
            entity.Property(e => e.ActivoContrato).HasColumnName("ACTIVO_CONTRATO");
            entity.Property(e => e.FechaActualizaContrato)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACTUALIZA_CONTRATO");
            entity.Property(e => e.FechaRegistroContrato)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO_CONTRATO");
            entity.Property(e => e.FechafinContrato)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_CONTRATO");
            entity.Property(e => e.FechainicioContrato)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_CONTRATO");
            entity.Property(e => e.IdContratoModalidad).HasColumnName("ID_CONTRATO_MODALIDAD");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdEstadoContrato).HasColumnName("ID_ESTADO_CONTRATO");
            entity.Property(e => e.IdModalidadContrato).HasColumnName("ID_MODALIDAD_CONTRATO");
            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");
            entity.Property(e => e.IdconcursoContrato).HasColumnName("IDCONCURSO_CONTRATO");
            entity.Property(e => e.NumeroContrato)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CONTRATO");
            entity.Property(e => e.RmuContrato).HasColumnName("RMU_CONTRATO");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_CONTRATO_FK_CONTRA_EMPLEADO");

            entity.HasOne(d => d.IdEstadoContratoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEstadoContrato)
                .HasConstraintName("FK_CONTRATO_FK_CONTRA_ESTADO_C");

            entity.HasOne(d => d.IdModalidadContratoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdModalidadContrato)
                .HasConstraintName("FK_CONTRATO_FK_CONTRA_MODALIDA");

            entity.HasOne(d => d.IdTipoContratoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdTipoContrato)
                .HasConstraintName("FK_CONTRATO_FK_CONTRA_TIPO_CON");
        });

        modelBuilder.Entity<ControlesPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdControlPeriodo).IsClustered(false);

            entity.ToTable("CONTROLES_PERIODO");

            entity.Property(e => e.IdControlPeriodo).HasColumnName("ID_CONTROL_PERIODO");
            entity.Property(e => e.ActivoControlPeriodo).HasColumnName("ACTIVO_CONTROL_PERIODO");
            entity.Property(e => e.FechafControlPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_CONTROL_PERIODO");
            entity.Property(e => e.FechaiControlPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_CONTROL_PERIODO");
            entity.Property(e => e.IdCarreraControlPeriodo).HasColumnName("ID_CARRERA_CONTROL_PERIODO");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdFacultadControlPeriodo).HasColumnName("ID_FACULTAD_CONTROL_PERIODO");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.NombreControlPeriodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONTROL_PERIODO");
            entity.Property(e => e.VigenteControlPeriodo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("VIGENTE_CONTROL_PERIODO");

            entity.HasOne(d => d.Periodo).WithMany(p => p.ControlesPeriodos)
                .HasForeignKey(d => new { d.IdPeriodo, d.IdPeriodicidad, d.IdTipoPeriodo, d.IdModalidad, d.IdEstadoPeriodo })
                .HasConstraintName("FK_CONTROLE_FK_CONTRO_PERIODO");
        });

        modelBuilder.Entity<Convenio>(entity =>
        {
            entity.HasKey(e => e.IdConvenios).IsClustered(false);

            entity.ToTable("CONVENIOS");

            entity.Property(e => e.IdConvenios).HasColumnName("ID_CONVENIOS");
            entity.Property(e => e.ActivoConvenios).HasColumnName("ACTIVO_CONVENIOS");
            entity.Property(e => e.EmpresaConvenios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMPRESA_CONVENIOS");
            entity.Property(e => e.FechafinConvenios)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_CONVENIOS");
            entity.Property(e => e.FechainicioConvenios)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_CONVENIOS");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.IdTipoConvenio).HasColumnName("ID_TIPO_CONVENIO");
            entity.Property(e => e.NombreConvenios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CONVENIOS");
            entity.Property(e => e.PathConvenios)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATH_CONVENIOS");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_CONVENIO_FK_CONVEN_INSTITUC");

            entity.HasOne(d => d.IdTipoConvenioNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.IdTipoConvenio)
                .HasConstraintName("FK_CONVENIO_FK_CONVEN_TIPO_CON");
        });

        modelBuilder.Entity<Correquisito>(entity =>
        {
            entity.HasKey(e => e.IdCorrequisito).IsClustered(false);

            entity.ToTable("CORREQUISITO");

            entity.Property(e => e.IdCorrequisito).HasColumnName("ID_CORREQUISITO");
            entity.Property(e => e.ActivoMateriaCorrequisito).HasColumnName("ACTIVO_MATERIA_CORREQUISITO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.IdTipoPrecorrequisito).HasColumnName("ID_TIPO_PRECORREQUISITO");
            entity.Property(e => e.ObservacionCorrequisito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_CORREQUISITO");
            entity.Property(e => e.PathCorrequisito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH_CORREQUISITO");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Correquisitos)
                .HasForeignKey(d => d.IdPlanEstudio)
                .HasConstraintName("FK_CORREQUI_FK_CORREQ_PLAN_EST");

            entity.HasOne(d => d.IdTipoAprobacionNavigation).WithMany(p => p.Correquisitos)
                .HasForeignKey(d => d.IdTipoAprobacion)
                .HasConstraintName("FK_CORREQUI_FK_TIPOAP_TIPO_APR");

            entity.HasOne(d => d.IdTipoPrecorrequisitoNavigation).WithMany(p => p.Correquisitos)
                .HasForeignKey(d => d.IdTipoPrecorrequisito)
                .HasConstraintName("FK_CORREQUI_FK_CORREQ_TIPO_PRE");
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
                .HasColumnType("datetime")
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
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("DATABASECHANGELOGLOCK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Lockedby)
                .HasMaxLength(255)
                .HasColumnName("LOCKEDBY");
            entity.Property(e => e.Lockgranted)
                .HasColumnType("datetime")
                .HasColumnName("LOCKGRANTED");
        });

        modelBuilder.Entity<Dedicacion>(entity =>
        {
            entity.HasKey(e => e.IdDedicacion).IsClustered(false);

            entity.ToTable("DEDICACION");

            entity.Property(e => e.IdDedicacion).HasColumnName("ID_DEDICACION");
            entity.Property(e => e.ActivoDedicacion).HasColumnName("ACTIVO_DEDICACION");
            entity.Property(e => e.HorasDedicacion).HasColumnName("HORAS_DEDICACION");
            entity.Property(e => e.NombreDedicacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DEDICACION");
        });

        modelBuilder.Entity<Descuento>(entity =>
        {
            entity.HasKey(e => e.IdDescuento).IsClustered(false);

            entity.ToTable("DESCUENTOS");

            entity.Property(e => e.IdDescuento).HasColumnName("ID_DESCUENTO");
            entity.Property(e => e.ActivoDescuento).HasColumnName("ACTIVO_DESCUENTO");
            entity.Property(e => e.ConceptoGeneralPrecioDescuento).HasColumnName("CONCEPTO_GENERAL_PRECIO_DESCUENTO");
            entity.Property(e => e.FechaelimDescuento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAELIM_DESCUENTO");
            entity.Property(e => e.FechafDescuento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_DESCUENTO");
            entity.Property(e => e.FechaiDescuento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_DESCUENTO");
            entity.Property(e => e.FechamodDescuento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMOD_DESCUENTO");
            entity.Property(e => e.FecharegDescuento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_DESCUENTO");
            entity.Property(e => e.IdEstadoDescuento).HasColumnName("ID_ESTADO_DESCUENTO");
            entity.Property(e => e.MotivoDescuento)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("MOTIVO_DESCUENTO");
            entity.Property(e => e.UsuarioelimDescuento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOELIM_DESCUENTO");
            entity.Property(e => e.UsuariomodDescuento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOMOD_DESCUENTO");
            entity.Property(e => e.UsuarioregDescuento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOREG_DESCUENTO");
            entity.Property(e => e.ValorDescuento).HasColumnName("VALOR_DESCUENTO");

            entity.HasOne(d => d.IdEstadoDescuentoNavigation).WithMany(p => p.Descuentos)
                .HasForeignKey(d => d.IdEstadoDescuento)
                .HasConstraintName("FK_DESCUENT_FK_DESCUE_ESTADO_D");
        });

        modelBuilder.Entity<DesignacionesCarrera>(entity =>
        {
            entity.HasKey(e => e.IdDesignacionesCarreras).IsClustered(false);

            entity.ToTable("DESIGNACIONES_CARRERAS");

            entity.Property(e => e.IdDesignacionesCarreras).HasColumnName("ID_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.ActivoDesignacionesCarreras).HasColumnName("ACTIVO_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.DniusuarioDesignacionesCarreras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNIUSUARIO_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.FecahdelDesignacionesCarreras)
                .HasColumnType("datetime")
                .HasColumnName("FECAHDEL_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.FechaactDesignacionesCarreras)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.FechafinDesignacionesCarreras)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.FechainicioDesignacionesCarreras)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.FecharegDesignacionesCarreras)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.IdAutoridadentranteDesignacionesCarreras).HasColumnName("ID_AUTORIDADENTRANTE_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.IdAutoridadsalienteDesignacionesCarreras).HasColumnName("ID_AUTORIDADSALIENTE_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.MotivoDesignacionesCarreras)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOTIVO_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.ObservacionDesignacionesCarreras)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_DESIGNACIONES_CARRERAS");
            entity.Property(e => e.PatharchivoDesignacionesCarreras)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATHARCHIVO_DESIGNACIONES_CARRERAS");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.DesignacionesCarreras)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_DESIGNAC_FK_DESIGN_CARRERA");
        });

        modelBuilder.Entity<DesignacionesFacultad>(entity =>
        {
            entity.HasKey(e => e.IdDesignacionesFacultad).IsClustered(false);

            entity.ToTable("DESIGNACIONES_FACULTAD");

            entity.Property(e => e.IdDesignacionesFacultad).HasColumnName("ID_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.ActivoDesignacionesFacultad).HasColumnName("ACTIVO_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.DniusuarioDesignacionesFacultad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNIUSUARIO_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.FechaactDesignacionesFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.FechadelDesignacionesFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHADEL_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.FechafinDesignacionesFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.FechainicioDesignacionesFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.FecharegDesignacionesFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.IdAutoridadentranteDesignacionesFacultad).HasColumnName("ID_AUTORIDADENTRANTE_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.IdAutoridadsalienteDesignacionesFacultad).HasColumnName("ID_AUTORIDADSALIENTE_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.MotivoDesignacionesFacultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOTIVO_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.ObservacionDesignacionesFacultad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_DESIGNACIONES_FACULTAD");
            entity.Property(e => e.PatharchivoDesignacionesFacultad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATHARCHIVO_DESIGNACIONES_FACULTAD");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.DesignacionesFacultads)
                .HasForeignKey(d => d.IdFacultad)
                .HasConstraintName("FK_DESIGNAC_FK_DESIGN_FACULTAD");
        });

        modelBuilder.Entity<DesignacionesInstitucionEducativa>(entity =>
        {
            entity.HasKey(e => e.IdDesignacionesIe)
                .HasName("PK_DESIGNACIONES_INSTITUCION_E")
                .IsClustered(false);

            entity.ToTable("DESIGNACIONES_INSTITUCION_EDUCATIVA");

            entity.Property(e => e.IdDesignacionesIe).HasColumnName("ID_DESIGNACIONES_IE");
            entity.Property(e => e.ActivoDesignacionesIe).HasColumnName("ACTIVO_DESIGNACIONES_IE");
            entity.Property(e => e.DniusuarioDesignacionesIe)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNIUSUARIO_DESIGNACIONES_IE");
            entity.Property(e => e.FecahdelDesignacionesIe)
                .HasColumnType("datetime")
                .HasColumnName("FECAHDEL_DESIGNACIONES_IE");
            entity.Property(e => e.FecahfinDesignacionesIe)
                .HasColumnType("datetime")
                .HasColumnName("FECAHFIN_DESIGNACIONES_IE");
            entity.Property(e => e.FechaactDesignacionesIe)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_DESIGNACIONES_IE");
            entity.Property(e => e.FechainicioDesignacionesIe)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_DESIGNACIONES_IE");
            entity.Property(e => e.FecharegDesignacionesIe)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_DESIGNACIONES_IE");
            entity.Property(e => e.IdAutoridadieentranteDesignacionesIe).HasColumnName("ID_AUTORIDADIEENTRANTE_DESIGNACIONES_IE");
            entity.Property(e => e.IdAutoridadiesalienteDesignacionesIe).HasColumnName("ID_AUTORIDADIESALIENTE_DESIGNACIONES_IE");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.MotivoDesignacionesIe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOTIVO_DESIGNACIONES_IE");
            entity.Property(e => e.ObservacionDesignacionesIe)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_DESIGNACIONES_IE");
            entity.Property(e => e.PatharchivoDesignacionesIe)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATHARCHIVO_DESIGNACIONES_IE");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.DesignacionesInstitucionEducativas)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_DESIGNAC_FK_DESIGN_INSTITUC");
        });

        modelBuilder.Entity<DetalleItem>(entity =>
        {
            entity.HasKey(e => e.IdDetalleItem).IsClustered(false);

            entity.ToTable("DETALLE_ITEM");

            entity.Property(e => e.IdDetalleItem).HasColumnName("ID_DETALLE_ITEM");
            entity.Property(e => e.ActivoDetalleItem).HasColumnName("ACTIVO_DETALLE_ITEM");
            entity.Property(e => e.AnchoDetalleItem).HasColumnName("ANCHO_DETALLE_ITEM");
            entity.Property(e => e.AreaDetalleItem).HasColumnName("AREA_DETALLE_ITEM");
            entity.Property(e => e.DescripcionDetalleItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_DETALLE_ITEM");
            entity.Property(e => e.DimensionesDetalleItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIMENSIONES_DETALLE_ITEM");
            entity.Property(e => e.IdItem).HasColumnName("ID_ITEM");
            entity.Property(e => e.LargoDetalleItem).HasColumnName("LARGO_DETALLE_ITEM");
            entity.Property(e => e.NombreDetalleItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DETALLE_ITEM");
            entity.Property(e => e.ObservacionesDetalleItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_DETALLE_ITEM");
            entity.Property(e => e.ProfundidadDetalleItem).HasColumnName("PROFUNDIDAD_DETALLE_ITEM");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.DetalleItems)
                .HasForeignKey(d => d.IdItem)
                .HasConstraintName("FK_DETALLE__FK_DETALL_ITEM");
        });

        modelBuilder.Entity<DetalleOcupanteHorario>(entity =>
        {
            entity.HasKey(e => e.IdDetalleOcupanteHorario).IsClustered(false);

            entity.ToTable("DETALLE_OCUPANTE_HORARIO");

            entity.Property(e => e.IdDetalleOcupanteHorario).HasColumnName("ID_DETALLE_OCUPANTE_HORARIO");
            entity.Property(e => e.ActivoDetalleOcupanteHorario).HasColumnName("ACTIVO_DETALLE_OCUPANTE_HORARIO");
            entity.Property(e => e.DiasDetalleOcupanteHorario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DIAS_DETALLE_OCUPANTE_HORARIO");
            entity.Property(e => e.HorafDetalleOcupanteHorario)
                .HasColumnType("datetime")
                .HasColumnName("HORAF_DETALLE_OCUPANTE_HORARIO");
            entity.Property(e => e.HoraiDetalleOcupanteHorario)
                .HasColumnType("datetime")
                .HasColumnName("HORAI_DETALLE_OCUPANTE_HORARIO");
            entity.Property(e => e.IdOcupanteHorario).HasColumnName("ID_OCUPANTE_HORARIO");
            entity.Property(e => e.ObservacionesDetalleOcupanteHorario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_DETALLE_OCUPANTE_HORARIO");

            entity.HasOne(d => d.IdOcupanteHorarioNavigation).WithMany(p => p.DetalleOcupanteHorarios)
                .HasForeignKey(d => d.IdOcupanteHorario)
                .HasConstraintName("FK_DETALLE__FK_DETALL_OCUPANTE");
        });

        modelBuilder.Entity<DetallesEspacio>(entity =>
        {
            entity.HasKey(e => e.IdDetallesEspacio).IsClustered(false);

            entity.ToTable("DETALLES_ESPACIO");

            entity.Property(e => e.IdDetallesEspacio).HasColumnName("ID_DETALLES_ESPACIO");
            entity.Property(e => e.ActivoDetallesEspacio).HasColumnName("ACTIVO_DETALLES_ESPACIO");
            entity.Property(e => e.Coordenadax1DetallesEspacio).HasColumnName("COORDENADAX1_DETALLES_ESPACIO");
            entity.Property(e => e.Coordenadax2DetallesEspacio).HasColumnName("COORDENADAX2_DETALLES_ESPACIO");
            entity.Property(e => e.Coordenaday1DetallesEspacio).HasColumnName("COORDENADAY1_DETALLES_ESPACIO");
            entity.Property(e => e.Coordenaday2DetallesEspacio).HasColumnName("COORDENADAY2_DETALLES_ESPACIO");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.ObservacionesDetallesEspacio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_DETALLES_ESPACIO");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.DetallesEspacios)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_DETALLES_FK_DETALL_ESPACIOS");
        });

        modelBuilder.Entity<DistributivoDocente>(entity =>
        {
            entity.HasKey(e => e.IdDistributivo).IsClustered(false);

            entity.ToTable("DISTRIBUTIVO_DOCENTE");

            entity.Property(e => e.IdDistributivo).HasColumnName("ID_DISTRIBUTIVO");
            entity.Property(e => e.IdContratoDistributivo).HasColumnName("ID_CONTRATO_DISTRIBUTIVO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.DistributivoDocentes)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_DISTRIBU_FK_DISTRI_EMPLEADO");
        });

        modelBuilder.Entity<Dium>(entity =>
        {
            entity.HasKey(e => e.IdDia).IsClustered(false);

            entity.ToTable("DIA");

            entity.Property(e => e.IdDia)
                .ValueGeneratedNever()
                .HasColumnName("ID_DIA");
            entity.Property(e => e.CodDia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_DIA");
            entity.Property(e => e.DescripcionDia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_DIA");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DIA");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmp).IsClustered(false);

            entity.ToTable("EMPLEADO");

            entity.HasIndex(e => e.DniEmp, "AK_UQ__EMPLEADO__E35A_EMPLEADO").IsUnique();

            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.ActivoEmp).HasColumnName("ACTIVO_EMP");
            entity.Property(e => e.ApellidoEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_EMP");
            entity.Property(e => e.DniEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_EMP");
            entity.Property(e => e.EdadEmp).HasColumnName("EDAD_EMP");
            entity.Property(e => e.FechaActualizaEmp)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACTUALIZA_EMP");
            entity.Property(e => e.FechaRegistroEmp)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO_EMP");
            entity.Property(e => e.FnacEmp)
                .HasColumnType("datetime")
                .HasColumnName("FNAC_EMP");
            entity.Property(e => e.FotoEmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FOTO_EMP");
            entity.Property(e => e.IdEstadoEmp).HasColumnName("ID_ESTADO_EMP");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.IdTipoEmp).HasColumnName("ID_TIPO_EMP");
            entity.Property(e => e.NombresEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_EMP");
            entity.Property(e => e.PathfirmadigitalEmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMADIGITAL_EMP");

            entity.HasOne(d => d.IdEstadoEmpNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdEstadoEmp)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_ESTADO_E");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdFacultad)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_FACULTAD");

            entity.HasOne(d => d.IdTipoEmpNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdTipoEmp)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_TIPO_EMP");
        });

        modelBuilder.Entity<EspaciosFisico>(entity =>
        {
            entity.HasKey(e => e.IdEspaciosFisicos).IsClustered(false);

            entity.ToTable("ESPACIOS_FISICOS");

            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.ActivoEspaciosFisicos).HasColumnName("ACTIVO_ESPACIOS_FISICOS");
            entity.Property(e => e.AreaEspaciosFisicos).HasColumnName("AREA_ESPACIOS_FISICOS");
            entity.Property(e => e.CapacidadParcialEspaciosFisicos).HasColumnName("CAPACIDAD_PARCIAL_ESPACIOS_FISICOS");
            entity.Property(e => e.CapacidadTotalEspaciosFisicos).HasColumnName("CAPACIDAD_TOTAL_ESPACIOS_FISICOS");
            entity.Property(e => e.CapacidadVirtualEspaciosFisicos).HasColumnName("CAPACIDAD_VIRTUAL_ESPACIOS_FISICOS");
            entity.Property(e => e.CodigoEspaciosFisicos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_ESPACIOS_FISICOS");
            entity.Property(e => e.DescripcionEspaciosFisicos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_ESPACIOS_FISICOS");
            entity.Property(e => e.IdEstadoEspacio).HasColumnName("ID_ESTADO_ESPACIO");
            entity.Property(e => e.IdNivelInfraestructura).HasColumnName("ID_NIVEL_INFRAESTRUCTURA");
            entity.Property(e => e.IdTipoEspacio).HasColumnName("ID_TIPO_ESPACIO");
            entity.Property(e => e.NombreEspaciosFisicos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESPACIOS_FISICOS");

            entity.HasOne(d => d.IdEstadoEspacioNavigation).WithMany(p => p.EspaciosFisicos)
                .HasForeignKey(d => d.IdEstadoEspacio)
                .HasConstraintName("FK_ESPACIOS_FK_ESPACI_ESTADO_E");

            entity.HasOne(d => d.IdNivelInfraestructuraNavigation).WithMany(p => p.EspaciosFisicos)
                .HasForeignKey(d => d.IdNivelInfraestructura)
                .HasConstraintName("FK_ESPACIOS_FK_ESPACI_NIVEL_IN");

            entity.HasOne(d => d.IdTipoEspacioNavigation).WithMany(p => p.EspaciosFisicos)
                .HasForeignKey(d => d.IdTipoEspacio)
                .HasConstraintName("FK_ESPACIOS_FK_ESPACI_TIPO_ESP");
        });

        modelBuilder.Entity<EstadoCarrera>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCarrera).IsClustered(false);

            entity.ToTable("ESTADO_CARRERA");

            entity.Property(e => e.IdEstadoCarrera).HasColumnName("ID_ESTADO_CARRERA");
            entity.Property(e => e.ActivoEstadoCarrera).HasColumnName("ACTIVO_ESTADO_CARRERA");
            entity.Property(e => e.NombreEstadoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_CARRERA");
        });

        modelBuilder.Entity<EstadoContrato>(entity =>
        {
            entity.HasKey(e => e.IdEstadoContrato).IsClustered(false);

            entity.ToTable("ESTADO_CONTRATO");

            entity.Property(e => e.IdEstadoContrato).HasColumnName("ID_ESTADO_CONTRATO");
            entity.Property(e => e.ActivoEstadoContrato).HasColumnName("ACTIVO_ESTADO_CONTRATO");
            entity.Property(e => e.NombreEstadoContrato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_CONTRATO");
        });

        modelBuilder.Entity<EstadoDescuento>(entity =>
        {
            entity.HasKey(e => e.IdEstadoDescuento).IsClustered(false);

            entity.ToTable("ESTADO_DESCUENTO");

            entity.Property(e => e.IdEstadoDescuento).HasColumnName("ID_ESTADO_DESCUENTO");
            entity.Property(e => e.ActivoEstadoDescuento).HasColumnName("ACTIVO_ESTADO_DESCUENTO");
            entity.Property(e => e.DescripcionEstadoDescuento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_ESTADO_DESCUENTO");
            entity.Property(e => e.NombreEstadoDescuento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_DESCUENTO");
        });

        modelBuilder.Entity<EstadoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdEstadoEmp).IsClustered(false);

            entity.ToTable("ESTADO_EMPLEADO");

            entity.Property(e => e.IdEstadoEmp).HasColumnName("ID_ESTADO_EMP");
            entity.Property(e => e.ActivoEstadoEmp).HasColumnName("ACTIVO_ESTADO_EMP");
            entity.Property(e => e.NombreEstadoEmp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_EMP");
        });

        modelBuilder.Entity<EstadoEspacio>(entity =>
        {
            entity.HasKey(e => e.IdEstadoEspacio).IsClustered(false);

            entity.ToTable("ESTADO_ESPACIO");

            entity.Property(e => e.IdEstadoEspacio).HasColumnName("ID_ESTADO_ESPACIO");
            entity.Property(e => e.ActivoEstadoEspacio).HasColumnName("ACTIVO_ESTADO_ESPACIO");
            entity.Property(e => e.DescripcionEstadoEsapcio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_ESTADO_ESAPCIO");
            entity.Property(e => e.NombreEstadoEspacio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_ESPACIO");
        });

        modelBuilder.Entity<EstadoFacultad>(entity =>
        {
            entity.HasKey(e => e.IdEstadoFacultad).IsClustered(false);

            entity.ToTable("ESTADO_FACULTAD");

            entity.Property(e => e.IdEstadoFacultad).HasColumnName("ID_ESTADO_FACULTAD");
            entity.Property(e => e.ActivoEstadoFacultad).HasColumnName("ACTIVO_ESTADO_FACULTAD");
            entity.Property(e => e.NombreEstadoFacultad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_FACULTAD");
        });

        modelBuilder.Entity<EstadoFechasHorario>(entity =>
        {
            entity.HasKey(e => e.IdEstadoFechasHorario).IsClustered(false);

            entity.ToTable("ESTADO_FECHAS_HORARIO");

            entity.Property(e => e.IdEstadoFechasHorario).HasColumnName("ID_ESTADO_FECHAS_HORARIO");
            entity.Property(e => e.ActivoEstadoFechasHorario).HasColumnName("ACTIVO_ESTADO_FECHAS_HORARIO");
            entity.Property(e => e.NombreEstadoFechasHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_FECHAS_HORARIO");
        });

        modelBuilder.Entity<EstadoFranjaHorario>(entity =>
        {
            entity.HasKey(e => e.IdEstadoFranjaHorario).IsClustered(false);

            entity.ToTable("ESTADO_FRANJA_HORARIO");

            entity.Property(e => e.IdEstadoFranjaHorario).HasColumnName("ID_ESTADO_FRANJA_HORARIO");
            entity.Property(e => e.ActivoEstadoFranjaHorario).HasColumnName("ACTIVO_ESTADO_FRANJA_HORARIO");
            entity.Property(e => e.NombreEstadoFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_FRANJA_HORARIO");
        });

        modelBuilder.Entity<EstadoItem>(entity =>
        {
            entity.HasKey(e => e.IdEstadoItem).IsClustered(false);

            entity.ToTable("ESTADO_ITEM");

            entity.Property(e => e.IdEstadoItem).HasColumnName("ID_ESTADO_ITEM");
            entity.Property(e => e.ActivoEstadoItem).HasColumnName("ACTIVO_ESTADO_ITEM");
            entity.Property(e => e.DescripcionEstadoItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_ESTADO_ITEM");
            entity.Property(e => e.NombreEstadoItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_ITEM");
        });

        modelBuilder.Entity<EstadoOcupanteHorario>(entity =>
        {
            entity.HasKey(e => e.IdEstadoOcupanteHorario).IsClustered(false);

            entity.ToTable("ESTADO_OCUPANTE_HORARIO");

            entity.Property(e => e.IdEstadoOcupanteHorario).HasColumnName("ID_ESTADO_OCUPANTE_HORARIO");
            entity.Property(e => e.ActivoEstadoOcupanteHorario).HasColumnName("ACTIVO_ESTADO_OCUPANTE_HORARIO");
            entity.Property(e => e.NombreEstadoOcupanteHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_OCUPANTE_HORARIO");
        });

        modelBuilder.Entity<EstadoPe>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPe).IsClustered(false);

            entity.ToTable("ESTADO_PE");

            entity.Property(e => e.IdEstadoPe).HasColumnName("ID_ESTADO_PE");
            entity.Property(e => e.ActivoEstadoPe).HasColumnName("ACTIVO_ESTADO_PE");
            entity.Property(e => e.NombreEstadoPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_PE");
        });

        modelBuilder.Entity<EstadoPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPeriodo).IsClustered(false);

            entity.ToTable("ESTADO_PERIODO");

            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.ActivoEstadoPeriodo).HasColumnName("ACTIVO_ESTADO_PERIODO");
            entity.Property(e => e.NombreEstadoPeriodo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_PERIODO");
        });

        modelBuilder.Entity<EstadoRequisito>(entity =>
        {
            entity.HasKey(e => e.IdEstadoRequisitos).IsClustered(false);

            entity.ToTable("ESTADO_REQUISITOS");

            entity.Property(e => e.IdEstadoRequisitos).HasColumnName("ID_ESTADO_REQUISITOS");
            entity.Property(e => e.ActivoEstadoRequisito).HasColumnName("ACTIVO_ESTADO_REQUISITO");
            entity.Property(e => e.NombreEstadoRequisito)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ESTADO_REQUISITO");
        });

        modelBuilder.Entity<Facultad>(entity =>
        {
            entity.HasKey(e => e.IdFacultad).IsClustered(false);

            entity.ToTable("FACULTAD");

            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.ActivoFacultad).HasColumnName("ACTIVO_FACULTAD");
            entity.Property(e => e.CodigoFacultad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODIGO_FACULTAD");
            entity.Property(e => e.DescripcionFacultad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_FACULTAD");
            entity.Property(e => e.FechaactFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_FACULTAD");
            entity.Property(e => e.FechacierreFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRE_FACULTAD");
            entity.Property(e => e.FechacreaFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_FACULTAD");
            entity.Property(e => e.FecharegistroFacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO_FACULTAD");
            entity.Property(e => e.IdCampus).HasColumnName("ID_CAMPUS");
            entity.Property(e => e.IdEstadoFacultad).HasColumnName("ID_ESTADO_FACULTAD");
            entity.Property(e => e.NombreFacultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FACULTAD");
            entity.Property(e => e.ResolucionFacultad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RESOLUCION_FACULTAD");

            entity.HasOne(d => d.IdCampusNavigation).WithMany(p => p.Facultads)
                .HasForeignKey(d => d.IdCampus)
                .HasConstraintName("FK_FACULTAD_FK_FACULT_CAMPUS");

            entity.HasOne(d => d.IdEstadoFacultadNavigation).WithMany(p => p.Facultads)
                .HasForeignKey(d => d.IdEstadoFacultad)
                .HasConstraintName("FK_FACULTAD_FK_FACULT_ESTADO_F");
        });

        modelBuilder.Entity<FechasConceptocalif>(entity =>
        {
            entity.HasKey(e => e.IdFechaConcalif).IsClustered(false);

            entity.ToTable("FECHAS_CONCEPTOCALIF");

            entity.Property(e => e.IdFechaConcalif).HasColumnName("ID_FECHA_CONCALIF");
            entity.Property(e => e.ActivoConcalif).HasColumnName("ACTIVO_CONCALIF");
            entity.Property(e => e.FechafinConcalif)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN_CONCALIF");
            entity.Property(e => e.FechainicioConcalif)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO_CONCALIF");
            entity.Property(e => e.IdConceptocalif).HasColumnName("ID_CONCEPTOCALIF");
            entity.Property(e => e.NombreFechaConcalif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FECHA_CONCALIF");

            entity.HasOne(d => d.IdConceptocalifNavigation).WithMany(p => p.FechasConceptocalifs)
                .HasForeignKey(d => d.IdConceptocalif)
                .HasConstraintName("FK_FECHAS_C_FK_FECHAS_CONCEPTO");
        });

        modelBuilder.Entity<FechasHorario>(entity =>
        {
            entity.HasKey(e => e.IdFechaHorario).IsClustered(false);

            entity.ToTable("FECHAS_HORARIO");

            entity.Property(e => e.IdFechaHorario).HasColumnName("ID_FECHA_HORARIO");
            entity.Property(e => e.ActividadFechaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVIDAD_FECHA_HORARIO");
            entity.Property(e => e.ActivoFechaHorario).HasColumnName("ACTIVO_FECHA_HORARIO");
            entity.Property(e => e.DescripcionFechaHorario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_FECHA_HORARIO");
            entity.Property(e => e.FechafFechaHorario)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_FECHA_HORARIO");
            entity.Property(e => e.FechaiFechaHorario)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_FECHA_HORARIO");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdEstadoFechasHorario).HasColumnName("ID_ESTADO_FECHAS_HORARIO");
            entity.Property(e => e.IdPlanestudioFechasHorario).HasColumnName("ID_PLANESTUDIO_FECHAS_HORARIO");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.FechasHorarios)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_FECHAS_H_FK_FECHAS_ESPACIOS");

            entity.HasOne(d => d.IdEstadoFechasHorarioNavigation).WithMany(p => p.FechasHorarios)
                .HasForeignKey(d => d.IdEstadoFechasHorario)
                .HasConstraintName("FK_FECHAS_H_FK_FECHAS_ESTADO_F");
        });

        modelBuilder.Entity<FranjaHorario>(entity =>
        {
            entity.HasKey(e => e.IdFranjaHorario).IsClustered(false);

            entity.ToTable("FRANJA_HORARIO");

            entity.Property(e => e.IdFranjaHorario).HasColumnName("ID_FRANJA_HORARIO");
            entity.Property(e => e.ActivoFranjaHorario).HasColumnName("ACTIVO_FRANJA_HORARIO");
            entity.Property(e => e.DomingoFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOMINGO_FRANJA_HORARIO");
            entity.Property(e => e.EstadoDomingoFranjaHorario).HasColumnName("ESTADO_DOMINGO_FRANJA_HORARIO");
            entity.Property(e => e.EstadoJuevesFranjaHorario).HasColumnName("ESTADO_JUEVES_FRANJA_HORARIO");
            entity.Property(e => e.EstadoLunesFranjaHorario).HasColumnName("ESTADO_LUNES_FRANJA_HORARIO");
            entity.Property(e => e.EstadoMartesFranjaHorario).HasColumnName("ESTADO_MARTES_FRANJA_HORARIO");
            entity.Property(e => e.EstadoMiercolesFranjaHorario).HasColumnName("ESTADO_MIERCOLES_FRANJA_HORARIO");
            entity.Property(e => e.EstadoSabadoFranjaHorario).HasColumnName("ESTADO_SABADO_FRANJA_HORARIO");
            entity.Property(e => e.EstadoViernesFranjaHorario).HasColumnName("ESTADO_VIERNES_FRANJA_HORARIO");
            entity.Property(e => e.HorariofFranjaHorario)
                .HasColumnType("datetime")
                .HasColumnName("HORARIOF_FRANJA_HORARIO");
            entity.Property(e => e.HorarioiFranjaHorario)
                .HasColumnType("datetime")
                .HasColumnName("HORARIOI_FRANJA_HORARIO");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdEstadoFranjaHorario).HasColumnName("ID_ESTADO_FRANJA_HORARIO");
            entity.Property(e => e.JuevesFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUEVES_FRANJA_HORARIO");
            entity.Property(e => e.LunesFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUNES_FRANJA_HORARIO");
            entity.Property(e => e.MartesFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARTES_FRANJA_HORARIO");
            entity.Property(e => e.MiercolesFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MIERCOLES_FRANJA_HORARIO");
            entity.Property(e => e.ObservacionFranjaHorario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioDomingoFranjaHorario).HasColumnName("PLANESTUDIO_DOMINGO_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioJuevesFranjaHorario).HasColumnName("PLANESTUDIO_JUEVES_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioLunesFranjaHorario).HasColumnName("PLANESTUDIO_LUNES_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioMartesFranjaHorario).HasColumnName("PLANESTUDIO_MARTES_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioMiercolesFranjaHorario).HasColumnName("PLANESTUDIO_MIERCOLES_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioSabadoFranjaHorario).HasColumnName("PLANESTUDIO_SABADO_FRANJA_HORARIO");
            entity.Property(e => e.PlanestudioViernesFranjaHorario).HasColumnName("PLANESTUDIO_VIERNES_FRANJA_HORARIO");
            entity.Property(e => e.SabadoFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SABADO_FRANJA_HORARIO");
            entity.Property(e => e.ViernesFranjaHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VIERNES_FRANJA_HORARIO");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.FranjaHorarios)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_FRANJA_H_FK_FRANJA_ESPACIOS");

            entity.HasOne(d => d.IdEstadoFranjaHorarioNavigation).WithMany(p => p.FranjaHorarios)
                .HasForeignKey(d => d.IdEstadoFranjaHorario)
                .HasConstraintName("FK_FRANJA_H_FK_FRANJA_ESTADO_F");
        });

        modelBuilder.Entity<FranjaHorarium>(entity =>
        {
            entity.HasKey(e => e.IdFh).IsClustered(false);

            entity.ToTable("FRANJA_HORARIA");

            entity.Property(e => e.IdFh).HasColumnName("ID_FH");
            entity.Property(e => e.ActivoFh).HasColumnName("ACTIVO_FH");
            entity.Property(e => e.DiaFin).HasColumnName("DIA_FIN");
            entity.Property(e => e.DiaIni).HasColumnName("DIA_INI");
            entity.Property(e => e.HoraFin)
                .HasColumnType("datetime")
                .HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INI");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.SemestreFin).HasColumnName("SEMESTRE_FIN");
            entity.Property(e => e.SemestreIni).HasColumnName("SEMESTRE_INI");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.FranjaHoraria)
                .HasForeignKey(d => d.IdPlanEstudio)
                .HasConstraintName("FK_FRANJA_H_FK_FRANJA_PLAN_EST");
        });

        modelBuilder.Entity<GestionDocumental>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).IsClustered(false);

            entity.ToTable("GESTION_DOCUMENTAL");

            entity.Property(e => e.IdDocumento).HasColumnName("ID_DOCUMENTO");
            entity.Property(e => e.EstadoDocumento).HasColumnName("ESTADO_DOCUMENTO");
            entity.Property(e => e.IdContrato).HasColumnName("ID_CONTRATO");
            entity.Property(e => e.IdEstadoRequisitos).HasColumnName("ID_ESTADO_REQUISITOS");
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DOCUMENTO");
            entity.Property(e => e.PathDocumento)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATH_DOCUMENTO");

            entity.HasOne(d => d.IdContratoNavigation).WithMany(p => p.GestionDocumentals)
                .HasForeignKey(d => d.IdContrato)
                .HasConstraintName("FK_GESTION__FK_GESTIO_CONTRATO");

            entity.HasOne(d => d.IdEstadoRequisitosNavigation).WithMany(p => p.GestionDocumentals)
                .HasForeignKey(d => d.IdEstadoRequisitos)
                .HasConstraintName("FK_GESTION__FK_GESTIO_ESTADO_R");
        });

        modelBuilder.Entity<HistorialContrato>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).IsClustered(false);

            entity.ToTable("HISTORIAL_CONTRATO");

            entity.Property(e => e.IdHistorial).HasColumnName("ID_HISTORIAL");
            entity.Property(e => e.Dedicacion).HasColumnName("DEDICACION");
            entity.Property(e => e.EstadoContrato).HasColumnName("ESTADO_CONTRATO");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACTUALIZACION");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.IdContrato).HasColumnName("ID_CONTRATO");
            entity.Property(e => e.NumeroContratoHistorial)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CONTRATO_HISTORIAL");
            entity.Property(e => e.RelacionContrato).HasColumnName("RELACION_CONTRATO");
            entity.Property(e => e.TipoContrato).HasColumnName("TIPO_CONTRATO");

            entity.HasOne(d => d.IdContratoNavigation).WithMany(p => p.HistorialContratos)
                .HasForeignKey(d => d.IdContrato)
                .HasConstraintName("FK_HISTORIA_FK_HISTOR_CONTRATO");
        });

        modelBuilder.Entity<HistorialPrecio>(entity =>
        {
            entity.HasKey(e => e.IdHprecios).IsClustered(false);

            entity.ToTable("HISTORIAL_PRECIOS");

            entity.Property(e => e.IdHprecios).HasColumnName("ID_HPRECIOS");
            entity.Property(e => e.ActivoHprecios).HasColumnName("ACTIVO_HPRECIOS");
            entity.Property(e => e.DescripcionHprecios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_HPRECIOS");
            entity.Property(e => e.FechafHprecios)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_HPRECIOS");
            entity.Property(e => e.FechaiHprecios)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_HPRECIOS");
            entity.Property(e => e.FecharegHprecios)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_HPRECIOS");
            entity.Property(e => e.IdPrecio).HasColumnName("ID_PRECIO");
            entity.Property(e => e.MotivocambioHprecios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOTIVOCAMBIO_HPRECIOS");
            entity.Property(e => e.NombreHprecios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_HPRECIOS");
            entity.Property(e => e.ObservacionHprecios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_HPRECIOS");
            entity.Property(e => e.UsuariomodHprecios)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOMOD_HPRECIOS");
            entity.Property(e => e.UsuarioregHprecios)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOREG_HPRECIOS");
            entity.Property(e => e.ValorHprecios).HasColumnName("VALOR_HPRECIOS");

            entity.HasOne(d => d.IdPrecioNavigation).WithMany(p => p.HistorialPrecios)
                .HasForeignKey(d => d.IdPrecio)
                .HasConstraintName("FK_HISTORIA_FK_HISTOR_CONCEPTO");
        });

        modelBuilder.Entity<HistoricoCarrera>(entity =>
        {
            entity.HasKey(e => e.IdHistoricoc).IsClustered(false);

            entity.ToTable("HISTORICO_CARRERA");

            entity.Property(e => e.IdHistoricoc).HasColumnName("ID_HISTORICOC");
            entity.Property(e => e.ActivoHistoricoc).HasColumnName("ACTIVO_HISTORICOC");
            entity.Property(e => e.CodigoHistoricoc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODIGO_HISTORICOC");
            entity.Property(e => e.DescripcionHistoricoc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_HISTORICOC");
            entity.Property(e => e.FechaactHistoricoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_HISTORICOC");
            entity.Property(e => e.FechacierreHistoricoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRE_HISTORICOC");
            entity.Property(e => e.FechacreaHistoricoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_HISTORICOC");
            entity.Property(e => e.FecharegistroHistoricoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO_HISTORICOC");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.NombreHistoricoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_HISTORICOC");
            entity.Property(e => e.PathHistoricoc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATH_HISTORICOC");
            entity.Property(e => e.ResolucionHistoricoc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RESOLUCION_HISTORICOC");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.HistoricoCarreras)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_HISTORIC_FK_HISTOR_CARRERA");
        });

        modelBuilder.Entity<HistoricoFacultad>(entity =>
        {
            entity.HasKey(e => e.IdHfacultad).IsClustered(false);

            entity.ToTable("HISTORICO_FACULTAD");

            entity.Property(e => e.IdHfacultad).HasColumnName("ID_HFACULTAD");
            entity.Property(e => e.ActivoHfacultad).HasColumnName("ACTIVO_HFACULTAD");
            entity.Property(e => e.CodigoHfacultad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODIGO_HFACULTAD");
            entity.Property(e => e.DescripcionHfacultad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_HFACULTAD");
            entity.Property(e => e.FechaactHfacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_HFACULTAD");
            entity.Property(e => e.FechacierreHfacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRE_HFACULTAD");
            entity.Property(e => e.FechacreaHfacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_HFACULTAD");
            entity.Property(e => e.FecharegistroHfacultad)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO_HFACULTAD");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.NombreHfacultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_HFACULTAD");
            entity.Property(e => e.ParthHfacultad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PARTH_HFACULTAD");
            entity.Property(e => e.ResolucionHfacultad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RESOLUCION_HFACULTAD");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.HistoricoFacultads)
                .HasForeignKey(d => d.IdFacultad)
                .HasConstraintName("FK_HISTORIC_FK_HISTOR_FACULTAD");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO");

            entity.Property(e => e.HoraFin)
                .HasColumnType("datetime")
                .HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INI");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");

            entity.HasOne(d => d.IdDiaNavigation).WithMany()
                .HasForeignKey(d => d.IdDia)
                .HasConstraintName("FK_HORARIO_FK_DIA_RE_DIA");

            entity.HasOne(d => d.Planificacion).WithMany()
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio, d.IdPeriodo, d.IdPeriodicidad, d.IdTipoPeriodo, d.IdModalidad, d.IdEstadoPeriodo, d.IdModalidadPlanificacion, d.IdPeriodicidadPlanificacion, d.IdTipoComponente, d.Paralelo })
                .HasConstraintName("FK_HORARIO_FK_PLANIF_PLANIFIC");
        });

        modelBuilder.Entity<HorarioFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_FECHA");

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraFin)
                .HasColumnType("datetime")
                .HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INI");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");

            entity.HasOne(d => d.Planificacion).WithMany()
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio, d.IdPeriodo, d.IdPeriodicidad, d.IdTipoPeriodo, d.IdModalidad, d.IdEstadoPeriodo, d.IdModalidadPlanificacion, d.IdPeriodicidadPlanificacion, d.IdTipoComponente, d.Paralelo })
                .HasConstraintName("FK_HORARIO__RELATIONS_PLANIFIC");
        });

        modelBuilder.Entity<HorasModalidadMalla>(entity =>
        {
            entity.HasKey(e => e.IdHorasModalidadMalla).IsClustered(false);

            entity.ToTable("HORAS_MODALIDAD_MALLA");

            entity.Property(e => e.IdHorasModalidadMalla).HasColumnName("ID_HORAS_MODALIDAD_MALLA");
            entity.Property(e => e.ActivoModalidadMalla).HasColumnName("ACTIVO_MODALIDAD_MALLA");
            entity.Property(e => e.DescripcionModalidadMalla)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MODALIDAD_MALLA");
            entity.Property(e => e.HoraFinModalidadMalla)
                .HasColumnType("datetime")
                .HasColumnName("HORA_FIN_MODALIDAD_MALLA");
            entity.Property(e => e.HoraInicioModalidadMalla)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INICIO_MODALIDAD_MALLA");
            entity.Property(e => e.NombreModalidadMalla)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDAD_MALLA");
        });

        modelBuilder.Entity<InfoAcademica>(entity =>
        {
            entity.HasKey(e => e.IdInfoAcademica).IsClustered(false);

            entity.ToTable("INFO_ACADEMICA");

            entity.Property(e => e.IdInfoAcademica).HasColumnName("ID_INFO_ACADEMICA");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.InfoAcademicas)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_INFO_ACA_FK_INFO_A_EMPLEADO");
        });

        modelBuilder.Entity<InfoExperiencium>(entity =>
        {
            entity.HasKey(e => e.IdInfoExperiencia).IsClustered(false);

            entity.ToTable("INFO_EXPERIENCIA");

            entity.Property(e => e.IdInfoExperiencia).HasColumnName("ID_INFO_EXPERIENCIA");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.InfoExperiencia)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_INFO_EXP_FK_INFO_E_EMPLEADO");
        });

        modelBuilder.Entity<InfoPersonal>(entity =>
        {
            entity.HasKey(e => e.IdInforPersonal).IsClustered(false);

            entity.ToTable("INFO_PERSONAL");

            entity.Property(e => e.IdInforPersonal).HasColumnName("ID_INFOR_PERSONAL");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.InfoPersonals)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_INFO_PER_FK_INFO_P_EMPLEADO");
        });

        modelBuilder.Entity<InfoTitulo>(entity =>
        {
            entity.HasKey(e => e.IdInfoTitulos).IsClustered(false);

            entity.ToTable("INFO_TITULOS");

            entity.Property(e => e.IdInfoTitulos).HasColumnName("ID_INFO_TITULOS");
            entity.Property(e => e.IdInfoAcademica).HasColumnName("ID_INFO_ACADEMICA");

            entity.HasOne(d => d.IdInfoAcademicaNavigation).WithMany(p => p.InfoTitulos)
                .HasForeignKey(d => d.IdInfoAcademica)
                .HasConstraintName("FK_INFO_TIT_FK_INFO_T_INFO_ACA");
        });

        modelBuilder.Entity<Infraestructura>(entity =>
        {
            entity.HasKey(e => e.IdInfraestructura).IsClustered(false);

            entity.ToTable("INFRAESTRUCTURA");

            entity.Property(e => e.IdInfraestructura).HasColumnName("ID_INFRAESTRUCTURA");
            entity.Property(e => e.ActivoInfraestructura).HasColumnName("ACTIVO_INFRAESTRUCTURA");
            entity.Property(e => e.CodigoInfraestructura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_INFRAESTRUCTURA");
            entity.Property(e => e.IdCampus).HasColumnName("ID_CAMPUS");
            entity.Property(e => e.IdTipoInfraestructura).HasColumnName("ID_TIPO_INFRAESTRUCTURA");
            entity.Property(e => e.NombreInfraestructura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_INFRAESTRUCTURA");
            entity.Property(e => e.ReferenciaInfraestructura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA_INFRAESTRUCTURA");

            entity.HasOne(d => d.IdCampusNavigation).WithMany(p => p.Infraestructuras)
                .HasForeignKey(d => d.IdCampus)
                .HasConstraintName("FK_INFRAEST_FK_INFRAE_CAMPUS");

            entity.HasOne(d => d.IdTipoInfraestructuraNavigation).WithMany(p => p.Infraestructuras)
                .HasForeignKey(d => d.IdTipoInfraestructura)
                .HasConstraintName("FK_INFRAEST_FK_INFRAE_TIPO_INF");
        });

        modelBuilder.Entity<InstitucionEducativa>(entity =>
        {
            entity.HasKey(e => e.IdInstitucionEducativa).IsClustered(false);

            entity.ToTable("INSTITUCION_EDUCATIVA");

            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.ActivoInstitucionEducativa).HasColumnName("ACTIVO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.CodautorizacionInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODAUTORIZACION_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.CodigoInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.FechaactInstitucionEducativa)
                .HasColumnType("datetime")
                .HasColumnName("FECHAACT_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.FechacreaInstitucionEducativa)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.FechaeliInstitucionEducativa)
                .HasColumnType("datetime")
                .HasColumnName("FECHAELI_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.IdTipoInstitucionEducativa).HasColumnName("ID_TIPO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.NombreInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.PathauitorizacionInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHAUITORIZACION_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.UseractInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERACT_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.UsercreaInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERCREA_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.UsereliInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERELI_INSTITUCION_EDUCATIVA");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.InstitucionEducativas)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK_INSTITUC_FK_INSTIT_CATEGORI");

            entity.HasOne(d => d.IdTipoInstitucionEducativaNavigation).WithMany(p => p.InstitucionEducativas)
                .HasForeignKey(d => d.IdTipoInstitucionEducativa)
                .HasConstraintName("FK_INSTITUC_FK_INSTIT_TIPO_INS");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.IdItem).IsClustered(false);

            entity.ToTable("ITEM");

            entity.Property(e => e.IdItem).HasColumnName("ID_ITEM");
            entity.Property(e => e.ActivoItem).HasColumnName("ACTIVO_ITEM");
            entity.Property(e => e.DescripcionItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_ITEM");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdEstadoItem).HasColumnName("ID_ESTADO_ITEM");
            entity.Property(e => e.IdTipoItem).HasColumnName("ID_TIPO_ITEM");
            entity.Property(e => e.NombreItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ITEM");
            entity.Property(e => e.PathfotoItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFOTO_ITEM");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_ITEM_FK_ITEM_R_ESPACIOS");

            entity.HasOne(d => d.IdEstadoItemNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.IdEstadoItem)
                .HasConstraintName("FK_ITEM_FK_ITEM_R_ESTADO_I");

            entity.HasOne(d => d.IdTipoItemNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.IdTipoItem)
                .HasConstraintName("FK_ITEM_FK_ITEM_R_TIPO_ITE");
        });

        modelBuilder.Entity<Malla>(entity =>
        {
            entity.HasKey(e => new { e.IdMalla, e.IdMateria, e.IdNivelEstudio, e.IdPlanEstudio }).IsClustered(false);

            entity.ToTable("MALLA");

            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.ActivoMalla).HasColumnName("ACTIVO_MALLA");
            entity.Property(e => e.FecharegMalla)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_MALLA");
            entity.Property(e => e.ObservacionMalla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_MALLA");
            entity.Property(e => e.OrdenMalla).HasColumnName("ORDEN_MALLA");
            entity.Property(e => e.UsuarioactMalla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOACT_MALLA");
            entity.Property(e => e.UsuarioelimMalla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOELIM_MALLA");
            entity.Property(e => e.UsuarioregMalla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIOREG_MALLA");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Mallas)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MALLA_FK_PLAN_E_MATERIA");

            entity.HasOne(d => d.IdNivelEstudioNavigation).WithMany(p => p.Mallas)
                .HasForeignKey(d => d.IdNivelEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MALLA_FK_MATERI_NIVEL_ES");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Mallas)
                .HasForeignKey(d => d.IdPlanEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MALLA_FK_PE_REL_PLAN_EST");
        });

        modelBuilder.Entity<MateriaCompartidum>(entity =>
        {
            entity.HasKey(e => e.IdMateriaCompartida).IsClustered(false);

            entity.ToTable("MATERIA_COMPARTIDA");

            entity.Property(e => e.IdMateriaCompartida).HasColumnName("ID_MATERIA_COMPARTIDA");
            entity.Property(e => e.ActivoMateriaCompartida).HasColumnName("ACTIVO_MATERIA_COMPARTIDA");
            entity.Property(e => e.CarreraMateriaCompartida).HasColumnName("CARRERA_MATERIA_COMPARTIDA");
            entity.Property(e => e.CodigoMateriaCompartida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIA_COMPARTIDA");
            entity.Property(e => e.DescripcionMateriaCompartida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MATERIA_COMPARTIDA");
            entity.Property(e => e.NombreMateriaCompartida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIA_COMPARTIDA");
            entity.Property(e => e.ObservacionesMateriaCompartida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_MATERIA_COMPARTIDA");
            entity.Property(e => e.PlanEstudiosMateriaCompartida).HasColumnName("PLAN_ESTUDIOS_MATERIA_COMPARTIDA");
        });

        modelBuilder.Entity<MateriaEquivalente>(entity =>
        {
            entity.HasKey(e => e.IdMateriaEquivalente).IsClustered(false);

            entity.ToTable("MATERIA_EQUIVALENTE");

            entity.Property(e => e.IdMateriaEquivalente).HasColumnName("ID_MATERIA_EQUIVALENTE");
            entity.Property(e => e.ActivoMateriaEquivalente).HasColumnName("ACTIVO_MATERIA_EQUIVALENTE");
            entity.Property(e => e.AutorizacionMateriaEquivalente).HasColumnName("AUTORIZACION_MATERIA_EQUIVALENTE");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.MalIdMalla).HasColumnName("MAL_ID_MALLA");
            entity.Property(e => e.MalIdMateria).HasColumnName("MAL_ID_MATERIA");
            entity.Property(e => e.MalIdNivelEstudio).HasColumnName("MAL_ID_NIVEL_ESTUDIO");
            entity.Property(e => e.MalIdPlanEstudio).HasColumnName("MAL_ID_PLAN_ESTUDIO");
            entity.Property(e => e.ObservacionesMateriaEquivalente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_MATERIA_EQUIVALENTE");
            entity.Property(e => e.PathautorizacionMateriaEquivalente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHAUTORIZACION_MATERIA_EQUIVALENTE");

            entity.HasOne(d => d.Malla).WithMany(p => p.MateriaEquivalenteMallas)
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio })
                .HasConstraintName("FK_MATERIA__RELATIONS_MALLA_MAT");

            entity.HasOne(d => d.MallaNavigation).WithMany(p => p.MateriaEquivalenteMallaNavigations)
                .HasForeignKey(d => new { d.MalIdMalla, d.MalIdMateria, d.MalIdNivelEstudio, d.MalIdPlanEstudio })
                .HasConstraintName("FK_MATERIA_RELATIONS_MALLA_MATEQ");
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.IdMateria).IsClustered(false);

            entity.ToTable("MATERIA");

            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.ActivoMateria).HasColumnName("ACTIVO_MATERIA");
            entity.Property(e => e.CampoUnescoMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAMPO_UNESCO_MATERIA");
            entity.Property(e => e.CodigoMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIA");
            entity.Property(e => e.CreditosMateria).HasColumnName("CREDITOS_MATERIA");
            entity.Property(e => e.CuposMatriculaMateria).HasColumnName("CUPOS_MATRICULA_MATERIA");
            entity.Property(e => e.HorasSemestralesMateria).HasColumnName("HORAS_SEMESTRALES_MATERIA");
            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.IdUoc).HasColumnName("ID_UOC");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIA");

            entity.HasOne(d => d.IdTipoAprobacionNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdTipoAprobacion)
                .HasConstraintName("FK_MATERIA_FK_TIPO_A_TIPO_APR");

            entity.HasOne(d => d.IdUocNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdUoc)
                .HasConstraintName("FK_MATERIA_FK_MATERI_UNIDAD_O");
        });

        modelBuilder.Entity<ModalidadContrato>(entity =>
        {
            entity.HasKey(e => e.IdModalidadContrato).IsClustered(false);

            entity.ToTable("MODALIDAD_CONTRATO");

            entity.Property(e => e.IdModalidadContrato).HasColumnName("ID_MODALIDAD_CONTRATO");
            entity.Property(e => e.ActivoModalidadContrato).HasColumnName("ACTIVO_MODALIDAD_CONTRATO");
            entity.Property(e => e.DescripcionModalidadContrato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MODALIDAD_CONTRATO");
            entity.Property(e => e.NombreModalidadContrato)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDAD_CONTRATO");
        });

        modelBuilder.Entity<ModalidadPe>(entity =>
        {
            entity.HasKey(e => e.IdModalidadPe).IsClustered(false);

            entity.ToTable("MODALIDAD_PE");

            entity.Property(e => e.IdModalidadPe).HasColumnName("ID_MODALIDAD_PE");
            entity.Property(e => e.ActivoModalidadPe).HasColumnName("ACTIVO_MODALIDAD_PE");
            entity.Property(e => e.CodigoModalidadPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MODALIDAD_PE");
            entity.Property(e => e.DescripcionModalidadPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MODALIDAD_PE");
            entity.Property(e => e.NombreModalidadPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDAD_PE");
        });

        modelBuilder.Entity<ModalidadPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdModalidad).IsClustered(false);

            entity.ToTable("MODALIDAD_PERIODO");

            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.ActivoModalidadp).HasColumnName("ACTIVO_MODALIDADP");
            entity.Property(e => e.DescripcionModalidadp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_MODALIDADP");
            entity.Property(e => e.NombreModalidadp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDADP");
        });

        modelBuilder.Entity<ModalidadTitulacionPe>(entity =>
        {
            entity.HasKey(e => e.IdModalidadTitulacionPe).IsClustered(false);

            entity.ToTable("MODALIDAD_TITULACION_PE");

            entity.Property(e => e.IdModalidadTitulacionPe).HasColumnName("ID_MODALIDAD_TITULACION_PE");
            entity.Property(e => e.ActivoModalidadTitulacionPe).HasColumnName("ACTIVO_MODALIDAD_TITULACION_PE");
            entity.Property(e => e.CodigoModalidadTitulacionPe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MODALIDAD_TITULACION_PE");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdSubtipoTitulacion).HasColumnName("ID_SUBTIPO_TITULACION");
            entity.Property(e => e.NombreModalidadTitulacionPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDAD_TITULACION_PE");
            entity.Property(e => e.ObservacionModalidadTitulacionPe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_MODALIDAD_TITULACION_PE");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.ModalidadTitulacionPes)
                .HasForeignKey(d => d.IdPlanEstudio)
                .HasConstraintName("FK_MODALIDA_FK_MODALI_PLAN_EST");

            entity.HasOne(d => d.IdSubtipoTitulacionNavigation).WithMany(p => p.ModalidadTitulacionPes)
                .HasForeignKey(d => d.IdSubtipoTitulacion)
                .HasConstraintName("FK_MODALIDA_FK_SUBTIP_SUBTIPO_");
        });

        modelBuilder.Entity<NivelEstudio>(entity =>
        {
            entity.HasKey(e => e.IdNivelEstudio).IsClustered(false);

            entity.ToTable("NIVEL_ESTUDIO");

            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.ActivoNivelEstudio).HasColumnName("ACTIVO_NIVEL_ESTUDIO");
            entity.Property(e => e.CodigoNivelEstudio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_NIVEL_ESTUDIO");
            entity.Property(e => e.DescripcionNivelEstudio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_NIVEL_ESTUDIO");
            entity.Property(e => e.NombreNivelEstudio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_NIVEL_ESTUDIO");
        });

        modelBuilder.Entity<NivelInfraestructura>(entity =>
        {
            entity.HasKey(e => e.IdNivelInfraestructura).IsClustered(false);

            entity.ToTable("NIVEL_INFRAESTRUCTURA");

            entity.Property(e => e.IdNivelInfraestructura).HasColumnName("ID_NIVEL_INFRAESTRUCTURA");
            entity.Property(e => e.ActivoNivelInfraestructura).HasColumnName("ACTIVO_NIVEL_INFRAESTRUCTURA");
            entity.Property(e => e.CodigoNivelInfraestructura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_NIVEL_INFRAESTRUCTURA");
            entity.Property(e => e.IdInfraestructura).HasColumnName("ID_INFRAESTRUCTURA");
            entity.Property(e => e.IdPlanoNivel).HasColumnName("ID_PLANO_NIVEL");
            entity.Property(e => e.NombreNivelInfraestructura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_NIVEL_INFRAESTRUCTURA");

            entity.HasOne(d => d.IdInfraestructuraNavigation).WithMany(p => p.NivelInfraestructuras)
                .HasForeignKey(d => d.IdInfraestructura)
                .HasConstraintName("FK_NIVEL_IN_FK_NIVEL__INFRAEST");

            entity.HasOne(d => d.IdPlanoNivelNavigation).WithMany(p => p.NivelInfraestructuras)
                .HasForeignKey(d => d.IdPlanoNivel)
                .HasConstraintName("FK_NIVEL_IN_FK_NIVEL__PLANO_NI");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.IdNotac).IsClustered(false);

            entity.ToTable("NOTAS");

            entity.Property(e => e.IdNotac).HasColumnName("ID_NOTAC");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.EstadoNotac).HasColumnName("ESTADO_NOTAC");
            entity.Property(e => e.PorcentajeNotac).HasColumnName("PORCENTAJE_NOTAC");
            entity.Property(e => e.ValorNotac).HasColumnName("VALOR_NOTAC");

            entity.HasOne(d => d.DniProfesorcNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.DniProfesorc)
                .HasConstraintName("FK_NOTAS_FK_NOTAS__PROFESOR");
        });

        modelBuilder.Entity<NotificacionesCorreo>(entity =>
        {
            entity.HasKey(e => e.IdNotifCorreo).IsClustered(false);

            entity.ToTable("NOTIFICACIONES_CORREO");

            entity.Property(e => e.IdNotifCorreo).HasColumnName("ID_NOTIF_CORREO");
            entity.Property(e => e.ActivoNotifCorreo).HasColumnName("ACTIVO_NOTIF_CORREO");
            entity.Property(e => e.CorreoNotifCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_NOTIF_CORREO");
            entity.Property(e => e.ProcesoNotifCorreo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROCESO_NOTIF_CORREO");
        });

        modelBuilder.Entity<OcupanteHorario>(entity =>
        {
            entity.HasKey(e => e.IdOcupanteHorario).IsClustered(false);

            entity.ToTable("OCUPANTE_HORARIO");

            entity.Property(e => e.IdOcupanteHorario).HasColumnName("ID_OCUPANTE_HORARIO");
            entity.Property(e => e.ActivoOcupanteHorario).HasColumnName("ACTIVO_OCUPANTE_HORARIO");
            entity.Property(e => e.DniOcupanteHorario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_OCUPANTE_HORARIO");
            entity.Property(e => e.FechafOcupanteHorario)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_OCUPANTE_HORARIO");
            entity.Property(e => e.FechaiOcupanteHorario)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_OCUPANTE_HORARIO");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdEstadoOcupanteHorario).HasColumnName("ID_ESTADO_OCUPANTE_HORARIO");
            entity.Property(e => e.ObservacionesOcupanteHorario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_OCUPANTE_HORARIO");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.OcupanteHorarios)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_OCUPANTE_FK_OCUPAN_ESPACIOS");

            entity.HasOne(d => d.IdEstadoOcupanteHorarioNavigation).WithMany(p => p.OcupanteHorarios)
                .HasForeignKey(d => d.IdEstadoOcupanteHorario)
                .HasConstraintName("FK_OCUPANTE_FK_OCUPAN_ESTADO_O");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).IsClustered(false);

            entity.ToTable("PAIS");

            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.ActivoPais).HasColumnName("ACTIVO_PAIS");
            entity.Property(e => e.CodigoPais)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PAIS");
            entity.Property(e => e.CodsniesePais)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CODSNIESE_PAIS");
            entity.Property(e => e.NombrePais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PAIS");
        });

        modelBuilder.Entity<Parroquium>(entity =>
        {
            entity.HasKey(e => e.IdParroquia).IsClustered(false);

            entity.ToTable("PARROQUIA");

            entity.Property(e => e.IdParroquia).HasColumnName("ID_PARROQUIA");
            entity.Property(e => e.ActivoParroquia).HasColumnName("ACTIVO_PARROQUIA");
            entity.Property(e => e.CodigoParroquia)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PARROQUIA");
            entity.Property(e => e.IdCanton).HasColumnName("ID_CANTON");
            entity.Property(e => e.NombreParroquia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PARROQUIA");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Parroquia)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("FK_PARROQUIA_CANTON");
        });

        modelBuilder.Entity<PartidaPresupuestarium>(entity =>
        {
            entity.HasKey(e => e.IdPartida).IsClustered(false);

            entity.ToTable("PARTIDA_PRESUPUESTARIA");

            entity.Property(e => e.IdPartida).HasColumnName("ID_PARTIDA");
            entity.Property(e => e.ActivaPartida).HasColumnName("ACTIVA_PARTIDA");
            entity.Property(e => e.FechacierrePartida)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRE_PARTIDA");
            entity.Property(e => e.FechacreaPartida)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREA_PARTIDA");
            entity.Property(e => e.NombrePartida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PARTIDA");
            entity.Property(e => e.SaldoPartida).HasColumnName("SALDO_PARTIDA");
            entity.Property(e => e.ValorPartida).HasColumnName("VALOR_PARTIDA");
            entity.Property(e => e.VinicialPartida).HasColumnName("VINICIAL_PARTIDA");
        });

        modelBuilder.Entity<Periodicidad>(entity =>
        {
            entity.HasKey(e => e.IdPeriodicidad).IsClustered(false);

            entity.ToTable("PERIODICIDAD");

            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.ActivoPeriodicidad).HasColumnName("ACTIVO_PERIODICIDAD");
            entity.Property(e => e.NombrePeriodicidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERIODICIDAD");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => new { e.IdPeriodo, e.IdPeriodicidad, e.IdTipoPeriodo, e.IdModalidad, e.IdEstadoPeriodo }).IsClustered(false);

            entity.ToTable("PERIODO");

            entity.Property(e => e.IdPeriodo)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.ActivoPeriodo).HasColumnName("ACTIVO_PERIODO");
            entity.Property(e => e.CodigoNumeroPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_NUMERO_PERIODO");
            entity.Property(e => e.CodigoPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PERIODO");
            entity.Property(e => e.CodigoTextoPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TEXTO_PERIODO");
            entity.Property(e => e.DescripcionPeriodo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PERIODO");
            entity.Property(e => e.FechaActualizaPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACTUALIZA_PERIODO");
            entity.Property(e => e.FechaFinPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FIN_PERIODO");
            entity.Property(e => e.FechaInicioPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INICIO_PERIODO");
            entity.Property(e => e.FechaRegistroPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO_PERIODO");

            entity.HasOne(d => d.IdEstadoPeriodoNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdEstadoPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_ESTADO_P");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdModalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_MODALIDA");

            entity.HasOne(d => d.IdPeriodicidadNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdPeriodicidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_PERIODIC");

            entity.HasOne(d => d.IdTipoPeriodoNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdTipoPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_TIPO_PER");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermisos).IsClustered(false);

            entity.ToTable("PERMISOS");

            entity.Property(e => e.IdPermisos).HasColumnName("ID_PERMISOS");
            entity.Property(e => e.ActivoPermisos).HasColumnName("ACTIVO_PERMISOS");
            entity.Property(e => e.DescripcionPermisos)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PERMISOS");
            entity.Property(e => e.FecharegPermisos)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_PERMISOS");
            entity.Property(e => e.IdCampus).HasColumnName("ID_CAMPUS");
            entity.Property(e => e.IdTipoPermiso).HasColumnName("ID_TIPO_PERMISO");
            entity.Property(e => e.NombrePermisos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERMISOS");
            entity.Property(e => e.PathPermisos)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATH_PERMISOS");
            entity.Property(e => e.UsercreaPermisos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USERCREA_PERMISOS");

            entity.HasOne(d => d.IdCampusNavigation).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.IdCampus)
                .HasConstraintName("FK_PERMISOS_FK_PERMIS_CAMPUS");

            entity.HasOne(d => d.IdTipoPermisoNavigation).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.IdTipoPermiso)
                .HasConstraintName("FK_PERMISOS_RELATIONS_TIPO_PER");
        });

        modelBuilder.Entity<PermisosCarrera>(entity =>
        {
            entity.HasKey(e => e.IdPermisosCarrera).IsClustered(false);

            entity.ToTable("PERMISOS_CARRERA");

            entity.Property(e => e.IdPermisosCarrera).HasColumnName("ID_PERMISOS_CARRERA");
            entity.Property(e => e.ActivoPermisosCarrera).HasColumnName("ACTIVO_PERMISOS_CARRERA");
            entity.Property(e => e.DescripcionPermisosCarrera)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PERMISOS_CARRERA");
            entity.Property(e => e.FecahregPermisosCarrera)
                .HasColumnType("datetime")
                .HasColumnName("FECAHREG_PERMISOS_CARRERA");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.IdTipoPermisoCarrera).HasColumnName("ID_TIPO_PERMISO_CARRERA");
            entity.Property(e => e.NombrePermisosCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERMISOS_CARRERA");
            entity.Property(e => e.PathPermisosCarrera)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PATH_PERMISOS_CARRERA");
            entity.Property(e => e.UsercreaPermisosCarrera)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USERCREA_PERMISOS_CARRERA");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.PermisosCarreras)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_PERMISOS_FK_PERMIS_CARRERA");

            entity.HasOne(d => d.IdTipoPermisoCarreraNavigation).WithMany(p => p.PermisosCarreras)
                .HasForeignKey(d => d.IdTipoPermisoCarrera)
                .HasConstraintName("FK_PERMISOSCARR_RELATIONS_TIPO_PER_CARR");
        });

        modelBuilder.Entity<PlanEstudio>(entity =>
        {
            entity.HasKey(e => e.IdPlanEstudio).IsClustered(false);

            entity.ToTable("PLAN_ESTUDIO");

            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.ActivoMalla).HasColumnName("ACTIVO_MALLA");
            entity.Property(e => e.CodigoPlanEstudioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PLAN_ESTUDIO_MALLA");
            entity.Property(e => e.CupoCesMalla).HasColumnName("CUPO_CES_MALLA");
            entity.Property(e => e.DuracionSemestresMalla).HasColumnName("DURACION_SEMESTRES_MALLA");
            entity.Property(e => e.FechaAprobacionMalla)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_APROBACION_MALLA");
            entity.Property(e => e.FechaVigenciaMalla)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VIGENCIA_MALLA");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.IdEstadoPe).HasColumnName("ID_ESTADO_PE");
            entity.Property(e => e.IdModalidadPe).HasColumnName("ID_MODALIDAD_PE");
            entity.Property(e => e.NumerodecretoCesMalla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUMERODECRETO_CES_MALLA");
            entity.Property(e => e.ObservacionesMalla)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_MALLA");
            entity.Property(e => e.PathdecretoCesMalla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHDECRETO_CES_MALLA");
            entity.Property(e => e.PathresolucionactivaMalla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHRESOLUCIONACTIVA_MALLA");
            entity.Property(e => e.PathresolucioncierreMalla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHRESOLUCIONCIERRE_MALLA");
            entity.Property(e => e.PeriodicidadMalla).HasColumnName("PERIODICIDAD_MALLA");
            entity.Property(e => e.SemestreFinMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEMESTRE_FIN_MALLA");
            entity.Property(e => e.SemestreInicioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEMESTRE_INICIO_MALLA");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.PlanEstudios)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_PLAN_EST_FK_MALLA__CARRERA");

            entity.HasOne(d => d.IdEstadoPeNavigation).WithMany(p => p.PlanEstudios)
                .HasForeignKey(d => d.IdEstadoPe)
                .HasConstraintName("FK_PLAN_EST_FK_MALLA__ESTADO_P");

            entity.HasOne(d => d.IdModalidadPeNavigation).WithMany(p => p.PlanEstudios)
                .HasForeignKey(d => d.IdModalidadPe)
                .HasConstraintName("FK_PLAN_EST_FK_MODALI_MODALIDA");

            entity.HasOne(d => d.PeriodicidadMallaNavigation).WithMany(p => p.PlanEstudios)
                .HasForeignKey(d => d.PeriodicidadMalla)
                .HasConstraintName("FK_PLAN_ESTUDIO_PERIODICIDAD");
        });

        modelBuilder.Entity<Planificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdMalla, e.IdMateria, e.IdNivelEstudio, e.IdPlanEstudio, e.IdPeriodo, e.IdPeriodicidad, e.IdTipoPeriodo, e.IdModalidad, e.IdEstadoPeriodo, e.IdModalidadPlanificacion, e.IdPeriodicidadPlanificacion, e.IdTipoComponente, e.Paralelo }).IsClustered(false);

            entity.ToTable("PLANIFICACION");

            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("ID_PERIODICIDAD");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.Cupo).HasColumnName("CUPO");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");

            entity.HasOne(d => d.DniProfesorcNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.DniProfesorc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_PROFES_PROFESOR");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .HasConstraintName("FK_PLANIFIC_RELATIONS_ESPACIOS");

            entity.HasOne(d => d.IdModalidadPlanificacionNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdModalidadPlanificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_MODALI_MODALIDA");

            entity.HasOne(d => d.IdPeriodicidadPlanificacionNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdPeriodicidadPlanificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_PERIOD_PERIODIC");

            entity.HasOne(d => d.Componente).WithMany(p => p.Planificacions)
                .HasForeignKey(d => new { d.IdTipoComponente, d.IdMateria })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_RELATIONS_COMPONEN");

            entity.HasOne(d => d.Malla).WithMany(p => p.Planificacions)
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_MALLA__MALLA");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Planificacions)
                .HasForeignKey(d => new { d.IdPeriodo, d.IdPeriodicidad, d.IdTipoPeriodo, d.IdModalidad, d.IdEstadoPeriodo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_PERIOD_PERIODO");
        });

        modelBuilder.Entity<PlanoNivel>(entity =>
        {
            entity.HasKey(e => e.IdPlanoNivel).IsClustered(false);

            entity.ToTable("PLANO_NIVEL");

            entity.Property(e => e.IdPlanoNivel).HasColumnName("ID_PLANO_NIVEL");
            entity.Property(e => e.ActivoPlanoNivel).HasColumnName("ACTIVO_PLANO_NIVEL");
            entity.Property(e => e.CodigoPlanoNivel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PLANO_NIVEL");
            entity.Property(e => e.IdNivelInfraestructura).HasColumnName("ID_NIVEL_INFRAESTRUCTURA");
            entity.Property(e => e.NombrePlanoNivel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PLANO_NIVEL");
            entity.Property(e => e.PathPlanoNivel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH_PLANO_NIVEL");

            entity.HasOne(d => d.IdNivelInfraestructuraNavigation).WithMany(p => p.PlanoNivels)
                .HasForeignKey(d => d.IdNivelInfraestructura)
                .HasConstraintName("FK_PLANO_NI_FK_PLANO__NIVEL_IN");
        });

        modelBuilder.Entity<Premio>(entity =>
        {
            entity.HasKey(e => e.IdPremios).IsClustered(false);

            entity.ToTable("PREMIOS");

            entity.Property(e => e.IdPremios).HasColumnName("ID_PREMIOS");
            entity.Property(e => e.ActivoPremios).HasColumnName("ACTIVO_PREMIOS");
            entity.Property(e => e.FecahregPremios)
                .HasColumnType("datetime")
                .HasColumnName("FECAHREG_PREMIOS");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.NombrePremios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PREMIOS");
            entity.Property(e => e.OtorgaPremios)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OTORGA_PREMIOS");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.Premios)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_PREMIOS_FK_PREMIO_INSTITUC");
        });

        modelBuilder.Entity<Prerrequisito>(entity =>
        {
            entity.HasKey(e => e.IdPrerequisito).IsClustered(false);

            entity.ToTable("PRERREQUISITO");

            entity.Property(e => e.IdPrerequisito).HasColumnName("ID_PREREQUISITO");
            entity.Property(e => e.ActivoMateriaPpestudios).HasColumnName("ACTIVO_MATERIA_PPESTUDIOS");
            entity.Property(e => e.DescripcionPpestudios)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_PPESTUDIOS");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.IdTipoPrecorrequisito).HasColumnName("ID_TIPO_PRECORREQUISITO");
            entity.Property(e => e.PathPrerrequsito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH_PRERREQUSITO");

            entity.HasOne(d => d.IdTipoAprobacionNavigation).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => d.IdTipoAprobacion)
                .HasConstraintName("FK_PRERREQU_FK_TIPOAP_TIPO_APR");

            entity.HasOne(d => d.IdTipoPrecorrequisitoNavigation).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => d.IdTipoPrecorrequisito)
                .HasConstraintName("FK_PRERREQU_FK_TIPOPR_TIPO_PRE");

            entity.HasOne(d => d.Malla).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => new { d.IdMalla, d.IdMateria, d.IdNivelEstudio, d.IdPlanEstudio })
                .HasConstraintName("FK_PRERREQU_FK_PRERRE_MALLA");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.DniProfesorc).IsClustered(false);

            entity.ToTable("PROFESOR");

            entity.HasIndex(e => e.DniProfesorc, "AK_UQ__PROFESOR__E6D1_PROFESOR").IsUnique();

            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.ActivoProfesorc).HasColumnName("ACTIVO_PROFESORC");
            entity.Property(e => e.PricipalProfesorc).HasColumnName("PRICIPAL_PROFESORC");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).IsClustered(false);

            entity.ToTable("PROVINCIA");

            entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");
            entity.Property(e => e.ActivoProvincia).HasColumnName("ACTIVO_PROVINCIA");
            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PROVINCIA");
            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.NombreProvincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PROVINCIA");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK_PROVINCIA_PAIS");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.IdRegion).IsClustered(false);

            entity.ToTable("REGION");

            entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");
            entity.Property(e => e.ActivoRegion).HasColumnName("ACTIVO_REGION");
            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.NombreRegion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_REGION");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Regions)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK_REGION_FK_REGION_PAIS");
        });

        modelBuilder.Entity<RelacionContrato>(entity =>
        {
            entity.HasKey(e => e.IdRelacion).IsClustered(false);

            entity.ToTable("RELACION_CONTRATO");

            entity.Property(e => e.IdRelacion).HasColumnName("ID_RELACION");
            entity.Property(e => e.ActivoRelacion).HasColumnName("ACTIVO_RELACION");
            entity.Property(e => e.DescripcionRelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RELACION");
            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");
            entity.Property(e => e.NombreRelacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_RELACION");

            entity.HasOne(d => d.IdTipoContratoNavigation).WithMany(p => p.RelacionContratos)
                .HasForeignKey(d => d.IdTipoContrato)
                .HasConstraintName("FK_RELACION_FK_RELACI_TIPO_CON");
        });

        modelBuilder.Entity<RequisitosEgresamientoPe>(entity =>
        {
            entity.HasKey(e => e.IdReqEgresamientoPe).IsClustered(false);

            entity.ToTable("REQUISITOS_EGRESAMIENTO_PE");

            entity.Property(e => e.IdReqEgresamientoPe).HasColumnName("ID_REQ_EGRESAMIENTO_PE");
            entity.Property(e => e.ActivoReqEgresamientoPe).HasColumnName("ACTIVO_REQ_EGRESAMIENTO_PE");
            entity.Property(e => e.CodigoReqEgresamientoPe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_REQ_EGRESAMIENTO_PE");
            entity.Property(e => e.DescripcionReqEgresamientoPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_REQ_EGRESAMIENTO_PE");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdTipoReqEgresamiento).HasColumnName("ID_TIPO_REQ_EGRESAMIENTO");
            entity.Property(e => e.NombreReqEgresamientoPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_REQ_EGRESAMIENTO_PE");
            entity.Property(e => e.ObservacionReqEgresamientoPe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_REQ_EGRESAMIENTO_PE");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.RequisitosEgresamientoPes)
                .HasForeignKey(d => d.IdPlanEstudio)
                .HasConstraintName("FK_REQUISIT_FK_REQUIS_PLAN_EST");

            entity.HasOne(d => d.IdTipoReqEgresamientoNavigation).WithMany(p => p.RequisitosEgresamientoPes)
                .HasForeignKey(d => d.IdTipoReqEgresamiento)
                .HasConstraintName("FK_REQUISIT_FK_REQUIS_TIPO_REQ");
        });

        modelBuilder.Entity<RequisitosTipoContrato>(entity =>
        {
            entity.HasKey(e => e.IdRequisitosTipoContrato).IsClustered(false);

            entity.ToTable("REQUISITOS_TIPO_CONTRATO");

            entity.Property(e => e.IdRequisitosTipoContrato).HasColumnName("ID_REQUISITOS_TIPO_CONTRATO");
            entity.Property(e => e.IdCatalogodocumentosrequisitosTipoContrato).HasColumnName("ID_CATALOGODOCUMENTOSREQUISITOS_TIPO_CONTRATO");
            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");

            entity.HasOne(d => d.IdTipoContratoNavigation).WithMany(p => p.RequisitosTipoContratos)
                .HasForeignKey(d => d.IdTipoContrato)
                .HasConstraintName("FK_REQUISIT_FK_REQUIS_TIPO_CON");
        });

        modelBuilder.Entity<SedeInstitucion>(entity =>
        {
            entity.HasKey(e => e.IdSedeInstitucion).IsClustered(false);

            entity.ToTable("SEDE_INSTITUCION");

            entity.Property(e => e.IdSedeInstitucion).HasColumnName("ID_SEDE_INSTITUCION");
            entity.Property(e => e.ActivoSedeInstitucion).HasColumnName("ACTIVO_SEDE_INSTITUCION");
            entity.Property(e => e.CodigoSedeInstitucion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_SEDE_INSTITUCION");
            entity.Property(e => e.IdInstitucionEducativa).HasColumnName("ID_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.NombreSedeInstitucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_SEDE_INSTITUCION");

            entity.HasOne(d => d.IdInstitucionEducativaNavigation).WithMany(p => p.SedeInstitucions)
                .HasForeignKey(d => d.IdInstitucionEducativa)
                .HasConstraintName("FK_SEDE_INS_FK_SEDE_I_INSTITUC");
        });

        modelBuilder.Entity<SubnivelEstudio>(entity =>
        {
            entity.HasKey(e => e.IdSubnivelEstudio).IsClustered(false);

            entity.ToTable("SUBNIVEL_ESTUDIO");

            entity.Property(e => e.IdSubnivelEstudio).HasColumnName("ID_SUBNIVEL_ESTUDIO");
            entity.Property(e => e.ActivoSubnivelEstudio).HasColumnName("ACTIVO_SUBNIVEL_ESTUDIO");
            entity.Property(e => e.CodigoSubnivelEstudio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_SUBNIVEL_ESTUDIO");
            entity.Property(e => e.DescripcionSubnivelEstudio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_SUBNIVEL_ESTUDIO");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.NombreSubnivelEstudio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_SUBNIVEL_ESTUDIO");

            entity.HasOne(d => d.IdNivelEstudioNavigation).WithMany(p => p.SubnivelEstudios)
                .HasForeignKey(d => d.IdNivelEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUBNIVEL_ESTUDIO_NIVEL_ESTUDIO");
        });

        modelBuilder.Entity<SubtipoTitulacion>(entity =>
        {
            entity.HasKey(e => e.IdSubtipoTitulacion).IsClustered(false);

            entity.ToTable("SUBTIPO_TITULACION");

            entity.Property(e => e.IdSubtipoTitulacion).HasColumnName("ID_SUBTIPO_TITULACION");
            entity.Property(e => e.ActivoTipoTitulacion).HasColumnName("ACTIVO_TIPO_TITULACION");
            entity.Property(e => e.IdTipoTitulacion).HasColumnName("ID_TIPO_TITULACION");
            entity.Property(e => e.NombreSubtipoTitulacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_SUBTIPO_TITULACION");

            entity.HasOne(d => d.IdTipoTitulacionNavigation).WithMany(p => p.SubtipoTitulacions)
                .HasForeignKey(d => d.IdTipoTitulacion)
                .HasConstraintName("FK_SUBTIPO__FK_TIPOTI_TIPO_TIT");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity.HasKey(e => e.DiagramId)
                .HasName("PK_SYSDIAGRAMS")
                .IsClustered(false);

            entity.ToTable("sysdiagrams", tb => tb.HasComment("1"));

            entity.HasIndex(e => new { e.PrincipalId, e.Name }, "AK_UK_PRINCIPAL_NAME_SYSDIAGR").IsUnique();

            entity.Property(e => e.DiagramId).HasColumnName("DIAGRAM_ID");
            entity.Property(e => e.Definition).HasColumnName("DEFINITION");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME");
            entity.Property(e => e.PrincipalId).HasColumnName("PRINCIPAL_ID");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<TipoActividade>(entity =>
        {
            entity.HasKey(e => e.IdTipoActividades).IsClustered(false);

            entity.ToTable("TIPO_ACTIVIDADES");

            entity.Property(e => e.IdTipoActividades).HasColumnName("ID_TIPO_ACTIVIDADES");
            entity.Property(e => e.IdActividades).HasColumnName("ID_ACTIVIDADES");

            entity.HasOne(d => d.IdActividadesNavigation).WithMany(p => p.TipoActividades)
                .HasForeignKey(d => d.IdActividades)
                .HasConstraintName("FK_TIPO_ACT_FK_TIPO_A_ACTIVIDA");
        });

        modelBuilder.Entity<TipoAprobacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoAprobacion).IsClustered(false);

            entity.ToTable("TIPO_APROBACION");

            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.ActivoTipoAprobacion).HasColumnName("ACTIVO_TIPO_APROBACION");
            entity.Property(e => e.CodigoTipoAprobacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TIPO_APROBACION");
            entity.Property(e => e.NombreTipoAprobacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_APROBACION");
            entity.Property(e => e.ObservacionesTipoAprobacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_TIPO_APROBACION");
        });

        modelBuilder.Entity<TipoAutoridadCarrera>(entity =>
        {
            entity.HasKey(e => e.IdTipoAutoridadc).IsClustered(false);

            entity.ToTable("TIPO_AUTORIDAD_CARRERA");

            entity.Property(e => e.IdTipoAutoridadc).HasColumnName("ID_TIPO_AUTORIDADC");
            entity.Property(e => e.ActivoTipoAutoridadc).HasColumnName("ACTIVO_TIPO_AUTORIDADC");
            entity.Property(e => e.NombreTipoAutoridadc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_AUTORIDADC");
        });

        modelBuilder.Entity<TipoAutoridadInstitucionEducativa>(entity =>
        {
            entity.HasKey(e => e.IdTipoAie)
                .HasName("PK_TIPO_AUTORIDAD_INSTITUCION_")
                .IsClustered(false);

            entity.ToTable("TIPO_AUTORIDAD_INSTITUCION_EDUCATIVA");

            entity.Property(e => e.IdTipoAie).HasColumnName("ID_TIPO_AIE");
            entity.Property(e => e.ActivoTipoAie).HasColumnName("ACTIVO_TIPO_AIE");
            entity.Property(e => e.DescripcionTipoAie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_AIE");
            entity.Property(e => e.FechafTipoAie)
                .HasColumnType("datetime")
                .HasColumnName("FECHAF_TIPO_AIE");
            entity.Property(e => e.FechaiTipoAie)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI_TIPO_AIE");
            entity.Property(e => e.FecharegTipoAie)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_TIPO_AIE");
            entity.Property(e => e.NombreTipoAie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_AIE");
        });

        modelBuilder.Entity<TipoAutoridadfacultad>(entity =>
        {
            entity.HasKey(e => e.IdTipoautoridadf).IsClustered(false);

            entity.ToTable("TIPO_AUTORIDADFACULTAD");

            entity.Property(e => e.IdTipoautoridadf).HasColumnName("ID_TIPOAUTORIDADF");
            entity.Property(e => e.ActivoTipoautoridadf).HasColumnName("ACTIVO_TIPOAUTORIDADF");
            entity.Property(e => e.NombreTipoautoridadf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPOAUTORIDADF");
        });

        modelBuilder.Entity<TipoComponente>(entity =>
        {
            entity.HasKey(e => e.IdTipoComponente).IsClustered(false);

            entity.ToTable("TIPO_COMPONENTE");

            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.ActivoTipoComponente).HasColumnName("ACTIVO_TIPO_COMPONENTE");
            entity.Property(e => e.CodigoTipoComponente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TIPO_COMPONENTE");
            entity.Property(e => e.DescripcionTipoComponente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_COMPONENTE");
            entity.Property(e => e.IncluyeDedicacionDocenteTipoComponente).HasColumnName("INCLUYE_DEDICACION_DOCENTE_TIPO_COMPONENTE");
            entity.Property(e => e.NombreTipoComponente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_COMPONENTE");
        });

        modelBuilder.Entity<TipoConceptocalif>(entity =>
        {
            entity.HasKey(e => e.IdTipoConceptocalif).IsClustered(false);

            entity.ToTable("TIPO_CONCEPTOCALIF");

            entity.Property(e => e.IdTipoConceptocalif).HasColumnName("ID_TIPO_CONCEPTOCALIF");
            entity.Property(e => e.ActivoTipoConceptocalif).HasColumnName("ACTIVO_TIPO_CONCEPTOCALIF");
            entity.Property(e => e.DescripcionTipoConceptocalif)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_CONCEPTOCALIF");
            entity.Property(e => e.NombreTipoConceptocalif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_CONCEPTOCALIF");
        });

        modelBuilder.Entity<TipoContrato>(entity =>
        {
            entity.HasKey(e => e.IdTipoContrato).IsClustered(false);

            entity.ToTable("TIPO_CONTRATO");

            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");
            entity.Property(e => e.ActivoTipoContrato).HasColumnName("ACTIVO_TIPO_CONTRATO");
            entity.Property(e => e.IdDedicacion).HasColumnName("ID_DEDICACION");
            entity.Property(e => e.IdPartida).HasColumnName("ID_PARTIDA");
            entity.Property(e => e.NombreTipoContrato)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_CONTRATO");

            entity.HasOne(d => d.IdDedicacionNavigation).WithMany(p => p.TipoContratos)
                .HasForeignKey(d => d.IdDedicacion)
                .HasConstraintName("FK_TIPO_CON_FK_TIPO_C_DEDICACI");

            entity.HasOne(d => d.IdPartidaNavigation).WithMany(p => p.TipoContratos)
                .HasForeignKey(d => d.IdPartida)
                .HasConstraintName("FK_TIPO_CON_FK_TIPO_C_PARTIDA_");
        });

        modelBuilder.Entity<TipoConvenio>(entity =>
        {
            entity.HasKey(e => e.IdTipoConvenio).IsClustered(false);

            entity.ToTable("TIPO_CONVENIO");

            entity.Property(e => e.IdTipoConvenio).HasColumnName("ID_TIPO_CONVENIO");
            entity.Property(e => e.ActivoTipoConvenio).HasColumnName("ACTIVO_TIPO_CONVENIO");
            entity.Property(e => e.DescripcionTipoConvenio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_CONVENIO");
            entity.Property(e => e.NombreTipoConvenio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_CONVENIO");
        });

        modelBuilder.Entity<TipoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdTipoEmp).IsClustered(false);

            entity.ToTable("TIPO_EMPLEADO");

            entity.Property(e => e.IdTipoEmp).HasColumnName("ID_TIPO_EMP");
            entity.Property(e => e.ActivoTipoEmp).HasColumnName("ACTIVO_TIPO_EMP");
            entity.Property(e => e.DescripcionTipoEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_EMP");
            entity.Property(e => e.NombreTipoEmp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_EMP");
        });

        modelBuilder.Entity<TipoEspacio>(entity =>
        {
            entity.HasKey(e => e.IdTipoEspacio).IsClustered(false);

            entity.ToTable("TIPO_ESPACIO");

            entity.Property(e => e.IdTipoEspacio).HasColumnName("ID_TIPO_ESPACIO");
            entity.Property(e => e.CodigoTipoEspacio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TIPO_ESPACIO");
            entity.Property(e => e.NombreTipoEspacio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_ESPACIO");
            entity.Property(e => e.ReferenciaTipoEspacio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA_TIPO_ESPACIO");
        });

        modelBuilder.Entity<TipoInfraestructura>(entity =>
        {
            entity.HasKey(e => e.IdTipoInfraestructura).IsClustered(false);

            entity.ToTable("TIPO_INFRAESTRUCTURA");

            entity.Property(e => e.IdTipoInfraestructura).HasColumnName("ID_TIPO_INFRAESTRUCTURA");
            entity.Property(e => e.ActivoTipoInfraestructura).HasColumnName("ACTIVO_TIPO_INFRAESTRUCTURA");
            entity.Property(e => e.CodigoTipoInfraestructura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TIPO_INFRAESTRUCTURA");
            entity.Property(e => e.NombreTipoInfraestructura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_INFRAESTRUCTURA");
        });

        modelBuilder.Entity<TipoInstitucionEducativa>(entity =>
        {
            entity.HasKey(e => e.IdTipoInstitucionEducativa).IsClustered(false);

            entity.ToTable("TIPO_INSTITUCION_EDUCATIVA");

            entity.Property(e => e.IdTipoInstitucionEducativa).HasColumnName("ID_TIPO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.ActivoTipoInstitucionEducativa).HasColumnName("ACTIVO_TIPO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.DescripcionTipoInstitucionEducativa)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_INSTITUCION_EDUCATIVA");
            entity.Property(e => e.NombreTipoInstitucionEducativa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_INSTITUCION_EDUCATIVA");
        });

        modelBuilder.Entity<TipoItem>(entity =>
        {
            entity.HasKey(e => e.IdTipoItem).IsClustered(false);

            entity.ToTable("TIPO_ITEM");

            entity.Property(e => e.IdTipoItem).HasColumnName("ID_TIPO_ITEM");
            entity.Property(e => e.ActivoTipoItem).HasColumnName("ACTIVO_TIPO_ITEM");
            entity.Property(e => e.CodigoFusionInventoryItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO_FUSION_INVENTORY_ITEM");
            entity.Property(e => e.DescripcionTipoItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_ITEM");
            entity.Property(e => e.NombreTipoItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_ITEM");
        });

        modelBuilder.Entity<TipoMateriaCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdTipoMateriaCatalogo).IsClustered(false);

            entity.ToTable("TIPO_MATERIA_CATALOGO");

            entity.Property(e => e.IdTipoMateriaCatalogo).HasColumnName("ID_TIPO_MATERIA_CATALOGO");
            entity.Property(e => e.ActivoTipoMateriaCatalogo).HasColumnName("ACTIVO_TIPO_MATERIA_CATALOGO");
            entity.Property(e => e.DescripcionTipoMateriaCatalogo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_MATERIA_CATALOGO");
            entity.Property(e => e.NombreTipoMateriaCatalogo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_MATERIA_CATALOGO");
        });

        modelBuilder.Entity<TipoPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdTipoPeriodo).IsClustered(false);

            entity.ToTable("TIPO_PERIODO");

            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");
            entity.Property(e => e.ActivoTipoPeriodo).HasColumnName("ACTIVO_TIPO_PERIODO");
            entity.Property(e => e.NombreTipoPeriodo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_PERIODO");
        });

        modelBuilder.Entity<TipoPermiso>(entity =>
        {
            entity.HasKey(e => e.IdTipoPermiso).IsClustered(false);

            entity.ToTable("TIPO_PERMISO");

            entity.Property(e => e.IdTipoPermiso).HasColumnName("ID_TIPO_PERMISO");
            entity.Property(e => e.ActivoTipoPermiso).HasColumnName("ACTIVO_TIPO_PERMISO");
            entity.Property(e => e.DescriocionTipoPermiso)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIOCION_TIPO_PERMISO");
            entity.Property(e => e.NombreTipoPermiso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_PERMISO");
        });

        modelBuilder.Entity<TipoPermisoCarrera>(entity =>
        {
            entity.HasKey(e => e.IdTipoPermisoCarrera).IsClustered(false);

            entity.ToTable("TIPO_PERMISO_CARRERA");

            entity.Property(e => e.IdTipoPermisoCarrera).HasColumnName("ID_TIPO_PERMISO_CARRERA");
            entity.Property(e => e.ActivoTipoPermisoCarrera).HasColumnName("ACTIVO_TIPO_PERMISO_CARRERA");
            entity.Property(e => e.DescripcionTipoPermisoCarrera)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TIPO_PERMISO_CARRERA");
            entity.Property(e => e.NombreTipoPermisoCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_PERMISO_CARRERA");
        });

        modelBuilder.Entity<TipoPrecorequisito>(entity =>
        {
            entity.HasKey(e => e.IdTipoPrecorrequisito).IsClustered(false);

            entity.ToTable("TIPO_PRECOREQUISITO");

            entity.Property(e => e.IdTipoPrecorrequisito).HasColumnName("ID_TIPO_PRECORREQUISITO");
            entity.Property(e => e.ActivoTipoPrecorrequisito).HasColumnName("ACTIVO_TIPO_PRECORREQUISITO");
            entity.Property(e => e.ArchivoTipoPrecorrequisito).HasColumnName("ARCHIVO_TIPO_PRECORREQUISITO");
            entity.Property(e => e.ModoTipoPrecorrequisito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODO_TIPO_PRECORREQUISITO");
            entity.Property(e => e.NombreTipoPrecorrequisito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_PRECORREQUISITO");
        });

        modelBuilder.Entity<TipoRequisitoEgresamiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoReqEgresamiento).IsClustered(false);

            entity.ToTable("TIPO_REQUISITO_EGRESAMIENTO");

            entity.Property(e => e.IdTipoReqEgresamiento).HasColumnName("ID_TIPO_REQ_EGRESAMIENTO");
            entity.Property(e => e.ActivoTipoReqEgresamiento).HasColumnName("ACTIVO_TIPO_REQ_EGRESAMIENTO");
            entity.Property(e => e.NombreTipoReqEgresamiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_REQ_EGRESAMIENTO");
        });

        modelBuilder.Entity<TipoTitulacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoTitulacion).IsClustered(false);

            entity.ToTable("TIPO_TITULACION");

            entity.Property(e => e.IdTipoTitulacion).HasColumnName("ID_TIPO_TITULACION");
            entity.Property(e => e.ActivoTipoTitulacion).HasColumnName("ACTIVO_TIPO_TITULACION");
            entity.Property(e => e.NombreTipoTitulacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_TITULACION");
        });

        modelBuilder.Entity<UnidadOrganizacionCurricular>(entity =>
        {
            entity.HasKey(e => e.IdUoc)
                .HasName("PK_UNIDAD_ORGANIZACION_CURRICU")
                .IsClustered(false);

            entity.ToTable("UNIDAD_ORGANIZACION_CURRICULAR");

            entity.Property(e => e.IdUoc).HasColumnName("ID_UOC");
            entity.Property(e => e.ActivoUoc).HasColumnName("ACTIVO_UOC");
            entity.Property(e => e.CodigoUoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_UOC");
            entity.Property(e => e.NombreUoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_UOC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
