using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Core.Entidades.Core;
using Microsoft.Extensions.Configuration;

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

    public virtual DbSet<ArchivoPlanificacionTemporal> ArchivoPlanificacionTemporals { get; set; }

    public virtual DbSet<AutoridadesCarrera> AutoridadesCarreras { get; set; }

    public virtual DbSet<AutoridadesFacultad> AutoridadesFacultads { get; set; }

    public virtual DbSet<AutoridadesInstitucionEducativa> AutoridadesInstitucionEducativas { get; set; }

    public virtual DbSet<Calendario> Calendarios { get; set; }

    public virtual DbSet<CampoAmplio> CampoAmplios { get; set; }

    public virtual DbSet<CampoDetallado> CampoDetallados { get; set; }

    public virtual DbSet<CampoEspecifico> CampoEspecificos { get; set; }

    public virtual DbSet<Campus> Campuses { get; set; }

    public virtual DbSet<Canton> Cantons { get; set; }

    public virtual DbSet<Capacitacion> Capacitacions { get; set; }

    public virtual DbSet<CarnetConadi> CarnetConadis { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<CatalogoDocumentosContratoDocente> CatalogoDocumentosContratoDocentes { get; set; }

    public virtual DbSet<CatalogoMateria> CatalogoMaterias { get; set; }

    public virtual DbSet<CategoriaEmp> CategoriaEmps { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Competencium> Competencia { get; set; }

    public virtual DbSet<Componente> Componentes { get; set; }

    public virtual DbSet<ComponenteCatalogo> ComponenteCatalogos { get; set; }

    public virtual DbSet<ConceptoCalificacione> ConceptoCalificaciones { get; set; }

    public virtual DbSet<ConceptoMateriaConfiguracion> ConceptoMateriaConfiguracions { get; set; }

    public virtual DbSet<ConceptoPrecio> ConceptoPrecios { get; set; }

    public virtual DbSet<ConceptosAdicionalesMaterium> ConceptosAdicionalesMateria { get; set; }

    public virtual DbSet<ConceptosGeneralesDescuento> ConceptosGeneralesDescuentos { get; set; }

    public virtual DbSet<ConceptosGeneralesPrecio> ConceptosGeneralesPrecios { get; set; }

    public virtual DbSet<ConfiguracionesGenerale> ConfiguracionesGenerales { get; set; }

    public virtual DbSet<ContactoEmergencium> ContactoEmergencia { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<ControlesPeriodo> ControlesPeriodos { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<Correquisito> Correquisitos { get; set; }

    public virtual DbSet<CruceHorario> CruceHorarios { get; set; }

    public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }

    public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }

    public virtual DbSet<DatoPersonale> DatoPersonales { get; set; }

    public virtual DbSet<Dedicacion> Dedicacions { get; set; }

    public virtual DbSet<DedicacionN> DedicacionNs { get; set; }

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

    public virtual DbSet<EmpleadoTempArchivo> EmpleadoTempArchivos { get; set; }

    public virtual DbSet<EmpleadoTempNuevo> EmpleadoTempNuevos { get; set; }

    public virtual DbSet<Errorplan20251> Errorplan20251s { get; set; }

    public virtual DbSet<Errorplan20253> Errorplan20253s { get; set; }

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

    public virtual DbSet<EstadoSolicitud> EstadoSolicituds { get; set; }

    public virtual DbSet<Etnium> Etnia { get; set; }

    public virtual DbSet<ExperienciaDocente> ExperienciaDocentes { get; set; }

    public virtual DbSet<ExperienciaLaboral> ExperienciaLaborals { get; set; }

    public virtual DbSet<Facultad> Facultads { get; set; }

    public virtual DbSet<FechasConceptocalif> FechasConceptocalifs { get; set; }

    public virtual DbSet<FechasHorario> FechasHorarios { get; set; }

    public virtual DbSet<FormaPagoEmp> FormaPagoEmps { get; set; }

    public virtual DbSet<FranjaHorario> FranjaHorarios { get; set; }

    public virtual DbSet<FranjaHorarium> FranjaHoraria { get; set; }

    public virtual DbSet<GestionDocumental> GestionDocumentals { get; set; }

    public virtual DbSet<Hamb20234> Hamb20234s { get; set; }

    public virtual DbSet<Harq20234> Harq20234s { get; set; }

    public virtual DbSet<Hbsch20234> Hbsch20234s { get; set; }

    public virtual DbSet<HistorialContrato> HistorialContratos { get; set; }

    public virtual DbSet<HistorialPrecio> HistorialPrecios { get; set; }

    public virtual DbSet<HistoricoCarrera> HistoricoCarreras { get; set; }

    public virtual DbSet<HistoricoFacultad> HistoricoFacultads { get; set; }

    public virtual DbSet<Hlsodom20234> Hlsodom20234s { get; set; }

    public virtual DbSet<Hmapi20234> Hmapi20234s { get; set; }

    public virtual DbSet<Hmed20234> Hmed20234s { get; set; }

    public virtual DbSet<Hoja2> Hoja2s { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<HorarioArq20234> HorarioArq20234s { get; set; }

    public virtual DbSet<HorarioCea20234> HorarioCea20234s { get; set; }

    public virtual DbSet<HorarioCisa20234> HorarioCisa20234s { get; set; }

    public virtual DbSet<HorarioDer20234> HorarioDer20234s { get; set; }

    public virtual DbSet<HorarioFecha> HorarioFechas { get; set; }

    public virtual DbSet<HorarioFechaLog> HorarioFechaLogs { get; set; }

    public virtual DbSet<HorarioFechaTemp> HorarioFechaTemps { get; set; }

    public virtual DbSet<HorarioFinAb20234> HorarioFinAb20234s { get; set; }

    public virtual DbSet<HorarioFinAb20253> HorarioFinAb20253s { get; set; }

    public virtual DbSet<HorarioFinModAb20234> HorarioFinModAb20234s { get; set; }

    public virtual DbSet<HorarioFinModOc20251> HorarioFinModOc20251s { get; set; }

    public virtual DbSet<HorarioFinOc20251> HorarioFinOc20251s { get; set; }

    public virtual DbSet<HorarioFinValidacion20251> HorarioFinValidacion20251s { get; set; }

    public virtual DbSet<HorarioFinal20234> HorarioFinal20234s { get; set; }

    public virtual DbSet<HorarioFinal20234Resp> HorarioFinal20234Resps { get; set; }

    public virtual DbSet<HorarioLog> HorarioLogs { get; set; }

    public virtual DbSet<HorarioLso20234> HorarioLso20234s { get; set; }

    public virtual DbSet<HorarioLsodom20234> HorarioLsodom20234s { get; set; }

    public virtual DbSet<HorarioMec20234> HorarioMec20234s { get; set; }

    public virtual DbSet<HorarioMod20251> HorarioMod20251s { get; set; }

    public virtual DbSet<HorarioMod20251V2> HorarioMod20251V2s { get; set; }

    public virtual DbSet<HorarioMod20251V3> HorarioMod20251V3s { get; set; }

    public virtual DbSet<HorarioMod20251V4> HorarioMod20251V4s { get; set; }

    public virtual DbSet<HorarioModValidacion20251> HorarioModValidacion20251s { get; set; }

    public virtual DbSet<HorarioTemp> HorarioTemps { get; set; }

    public virtual DbSet<HorarioTemporal16102023> HorarioTemporal16102023s { get; set; }

    public virtual DbSet<Horarioprueba20243> Horarioprueba20243s { get; set; }

    public virtual DbSet<Horariopruebafin20243> Horariopruebafin20243s { get; set; }

    public virtual DbSet<Horariopruebafin20251> Horariopruebafin20251s { get; set; }

    public virtual DbSet<Horarios20234> Horarios20234s { get; set; }

    public virtual DbSet<Horariotemporal17112023> Horariotemporal17112023s { get; set; }

    public virtual DbSet<HorasDium> HorasDia { get; set; }

    public virtual DbSet<HorasModalidadMalla> HorasModalidadMallas { get; set; }

    public virtual DbSet<Hsoju20234> Hsoju20234s { get; set; }

    public virtual DbSet<Hsso20234> Hsso20234s { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<InfoAcademica> InfoAcademicas { get; set; }

    public virtual DbSet<InfoAcademicaNew> InfoAcademicaNews { get; set; }

    public virtual DbSet<InfoAcademicaSubir> InfoAcademicaSubirs { get; set; }

    public virtual DbSet<InfoEmpleado> InfoEmpleados { get; set; }

    public virtual DbSet<InfoExperiencium> InfoExperiencia { get; set; }

    public virtual DbSet<InfoPersonal> InfoPersonals { get; set; }

    public virtual DbSet<InfoPlanificacion> InfoPlanificacions { get; set; }

    public virtual DbSet<Infraestructura> Infraestructuras { get; set; }

    public virtual DbSet<InstitucionEducativa> InstitucionEducativas { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<LogObservacionSolicitudEmp> LogObservacionSolicitudEmps { get; set; }

    public virtual DbSet<Malla> Mallas { get; set; }

    public virtual DbSet<Mallaasignaturakaty> Mallaasignaturakaties { get; set; }

    public virtual DbSet<Mallakaty> Mallakaties { get; set; }

    public virtual DbSet<MateriaCompartidum> MateriaCompartida { get; set; }

    public virtual DbSet<MateriaEquivalente> MateriaEquivalentes { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<ModalidadContrato> ModalidadContratos { get; set; }

    public virtual DbSet<ModalidadPe> ModalidadPes { get; set; }

    public virtual DbSet<ModalidadPeriodo> ModalidadPeriodos { get; set; }

    public virtual DbSet<ModalidadTitulacionPe> ModalidadTitulacionPes { get; set; }

    public virtual DbSet<NivelAcademico> NivelAcademicos { get; set; }

    public virtual DbSet<NivelEstudio> NivelEstudios { get; set; }

    public virtual DbSet<NivelInfraestructura> NivelInfraestructuras { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<NotificacionesCorreo> NotificacionesCorreos { get; set; }

    public virtual DbSet<OcupacionHorarios20243> OcupacionHorarios20243s { get; set; }

    public virtual DbSet<OcupacionHorarios20243V2> OcupacionHorarios20243V2s { get; set; }

    public virtual DbSet<OcupacionHorarios20243V3> OcupacionHorarios20243V3s { get; set; }

    public virtual DbSet<OcupacionHorarios20251> OcupacionHorarios20251s { get; set; }

    public virtual DbSet<OcupanteHorario> OcupanteHorarios { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Parroquium> Parroquia { get; set; }

    public virtual DbSet<PartidaPresupuestarium> PartidaPresupuestaria { get; set; }

    public virtual DbSet<Periodicidad> Periodicidads { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PermisosCarrera> PermisosCarreras { get; set; }

    public virtual DbSet<PlanEstudio> PlanEstudios { get; set; }

    public virtual DbSet<PlanUmas20243> PlanUmas20243s { get; set; }

    public virtual DbSet<PlanUmas20243Fin> PlanUmas20243Fins { get; set; }

    public virtual DbSet<PlanUmas20243FinAbril> PlanUmas20243FinAbrils { get; set; }

    public virtual DbSet<PlanUmas20243FinMayo> PlanUmas20243FinMayos { get; set; }

    public virtual DbSet<Planificacion> Planificacions { get; set; }

    public virtual DbSet<PlanificacionCompartida> PlanificacionCompartidas { get; set; }

    public virtual DbSet<PlanificacionLog> PlanificacionLogs { get; set; }

    public virtual DbSet<PlanificacionTemp> PlanificacionTemps { get; set; }

    public virtual DbSet<PlanoNivel> PlanoNivels { get; set; }

    public virtual DbSet<Premio> Premios { get; set; }

    public virtual DbSet<Prerrequisito> Prerrequisitos { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<ProyectoInvestigacion> ProyectoInvestigacions { get; set; }

    public virtual DbSet<ProyectoVinculacion> ProyectoVinculacions { get; set; }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    public virtual DbSet<PruebaEdi> PruebaEdis { get; set; }

    public virtual DbSet<PruebaUmaAct> PruebaUmaActs { get; set; }

    public virtual DbSet<Publicacion> Publicacions { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RelacionContrato> RelacionContratos { get; set; }

    public virtual DbSet<RequisitosEgresamientoPe> RequisitosEgresamientoPes { get; set; }

    public virtual DbSet<RequisitosTipoContrato> RequisitosTipoContratos { get; set; }

    public virtual DbSet<SedeInstitucion> SedeInstitucions { get; set; }

    public virtual DbSet<SekMallasComponente> SekMallasComponentes { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    public virtual DbSet<SubnivelEstudio> SubnivelEstudios { get; set; }

    public virtual DbSet<SubtipoComponente> SubtipoComponentes { get; set; }

    public virtual DbSet<SubtipoTitulacion> SubtipoTitulacions { get; set; }

    public virtual DbSet<Tesi> Teses { get; set; }

    public virtual DbSet<TipoActividad> TipoActividads { get; set; }

    public virtual DbSet<TipoActividade> TipoActividades { get; set; }

    public virtual DbSet<TipoAprobacion> TipoAprobacions { get; set; }

    public virtual DbSet<TipoAprobacionCapacitacion> TipoAprobacionCapacitacions { get; set; }

    public virtual DbSet<TipoAutoridadCarrera> TipoAutoridadCarreras { get; set; }

    public virtual DbSet<TipoAutoridadInstitucionEducativa> TipoAutoridadInstitucionEducativas { get; set; }

    public virtual DbSet<TipoAutoridadfacultad> TipoAutoridadfacultads { get; set; }

    public virtual DbSet<TipoComponente> TipoComponentes { get; set; }

    public virtual DbSet<TipoConceptocalif> TipoConceptocalifs { get; set; }

    public virtual DbSet<TipoContrato> TipoContratos { get; set; }

    public virtual DbSet<TipoContratoN> TipoContratoNs { get; set; }

    public virtual DbSet<TipoConvenio> TipoConvenios { get; set; }

    public virtual DbSet<TipoDiscapacidad> TipoDiscapacidads { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

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

    public virtual DbSet<TipoPublicacion> TipoPublicacions { get; set; }

    public virtual DbSet<TipoRequisitoEgresamiento> TipoRequisitoEgresamientos { get; set; }

    public virtual DbSet<TipoTitulacion> TipoTitulacions { get; set; }

    public virtual DbSet<TitularidadEmp> TitularidadEmps { get; set; }

    public virtual DbSet<UnidadEducativa> UnidadEducativas { get; set; }

    public virtual DbSet<UnidadOrganizacionCurricular> UnidadOrganizacionCurriculars { get; set; }

    public virtual DbSet<UnidadOrganizativa> UnidadOrganizativas { get; set; }

    public virtual DbSet<ValidacionMaterium> ValidacionMateria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ZEUS"));

    }
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

        modelBuilder.Entity<ArchivoPlanificacionTemporal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArchivoPlanificacionTemporal");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
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

        modelBuilder.Entity<Calendario>(entity =>
        {
            entity.HasKey(e => e.CalendarDate).HasName("PK_CalendarDate");

            entity.ToTable("CALENDARIO");

            entity.Property(e => e.CalendarCa)
                .HasComputedColumnSql("(datediff(day,dateadd(day,(1)-datepart(day,[CalendarDate]),[CalendarDate]),[CalendarDate])/(7)+(1))", true)
                .HasColumnName("CalendarCA");
            entity.Property(e => e.CalendarCd)
                .HasComputedColumnSql("(datediff(day,[CalendarDate],dateadd(day,(-1),dateadd(month,(1),dateadd(day,(1)-datepart(day,[CalendarDate]),[CalendarDate]))))/(7)+(1))", true)
                .HasColumnName("CalendarCD");
            entity.Property(e => e.WeekDayId)
                .HasComputedColumnSql("(datepart(weekday,[CalendarDate]))", false)
                .HasColumnName("WeekDayID");
            entity.Property(e => e.WeekDayName)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasComputedColumnSql("(case datepart(weekday,[CalendarDate]) when (7) then 'DOMINGO' when (1) then 'LUNES' when (2) then 'MARTES' when (3) then 'MIÉRCOLES' when (4) then 'JUEVES' when (5) then 'VIERNES' when (6) then 'SÁBADO'  end)", false);
        });

        modelBuilder.Entity<CampoAmplio>(entity =>
        {
            entity.HasKey(e => e.IdCa);

            entity.ToTable("CAMPO_AMPLIO");

            entity.Property(e => e.IdCa).HasColumnName("ID_CA");
            entity.Property(e => e.CampoAmplio1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_AMPLIO");
            entity.Property(e => e.CodigoCa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CA");
        });

        modelBuilder.Entity<CampoDetallado>(entity =>
        {
            entity.HasKey(e => e.IdCd);

            entity.ToTable("CAMPO_DETALLADO");

            entity.Property(e => e.IdCd).HasColumnName("ID_CD");
            entity.Property(e => e.CampoDetallado1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_DETALLADO");
            entity.Property(e => e.CodigoCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CD");
            entity.Property(e => e.IdCe).HasColumnName("ID_CE");
        });

        modelBuilder.Entity<CampoEspecifico>(entity =>
        {
            entity.HasKey(e => e.IdCe);

            entity.ToTable("CAMPO_ESPECIFICO");

            entity.Property(e => e.IdCe).HasColumnName("ID_CE");
            entity.Property(e => e.CampoEspecifico1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPO_ESPECIFICO");
            entity.Property(e => e.CodigoCe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CE");
            entity.Property(e => e.IdCa).HasColumnName("ID_CA");
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

        modelBuilder.Entity<Capacitacion>(entity =>
        {
            entity.HasKey(e => e.IdCapacitacion).IsClustered(false);

            entity.ToTable("CAPACITACION");

            entity.Property(e => e.IdCapacitacion).HasColumnName("ID_CAPACITACION");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.Certificado)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO");
            entity.Property(e => e.Duracion).HasColumnName("DURACION");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaFin).HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio).HasColumnName("FECHA_INICIO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdTipoActividad).HasColumnName("ID_TIPO_ACTIVIDAD");
            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.Institucion)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Titulo)
                .IsUnicode(false)
                .HasColumnName("TITULO");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Capacitacions)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPACITACION_EMPLEADO");
        });

        modelBuilder.Entity<CarnetConadi>(entity =>
        {
            entity.HasKey(e => e.IdCarnetConadis).IsClustered(false);

            entity.ToTable("CARNET_CONADIS");

            entity.Property(e => e.IdCarnetConadis)
                .ValueGeneratedNever()
                .HasColumnName("ID_CARNET_CONADIS");
            entity.Property(e => e.Carnet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARNET");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdTipoDiscapacidad).HasColumnName("ID_TIPO_DISCAPACIDAD");
            entity.Property(e => e.NumeroCarnet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CARNET");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(2, 2)")
                .HasColumnName("PORCENTAJE");
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
            entity.Property(e => e.IdCa).HasColumnName("ID_CA");
            entity.Property(e => e.IdCd).HasColumnName("ID_CD");
            entity.Property(e => e.IdCe).HasColumnName("ID_CE");
            entity.Property(e => e.IdEstadoCarrera).HasColumnName("ID_ESTADO_CARRERA");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("id_nivel_estudio");
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
                .HasMaxLength(150)
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

        modelBuilder.Entity<CategoriaEmp>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__CATEGORI__4BD51FA595E961EE");

            entity.ToTable("CATEGORIA_EMP");

            entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORIA");
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

        modelBuilder.Entity<Competencium>(entity =>
        {
            entity.HasKey(e => e.IdCompetencia).IsClustered(false);

            entity.ToTable("COMPETENCIA");

            entity.Property(e => e.IdCompetencia)
                .ValueGeneratedNever()
                .HasColumnName("ID_COMPETENCIA");
            entity.Property(e => e.Competencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPETENCIA");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
        });

        modelBuilder.Entity<Componente>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanEstudio, e.IdMateria, e.IdSubtipoComponente }).IsClustered(false);

            entity.ToTable("COMPONENTE");

            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdSubtipoComponente).HasColumnName("ID_SUBTIPO_COMPONENTE");
            entity.Property(e => e.ActivoComponente).HasColumnName("ACTIVO_COMPONENTE");
            entity.Property(e => e.CodigoComponente)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CODIGO_COMPONENTE");
            entity.Property(e => e.HorasComponente).HasColumnName("HORAS_COMPONENTE");
            entity.Property(e => e.IdComponente)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_COMPONENTE");
            entity.Property(e => e.PesoComponente).HasColumnName("PESO_COMPONENTE");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Componentes)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPONEN_FK_MATERI_MATERIA");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Componentes)
                .HasForeignKey(d => d.IdPlanEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPONENTE_PLAN_ESTUDIO");

            entity.HasOne(d => d.IdSubtipoComponenteNavigation).WithMany(p => p.Componentes)
                .HasForeignKey(d => d.IdSubtipoComponente)
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

            entity.HasOne(d => d.IdMallaNavigation).WithMany(p => p.ConceptoPrecios)
                .HasForeignKey(d => d.IdMalla)
                .HasConstraintName("FK_CONCEPTO_PRECIOS_MALLA");
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
        });

        modelBuilder.Entity<ContactoEmergencium>(entity =>
        {
            entity.HasKey(e => e.IdContactoEmergencia).IsClustered(false);

            entity.ToTable("CONTACTO_EMERGENCIA");

            entity.Property(e => e.IdContactoEmergencia).HasColumnName("ID_CONTACTO_EMERGENCIA");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.Celular)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.Relacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELACION");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");
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

        modelBuilder.Entity<CruceHorario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CruceHorario");

            entity.Property(e => e.Aula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AULA");
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Cedula)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.CodigoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_carrera");
            entity.Property(e => e.Dia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Docente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOCENTE");
            entity.Property(e => e.HoraFin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HORA_INI");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Malla)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MALLA");
            entity.Property(e => e.Materia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
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

        modelBuilder.Entity<DatoPersonale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Apellidos)
                .HasMaxLength(255)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");
            entity.Property(e => e.CallePrincipal)
                .HasMaxLength(255)
                .HasColumnName("CALLE_PRINCIPAL");
            entity.Property(e => e.CalleSecundaria)
                .HasMaxLength(255)
                .HasColumnName("CALLE_SECUNDARIA");
            entity.Property(e => e.Canton)
                .HasMaxLength(255)
                .HasColumnName("CANTON");
            entity.Property(e => e.Celular)
                .HasMaxLength(255)
                .HasColumnName("CELULAR");
            entity.Property(e => e.CodPostal).HasColumnName("COD_POSTAL");
            entity.Property(e => e.CorreoInst)
                .HasMaxLength(255)
                .HasColumnName("CORREO_INST");
            entity.Property(e => e.CorreoPersonal)
                .HasMaxLength(255)
                .HasColumnName("CORREO_PERSONAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(255)
                .HasColumnName("ESTADO_CIVIL");
            entity.Property(e => e.Etnia)
                .HasMaxLength(255)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNac)
                .HasMaxLength(255)
                .HasColumnName("FECHA_NAC");
            entity.Property(e => e.Identificacion).HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Nombres)
                .HasMaxLength(255)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Numeracion)
                .HasMaxLength(255)
                .HasColumnName("NUMERACION");
            entity.Property(e => e.NumeroCarnetConadis)
                .HasMaxLength(255)
                .HasColumnName("NUMERO_CARNET_CONADIS");
            entity.Property(e => e.Pais)
                .HasMaxLength(255)
                .HasColumnName("PAIS");
            entity.Property(e => e.PaisNac)
                .HasMaxLength(255)
                .HasColumnName("PAIS_NAC");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(255)
                .HasColumnName("PARROQUIA");
            entity.Property(e => e.PorcentajeDisc)
                .HasMaxLength(255)
                .HasColumnName("PORCENTAJE_DISC");
            entity.Property(e => e.Provincia)
                .HasMaxLength(255)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Referencia)
                .HasMaxLength(255)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Sexo)
                .HasMaxLength(255)
                .HasColumnName("SEXO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TiempoResidenciaEc)
                .HasMaxLength(255)
                .HasColumnName("TIEMPO_RESIDENCIA_EC");
            entity.Property(e => e.TipoDiscapacidad)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DISCAPACIDAD");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DOCUMENTO");
            entity.Property(e => e.TipoEmpleado)
                .HasMaxLength(255)
                .HasColumnName("TIPO_EMPLEADO");
            entity.Property(e => e.TipoSangre)
                .HasMaxLength(255)
                .HasColumnName("TIPO_SANGRE");
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

        modelBuilder.Entity<DedicacionN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEDICACION_N");

            entity.Property(e => e.Dedicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEDICACION");
            entity.Property(e => e.DescDedicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC_DEDICACION");
            entity.Property(e => e.IdDedicacion)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_DEDICACION");
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

            entity.ToTable("EMPLEADO", tb => tb.HasTrigger("CreaDocente"));

            entity.HasIndex(e => e.IdentificacionEmp, "AK_UQ__EMPLEADO__E35A_EMPLEADO").IsUnique();

            entity.HasIndex(e => e.IdEmp, "IX_CLUS_ID").IsClustered();

            entity.HasIndex(e => e.IdentificacionEmp, "IX_NCLUS_IDENTIFICACION");

            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.AceptaPd).HasColumnName("ACEPTA_PD");
            entity.Property(e => e.ActivoEmp).HasColumnName("ACTIVO_EMP");
            entity.Property(e => e.ApellidoEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_EMP");
            entity.Property(e => e.Barrio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BARRIO");
            entity.Property(e => e.CallePrincipal)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_PRINCIPAL");
            entity.Property(e => e.CalleSecundaria)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_SECUNDARIA");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARGO");
            entity.Property(e => e.CarnetArchivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARNET_ARCHIVO");
            entity.Property(e => e.CarnetConadis).HasColumnName("CARNET_CONADIS");
            entity.Property(e => e.Cdc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CDC");
            entity.Property(e => e.CedulaArchivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CEDULA_ARCHIVO");
            entity.Property(e => e.CelularEmp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CELULAR_EMP");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_POSTAL");
            entity.Property(e => e.CorreoEmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_EMP");
            entity.Property(e => e.CorreoInst)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_INST");
            entity.Property(e => e.EdadEmp).HasColumnName("EDAD_EMP");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO_CIVIL");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaAceptaPd)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACEPTA_PD");
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
                .HasColumnType("text")
                .HasColumnName("FOTO_EMP");
            entity.Property(e => e.IdCanton).HasColumnName("ID_CANTON");
            entity.Property(e => e.IdEstadoEmp).HasColumnName("ID_ESTADO_EMP");
            entity.Property(e => e.IdEtnia).HasColumnName("ID_ETNIA");
            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.IdPaisNac).HasColumnName("ID_PAIS_NAC");
            entity.Property(e => e.IdParroquia).HasColumnName("ID_PARROQUIA");
            entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");
            entity.Property(e => e.IdTipoDiscapacidad).HasColumnName("ID_TIPO_DISCAPACIDAD");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("ID_TIPO_DOCUMENTO");
            entity.Property(e => e.IdTipoEmp).HasColumnName("ID_TIPO_EMP");
            entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");
            entity.Property(e => e.IdentificacionEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDENTIFICACION_EMP");
            entity.Property(e => e.NombresEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_EMP");
            entity.Property(e => e.Numeracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERACION");
            entity.Property(e => e.NumeroCarnetConadis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CARNET_CONADIS");
            entity.Property(e => e.PathfirmadigitalEmp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHFIRMADIGITAL_EMP");
            entity.Property(e => e.PorcentajeDisc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PORCENTAJE_DISC");
            entity.Property(e => e.Referencia)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.SexoEmp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SEXO_EMP");
            entity.Property(e => e.TelefonoEmp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_EMP");
            entity.Property(e => e.TiempoResidenciaEc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIEMPO_RESIDENCIA_EC");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoSangre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TIPO_SANGRE");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("FK_EMPLEADO_CANTON");

            entity.HasOne(d => d.IdEstadoEmpNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdEstadoEmp)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_ESTADO_E");

            entity.HasOne(d => d.IdEtniaNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdEtnia)
                .HasConstraintName("FK_EMPLEADO_ETNIA");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.EmpleadoIdPaisNavigations)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK_EMPLEADO_PAIS1");

            entity.HasOne(d => d.IdPaisNacNavigation).WithMany(p => p.EmpleadoIdPaisNacNavigations)
                .HasForeignKey(d => d.IdPaisNac)
                .HasConstraintName("FK_EMPLEADO_PAIS");

            entity.HasOne(d => d.IdParroquiaNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdParroquia)
                .HasConstraintName("FK_EMPLEADO_PARROQUIA");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_EMPLEADO_PROVINCIA");

            entity.HasOne(d => d.IdTipoDiscapacidadNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdTipoDiscapacidad)
                .HasConstraintName("FK_EMPLEADO_TIPO_DISCAPACIDAD");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPLEADO_TIPO_DOCUMENTO");

            entity.HasOne(d => d.IdTipoEmpNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdTipoEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_TIPO_EMP");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdUnidad)
                .HasConstraintName("FK_EMPLEADO_FK_EMPLEA_FACULTAD");
        });

        modelBuilder.Entity<EmpleadoTempArchivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLEADO__3214EC27B1AE14D1");

            entity.ToTable("EMPLEADO_TEMP_ARCHIVOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdEmpNuevo).HasColumnName("ID_EMP_NUEVO");
            entity.Property(e => e.IdTipoArchivo).HasColumnName("ID_TIPO_ARCHIVO");
            entity.Property(e => e.PathArchivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH_ARCHIVO");
        });

        modelBuilder.Entity<EmpleadoTempNuevo>(entity =>
        {
            entity.HasKey(e => e.IdEmpNuevo).HasName("PK__EMPLEADO__920D7532B27C06CA");

            entity.ToTable("EMPLEADO_TEMP_NUEVO", tb => tb.HasTrigger("APROBACION_SOLICITUD_EMPN"));

            entity.Property(e => e.IdEmpNuevo).HasColumnName("ID_EMP_NUEVO");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Celular)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.Horario)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HORARIO");
            entity.Property(e => e.IdCampoAmplio).HasColumnName("ID_CAMPO_AMPLIO");
            entity.Property(e => e.IdCampoAmplio2).HasColumnName("ID_CAMPO_AMPLIO2");
            entity.Property(e => e.IdCampoEspecifico).HasColumnName("ID_CAMPO_ESPECIFICO");
            entity.Property(e => e.IdCampoEspecifico2).HasColumnName("ID_CAMPO_ESPECIFICO2");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.IdDedicacion).HasColumnName("ID_DEDICACION");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.IdFormaPago).HasColumnName("ID_FORMA_PAGO");
            entity.Property(e => e.IdNivelAcadTit).HasColumnName("ID_NIVEL_ACAD_TIT");
            entity.Property(e => e.IdNivelAcadTit2).HasColumnName("ID_NIVEL_ACAD_TIT2");
            entity.Property(e => e.IdPaisResidencia).HasColumnName("ID_PAIS_RESIDENCIA");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");
            entity.Property(e => e.IdTipoEmpleado).HasColumnName("ID_TIPO_EMPLEADO");
            entity.Property(e => e.IdTitularidad).HasColumnName("ID_TITULARIDAD");
            entity.Property(e => e.IdUnidadEducativa).HasColumnName("ID_UNIDAD_EDUCATIVA");
            entity.Property(e => e.IdUnidadEducativa2).HasColumnName("ID_UNIDAD_EDUCATIVA2");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Motivo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.Residente).HasColumnName("RESIDENTE");
            entity.Property(e => e.TipoIdentificacion).HasColumnName("TIPO_IDENTIFICACION");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITULO");
            entity.Property(e => e.Titulo2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITULO2");
            entity.Property(e => e.Ua)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UC");
            entity.Property(e => e.UnidadEducativa)
                .IsUnicode(false)
                .HasColumnName("UNIDAD_EDUCATIVA");
            entity.Property(e => e.UnidadEducativa2)
                .IsUnicode(false)
                .HasColumnName("UNIDAD_EDUCATIVA2");

            entity.HasOne(d => d.IdCampoAmplioNavigation).WithMany(p => p.EmpleadoTempNuevoIdCampoAmplioNavigations)
                .HasForeignKey(d => d.IdCampoAmplio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_CAMPO_AMPLIO");

            entity.HasOne(d => d.IdCampoAmplio2Navigation).WithMany(p => p.EmpleadoTempNuevoIdCampoAmplio2Navigations)
                .HasForeignKey(d => d.IdCampoAmplio2)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_CAMPO_AMPLIO1");

            entity.HasOne(d => d.IdCampoEspecificoNavigation).WithMany(p => p.EmpleadoTempNuevoIdCampoEspecificoNavigations)
                .HasForeignKey(d => d.IdCampoEspecifico)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_CAMPO_ESPECIFICO");

            entity.HasOne(d => d.IdCampoEspecifico2Navigation).WithMany(p => p.EmpleadoTempNuevoIdCampoEspecifico2Navigations)
                .HasForeignKey(d => d.IdCampoEspecifico2)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_CAMPO_ESPECIFICO1");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.EmpleadoTempNuevos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_ESTADO_SOLICITUD");

            entity.HasOne(d => d.IdFacultadNavigation).WithMany(p => p.EmpleadoTempNuevos)
                .HasForeignKey(d => d.IdFacultad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_FACULTAD");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.EmpleadoTempNuevos)
                .HasForeignKey(d => d.IdFormaPago)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_FORMA_PAGO_EMP");

            entity.HasOne(d => d.IdNivelAcadTitNavigation).WithMany(p => p.EmpleadoTempNuevoIdNivelAcadTitNavigations)
                .HasForeignKey(d => d.IdNivelAcadTit)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_NIVEL_ACADEMICO");

            entity.HasOne(d => d.IdNivelAcadTit2Navigation).WithMany(p => p.EmpleadoTempNuevoIdNivelAcadTit2Navigations)
                .HasForeignKey(d => d.IdNivelAcadTit2)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_NIVEL_ACADEMICO1");

            entity.HasOne(d => d.IdTipoEmpleadoNavigation).WithMany(p => p.EmpleadoTempNuevos)
                .HasForeignKey(d => d.IdTipoEmpleado)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_TIPO_EMPLEADO");

            entity.HasOne(d => d.IdUnidadEducativaNavigation).WithMany(p => p.EmpleadoTempNuevoIdUnidadEducativaNavigations)
                .HasForeignKey(d => d.IdUnidadEducativa)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_UNIDAD_EDUCATIVA");

            entity.HasOne(d => d.IdUnidadEducativa2Navigation).WithMany(p => p.EmpleadoTempNuevoIdUnidadEducativa2Navigations)
                .HasForeignKey(d => d.IdUnidadEducativa2)
                .HasConstraintName("FK_EMPLEADO_TEMP_NUEVO_UNIDAD_EDUCATIVA1");
        });

        modelBuilder.Entity<Errorplan20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ERRORPLAN20251");

            entity.Property(e => e.Error)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ERROR");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
        });

        modelBuilder.Entity<Errorplan20253>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ERRORPLAN20253");

            entity.Property(e => e.Error)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ERROR");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
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
            entity.Property(e => e.MacEthernet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAC_ETHERNET");
            entity.Property(e => e.MacWlan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAC_WLAN");
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

        modelBuilder.Entity<EstadoSolicitud>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__ESTADO_S__241E2E01B007F0CF");

            entity.ToTable("ESTADO_SOLICITUD");

            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
        });

        modelBuilder.Entity<Etnium>(entity =>
        {
            entity.HasKey(e => e.IdEtnia).IsClustered(false);

            entity.ToTable("ETNIA");

            entity.Property(e => e.IdEtnia)
                .ValueGeneratedNever()
                .HasColumnName("ID_ETNIA");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Etnia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
        });

        modelBuilder.Entity<ExperienciaDocente>(entity =>
        {
            entity.HasKey(e => e.IdExperienciaDocente).IsClustered(false);

            entity.ToTable("EXPERIENCIA_DOCENTE");

            entity.Property(e => e.IdExperienciaDocente).HasColumnName("ID_EXPERIENCIA_DOCENTE");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.CertificadoLaboral)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO_LABORAL");
            entity.Property(e => e.CertificadoTitularidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO_TITULARIDAD");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaFin).HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio).HasColumnName("FECHA_INICIO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdUnidadEducativa).HasColumnName("ID_UNIDAD_EDUCATIVA");
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.InstitucionSuperior).HasColumnName("INSTITUCION_SUPERIOR");
            entity.Property(e => e.Titular).HasColumnName("TITULAR");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.ExperienciaDocentes)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EXPERIENCIA_DOCENTE_EMPLEADO");
        });

        modelBuilder.Entity<ExperienciaLaboral>(entity =>
        {
            entity.HasKey(e => e.IdExperienciaLaboral).IsClustered(false);

            entity.ToTable("EXPERIENCIA_LABORAL");

            entity.Property(e => e.IdExperienciaLaboral).HasColumnName("ID_EXPERIENCIA_LABORAL");
            entity.Property(e => e.Actualmente).HasColumnName("ACTUALMENTE");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARGO");
            entity.Property(e => e.CargoContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARGO_CONTACTO");
            entity.Property(e => e.Certificado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaFin).HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio).HasColumnName("FECHA_INICIO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.RazonSalida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RAZON_SALIDA");
            entity.Property(e => e.Sueldo)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("SUELDO");
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_CONTACTO");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.ExperienciaLaborals)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EXPERIENCIA_LABORAL_EMPLEADO");
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

        modelBuilder.Entity<FormaPagoEmp>(entity =>
        {
            entity.HasKey(e => e.IdFpago).HasName("PK__FORMA_PA__636FAF8D73239255");

            entity.ToTable("FORMA_PAGO_EMP");

            entity.Property(e => e.IdFpago).HasColumnName("ID_FPAGO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Fpago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FPAGO");
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

        modelBuilder.Entity<Hamb20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HAMB_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Harq20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HARQ_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Hbsch20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HBSCH_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
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

        modelBuilder.Entity<Hlsodom20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HLSOdom_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Hmapi20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HMAPi_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Hmed20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HMED_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Hoja2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hoja2$");

            entity.Property(e => e.Aa)
                .HasMaxLength(255)
                .HasColumnName("AA");
            entity.Property(e => e.AcSem).HasColumnName("AC-sem");
            entity.Property(e => e.AcSemConvergen)
                .HasMaxLength(255)
                .HasColumnName("AC-sem_convergen");
            entity.Property(e => e.ApeAyud)
                .HasMaxLength(255)
                .HasColumnName("APE AYUD");
            entity.Property(e => e.ApeConvergenica)
                .HasMaxLength(255)
                .HasColumnName("APE-CONVERGENICA");
            entity.Property(e => e.ApeDoc)
                .HasMaxLength(255)
                .HasColumnName("APE_DOC");
            entity.Property(e => e.ApePres)
                .HasMaxLength(255)
                .HasColumnName("APE _PRES _");
            entity.Property(e => e.ApePresExternado)
                .HasMaxLength(255)
                .HasColumnName("APE _PRES _externado");
            entity.Property(e => e.CódAsignatura)
                .HasMaxLength(255)
                .HasColumnName("Cód# Asignatura");
            entity.Property(e => e.CódCarrera)
                .HasMaxLength(255)
                .HasColumnName("Cód# Carrera");
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.NombreAsignatura)
                .HasMaxLength(255)
                .HasColumnName("Nombre Asignatura");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(255)
                .HasColumnName("Nombre Carrera");
            entity.Property(e => e.NombrePlanEstudio)
                .HasMaxLength(255)
                .HasColumnName("Nombre Plan Estudio");
            entity.Property(e => e.Sigpestud)
                .HasMaxLength(255)
                .HasColumnName("SIGPESTUD");
            entity.Property(e => e.UnidadCurricular)
                .HasMaxLength(255)
                .HasColumnName("UNIDAD CURRICULAR");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO", tb =>
                {
                    tb.HasTrigger("LOG_HORARIO_DELETE");
                    tb.HasTrigger("LOG_HORARIO_INSERT");
                });

            entity.HasIndex(e => new { e.IdPlanificacion, e.IdDia, e.HoraIni, e.HoraFin }, "AK_HORARIO").IsUnique();

            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");

            entity.HasOne(d => d.IdDiaNavigation).WithMany()
                .HasForeignKey(d => d.IdDia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIO_FK_DIA_RE_DIA");

            entity.HasOne(d => d.IdPlanificacionNavigation).WithMany()
                .HasForeignKey(d => d.IdPlanificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIO_PLANIFICACION");
        });

        modelBuilder.Entity<HorarioArq20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioARQ-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioCea20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioCEA-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioCisa20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioCISA-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioDer20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioDER-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_FECHA", tb =>
                {
                    tb.HasTrigger("LOG_HORARIO_FECHA_DELETE");
                    tb.HasTrigger("LOG_HORARIO_FECHA_INSERT");
                });

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.OrdenFecha).HasColumnName("ORDEN_FECHA");
        });

        modelBuilder.Entity<HorarioFechaLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_FECHA_LOG");

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaLog)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.OrdenFecha).HasColumnName("ORDEN_FECHA");
            entity.Property(e => e.TipoModificacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO_MODIFICACION");
        });

        modelBuilder.Entity<HorarioFechaTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_FECHA_TEMP");

            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdPlanTemp).HasColumnName("ID_PLAN_TEMP");
            entity.Property(e => e.OrdenFecha).HasColumnName("ORDEN_FECHA");

            entity.HasOne(d => d.IdPlanTempNavigation).WithMany()
                .HasForeignKey(d => d.IdPlanTemp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIO_FECHA_TEMP_PLANIFICACION_TEMP");
        });

        modelBuilder.Entity<HorarioFinAb20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinAb_20234");

            entity.Property(e => e.Archivo)
                .HasMaxLength(255)
                .HasColumnName("ARCHIVO");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioFinAb20253>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinAb_20253");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioFinModAb20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinModAb_20234");

            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcarr)
                .HasMaxLength(255)
                .HasColumnName("CODCARR");
            entity.Property(e => e.Codplane)
                .HasMaxLength(255)
                .HasColumnName("CODPLANE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion).HasColumnName("SECCION");
        });

        modelBuilder.Entity<HorarioFinModOc20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinModOc_20251");

            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcarr)
                .HasMaxLength(255)
                .HasColumnName("CODCARR");
            entity.Property(e => e.Codplane)
                .HasMaxLength(255)
                .HasColumnName("CODPLANE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Procesado).HasColumnName("PROCESADO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion).HasColumnName("SECCION");
        });

        modelBuilder.Entity<HorarioFinOc20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinOc_20251");

            entity.Property(e => e.Archivo)
                .HasMaxLength(255)
                .HasColumnName("ARCHIVO");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioFinValidacion20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioFinValidacion_20251");

            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcarr)
                .HasMaxLength(255)
                .HasColumnName("CODCARR");
            entity.Property(e => e.Codplane)
                .HasMaxLength(255)
                .HasColumnName("CODPLANE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Procesado).HasColumnName("PROCESADO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
        });

        modelBuilder.Entity<HorarioFinal20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horarioFinal_20234");

            entity.Property(e => e.Archivo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ARCHIVO");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioFinal20234Resp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horarioFinal_20234_resp");

            entity.Property(e => e.Archivo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ARCHIVO");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_LOG");

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.TipoModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_MODIFICACION");
        });

        modelBuilder.Entity<HorarioLso20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioLSO-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioLsodom20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioLSOdom-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioMec20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioMEC-2023-4");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorarioMod20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_MOD_20251");

            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarr)
                .HasMaxLength(255)
                .HasColumnName("COD_CARR");
            entity.Property(e => e.Codmat)
                .HasMaxLength(255)
                .HasColumnName("CODMAT");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraF)
                .HasMaxLength(255)
                .HasColumnName("HORA_F");
            entity.Property(e => e.HoraI)
                .HasMaxLength(255)
                .HasColumnName("HORA_I");
            entity.Property(e => e.Horas)
                .HasMaxLength(255)
                .HasColumnName("HORAS");
            entity.Property(e => e.IdPlanificacion)
                .HasMaxLength(255)
                .HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Unido)
                .HasMaxLength(255)
                .HasColumnName("UNIDO");
        });

        modelBuilder.Entity<HorarioMod20251V2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_MOD_20251_v2");

            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarr)
                .HasMaxLength(255)
                .HasColumnName("COD_CARR");
            entity.Property(e => e.Codmat)
                .HasMaxLength(255)
                .HasColumnName("CODMAT");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraF)
                .HasMaxLength(255)
                .HasColumnName("HORA_F");
            entity.Property(e => e.HoraI)
                .HasMaxLength(255)
                .HasColumnName("HORA_I");
            entity.Property(e => e.Horas)
                .HasMaxLength(255)
                .HasColumnName("HORAS");
            entity.Property(e => e.IdPlanificacion)
                .HasMaxLength(255)
                .HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Unido)
                .HasMaxLength(255)
                .HasColumnName("UNIDO");
        });

        modelBuilder.Entity<HorarioMod20251V3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_MOD_20251_v3");

            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarr)
                .HasMaxLength(255)
                .HasColumnName("COD_CARR");
            entity.Property(e => e.Codmat)
                .HasMaxLength(255)
                .HasColumnName("CODMAT");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraF)
                .HasMaxLength(255)
                .HasColumnName("HORA_F");
            entity.Property(e => e.HoraI)
                .HasMaxLength(255)
                .HasColumnName("HORA_I");
            entity.Property(e => e.Horas)
                .HasMaxLength(255)
                .HasColumnName("HORAS");
            entity.Property(e => e.IdPlanificacion)
                .HasMaxLength(255)
                .HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Unido)
                .HasMaxLength(255)
                .HasColumnName("UNIDO");
        });

        modelBuilder.Entity<HorarioMod20251V4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horario_mod_20251_v4");

            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarr)
                .HasMaxLength(255)
                .HasColumnName("COD_CARR");
            entity.Property(e => e.Codmat)
                .HasMaxLength(255)
                .HasColumnName("CODMAT");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof).HasColumnName("CODPROF");
            entity.Property(e => e.F15).HasColumnType("datetime");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraF)
                .HasMaxLength(255)
                .HasColumnName("HORA_F");
            entity.Property(e => e.HoraI)
                .HasMaxLength(255)
                .HasColumnName("HORA_I");
            entity.Property(e => e.Horas)
                .HasMaxLength(255)
                .HasColumnName("HORAS");
            entity.Property(e => e.IdPlanificacion)
                .HasMaxLength(255)
                .HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion).HasColumnName("SECCION");
            entity.Property(e => e.Unido)
                .HasMaxLength(255)
                .HasColumnName("UNIDO");
        });

        modelBuilder.Entity<HorarioModValidacion20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horario_mod_validacion_20251");

            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarr)
                .HasMaxLength(255)
                .HasColumnName("COD_CARR");
            entity.Property(e => e.Codmat)
                .HasMaxLength(255)
                .HasColumnName("CODMAT");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof).HasColumnName("CODPROF");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.HoraF)
                .HasMaxLength(255)
                .HasColumnName("HORA_F");
            entity.Property(e => e.HoraI)
                .HasMaxLength(255)
                .HasColumnName("HORA_I");
            entity.Property(e => e.Horas)
                .HasMaxLength(255)
                .HasColumnName("HORAS");
            entity.Property(e => e.IdPlanificacion)
                .HasMaxLength(255)
                .HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Procesado).HasColumnName("PROCESADO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Unido)
                .HasMaxLength(255)
                .HasColumnName("UNIDO");
        });

        modelBuilder.Entity<HorarioTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIO_TEMP");

            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.HoraFin).HasColumnName("HORA_FIN");
            entity.Property(e => e.HoraIni).HasColumnName("HORA_INI");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdPlanTemp).HasColumnName("ID_PLAN_TEMP");

            entity.HasOne(d => d.IdDiaNavigation).WithMany()
                .HasForeignKey(d => d.IdDia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIO_TEMP_DIA");

            entity.HasOne(d => d.IdPlanTempNavigation).WithMany()
                .HasForeignKey(d => d.IdPlanTemp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIO_TEMP_PLANIFICACION_TEMP");
        });

        modelBuilder.Entity<HorarioTemporal16102023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HorarioTemporal16102023");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Horarioprueba20243>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIOPRUEBA20243");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("aula");
            entity.Property(e => e.CarreraU)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CarreraU+");
            entity.Property(e => e.CodCentro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodMat)
                .HasMaxLength(255)
                .HasColumnName("COD_MAT");
            entity.Property(e => e.Codcurso)
                .HasMaxLength(255)
                .HasColumnName("CODCURSO");
            entity.Property(e => e.CodigoEspaciosFisicos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_espacios_fisicos");
            entity.Property(e => e.Componente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("componente");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("desde");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("dia");
            entity.Property(e => e.Fila).HasColumnName("FILA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("grupo");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdentificacionEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("identificacion_Emp");
            entity.Property(e => e.MallaU)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MallaU+");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("materia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("profesor");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("semana");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("tarea");
            entity.Property(e => e.TipoComponente).HasColumnName("TIPO_COMPONENTE");
        });

        modelBuilder.Entity<Horariopruebafin20243>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIOPRUEBAFIN20243");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("aula");
            entity.Property(e => e.CarreraU)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CarreraU+");
            entity.Property(e => e.CodCentro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodMat)
                .HasMaxLength(255)
                .HasColumnName("COD_MAT");
            entity.Property(e => e.Codcurso)
                .HasMaxLength(255)
                .HasColumnName("CODCURSO");
            entity.Property(e => e.CodigoEspaciosFisicos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_espacios_fisicos");
            entity.Property(e => e.Componente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("componente");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("desde");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("dia");
            entity.Property(e => e.Fila).HasColumnName("FILA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("grupo");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.IdentificacionEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("identificacion_Emp");
            entity.Property(e => e.MallaU)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MallaU+");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("materia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nommateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMMATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("profesor");
            entity.Property(e => e.Seccion)
                .HasMaxLength(255)
                .HasColumnName("SECCION");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("semana");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("tarea");
            entity.Property(e => e.TipoComponente).HasColumnName("TIPO_COMPONENTE");
        });

        modelBuilder.Entity<Horariopruebafin20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIOPRUEBAFIN20251");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CodigoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_carrera");
            entity.Property(e => e.CodigoEspaciosFisicos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_espacios_fisicos");
            entity.Property(e => e.CodigoMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigo_materia");
            entity.Property(e => e.CodigoPlanEstudioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_plan_Estudio_malla");
            entity.Property(e => e.Componente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("componente");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni_profesorc");
            entity.Property(e => e.Fila).HasColumnName("FILA");
            entity.Property(e => e.HoraFin).HasColumnName("hora_fin");
            entity.Property(e => e.HoraIni).HasColumnName("hora_ini");
            entity.Property(e => e.IdDia).HasColumnName("id_dia");
            entity.Property(e => e.IdPlanificacion).HasColumnName("id_planificacion");
            entity.Property(e => e.IdTipoComponente).HasColumnName("id_tipo_componente");
            entity.Property(e => e.IdentificacionEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDENTIFICACION_EMP");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
            entity.Property(e => e.Nommateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMMATERIA");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("paralelo");
        });

        modelBuilder.Entity<Horarios20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horarios_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Horariotemporal17112023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horariotemporal17112023");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<HorasDium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horasDia");

            entity.Property(e => e.Horaf).HasColumnName("horaf");
            entity.Property(e => e.Horai).HasColumnName("horai");
            entity.Property(e => e.Id).HasColumnName("id");
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

        modelBuilder.Entity<Hsoju20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HSOJU_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Hsso20234>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HSSO_20234");

            entity.Property(e => e.Aula)
                .HasMaxLength(255)
                .HasColumnName("AULA");
            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("DESDE");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("DIA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(255)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("HASTA");
            entity.Property(e => e.Materia)
                .HasMaxLength(255)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semana)
                .HasMaxLength(255)
                .HasColumnName("SEMANA");
            entity.Property(e => e.Sesion)
                .HasMaxLength(255)
                .HasColumnName("SESION");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .HasColumnName("TAREA");
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.IdIdioma).IsClustered(false);

            entity.ToTable("IDIOMA");

            entity.Property(e => e.IdIdioma).HasColumnName("ID_IDIOMA");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.Certificacion).HasColumnName("CERTIFICACION");
            entity.Property(e => e.Certificado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaEmision).HasColumnName("FECHA_EMISION");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.Idioma1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDIOMA");
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Nivel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Idiomas)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IDIOMA_EMPLEADO");
        });

        modelBuilder.Entity<InfoAcademica>(entity =>
        {
            entity.HasKey(e => e.IdInfoAcademica).IsClustered(false);

            entity.ToTable("INFO_ACADEMICA");

            entity.Property(e => e.IdInfoAcademica).HasColumnName("ID_INFO_ACADEMICA");
            entity.Property(e => e.Certificado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO");
            entity.Property(e => e.FechaEgresa)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EGRESA");
            entity.Property(e => e.FechaRegSenecyt)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REG_SENECYT");
            entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdNivelAcademico).HasColumnName("ID_NIVEL_ACADEMICO");
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TITULO");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.InfoAcademicas)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INFO_ACADEMICA_PAIS");

            entity.HasOne(d => d.IdNivelAcademicoNavigation).WithMany(p => p.InfoAcademicas)
                .HasForeignKey(d => d.IdNivelAcademico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INFO_ACADEMICA_NIVEL_ACADEMICO");
        });

        modelBuilder.Entity<InfoAcademicaNew>(entity =>
        {
            entity.HasKey(e => e.IdInfoAcademica).IsClustered(false);

            entity.ToTable("INFO_ACADEMICA_NEW");

            entity.Property(e => e.IdInfoAcademica).HasColumnName("ID_INFO_ACADEMICA");
            entity.Property(e => e.AprobadoTh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("APROBADO_TH");
            entity.Property(e => e.CertificadoSenecyt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO_SENECYT");
            entity.Property(e => e.CertificadoTitulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO_TITULO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.FAprueba)
                .HasColumnType("datetime")
                .HasColumnName("F_APRUEBA");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaEmsision).HasColumnName("FECHA_EMSISION");
            entity.Property(e => e.FechaRegSenecyt).HasColumnName("FECHA_REG_SENECYT");
            entity.Property(e => e.IdCampoEspecifico).HasColumnName("ID_CAMPO_ESPECIFICO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdNivelAcademico).HasColumnName("ID_NIVEL_ACADEMICO");
            entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");
            entity.Property(e => e.IdUnidadEducativa).HasColumnName("ID_UNIDAD_EDUCATIVA");
            entity.Property(e => e.Institucion)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Titulo)
                .IsUnicode(false)
                .HasColumnName("TITULO");
            entity.Property(e => e.UAprueba)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("U_APRUEBA");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.InfoAcademicaNews)
                .HasForeignKey(d => d.IdEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INFO_ACADEMICA_NEW_EMPLEADO");

            entity.HasOne(d => d.IdNivelAcademicoNavigation).WithMany(p => p.InfoAcademicaNews)
                .HasForeignKey(d => d.IdNivelAcademico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INFO_ACADEMICA_NEW_NIVEL_ACADEMICO");

            entity.HasOne(d => d.IdUnidadEducativaNavigation).WithMany(p => p.InfoAcademicaNews)
                .HasForeignKey(d => d.IdUnidadEducativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INFO_ACADEMICA_NEW_UNIDAD_EDUCATIVA");
        });

        modelBuilder.Entity<InfoAcademicaSubir>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoAcademicaSubir");

            entity.Property(e => e.CampoAmplio)
                .HasMaxLength(255)
                .HasColumnName("CAMPO_AMPLIO");
            entity.Property(e => e.CampoEspecifico)
                .HasMaxLength(255)
                .HasColumnName("CAMPO_ESPECIFICO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(255)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F14).HasMaxLength(255);
            entity.Property(e => e.F15).HasMaxLength(255);
            entity.Property(e => e.FechaEmisionTitulo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EMISION_TITULO");
            entity.Property(e => e.FechaRegSenecyt)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REG_SENECYT");
            entity.Property(e => e.Identificacion).HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Institucion)
                .HasMaxLength(255)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.InstitucionExtranjera)
                .HasMaxLength(255)
                .HasColumnName("INSTITUCION_EXTRANJERA");
            entity.Property(e => e.NivelAcademico)
                .HasMaxLength(255)
                .HasColumnName("NIVEL_ACADEMICO");
            entity.Property(e => e.NumeroDeRegistro)
                .HasMaxLength(255)
                .HasColumnName("NUMERO DE REGISTRO");
            entity.Property(e => e.Pais)
                .HasMaxLength(255)
                .HasColumnName("PAIS");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("TITULO");
        });

        modelBuilder.Entity<InfoEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INFO_EMPLEADO");

            entity.Property(e => e.ApellidoEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_EMP");
            entity.Property(e => e.IdentificacionEmp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDENTIFICACION_EMP");
            entity.Property(e => e.NombresEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES_EMP");
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

        modelBuilder.Entity<InfoPlanificacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INFO_PLANIFICACION");

            entity.Property(e => e.CodigoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CARRERA");
            entity.Property(e => e.CodigoEspaciosFisicos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_ESPACIOS_FISICOS");
            entity.Property(e => e.CodigoFacultad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODIGO_FACULTAD");
            entity.Property(e => e.CodigoMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIA");
            entity.Property(e => e.CodigoPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PERIODO");
            entity.Property(e => e.CodigoPlanEstudioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PLAN_ESTUDIO_MALLA");
            entity.Property(e => e.CodigoSubtipoComponente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_SUBTIPO_COMPONENTE");
            entity.Property(e => e.CodigoTextoPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TEXTO_PERIODO");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.HFin)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("H_FIN");
            entity.Property(e => e.HIni)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("H_INI");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("MODALIDAD");
            entity.Property(e => e.NivelMateria).HasColumnName("NIVEL_MATERIA");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CARRERA");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DIA");
            entity.Property(e => e.NombreFacultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FACULTAD");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIA");
            entity.Property(e => e.NombreSubtipoComponente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_SUBTIPO_COMPONENTE");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
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

        modelBuilder.Entity<LogObservacionSolicitudEmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOG_OBSE__3214EC27855DED9E");

            entity.ToTable("LOG_OBSERVACION_SOLICITUD_EMP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.IdEmpNuevo).HasColumnName("ID_EMP_NUEVO");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.Uc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UC");
        });

        modelBuilder.Entity<Malla>(entity =>
        {
            entity.HasKey(e => e.IdMalla).HasName("PK_MALLA_1");

            entity.ToTable("MALLA");

            entity.HasIndex(e => new { e.IdMateria, e.IdNivelEstudio, e.IdPlanEstudio }, "AK_MALLA").IsUnique();

            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.ActivoMalla).HasColumnName("ACTIVO_MALLA");
            entity.Property(e => e.FecharegMalla)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREG_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("ID_NIVEL_ESTUDIO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
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

        modelBuilder.Entity<Mallaasignaturakaty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mallaasignaturakaty");

            entity.Property(e => e.Aa)
                .HasMaxLength(255)
                .HasColumnName("AA");
            entity.Property(e => e.Acesemcon)
                .HasMaxLength(255)
                .HasColumnName("ACESEMCON");
            entity.Property(e => e.Acsem).HasColumnName("ACSEM");
            entity.Property(e => e.Apeayud)
                .HasMaxLength(255)
                .HasColumnName("APEAYUD");
            entity.Property(e => e.Apeconver)
                .HasMaxLength(255)
                .HasColumnName("APECONVER");
            entity.Property(e => e.Apedoc)
                .HasMaxLength(255)
                .HasColumnName("APEDOC");
            entity.Property(e => e.Apepres)
                .HasMaxLength(255)
                .HasColumnName("APEPRES ");
            entity.Property(e => e.Apepresext)
                .HasMaxLength(255)
                .HasColumnName("APEPRESEXT");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Centro).HasColumnName("CENTRO");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcar)
                .HasMaxLength(255)
                .HasColumnName("CODCAR");
            entity.Property(e => e.Creditos).HasColumnName("CREDITOS");
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.Filtro).HasColumnName("filtro");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Nomasig)
                .HasMaxLength(255)
                .HasColumnName("NOMASIG");
            entity.Property(e => e.Nombrepe)
                .HasMaxLength(255)
                .HasColumnName("NOMBREPE");
            entity.Property(e => e.Plan)
                .HasMaxLength(255)
                .HasColumnName("PLAN");
            entity.Property(e => e.Sigpestud)
                .HasMaxLength(255)
                .HasColumnName("SIGPESTUD");
        });

        modelBuilder.Entity<Mallakaty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MALLAKATY");

            entity.Property(e => e.Aa)
                .HasMaxLength(255)
                .HasColumnName("AA");
            entity.Property(e => e.AcSem).HasColumnName("AC-sem");
            entity.Property(e => e.AcSemConvergen)
                .HasMaxLength(255)
                .HasColumnName("AC-sem_convergen");
            entity.Property(e => e.ApeAyud)
                .HasMaxLength(255)
                .HasColumnName("APE AYUD");
            entity.Property(e => e.ApeConvergenica)
                .HasMaxLength(255)
                .HasColumnName("APE-CONVERGENICA");
            entity.Property(e => e.ApeDoc)
                .HasMaxLength(255)
                .HasColumnName("APE_DOC");
            entity.Property(e => e.ApePres)
                .HasMaxLength(255)
                .HasColumnName("APE _PRES _");
            entity.Property(e => e.ApePresExternado)
                .HasMaxLength(255)
                .HasColumnName("APE _PRES _externado");
            entity.Property(e => e.CódAsignatura)
                .HasMaxLength(255)
                .HasColumnName("Cód# Asignatura");
            entity.Property(e => e.CódCarrera)
                .HasMaxLength(255)
                .HasColumnName("Cód# Carrera");
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.F21).HasMaxLength(255);
            entity.Property(e => e.F22).HasMaxLength(255);
            entity.Property(e => e.F23).HasMaxLength(255);
            entity.Property(e => e.F24).HasMaxLength(255);
            entity.Property(e => e.F25).HasMaxLength(255);
            entity.Property(e => e.F26).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.F28).HasMaxLength(255);
            entity.Property(e => e.Malla)
                .HasMaxLength(255)
                .HasColumnName("MALLA");
            entity.Property(e => e.NombreAsignatura)
                .HasMaxLength(255)
                .HasColumnName("Nombre Asignatura");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(255)
                .HasColumnName("Nombre Carrera");
            entity.Property(e => e.NombrePlanEstudio)
                .HasMaxLength(255)
                .HasColumnName("Nombre Plan Estudio");
            entity.Property(e => e.Sigpestud)
                .HasMaxLength(255)
                .HasColumnName("SIGPESTUD");
            entity.Property(e => e.UnidadCurricular)
                .HasMaxLength(255)
                .HasColumnName("UNIDAD CURRICULAR");
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
            entity.Property(e => e.MalIdMalla).HasColumnName("MAL_ID_MALLA");
            entity.Property(e => e.ObservacionesMateriaEquivalente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES_MATERIA_EQUIVALENTE");
            entity.Property(e => e.PathautorizacionMateriaEquivalente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATHAUTORIZACION_MATERIA_EQUIVALENTE");

            entity.HasOne(d => d.IdMallaNavigation).WithMany(p => p.MateriaEquivalenteIdMallaNavigations)
                .HasForeignKey(d => d.IdMalla)
                .HasConstraintName("FK_MATERIA_EQUIVALENTE_MALLA");

            entity.HasOne(d => d.MalIdMallaNavigation).WithMany(p => p.MateriaEquivalenteMalIdMallaNavigations)
                .HasForeignKey(d => d.MalIdMalla)
                .HasConstraintName("FK_MATERIA_EQUIVALENTE_MALLA1");
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
            entity.Property(e => e.IdTipoMateriaCatalogo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ID_TIPO_MATERIA_CATALOGO");
            entity.Property(e => e.IdUoc).HasColumnName("ID_UOC");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIA");
            entity.Property(e => e.RefCred).HasColumnName("REF_CRED");

            entity.HasOne(d => d.IdTipoAprobacionNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdTipoAprobacion)
                .HasConstraintName("FK_MATERIA_FK_TIPO_A_TIPO_APR");

            entity.HasOne(d => d.IdTipoMateriaCatalogoNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdTipoMateriaCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MATERIA__ID_TIPO__13BCEBC1");

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

        modelBuilder.Entity<NivelAcademico>(entity =>
        {
            entity.HasKey(e => e.IdNivelAcademico).IsClustered(false);

            entity.ToTable("NIVEL_ACADEMICO");

            entity.Property(e => e.IdNivelAcademico).HasColumnName("ID_NIVEL_ACADEMICO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.NivelAcademico1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NIVEL_ACADEMICO");
            entity.Property(e => e.TipoUnidadEducativa).HasColumnName("TIPO_UNIDAD_EDUCATIVA");
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
            entity.Property(e => e.NombreNivelInfraestructura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_NIVEL_INFRAESTRUCTURA");

            entity.HasOne(d => d.IdInfraestructuraNavigation).WithMany(p => p.NivelInfraestructuras)
                .HasForeignKey(d => d.IdInfraestructura)
                .HasConstraintName("FK_NIVEL_IN_FK_NIVEL__INFRAEST");
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

        modelBuilder.Entity<OcupacionHorarios20243>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCUPACION_HORARIOS_20243");

            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("desde");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("dia");
            entity.Property(e => e.E1pbl1).HasColumnName("E1PBL1");
            entity.Property(e => e.E1pbl2).HasColumnName("E1PBL2");
            entity.Property(e => e.E2ola1).HasColumnName("E2OLA1");
            entity.Property(e => e.E2ola2).HasColumnName("E2OLA2");
            entity.Property(e => e.E2ola3).HasColumnName("E2OLA3");
            entity.Property(e => e.E2ola4).HasColumnName("E2OLA4");
            entity.Property(e => e.E2ola5).HasColumnName("E2OLA5");
            entity.Property(e => e.E2p1a1).HasColumnName("E2P1A1");
            entity.Property(e => e.E2p1a2).HasColumnName("E2P1A2");
            entity.Property(e => e.E2p1a3).HasColumnName("E2P1A3");
            entity.Property(e => e.E2p1a4).HasColumnName("E2P1A4");
            entity.Property(e => e.E2p1a5).HasColumnName("E2P1A5");
            entity.Property(e => e.E2p1a6).HasColumnName("E2P1A6");
            entity.Property(e => e.E2p1a7).HasColumnName("E2P1A7");
            entity.Property(e => e.E2p1c1).HasColumnName("E2P1C1");
            entity.Property(e => e.E2p1l1).HasColumnName("E2P1L1");
            entity.Property(e => e.E2p2a1).HasColumnName("E2P2A1");
            entity.Property(e => e.E2p2a2).HasColumnName("E2P2A2");
            entity.Property(e => e.E2p2a4).HasColumnName("E2P2A4");
            entity.Property(e => e.E2p2a5).HasColumnName("E2P2A5");
            entity.Property(e => e.E2p2h1).HasColumnName("E2P2H1");
            entity.Property(e => e.E2p2l1).HasColumnName("E2P2L1");
            entity.Property(e => e.E2p2l2).HasColumnName("E2P2L2");
            entity.Property(e => e.E2p3a1).HasColumnName("E2P3A1");
            entity.Property(e => e.E2p3a11).HasColumnName("E2P3A11");
            entity.Property(e => e.E2p3a12).HasColumnName("E2P3A12");
            entity.Property(e => e.E2p3a2).HasColumnName("E2P3A2");
            entity.Property(e => e.E2p3a3).HasColumnName("E2P3A3");
            entity.Property(e => e.E2p3a8).HasColumnName("E2P3A8");
            entity.Property(e => e.E2p3a9).HasColumnName("E2P3A9");
            entity.Property(e => e.E2pba1).HasColumnName("E2PBA1");
            entity.Property(e => e.E2pba2).HasColumnName("E2PBA2");
            entity.Property(e => e.E2pbc1).HasColumnName("E2PBC1");
            entity.Property(e => e.E2pbl1).HasColumnName("E2PBL1");
            entity.Property(e => e.E2pbl2).HasColumnName("E2PBL2");
            entity.Property(e => e.E2pbl3).HasColumnName("E2PBL3");
            entity.Property(e => e.E2pbl4).HasColumnName("E2PBL4");
            entity.Property(e => e.E2pbl5).HasColumnName("E2PBL5");
            entity.Property(e => e.E3pbl1).HasColumnName("E3PBL1");
            entity.Property(e => e.E4p1a1).HasColumnName("E4P1A1");
            entity.Property(e => e.E4p1l1).HasColumnName("E4P1L1");
            entity.Property(e => e.E4p1l2).HasColumnName("E4P1L2");
            entity.Property(e => e.E4p1l3).HasColumnName("E4P1L3");
            entity.Property(e => e.E4p2a1).HasColumnName("E4P2A1");
            entity.Property(e => e.E4p2l1).HasColumnName("E4P2L1");
            entity.Property(e => e.E4p2l2).HasColumnName("E4P2L2");
            entity.Property(e => e.E4p2l3).HasColumnName("E4P2L3");
            entity.Property(e => e.E4pba1).HasColumnName("E4PBA1");
            entity.Property(e => e.E4pbc1).HasColumnName("E4PBC1");
            entity.Property(e => e.E4pbl0).HasColumnName("E4PBL0");
            entity.Property(e => e.E5p1a1).HasColumnName("E5P1A1");
            entity.Property(e => e.E5p1a2).HasColumnName("E5P1A2");
            entity.Property(e => e.E5p1a3).HasColumnName("E5P1A3");
            entity.Property(e => e.E5p1a4).HasColumnName("E5P1A4");
            entity.Property(e => e.E5p1b2).HasColumnName("E5P1B2");
            entity.Property(e => e.E5p1c1).HasColumnName("E5P1C1");
            entity.Property(e => e.E5p1l2).HasColumnName("E5P1L2");
            entity.Property(e => e.E5pba1).HasColumnName("E5PBA1");
            entity.Property(e => e.E5pba2).HasColumnName("E5PBA2");
            entity.Property(e => e.E5pba3).HasColumnName("E5PBA3");
            entity.Property(e => e.E5pbl1).HasColumnName("E5PBL1");
            entity.Property(e => e.E5pbt1).HasColumnName("E5PBT1");
            entity.Property(e => e.E5pbt2).HasColumnName("E5PBT2");
            entity.Property(e => e.Eap3l1).HasColumnName("EAP3L1");
            entity.Property(e => e.Eip63).HasColumnName("EIP6.3");
            entity.Property(e => e.Gp1a01).HasColumnName("GP1A01");
            entity.Property(e => e.Gp1a02).HasColumnName("GP1A02");
            entity.Property(e => e.Gp1a03).HasColumnName("GP1A03");
            entity.Property(e => e.Gp1a05).HasColumnName("GP1A05");
            entity.Property(e => e.Gp2a01).HasColumnName("GP2A01");
            entity.Property(e => e.Gp2a02).HasColumnName("GP2A02");
            entity.Property(e => e.Gp2a03).HasColumnName("GP2A03");
            entity.Property(e => e.Gp2a04).HasColumnName("GP2A04");
            entity.Property(e => e.Gp2a05).HasColumnName("GP2A05");
            entity.Property(e => e.Gp2a08).HasColumnName("GP2A08");
            entity.Property(e => e.Gp2a09).HasColumnName("GP2A09");
            entity.Property(e => e.Gp2a10).HasColumnName("GP2A10");
            entity.Property(e => e.Gpbsa1).HasColumnName("GPBSA1");
            entity.Property(e => e.Gpbt01).HasColumnName("GPBT01");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("id_dia");
            entity.Property(e => e.SA).HasColumnName("S/A");
        });

        modelBuilder.Entity<OcupacionHorarios20243V2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCUPACION_HORARIOS_20243_V2");

            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("desde");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("dia");
            entity.Property(e => e.E1pbl1).HasColumnName("E1PBL1");
            entity.Property(e => e.E1pbl2).HasColumnName("E1PBL2");
            entity.Property(e => e.E2ola1).HasColumnName("E2OLA1");
            entity.Property(e => e.E2ola2).HasColumnName("E2OLA2");
            entity.Property(e => e.E2ola3).HasColumnName("E2OLA3");
            entity.Property(e => e.E2ola4).HasColumnName("E2OLA4");
            entity.Property(e => e.E2ola5).HasColumnName("E2OLA5");
            entity.Property(e => e.E2p1a1).HasColumnName("E2P1A1");
            entity.Property(e => e.E2p1a2).HasColumnName("E2P1A2");
            entity.Property(e => e.E2p1a3).HasColumnName("E2P1A3");
            entity.Property(e => e.E2p1a4).HasColumnName("E2P1A4");
            entity.Property(e => e.E2p1a5).HasColumnName("E2P1A5");
            entity.Property(e => e.E2p1a6).HasColumnName("E2P1A6");
            entity.Property(e => e.E2p1a7).HasColumnName("E2P1A7");
            entity.Property(e => e.E2p1c1).HasColumnName("E2P1C1");
            entity.Property(e => e.E2p1l1).HasColumnName("E2P1L1");
            entity.Property(e => e.E2p2a1).HasColumnName("E2P2A1");
            entity.Property(e => e.E2p2a2).HasColumnName("E2P2A2");
            entity.Property(e => e.E2p2a4).HasColumnName("E2P2A4");
            entity.Property(e => e.E2p2a5).HasColumnName("E2P2A5");
            entity.Property(e => e.E2p2h1).HasColumnName("E2P2H1");
            entity.Property(e => e.E2p2l1).HasColumnName("E2P2L1");
            entity.Property(e => e.E2p2l2).HasColumnName("E2P2L2");
            entity.Property(e => e.E2p3a1).HasColumnName("E2P3A1");
            entity.Property(e => e.E2p3a11).HasColumnName("E2P3A11");
            entity.Property(e => e.E2p3a12).HasColumnName("E2P3A12");
            entity.Property(e => e.E2p3a2).HasColumnName("E2P3A2");
            entity.Property(e => e.E2p3a3).HasColumnName("E2P3A3");
            entity.Property(e => e.E2p3a8).HasColumnName("E2P3A8");
            entity.Property(e => e.E2p3a9).HasColumnName("E2P3A9");
            entity.Property(e => e.E2pba1).HasColumnName("E2PBA1");
            entity.Property(e => e.E2pba2).HasColumnName("E2PBA2");
            entity.Property(e => e.E2pbc1).HasColumnName("E2PBC1");
            entity.Property(e => e.E2pbl1).HasColumnName("E2PBL1");
            entity.Property(e => e.E2pbl2).HasColumnName("E2PBL2");
            entity.Property(e => e.E2pbl3).HasColumnName("E2PBL3");
            entity.Property(e => e.E2pbl4).HasColumnName("E2PBL4");
            entity.Property(e => e.E2pbl5).HasColumnName("E2PBL5");
            entity.Property(e => e.E3pbl1).HasColumnName("E3PBL1");
            entity.Property(e => e.E4p1a1).HasColumnName("E4P1A1");
            entity.Property(e => e.E4p1l1).HasColumnName("E4P1L1");
            entity.Property(e => e.E4p1l2).HasColumnName("E4P1L2");
            entity.Property(e => e.E4p1l3).HasColumnName("E4P1L3");
            entity.Property(e => e.E4p2a1).HasColumnName("E4P2A1");
            entity.Property(e => e.E4p2l1).HasColumnName("E4P2L1");
            entity.Property(e => e.E4p2l2).HasColumnName("E4P2L2");
            entity.Property(e => e.E4p2l3).HasColumnName("E4P2L3");
            entity.Property(e => e.E4pba1).HasColumnName("E4PBA1");
            entity.Property(e => e.E4pbc1).HasColumnName("E4PBC1");
            entity.Property(e => e.E4pbl0).HasColumnName("E4PBL0");
            entity.Property(e => e.E5p1a1).HasColumnName("E5P1A1");
            entity.Property(e => e.E5p1a2).HasColumnName("E5P1A2");
            entity.Property(e => e.E5p1a3).HasColumnName("E5P1A3");
            entity.Property(e => e.E5p1a4).HasColumnName("E5P1A4");
            entity.Property(e => e.E5p1b2).HasColumnName("E5P1B2");
            entity.Property(e => e.E5p1c1).HasColumnName("E5P1C1");
            entity.Property(e => e.E5p1l2).HasColumnName("E5P1L2");
            entity.Property(e => e.E5pba1).HasColumnName("E5PBA1");
            entity.Property(e => e.E5pba2).HasColumnName("E5PBA2");
            entity.Property(e => e.E5pba3).HasColumnName("E5PBA3");
            entity.Property(e => e.E5pbl1).HasColumnName("E5PBL1");
            entity.Property(e => e.E5pbt1).HasColumnName("E5PBT1");
            entity.Property(e => e.E5pbt2).HasColumnName("E5PBT2");
            entity.Property(e => e.Eap3l1).HasColumnName("EAP3L1");
            entity.Property(e => e.Eip63).HasColumnName("EIP6.3");
            entity.Property(e => e.Gp1a01).HasColumnName("GP1A01");
            entity.Property(e => e.Gp1a02).HasColumnName("GP1A02");
            entity.Property(e => e.Gp1a03).HasColumnName("GP1A03");
            entity.Property(e => e.Gp1a05).HasColumnName("GP1A05");
            entity.Property(e => e.Gp2a01).HasColumnName("GP2A01");
            entity.Property(e => e.Gp2a02).HasColumnName("GP2A02");
            entity.Property(e => e.Gp2a03).HasColumnName("GP2A03");
            entity.Property(e => e.Gp2a04).HasColumnName("GP2A04");
            entity.Property(e => e.Gp2a05).HasColumnName("GP2A05");
            entity.Property(e => e.Gp2a08).HasColumnName("GP2A08");
            entity.Property(e => e.Gp2a09).HasColumnName("GP2A09");
            entity.Property(e => e.Gp2a10).HasColumnName("GP2A10");
            entity.Property(e => e.Gpbsa1).HasColumnName("GPBSA1");
            entity.Property(e => e.Gpbt01).HasColumnName("GPBT01");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("id_dia");
            entity.Property(e => e.SA).HasColumnName("S/A");
        });

        modelBuilder.Entity<OcupacionHorarios20243V3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCUPACION_HORARIOS_20243_V3");

            entity.Property(e => e.Desde)
                .HasMaxLength(255)
                .HasColumnName("desde");
            entity.Property(e => e.Dia)
                .HasMaxLength(255)
                .HasColumnName("dia");
            entity.Property(e => e.E1pbl1).HasColumnName("E1PBL1");
            entity.Property(e => e.E1pbl2).HasColumnName("E1PBL2");
            entity.Property(e => e.E2ola1).HasColumnName("E2OLA1");
            entity.Property(e => e.E2ola2).HasColumnName("E2OLA2");
            entity.Property(e => e.E2ola3).HasColumnName("E2OLA3");
            entity.Property(e => e.E2ola4).HasColumnName("E2OLA4");
            entity.Property(e => e.E2ola5).HasColumnName("E2OLA5");
            entity.Property(e => e.E2p1a1).HasColumnName("E2P1A1");
            entity.Property(e => e.E2p1a2).HasColumnName("E2P1A2");
            entity.Property(e => e.E2p1a3).HasColumnName("E2P1A3");
            entity.Property(e => e.E2p1a4).HasColumnName("E2P1A4");
            entity.Property(e => e.E2p1a5).HasColumnName("E2P1A5");
            entity.Property(e => e.E2p1a6).HasColumnName("E2P1A6");
            entity.Property(e => e.E2p1a7).HasColumnName("E2P1A7");
            entity.Property(e => e.E2p1c1).HasColumnName("E2P1C1");
            entity.Property(e => e.E2p1l1).HasColumnName("E2P1L1");
            entity.Property(e => e.E2p2a1).HasColumnName("E2P2A1");
            entity.Property(e => e.E2p2a2).HasColumnName("E2P2A2");
            entity.Property(e => e.E2p2a4).HasColumnName("E2P2A4");
            entity.Property(e => e.E2p2a5).HasColumnName("E2P2A5");
            entity.Property(e => e.E2p2h1).HasColumnName("E2P2H1");
            entity.Property(e => e.E2p2l1).HasColumnName("E2P2L1");
            entity.Property(e => e.E2p2l2).HasColumnName("E2P2L2");
            entity.Property(e => e.E2p3a1).HasColumnName("E2P3A1");
            entity.Property(e => e.E2p3a11).HasColumnName("E2P3A11");
            entity.Property(e => e.E2p3a12).HasColumnName("E2P3A12");
            entity.Property(e => e.E2p3a2).HasColumnName("E2P3A2");
            entity.Property(e => e.E2p3a3).HasColumnName("E2P3A3");
            entity.Property(e => e.E2p3a4).HasColumnName("E2P3A4");
            entity.Property(e => e.E2p3a8).HasColumnName("E2P3A8");
            entity.Property(e => e.E2p3a9).HasColumnName("E2P3A9");
            entity.Property(e => e.E2pba1).HasColumnName("E2PBA1");
            entity.Property(e => e.E2pba2).HasColumnName("E2PBA2");
            entity.Property(e => e.E2pbc1).HasColumnName("E2PBC1");
            entity.Property(e => e.E2pbl1).HasColumnName("E2PBL1");
            entity.Property(e => e.E2pbl2).HasColumnName("E2PBL2");
            entity.Property(e => e.E2pbl3).HasColumnName("E2PBL3");
            entity.Property(e => e.E2pbl4).HasColumnName("E2PBL4");
            entity.Property(e => e.E2pbl5).HasColumnName("E2PBL5");
            entity.Property(e => e.E3pbl1).HasColumnName("E3PBL1");
            entity.Property(e => e.E4p1a1).HasColumnName("E4P1A1");
            entity.Property(e => e.E4p1l1).HasColumnName("E4P1L1");
            entity.Property(e => e.E4p1l2).HasColumnName("E4P1L2");
            entity.Property(e => e.E4p1l3).HasColumnName("E4P1L3");
            entity.Property(e => e.E4p2a1).HasColumnName("E4P2A1");
            entity.Property(e => e.E4p2l1).HasColumnName("E4P2L1");
            entity.Property(e => e.E4p2l2).HasColumnName("E4P2L2");
            entity.Property(e => e.E4p2l3).HasColumnName("E4P2L3");
            entity.Property(e => e.E4pba1).HasColumnName("E4PBA1");
            entity.Property(e => e.E4pbc1).HasColumnName("E4PBC1");
            entity.Property(e => e.E4pbl0).HasColumnName("E4PBL0");
            entity.Property(e => e.E5p1a1).HasColumnName("E5P1A1");
            entity.Property(e => e.E5p1a2).HasColumnName("E5P1A2");
            entity.Property(e => e.E5p1a3).HasColumnName("E5P1A3");
            entity.Property(e => e.E5p1a4).HasColumnName("E5P1A4");
            entity.Property(e => e.E5p1b2).HasColumnName("E5P1B2");
            entity.Property(e => e.E5p1c1).HasColumnName("E5P1C1");
            entity.Property(e => e.E5p1l2).HasColumnName("E5P1L2");
            entity.Property(e => e.E5pba1).HasColumnName("E5PBA1");
            entity.Property(e => e.E5pba2).HasColumnName("E5PBA2");
            entity.Property(e => e.E5pba3).HasColumnName("E5PBA3");
            entity.Property(e => e.E5pbl1).HasColumnName("E5PBL1");
            entity.Property(e => e.E5pbt1).HasColumnName("E5PBT1");
            entity.Property(e => e.E5pbt2).HasColumnName("E5PBT2");
            entity.Property(e => e.Eap3l1).HasColumnName("EAP3L1");
            entity.Property(e => e.Eip63).HasColumnName("EIP6.3");
            entity.Property(e => e.Gp1a01).HasColumnName("GP1A01");
            entity.Property(e => e.Gp1a02).HasColumnName("GP1A02");
            entity.Property(e => e.Gp1a05).HasColumnName("GP1A05");
            entity.Property(e => e.Gp1a07).HasColumnName("GP1A07");
            entity.Property(e => e.Gp2a01).HasColumnName("GP2A01");
            entity.Property(e => e.Gp2a02).HasColumnName("GP2A02");
            entity.Property(e => e.Gp2a03).HasColumnName("GP2A03");
            entity.Property(e => e.Gp2a05).HasColumnName("GP2A05");
            entity.Property(e => e.Gp2a06).HasColumnName("GP2A06");
            entity.Property(e => e.Gp2a08).HasColumnName("GP2A08");
            entity.Property(e => e.Gp2a09).HasColumnName("GP2A09");
            entity.Property(e => e.Gp2a10).HasColumnName("GP2A10");
            entity.Property(e => e.Gpbsa1).HasColumnName("GPBSA1");
            entity.Property(e => e.Gpbt01).HasColumnName("GPBT01");
            entity.Property(e => e.Hasta)
                .HasMaxLength(255)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("id_dia");
            entity.Property(e => e.SA).HasColumnName("S/A");
        });

        modelBuilder.Entity<OcupacionHorarios20251>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCUPACION_HORARIOS_20251");

            entity.Property(e => e.Desde)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("desde");
            entity.Property(e => e.E1pbcap).HasColumnName("E1PBCAP");
            entity.Property(e => e.E1pbsemio).HasColumnName("E1PBSEMIO");
            entity.Property(e => e.E2p1a1).HasColumnName("E2P1A1");
            entity.Property(e => e.E2p1a3).HasColumnName("E2P1A3");
            entity.Property(e => e.E2p1a4).HasColumnName("E2P1A4");
            entity.Property(e => e.E2p1a5).HasColumnName("E2P1A5");
            entity.Property(e => e.E2p1a6).HasColumnName("E2P1A6");
            entity.Property(e => e.E2p1c1).HasColumnName("E2P1C1");
            entity.Property(e => e.E2p1rx).HasColumnName("E2P1RX");
            entity.Property(e => e.E2p2a1).HasColumnName("E2P2A1");
            entity.Property(e => e.E2p2a2).HasColumnName("E2P2A2");
            entity.Property(e => e.E2p2a3).HasColumnName("E2P2A3");
            entity.Property(e => e.E2p2a4).HasColumnName("E2P2A4");
            entity.Property(e => e.E2p2a5).HasColumnName("E2P2A5");
            entity.Property(e => e.E2p2ginec).HasColumnName("E2P2GINEC");
            entity.Property(e => e.E2p2hosp).HasColumnName("E2P2HOSP");
            entity.Property(e => e.E2p2morfu).HasColumnName("E2P2MORFU");
            entity.Property(e => e.E2p3a1).HasColumnName("E2P3A1");
            entity.Property(e => e.E2p3a11).HasColumnName("E2P3A11");
            entity.Property(e => e.E2p3a12).HasColumnName("E2P3A12");
            entity.Property(e => e.E2p3a2).HasColumnName("E2P3A2");
            entity.Property(e => e.E2p3a3).HasColumnName("E2P3A3");
            entity.Property(e => e.E2p3a4).HasColumnName("E2P3A4");
            entity.Property(e => e.E2p3a5).HasColumnName("E2P3A5");
            entity.Property(e => e.E2p3a6).HasColumnName("E2P3A6");
            entity.Property(e => e.E2p3a7).HasColumnName("E2P3A7");
            entity.Property(e => e.E2p3a8).HasColumnName("E2P3A8");
            entity.Property(e => e.E2pba1).HasColumnName("E2PBA1");
            entity.Property(e => e.E2pba2).HasColumnName("E2PBA2");
            entity.Property(e => e.E2pbanmen).HasColumnName("E2PBANMEN");
            entity.Property(e => e.E2pbc1).HasColumnName("E2PBC1");
            entity.Property(e => e.E2pbfisio).HasColumnName("E2PBFISIO");
            entity.Property(e => e.E2pbmatde).HasColumnName("E2PBMATDE");
            entity.Property(e => e.E2pbsemio).HasColumnName("E2PBSEMIO");
            entity.Property(e => e.E2pbsimul).HasColumnName("E2PBSIMUL");
            entity.Property(e => e.E3pbcliO).HasColumnName("E3PBCLI-O");
            entity.Property(e => e.E4p1a1).HasColumnName("E4P1A1");
            entity.Property(e => e.E4p1emhis).HasColumnName("E4P1EMHIS");
            entity.Property(e => e.E4p1micro).HasColumnName("E4P1MICRO");
            entity.Property(e => e.E4p1quimi).HasColumnName("E4P1QUIMI");
            entity.Property(e => e.E4p2a1).HasColumnName("E4P2A1");
            entity.Property(e => e.E4p2anato).HasColumnName("E4P2ANATO");
            entity.Property(e => e.E4p2bcmol).HasColumnName("E4P2BCMOL");
            entity.Property(e => e.E4pba1).HasColumnName("E4PBA1");
            entity.Property(e => e.E4pbc1).HasColumnName("E4PBC1");
            entity.Property(e => e.E4pbgym).HasColumnName("E4PBGYM");
            entity.Property(e => e.E5p1a1).HasColumnName("E5P1A1");
            entity.Property(e => e.E5p1a2).HasColumnName("E5P1A2");
            entity.Property(e => e.E5p1a3).HasColumnName("E5P1A3");
            entity.Property(e => e.E5p1a4).HasColumnName("E5P1A4");
            entity.Property(e => e.E5p1a5).HasColumnName("E5P1A5");
            entity.Property(e => e.E5p1a6).HasColumnName("E5P1A6");
            entity.Property(e => e.E5p1a7).HasColumnName("E5P1A7");
            entity.Property(e => e.E5p1c1).HasColumnName("E5P1C1");
            entity.Property(e => e.E5pba1).HasColumnName("E5PBA1");
            entity.Property(e => e.E5pba2).HasColumnName("E5PBA2");
            entity.Property(e => e.E5pba3).HasColumnName("E5PBA3");
            entity.Property(e => e.E5pbciber).HasColumnName("E5PBCIBER");
            entity.Property(e => e.E5pbdmat).HasColumnName("E5PBDMAT");
            entity.Property(e => e.E5pbprmic).HasColumnName("E5PBPRMIC");
            entity.Property(e => e.E5pbt2).HasColumnName("E5PBT2");
            entity.Property(e => e.E5pbtaut).HasColumnName("E5PBTAUT");
            entity.Property(e => e.Eap3cliF).HasColumnName("EAP3CLI-F");
            entity.Property(e => e.Eap3l1).HasColumnName("EAP3L1");
            entity.Property(e => e.Eip42).HasColumnName("EIP4.2");
            entity.Property(e => e.Gp1a01).HasColumnName("GP1A01");
            entity.Property(e => e.Gp1a02).HasColumnName("GP1A02");
            entity.Property(e => e.Gp1a03).HasColumnName("GP1A03");
            entity.Property(e => e.Gp1a07).HasColumnName("GP1A07");
            entity.Property(e => e.Gp2a01).HasColumnName("GP2A01");
            entity.Property(e => e.Gp2a02).HasColumnName("GP2A02");
            entity.Property(e => e.Gp2a03).HasColumnName("GP2A03");
            entity.Property(e => e.Gp2a05).HasColumnName("GP2A05");
            entity.Property(e => e.Gp2a06).HasColumnName("GP2A06");
            entity.Property(e => e.Gp2a09).HasColumnName("GP2A09");
            entity.Property(e => e.Gp2a10).HasColumnName("GP2A10");
            entity.Property(e => e.Gpbsa1).HasColumnName("GPBSA1");
            entity.Property(e => e.Hasta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("hasta");
            entity.Property(e => e.IdDia).HasColumnName("ID_DIA");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_dia");
            entity.Property(e => e.Online).HasColumnName("ONLINE");
            entity.Property(e => e.SE).HasColumnName("S/E");
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
            entity.HasKey(e => e.IdPeriodo).HasName("PK_PERIODO_1");

            entity.ToTable("PERIODO");

            entity.HasIndex(e => new { e.IdTipoPeriodo, e.IdModalidad, e.IdEstadoPeriodo, e.CodigoPeriodo }, "AK_PERIODO").IsUnique();

            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.ActivoPeriodo).HasColumnName("ACTIVO_PERIODO");
            entity.Property(e => e.ActivoPeriodoPlanificacion).HasColumnName("ACTIVO_PERIODO_PLANIFICACION");
            entity.Property(e => e.ActivoPeriodoSilabo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACTIVO_PERIODO_SILABO");
            entity.Property(e => e.ActivoPeriodoVinculacion).HasColumnName("ACTIVO_PERIODO_VINCULACION");
            entity.Property(e => e.AnoPeriodo).HasColumnName("ANO_PERIODO");
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
            entity.Property(e => e.IdEstadoPeriodo).HasColumnName("ID_ESTADO_PERIODO");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");
            entity.Property(e => e.IdTipoPeriodo).HasColumnName("ID_TIPO_PERIODO");

            entity.HasOne(d => d.IdEstadoPeriodoNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdEstadoPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_ESTADO_P");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.IdModalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIODO_FK_PERIOD_MODALIDA");

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
            entity.Property(e => e.IdNivelEstudio).HasColumnName("id_nivel_estudio");
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

        modelBuilder.Entity<PlanUmas20243>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanUMAS20243");

            entity.Property(e => e.Asignado)
                .HasMaxLength(255)
                .HasColumnName("ASIGNADO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.CantAlumnos).HasColumnName("CANT ALUMNOS");
            entity.Property(e => e.CantAlumnosCarrera).HasColumnName("CANT ALUMNOS CARRERA");
            entity.Property(e => e.Centro)
                .HasMaxLength(255)
                .HasColumnName("CENTRO");
            entity.Property(e => e.Codprof).HasColumnName("CODPROF");
            entity.Property(e => e.Créditos).HasColumnName("CRÉDITOS");
            entity.Property(e => e.CódigoAsignatura)
                .HasMaxLength(255)
                .HasColumnName("CÓDIGO ASIGNATURA");
            entity.Property(e => e.CódigoCarrera)
                .HasMaxLength(255)
                .HasColumnName("CÓDIGO CARRERA");
            entity.Property(e => e.CódigoPlanEstudio)
                .HasMaxLength(255)
                .HasColumnName("CÓDIGO PLAN ESTUDIO");
            entity.Property(e => e.Horario)
                .HasMaxLength(255)
                .HasColumnName("HORARIO");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE CARRERA");
            entity.Property(e => e.Paralelo).HasColumnName("PARALELO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semestre)
                .HasMaxLength(255)
                .HasColumnName("SEMESTRE");
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(255)
                .HasColumnName("TIPO CONTRATO");
        });

        modelBuilder.Entity<PlanUmas20243Fin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanUMAS20243_Fin");

            entity.Property(e => e.Asignado)
                .HasMaxLength(255)
                .HasColumnName("ASIGNADO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Cantalum).HasColumnName("CANTALUM");
            entity.Property(e => e.Cantalumcarr).HasColumnName("CANTALUMCARR");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Centro)
                .HasMaxLength(255)
                .HasColumnName("CENTRO");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcar)
                .HasMaxLength(255)
                .HasColumnName("CODCAR");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof).HasColumnName("CODPROF");
            entity.Property(e => e.Creditos).HasColumnName("CREDITOS");
            entity.Property(e => e.Horario)
                .HasMaxLength(255)
                .HasColumnName("HORARIO");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Paralelo).HasColumnName("PARALELO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semestre)
                .HasMaxLength(255)
                .HasColumnName("SEMESTRE");
            entity.Property(e => e.Tc)
                .HasMaxLength(255)
                .HasColumnName("TC");
        });

        modelBuilder.Entity<PlanUmas20243FinAbril>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanUMAS20243_FinAbril");

            entity.Property(e => e.Asignado)
                .HasMaxLength(255)
                .HasColumnName("ASIGNADO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Cantalum).HasColumnName("CANTALUM");
            entity.Property(e => e.Cantalumcarr).HasColumnName("CANTALUMCARR");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Centro)
                .HasMaxLength(255)
                .HasColumnName("CENTRO");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcar)
                .HasMaxLength(255)
                .HasColumnName("CODCAR");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Creditos).HasColumnName("CREDITOS");
            entity.Property(e => e.Horario)
                .HasMaxLength(255)
                .HasColumnName("HORARIO");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Paralelo).HasColumnName("PARALELO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semestre)
                .HasMaxLength(255)
                .HasColumnName("SEMESTRE");
            entity.Property(e => e.Tc)
                .HasMaxLength(255)
                .HasColumnName("TC");
        });

        modelBuilder.Entity<PlanUmas20243FinMayo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanUMAS20243_FinMayo");

            entity.Property(e => e.Asignado)
                .HasMaxLength(255)
                .HasColumnName("ASIGNADO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(255)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Cantalum).HasColumnName("CANTALUM");
            entity.Property(e => e.Cantalumcarr).HasColumnName("CANTALUMCARR");
            entity.Property(e => e.Carrera)
                .HasMaxLength(255)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Centro)
                .HasMaxLength(255)
                .HasColumnName("CENTRO");
            entity.Property(e => e.Codasig)
                .HasMaxLength(255)
                .HasColumnName("CODASIG");
            entity.Property(e => e.Codcar)
                .HasMaxLength(255)
                .HasColumnName("CODCAR");
            entity.Property(e => e.Codpe)
                .HasMaxLength(255)
                .HasColumnName("CODPE");
            entity.Property(e => e.Codprof)
                .HasMaxLength(255)
                .HasColumnName("CODPROF");
            entity.Property(e => e.Creditos).HasColumnName("CREDITOS");
            entity.Property(e => e.Horario)
                .HasMaxLength(255)
                .HasColumnName("HORARIO");
            entity.Property(e => e.Jornada)
                .HasMaxLength(255)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Paralelo).HasColumnName("PARALELO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(255)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Semestre)
                .HasMaxLength(255)
                .HasColumnName("SEMESTRE");
            entity.Property(e => e.Tc)
                .HasMaxLength(255)
                .HasColumnName("TC");
        });

        modelBuilder.Entity<Planificacion>(entity =>
        {
            entity.HasKey(e => e.IdPlanificacion);

            entity.ToTable("PLANIFICACION", tb =>
            {
                tb.HasTrigger("LOG_PLANIFICACION");
                tb.HasTrigger("LOG_PLANIFICACION_INSERT");
            });

            entity.HasIndex(e => new { e.IdPeriodo, e.IdMalla, e.IdModalidadPlanificacion, e.IdPeriodicidadPlanificacion, e.IdTipoComponente, e.Paralelo, e.IdEspaciosFisicos }, "AK_PLANIFICACION").IsUnique();

            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.Activo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVO");
            entity.Property(e => e.Cupo).HasColumnName("CUPO");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.Ua)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.DniProfesorcNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.DniProfesorc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_PROFES_PROFESOR");

            entity.HasOne(d => d.IdEspaciosFisicosNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdEspaciosFisicos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_RELATIONS_ESPACIOS");

            entity.HasOne(d => d.IdMallaNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdMalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFICACION_MALLA");

            entity.HasOne(d => d.IdModalidadPlanificacionNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdModalidadPlanificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_MODALI_MODALIDA");

            entity.HasOne(d => d.IdPeriodicidadPlanificacionNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdPeriodicidadPlanificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFIC_FK_PERIOD_PERIODIC");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Planificacions)
                .HasForeignKey(d => d.IdPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFICACION_PERIODO");
        });

        modelBuilder.Entity<PlanificacionCompartida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PLANIFIC__3214EC2712BE43F7");

            entity.ToTable("PLANIFICACION_COMPARTIDAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdMateria).HasColumnName("ID_MATERIA");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("ID_PLAN_ESTUDIO");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.IdPlanificacionPrincipal).HasColumnName("ID_PLANIFICACION_PRINCIPAL");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.Ua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UC");
        });

        modelBuilder.Entity<PlanificacionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLANIFICACION_LOG");

            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Cupo).HasColumnName("CUPO");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.TipoModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_MODIFICACION");
            entity.Property(e => e.Ua)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UC");
        });

        modelBuilder.Entity<PlanificacionTemp>(entity =>
        {
            entity.HasKey(e => e.IdPlanTemp);

            entity.ToTable("PLANIFICACION_TEMP");

            entity.Property(e => e.IdPlanTemp).HasColumnName("ID_PLAN_TEMP");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Cupo).HasColumnName("CUPO");
            entity.Property(e => e.DniProfesorc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI_PROFESORC");
            entity.Property(e => e.IdEspaciosFisicos).HasColumnName("ID_ESPACIOS_FISICOS");
            entity.Property(e => e.IdMalla).HasColumnName("ID_MALLA");
            entity.Property(e => e.IdModalidadPlanificacion).HasColumnName("ID_MODALIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodicidadPlanificacion).HasColumnName("ID_PERIODICIDAD_PLANIFICACION");
            entity.Property(e => e.IdPeriodo).HasColumnName("ID_PERIODO");
            entity.Property(e => e.IdPlanificacion).HasColumnName("ID_PLANIFICACION");
            entity.Property(e => e.IdSolicitud).HasColumnName("ID_SOLICITUD");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.Paralelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARALELO");
            entity.Property(e => e.Tipod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOD");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.PlanificacionTemps)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLANIFICACION_TEMP_SOLICITUD");
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
            entity.Property(e => e.IdTipoAprobacion).HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.IdTipoPrecorrequisito).HasColumnName("ID_TIPO_PRECORREQUISITO");
            entity.Property(e => e.PathPrerrequsito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATH_PRERREQUSITO");

            entity.HasOne(d => d.IdMallaNavigation).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => d.IdMalla)
                .HasConstraintName("FK_PRERREQUISITO_MALLA");

            entity.HasOne(d => d.IdTipoAprobacionNavigation).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => d.IdTipoAprobacion)
                .HasConstraintName("FK_PRERREQU_FK_TIPOAP_TIPO_APR");

            entity.HasOne(d => d.IdTipoPrecorrequisitoNavigation).WithMany(p => p.Prerrequisitos)
                .HasForeignKey(d => d.IdTipoPrecorrequisito)
                .HasConstraintName("FK_PRERREQU_FK_TIPOPR_TIPO_PRE");
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

        modelBuilder.Entity<ProyectoInvestigacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROYECTO_INVESTIGACION");

            entity.Property(e => e.Duracion).HasColumnName("DURACION");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdProyInves)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PROY_INVES");
            entity.Property(e => e.Participantes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PARTICIPANTES");
            entity.Property(e => e.TituloPInv)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULO_P_INV");
        });

        modelBuilder.Entity<ProyectoVinculacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROYECTO_VINCULACION");

            entity.Property(e => e.Duracion).HasColumnName("DURACION");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdProyVincu)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PROY_VINCU");
            entity.Property(e => e.Participantes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PARTICIPANTES");
            entity.Property(e => e.TituloPVin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULO_P_VIN");
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("prueba");

            entity.Property(e => e.Algo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("algo");
        });

        modelBuilder.Entity<PruebaEdi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pruebaEdi");

            entity.Property(e => e.Algo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("algo");
            entity.Property(e => e.Algo2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("algo2");
            entity.Property(e => e.IdAlgo).HasColumnName("id_algo");
        });

        modelBuilder.Entity<PruebaUmaAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pruebaUMaAct");

            entity.Property(e => e.Codprof1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CODPROF1");
            entity.Property(e => e.Cupo).HasColumnName("CUPO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
        });

        modelBuilder.Entity<Publicacion>(entity =>
        {
            entity.HasKey(e => e.IdPublicacion).IsClustered(false);

            entity.ToTable("PUBLICACION");

            entity.Property(e => e.IdPublicacion).HasColumnName("ID_PUBLICACION");
            entity.Property(e => e.Ano).HasColumnName("ANO");
            entity.Property(e => e.BaseDatos)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BASE_DATOS");
            entity.Property(e => e.Certificado)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CERTIFICADO");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdTipoPublicacion).HasColumnName("ID_TIPO_PUBLICACION");
            entity.Property(e => e.IsbnIssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ISBN_ISSN");
            entity.Property(e => e.RegPropiedadIntelectual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_PROPIEDAD_INTELECTUAL");
            entity.Property(e => e.Titulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULO");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.IdEmpNavigation).WithMany(p => p.Publicacions)
                .HasForeignKey(d => d.IdEmp)
                .HasConstraintName("FK_PUBLICACION_EMPLEADO");
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

        modelBuilder.Entity<SekMallasComponente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SEK_MallasComponentes");

            entity.Property(e => e.Aa).HasColumnName("AA");
            entity.Property(e => e.AcD).HasColumnName("AC-D");
            entity.Property(e => e.AcDc).HasColumnName("AC-DC");
            entity.Property(e => e.ApeA).HasColumnName("APE-A");
            entity.Property(e => e.ApeD).HasColumnName("APE-D");
            entity.Property(e => e.ApeDc).HasColumnName("APE-DC");
            entity.Property(e => e.ApeDe).HasColumnName("APE-DE");
            entity.Property(e => e.ApeSd).HasColumnName("APE-SD");
            entity.Property(e => e.CodigoCarrera)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CARRERA");
            entity.Property(e => e.CodigoMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIA");
            entity.Property(e => e.CodigoPlanEstudioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PLAN_ESTUDIO_MALLA");
            entity.Property(e => e.CodigoUoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_UOC");
            entity.Property(e => e.CreditosMateria).HasColumnName("CREDITOS_MATERIA");
            entity.Property(e => e.HorasSemestralesMateria).HasColumnName("HORAS_SEMESTRALES_MATERIA");
            entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");
            entity.Property(e => e.IdNivelEstudio).HasColumnName("id_nivel_estudio");
            entity.Property(e => e.IdUoc).HasColumnName("ID_UOC");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.NombreCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CARRERA");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MATERIA");
            entity.Property(e => e.NombreModalidadPe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODALIDAD_PE");
            entity.Property(e => e.NombreNivelEstudio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_NIVEL_ESTUDIO");
            entity.Property(e => e.NombreUoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_UOC");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PK__SOLICITU__F090D584CCE9E49A");

            entity.ToTable("SOLICITUD", tb =>
            {
                tb.HasTrigger("APROBACION_SOLICITUD");
                tb.HasTrigger("SOLICITUD_NUEVO_EMP");
            });

            entity.Property(e => e.IdSolicitud).HasColumnName("ID_SOLICITUD");
            entity.Property(e => e.Fa)
                .HasColumnType("datetime")
                .HasColumnName("FA");
            entity.Property(e => e.Fc)
                .HasColumnType("datetime")
                .HasColumnName("FC");
            entity.Property(e => e.FechaSolicitud)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_SOLICITUD");
            entity.Property(e => e.IdAsociado).HasColumnName("ID_ASOCIADO");
            entity.Property(e => e.IdEmpTempN).HasColumnName("ID_EMP_TEMP_N");
            entity.Property(e => e.IdEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ID_ESTADO");
            entity.Property(e => e.Motivo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO_SOLICITUD");
            entity.Property(e => e.Ua)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UA");
            entity.Property(e => e.Uc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UC");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUD_ESTADO_SOLICITUD");
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

        modelBuilder.Entity<SubtipoComponente>(entity =>
        {
            entity.HasKey(e => e.IdSubtipoComponente).IsClustered(false);

            entity.ToTable("SUBTIPO_COMPONENTE");

            entity.Property(e => e.IdSubtipoComponente).HasColumnName("ID_SUBTIPO_COMPONENTE");
            entity.Property(e => e.ActivoSubtipoComponente).HasColumnName("ACTIVO_SUBTIPO_COMPONENTE");
            entity.Property(e => e.CodigoSubtipoComponente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_SUBTIPO_COMPONENTE");
            entity.Property(e => e.DescripcionSubtipoComponente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_SUBTIPO_COMPONENTE");
            entity.Property(e => e.IdTipoComponente).HasColumnName("ID_TIPO_COMPONENTE");
            entity.Property(e => e.IncluyeDedicacionDocenteSubtipoComponente).HasColumnName("INCLUYE_DEDICACION_DOCENTE_SUBTIPO_COMPONENTE");
            entity.Property(e => e.NombreSubtipoComponente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_SUBTIPO_COMPONENTE");

            entity.HasOne(d => d.IdTipoComponenteNavigation).WithMany(p => p.SubtipoComponentes)
                .HasForeignKey(d => d.IdTipoComponente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUBTIPOCOMPONENTE_FK_TIPOCOMPONENTE");
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

        modelBuilder.Entity<Tesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TESIS");

            entity.Property(e => e.Año)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AÑO");
            entity.Property(e => e.Coodirector).HasColumnName("COODIRECTOR");
            entity.Property(e => e.IdEmp).HasColumnName("ID_EMP");
            entity.Property(e => e.IdTesis)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_TESIS");
            entity.Property(e => e.Institucion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Tema)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TEMA");
            entity.Property(e => e.TipoTesis).HasColumnName("TIPO_TESIS");
        });

        modelBuilder.Entity<TipoActividad>(entity =>
        {
            entity.HasKey(e => e.IdTipoActividad).IsClustered(false);

            entity.ToTable("TIPO_ACTIVIDAD");

            entity.Property(e => e.IdTipoActividad).HasColumnName("ID_TIPO_ACTIVIDAD");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.TipoActividad1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_ACTIVIDAD");
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

        modelBuilder.Entity<TipoAprobacionCapacitacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TIPO_APROBACION_CAPACITACION");

            entity.Property(e => e.ActivoTipoAprobacion).HasColumnName("ACTIVO_TIPO_APROBACION");
            entity.Property(e => e.CodigoTipoAprobacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CODIGO_TIPO_APROBACION");
            entity.Property(e => e.IdTipoAprobacion)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_TIPO_APROBACION");
            entity.Property(e => e.TipoAprobacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO_APROBACION");
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

        modelBuilder.Entity<TipoContratoN>(entity =>
        {
            entity.HasKey(e => e.IdTipoContrato);

            entity.ToTable("TIPO_CONTRATO_N");

            entity.Property(e => e.IdTipoContrato).HasColumnName("ID_TIPO_CONTRATO");
            entity.Property(e => e.DescTipoContrato)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC_TIPO_CONTRATO");
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_CONTRATO");
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

        modelBuilder.Entity<TipoDiscapacidad>(entity =>
        {
            entity.HasKey(e => e.IdTipoDiscapacidad).IsClustered(false);

            entity.ToTable("TIPO_DISCAPACIDAD");

            entity.Property(e => e.IdTipoDiscapacidad).HasColumnName("ID_TIPO_DISCAPACIDAD");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.TipoDiscapacidad1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPO_DISCAPACIDAD");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento);

            entity.ToTable("TIPO_DOCUMENTO");

            entity.Property(e => e.IdTipoDocumento).HasColumnName("ID_TIPO_DOCUMENTO");
            entity.Property(e => e.ActivoTipoDocumento).HasColumnName("ACTIVO_TIPO_DOCUMENTO");
            entity.Property(e => e.TipoDocumento1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOCUMENTO");
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

        modelBuilder.Entity<TipoPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoPublicacion).IsClustered(false);

            entity.ToTable("TIPO_PUBLICACION");

            entity.Property(e => e.IdTipoPublicacion).HasColumnName("ID_TIPO_PUBLICACION");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.TipoPublicacion1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPO_PUBLICACION");
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

        modelBuilder.Entity<TitularidadEmp>(entity =>
        {
            entity.HasKey(e => e.IdTitularidad).HasName("PK__TITULARI__EB1414DA88463A52");

            entity.ToTable("TITULARIDAD_EMP");

            entity.Property(e => e.IdTitularidad).HasColumnName("ID_TITULARIDAD");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Titularidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TITULARIDAD");
        });

        modelBuilder.Entity<UnidadEducativa>(entity =>
        {
            entity.HasKey(e => e.IdUnidadEducativa);

            entity.ToTable("UNIDAD_EDUCATIVA");

            entity.Property(e => e.IdUnidadEducativa).HasColumnName("ID_UNIDAD_EDUCATIVA");
            entity.Property(e => e.ActivoUnidadEducativa).HasColumnName("ACTIVO_UNIDAD_EDUCATIVA");
            entity.Property(e => e.CodigoUnidadEducativa)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CODIGO_UNIDAD_EDUCATIVA");
            entity.Property(e => e.NombreUnidadEducativa)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_UNIDAD_EDUCATIVA");
            entity.Property(e => e.TipoUnidadEducativa).HasColumnName("TIPO_UNIDAD_EDUCATIVA");
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
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.NombreUoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_UOC");
        });

        modelBuilder.Entity<UnidadOrganizativa>(entity =>
        {
            entity.HasKey(e => e.IdUo).IsClustered(false);

            entity.ToTable("UNIDAD_ORGANIZATIVA");

            entity.Property(e => e.IdUo).HasColumnName("ID_UO");
            entity.Property(e => e.ActivoUo).HasColumnName("ACTIVO_UO");
            entity.Property(e => e.CodigoUo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_UO");
            entity.Property(e => e.IdFacultad).HasColumnName("ID_FACULTAD");
            entity.Property(e => e.UnidadOrganizativa1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNIDAD_ORGANIZATIVA");
        });

        modelBuilder.Entity<ValidacionMaterium>(entity =>
        {
            entity.HasKey(e => e.IdValidacionMateria).HasName("PK_VALIDA_MAT");

            entity.ToTable("VALIDACION_MATERIA");

            entity.Property(e => e.IdValidacionMateria).HasColumnName("ID_VALIDACION_MATERIA");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.CodigoMateria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_MATERIA");
            entity.Property(e => e.CodigoPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PERIODO");
            entity.Property(e => e.CodigoPlanEstudioMalla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PLAN_ESTUDIO_MALLA");
            entity.Property(e => e.IdModalidad).HasColumnName("ID_MODALIDAD");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.ValidacionMateria)
                .HasForeignKey(d => d.IdModalidad)
                .HasConstraintName("FK_VALIDA_MAT_FK_MODALIDAD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
