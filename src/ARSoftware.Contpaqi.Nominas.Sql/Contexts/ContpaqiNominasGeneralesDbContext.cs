using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Nominas.Sql.Contexts;

public partial class ContpaqiNominasGeneralesDbContext : DbContext
{
    public ContpaqiNominasGeneralesDbContext(DbContextOptions<ContpaqiNominasGeneralesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asc10001> Asc10001 { get; set; }

    public virtual DbSet<Asc10002> Asc10002 { get; set; }

    public virtual DbSet<Asc10003> Asc10003 { get; set; }

    public virtual DbSet<Asc10004> Asc10004 { get; set; }

    public virtual DbSet<CAC10000> CAC10000 { get; set; }

    public virtual DbSet<CAC20000> CAC20000 { get; set; }

    public virtual DbSet<CAC30000> CAC30000 { get; set; }

    public virtual DbSet<CAC40000> CAC40000 { get; set; }

    public virtual DbSet<CAC50000> CAC50000 { get; set; }

    public virtual DbSet<CAC60000> CAC60000 { get; set; }

    public virtual DbSet<CAC70000> CAC70000 { get; set; }

    public virtual DbSet<CAC80000> CAC80000 { get; set; }

    public virtual DbSet<CACIdiom> CACIdiom { get; set; }

    public virtual DbSet<DATAVIEW> DATAVIEW { get; set; }

    public virtual DbSet<DATAVIEW2> DATAVIEW2 { get; set; }

    public virtual DbSet<DDFIELD> DDFIELD { get; set; }

    public virtual DbSet<DDTABLE> DDTABLE { get; set; }

    public virtual DbSet<DiccionarioCatalogos> DiccionarioCatalogos { get; set; }

    public virtual DbSet<DiccionarioDescripciones> DiccionarioDescripciones { get; set; }

    public virtual DbSet<FechaCatalogos> FechaCatalogos { get; set; }

    public virtual DbSet<FechaCatalogosSAT> FechaCatalogosSAT { get; set; }

    public virtual DbSet<IMSSCatTipoSemanaReducida> IMSSCatTipoSemanaReducida { get; set; }

    public virtual DbSet<INFONAVITCatAvisos> INFONAVITCatAvisos { get; set; }

    public virtual DbSet<INFONAVITCatCreditos> INFONAVITCatCreditos { get; set; }

    public virtual DbSet<INFONAVITCatEstatusCredito> INFONAVITCatEstatusCredito { get; set; }

    public virtual DbSet<INFONAVITCatFacDescTipo1> INFONAVITCatFacDescTipo1 { get; set; }

    public virtual DbSet<INFONAVITCatPer> INFONAVITCatPer { get; set; }

    public virtual DbSet<INFONAVITCatSegDanos> INFONAVITCatSegDanos { get; set; }

    public virtual DbSet<INFONAVITCatSmyUmi> INFONAVITCatSmyUmi { get; set; }

    public virtual DbSet<INFONAVITCatTipoDesc> INFONAVITCatTipoDesc { get; set; }

    public virtual DbSet<NOM10000> NOM10000 { get; set; }

    public virtual DbSet<NOM30000> NOM30000 { get; set; }

    public virtual DbSet<Nom20000> Nom20000 { get; set; }

    public virtual DbSet<Nom40000> Nom40000 { get; set; }

    public virtual DbSet<Nom50000> Nom50000 { get; set; }

    public virtual DbSet<Nom60000> Nom60000 { get; set; }

    public virtual DbSet<Nom70000> Nom70000 { get; set; }

    public virtual DbSet<Nom80000> Nom80000 { get; set; }

    public virtual DbSet<Nom90000> Nom90000 { get; set; }

    public virtual DbSet<NomIDX> NomIDX { get; set; }

    public virtual DbSet<NomIdiom> NomIdiom { get; set; }

    public virtual DbSet<RELACION> RELACION { get; set; }

    public virtual DbSet<REPORTS> REPORTS { get; set; }

    public virtual DbSet<SATCatBancos> SATCatBancos { get; set; }

    public virtual DbSet<SATCatEntidadFederativa> SATCatEntidadFederativa { get; set; }

    public virtual DbSet<SATCatFormasPago> SATCatFormasPago { get; set; }

    public virtual DbSet<SATCatMotivoCancelacion> SATCatMotivoCancelacion { get; set; }

    public virtual DbSet<SATCatOrigenRecursos> SATCatOrigenRecursos { get; set; }

    public virtual DbSet<SATCatPeriodicidadPago> SATCatPeriodicidadPago { get; set; }

    public virtual DbSet<SATCatRegimenFiscal> SATCatRegimenFiscal { get; set; }

    public virtual DbSet<SATCatRiesgoPuesto> SATCatRiesgoPuesto { get; set; }

    public virtual DbSet<SATCatTipoContrato> SATCatTipoContrato { get; set; }

    public virtual DbSet<SATCatTipoDeduccion> SATCatTipoDeduccion { get; set; }

    public virtual DbSet<SATCatTipoHoras> SATCatTipoHoras { get; set; }

    public virtual DbSet<SATCatTipoIncapacidad> SATCatTipoIncapacidad { get; set; }

    public virtual DbSet<SATCatTipoJornada> SATCatTipoJornada { get; set; }

    public virtual DbSet<SATCatTipoNomina> SATCatTipoNomina { get; set; }

    public virtual DbSet<SATCatTipoOtrosPagos> SATCatTipoOtrosPagos { get; set; }

    public virtual DbSet<SATCatTipoPercepcion> SATCatTipoPercepcion { get; set; }

    public virtual DbSet<SATCatTipoRegimen> SATCatTipoRegimen { get; set; }

    public virtual DbSet<SATCatUsoCFDI> SATCatUsoCFDI { get; set; }

    public virtual DbSet<VersionDiccionarioCatalogos> VersionDiccionarioCatalogos { get; set; }

    public virtual DbSet<VistaRelacion> VistaRelacion { get; set; }

    public virtual DbSet<VistaTabla> VistaTabla { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Asc10001>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseName, e.TableName });

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemAlias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MainFields)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TableAlias)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asc10002>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseName, e.TableName, e.FieldName });

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FieldAlias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Index)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asc10003>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseName, e.TableName, e.FieldName, e.FieldValue });

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FieldValue)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.UserValue)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asc10004>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseName, e.TableName, e.FieldName });

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LookupField)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LookupTable)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC10000>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.Clave });

            entity.Property(e => e.IdSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC20000>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.Nivel, e.Proceso, e.Adicional });

            entity.Property(e => e.IdSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Proceso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Adicional)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength();
        });

        modelBuilder.Entity<CAC30000>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.Perfil });

            entity.Property(e => e.IdSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC40000>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.IdProceso, e.Identificacion });

            entity.HasIndex(e => new { e.IdSistema, e.Identificacion, e.Mensaje, e.WParam, e.LParam }, "IDMSGIDX");

            entity.HasIndex(e => new { e.IdSistema, e.Grupo }, "SISTEMAGRPIDX");

            entity.Property(e => e.IdSistema)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdProceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC50000>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.Grupo });

            entity.Property(e => e.IdSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Grupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC60000>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Datos)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasColumnType("smalldatetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC70000>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Encabezado)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LookUp)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Reporte)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoCampo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CAC80000>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BaseDatos)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CampoOrigen)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CampoVer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Despliegue)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Indice)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TablaOrigen)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TablaVer)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CACIdiom>(entity =>
        {
            entity.HasKey(e => new { e.NumeroSistema, e.NumeroIdioma });

            entity.Property(e => e.NombreArchivoAyuda)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NombreArchivoBDD)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NombreDLLApp)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreDLLErr)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreIdioma)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DATAVIEW>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClassDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Template).HasColumnType("image");
        });

        modelBuilder.Entity<DATAVIEW2>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClassDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Template).HasColumnType("image");
        });

        modelBuilder.Entity<DDFIELD>(entity =>
        {
            entity.HasKey(e => new { e.databasename, e.tablename, e.fieldname });

            entity.Property(e => e.databasename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.tablename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fieldname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.displayformat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fieldalias)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DDTABLE>(entity =>
        {
            entity.HasKey(e => new { e.databasename, e.tablename });

            entity.Property(e => e.databasename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.tablename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.group)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.tablealias)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DiccionarioCatalogos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampoBD)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CampoImportacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Catalogo)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DiccionarioDescripciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FechaCatalogos>(entity =>
        {
            entity.HasKey(e => e.TipoCatalogos);

            entity.Property(e => e.TipoCatalogos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimaActualizacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FechaCatalogosSAT>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UltimaActualizacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<IMSSCatTipoSemanaReducida>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<INFONAVITCatAvisos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClasificacionAviso)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.TipoAviso)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<INFONAVITCatCreditos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Descuento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<INFONAVITCatEstatusCredito>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.TipoEstatus)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<INFONAVITCatFacDescTipo1>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<INFONAVITCatPer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaFinalBimestre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicialBimestre).HasColumnType("datetime");
            entity.Property(e => e.FechaLimitePago).HasColumnType("datetime");
        });

        modelBuilder.Entity<INFONAVITCatSegDanos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
        });

        modelBuilder.Entity<INFONAVITCatSmyUmi>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.Medida)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<INFONAVITCatTipoDesc>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.TipoDescuento)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NOM10000>(entity =>
        {
            entity.HasKey(e => e.NombreEmpresa).IsClustered(false);

            entity.HasIndex(e => e.IDEmpresa, "IDXIDEMPRESA").IsClustered();

            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.AfectarPeriodosAnteriores)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.AfectarPeriodosFuturos)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ApMaternoRepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ApPaternoRepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ApartadoPostal)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.CURP)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CuentaCWGlobal)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.DatosVigente)
                .IsRequired()
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EstructuraCuentaCW)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaConstitucion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioHistoria).HasColumnType("datetime");
            entity.Property(e => e.FiniquitoDividido)
                .IsRequired()
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.FormatoSobreRecibo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FormatoSobreReciboCFDI)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.GUIDDSL)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.GUIDEmpresa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.GUIDEmpresaOrigen)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Homoclave)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IDEmpresa).ValueGeneratedOnAdd();
            entity.Property(e => e.Localidad)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MascarillaCodigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MostrarAgenda)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.NombreCorto)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpresaFiscal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NombreRepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OrigenRecursos)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RFC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RegistroCamara)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroComisionMixta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroFonacot)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegistroIMSS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegistroInfonavit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegistroSSA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RelacionarCFDI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RutaCheqpaqW)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RutaContpaqW)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RutaEmpresa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RutaRespaldo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TipoCalculoISR).HasDefaultValueSql("((1))");
            entity.Property(e => e.TipoCodigoEmpleado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ZonaSalarioGeneral)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.vConfigComplemento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.vConfigComprobante)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.vUltTimbreComplemento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.vUltTimbreComprobante)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<NOM30000>(entity =>
        {
            entity.HasKey(e => e.NombreFiltro);

            entity.Property(e => e.NombreFiltro)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CamposAgrupar).HasColumnType("text");
            entity.Property(e => e.FiltroModificable).HasColumnType("text");
            entity.Property(e => e.FiltroReal).HasColumnType("text");
            entity.Property(e => e.FiltroUsuario).HasColumnType("text");
            entity.Property(e => e.ListaCampos).HasColumnType("text");
            entity.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nom20000>(entity =>
        {
            entity.HasKey(e => e.IDUsuario);

            entity.Property(e => e.IDUsuario).ValueGeneratedNever();
            entity.Property(e => e.Acceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nom40000>(entity =>
        {
            entity.HasKey(e => e.NumeroTabla);

            entity.HasIndex(e => e.Descripcion, "IDXDESCRIPCION");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Nom50000>(entity =>
        {
            entity.HasKey(e => new { e.NumeroTabla, e.NumeroColumna });

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipoColumna)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nom60000>(entity =>
        {
            entity.HasKey(e => new { e.NumeroTabla, e.NumeroColumna, e.NumeroRenglon });

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Nom70000>(entity =>
        {
            entity.HasKey(e => e.idTabla);

            entity.HasIndex(e => e.FechaVigencia, "IDXFECHAVIGENCIA");

            entity.HasIndex(e => e.Nombre, "IDXNOMBRE");

            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Nom80000>(entity =>
        {
            entity.HasKey(e => e.idDetalleTabla);

            entity.HasIndex(e => e.idTabla, "IDXIDTABLA");

            entity.Property(e => e.DescripcionRango)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Nom90000>(entity =>
        {
            entity.HasIndex(e => e.Id, "IDXID");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<NomIDX>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Columnas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Indice)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tabla)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NomIdiom>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RELACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BaseDatos)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CampoOrigen)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CampoVer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Despliegue)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TablaOrigen)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TablaVer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorVer)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<REPORTS>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DataViewName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Template).HasColumnType("image");
        });

        modelBuilder.Entity<SATCatBancos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveBanco)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatEntidadFederativa>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveEstado)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ClavePais)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatFormasPago>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveFormaPago)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatMotivoCancelacion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveMotivoCancelacion)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatOrigenRecursos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveOrigenRecurso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatPeriodicidadPago>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClavePeriodicidadPago)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatRegimenFiscal>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveRegimenFiscal)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatRiesgoPuesto>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveRiesgo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoContrato>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoContrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoDeduccion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoDeduccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VersionAplica)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoHoras>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoHoras)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoIncapacidad>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoIncapacidad)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoJornada>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoJornada)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoNomina>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoNomina)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoOtrosPagos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveOtrosPagos)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VersionAplica)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoPercepcion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoPercepcion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VersionAplica)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatTipoRegimen>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveTipoRegimen)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SATCatUsoCFDI>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClaveUsoCFDI)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VersionDiccionarioCatalogos>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<VistaRelacion>(entity =>
        {
            entity.Property(e => e.campo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.campodestino)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VistaTabla>(entity =>
        {
            entity.HasKey(e => e.idtabla);

            entity.Property(e => e.alias)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
