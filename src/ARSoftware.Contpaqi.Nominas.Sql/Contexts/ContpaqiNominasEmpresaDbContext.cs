using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Nominas.Sql.Contexts;

public partial class ContpaqiNominasEmpresaDbContext : DbContext
{
    public ContpaqiNominasEmpresaDbContext(DbContextOptions<ContpaqiNominasEmpresaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nom1000x> Nom1000x { get; set; }

    public virtual DbSet<Nom10046> Nom10046 { get; set; }

    public virtual DbSet<VERSION> VERSION { get; set; }

    public virtual DbSet<nom10000> nom10000 { get; set; }

    public virtual DbSet<nom10001> nom10001 { get; set; }

    public virtual DbSet<nom10002> nom10002 { get; set; }

    public virtual DbSet<nom10003> nom10003 { get; set; }

    public virtual DbSet<nom10004> nom10004 { get; set; }

    public virtual DbSet<nom10005> nom10005 { get; set; }

    public virtual DbSet<nom10006> nom10006 { get; set; }

    public virtual DbSet<nom10007> nom10007 { get; set; }

    public virtual DbSet<nom10008> nom10008 { get; set; }

    public virtual DbSet<nom10009> nom10009 { get; set; }

    public virtual DbSet<nom10010> nom10010 { get; set; }

    public virtual DbSet<nom10011> nom10011 { get; set; }

    public virtual DbSet<nom10012> nom10012 { get; set; }

    public virtual DbSet<nom10013> nom10013 { get; set; }

    public virtual DbSet<nom10014> nom10014 { get; set; }

    public virtual DbSet<nom10015> nom10015 { get; set; }

    public virtual DbSet<nom10016> nom10016 { get; set; }

    public virtual DbSet<nom10017> nom10017 { get; set; }

    public virtual DbSet<nom10018> nom10018 { get; set; }

    public virtual DbSet<nom10019> nom10019 { get; set; }

    public virtual DbSet<nom10020> nom10020 { get; set; }

    public virtual DbSet<nom10021> nom10021 { get; set; }

    public virtual DbSet<nom10022> nom10022 { get; set; }

    public virtual DbSet<nom10023> nom10023 { get; set; }

    public virtual DbSet<nom10024> nom10024 { get; set; }

    public virtual DbSet<nom10025> nom10025 { get; set; }

    public virtual DbSet<nom10026> nom10026 { get; set; }

    public virtual DbSet<nom10027> nom10027 { get; set; }

    public virtual DbSet<nom10028> nom10028 { get; set; }

    public virtual DbSet<nom10029> nom10029 { get; set; }

    public virtual DbSet<nom10030> nom10030 { get; set; }

    public virtual DbSet<nom10031> nom10031 { get; set; }

    public virtual DbSet<nom10032> nom10032 { get; set; }

    public virtual DbSet<nom10033> nom10033 { get; set; }

    public virtual DbSet<nom10034> nom10034 { get; set; }

    public virtual DbSet<nom10035> nom10035 { get; set; }

    public virtual DbSet<nom10036> nom10036 { get; set; }

    public virtual DbSet<nom10037> nom10037 { get; set; }

    public virtual DbSet<nom10038> nom10038 { get; set; }

    public virtual DbSet<nom10039> nom10039 { get; set; }

    public virtual DbSet<nom10040> nom10040 { get; set; }

    public virtual DbSet<nom10041> nom10041 { get; set; }

    public virtual DbSet<nom10042> nom10042 { get; set; }

    public virtual DbSet<nom10043> nom10043 { get; set; }

    public virtual DbSet<nom10044> nom10044 { get; set; }

    public virtual DbSet<nom10045> nom10045 { get; set; }

    public virtual DbSet<nom10047> nom10047 { get; set; }

    public virtual DbSet<nom10048> nom10048 { get; set; }

    public virtual DbSet<nom10049> nom10049 { get; set; }

    public virtual DbSet<nom10050> nom10050 { get; set; }

    public virtual DbSet<nom10051> nom10051 { get; set; }

    public virtual DbSet<nom10052> nom10052 { get; set; }

    public virtual DbSet<nom10053> nom10053 { get; set; }

    public virtual DbSet<nom10054> nom10054 { get; set; }

    public virtual DbSet<nom10055> nom10055 { get; set; }

    public virtual DbSet<nom10056> nom10056 { get; set; }

    public virtual DbSet<nom10057> nom10057 { get; set; }

    public virtual DbSet<nom10058> nom10058 { get; set; }

    public virtual DbSet<nom10059> nom10059 { get; set; }

    public virtual DbSet<nom10060> nom10060 { get; set; }

    public virtual DbSet<nom10061> nom10061 { get; set; }

    public virtual DbSet<nom10062> nom10062 { get; set; }

    public virtual DbSet<nom100xx> nom100xx { get; set; }

    public virtual DbSet<nomblobs> nomblobs { get; set; }

    public virtual DbSet<nomdates> nomdates { get; set; }

    public virtual DbSet<nomsimul> nomsimul { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Nom1000x>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.timestam_).HasColumnType("datetime");
            entity.Property(e => e.valorReportado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<Nom10046>(entity =>
        {
            entity.HasKey(e => e.idEmpleado);

            entity.HasIndex(e => new { e.idFiniquito, e.idEmpleado }, "IDXFINIQUITOEMP").IsUnique();

            entity.HasIndex(e => new { e.idFiniquito, e.idPeriodo }, "IDXFINIQUITOPER");

            entity.HasIndex(e => new { e.idFiniquito, e.idPeriodo, e.idEmpleado }, "IDXFINIQUITOPEREMP");

            entity.HasIndex(e => new { e.idPeriodo, e.idEmpleado }, "IDXPERIODOEMP");

            entity.Property(e => e.idEmpleado).HasDefaultValueSql("('')");
            entity.Property(e => e.Calculado)
                .IsRequired()
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ConceptosCalculo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FechaBaja)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.ParametrosGenerales)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.idFiniquito).ValueGeneratedOnAdd();
            entity.Property(e => e.idPeriodo).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<VERSION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.comentario)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.firma)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.versionBDD)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10000>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CURP)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DatosVigente)
                .IsRequired()
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.FiniquitoDividido)
                .IsRequired()
                .HasDefaultValueSql("('1')");
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
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.GUIDEmpresaOrigen)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.NombreEmpresaFiscal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.OrigenRecursos)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RelacionarCFDI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TipoCalculoISR).HasDefaultValueSql("((1))");
            entity.Property(e => e.afectarperiodosanteriores)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.afectarperiodosfuturos)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.apartadopostal)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.apmaternorepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.appaternorepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.cuentacwglobal)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.estructuracuentacw)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.fechaconstitucion).HasColumnType("datetime");
            entity.Property(e => e.fechainiciohistoria).HasColumnType("datetime");
            entity.Property(e => e.formatosobrerecibo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.homoclave)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.localidad)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.mascarillacodigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.mostraragenda)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.nombrecorto)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.nombrerepresentante)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.registrocamara)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.registrocomisionmixta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.registrofonacot)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.registroimss)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.registroinfonavit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.registrossa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.rfc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.rutacheqpaqw)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.rutacontpaqw)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.rutarespaldo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.telefono1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.telefono2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.telefono3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipocodigoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
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
            entity.Property(e => e.zonasalariogeneral)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10001>(entity =>
        {
            entity.HasKey(e => e.idempleado);

            entity.HasIndex(e => e.codigoempleado, "IDXCODIGOEMPLEADO");

            entity.HasIndex(e => new { e.iddepartamento, e.idtipoperiodo }, "IDXDEPTOTIPOPER");

            entity.HasIndex(e => e.iddepartamento, "IDXIDDEPTO");

            entity.HasIndex(e => new { e.iddepartamento, e.codigoempleado }, "IDXIDDEPTOCODIGO");

            entity.HasIndex(e => new { e.idempleado, e.idtipoperiodo }, "IDXIDEMPLEADOTIPOPERIODO");

            entity.HasIndex(e => e.nombrelargo, "IDXNOMBRE");

            entity.HasIndex(e => e.idtipoperiodo, "IDXTIPOPERIODO");

            entity.HasIndex(e => new { e.idtipoperiodo, e.codigoempleado }, "IDXTIPOPERIODOCODIGO");

            entity.HasIndex(e => new { e.idtipoperiodo, e.iddepartamento }, "IDXTIPOPERIODODEPTO");

            entity.Property(e => e.ClabeInterbancaria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EntidadFederativa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFonacot)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Subcontratacion)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.TipoPrestacion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TipoRegimen)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.afectadoextraordinario).HasDefaultValueSql("((0))");
            entity.Property(e => e.apellidomaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.apellidopaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.bancopagoelectronico)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.basecotizacionimss)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.basepago)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.campoextra1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.campoextra2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.campoextra3)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.causabaja)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.cestadoempleadoperiodo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.cfechasueldomixto).HasColumnType("datetime");
            entity.Property(e => e.codigoempleado)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.cuentapagoelectronico)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.curpf)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.curpi)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.estadocivil)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.estadoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.expediente).HasColumnType("text");
            entity.Property(e => e.fechaalta).HasColumnType("datetime");
            entity.Property(e => e.fechabaja).HasColumnType("datetime");
            entity.Property(e => e.fechanacimiento).HasColumnType("datetime");
            entity.Property(e => e.fechareingreso).HasColumnType("datetime");
            entity.Property(e => e.fechasueldodiario).HasColumnType("datetime");
            entity.Property(e => e.fechasueldointegrado).HasColumnType("datetime");
            entity.Property(e => e.fechasueldopromedio).HasColumnType("datetime");
            entity.Property(e => e.fechasueldovariable).HasColumnType("datetime");
            entity.Property(e => e.formapago)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.fotografia).HasColumnType("image");
            entity.Property(e => e.homoclave)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.lugarnacimiento)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.nombrelargo)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.nombremadre)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.nombrepadre)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.numeroafore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.numerosegurosocial)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.poblacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.rfc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.sexo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sucursalpagoelectronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipocontrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.tipoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.zonasalario)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10002>(entity =>
        {
            entity.HasKey(e => e.idperiodo);

            entity.HasIndex(e => new { e.idtipoperiodo, e.ejercicio }, "IDXIDEJERCICIO");

            entity.HasIndex(e => new { e.idtipoperiodo, e.ejercicio, e.mes }, "IDXIDEJERCICIOMES");

            entity.HasIndex(e => new { e.idtipoperiodo, e.ejercicio, e.numeroperiodo }, "IDXIDEJERCICIONUMERO");

            entity.HasIndex(e => new { e.idtipoperiodo, e.fechafin }, "IDXIDFECHAFIN");

            entity.HasIndex(e => new { e.idtipoperiodo, e.fechainicio }, "IDXIDFECHAINICIO");

            entity.HasIndex(e => new { e.idtipoperiodo, e.fechainicio, e.fechafin }, "IDXIDFECHAS");

            entity.HasIndex(e => new { e.idtipoperiodo, e.mes, e.ejercicio }, "IDXIDMESEJERCICIO");

            entity.HasIndex(e => new { e.idperiodo, e.numeroperiodo }, "IDXIDNUMERO");

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => e.numeroperiodo, "IDXNUMEROPERIODO");

            entity.Property(e => e.fechaPago)
                .HasDefaultValueSql("('18991230')")
                .HasColumnType("datetime");
            entity.Property(e => e.fechafin).HasColumnType("datetime");
            entity.Property(e => e.fechainicio).HasColumnType("datetime");
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10003>(entity =>
        {
            entity.HasKey(e => e.iddepartamento);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.numerodepartamento, "IDXNUMERODEPARTAMENTO");

            entity.Property(e => e.beneficiario)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.csegmentonegocio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10004>(entity =>
        {
            entity.HasKey(e => e.idconcepto);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => new { e.numeroconcepto, e.tipoconcepto }, "IDXNUMEROCONCEPTO");

            entity.HasIndex(e => e.tipoconcepto, "IDXTIPOCONCEPTO");

            entity.Property(e => e.ClaveAgrupadoraSAT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CuentaExentoDeduc)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.CuentaExentoNoDeduc)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.CuentaGravado)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.FormulaValor).HasColumnType("text");
            entity.Property(e => e.MetodoDePago)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TipoClaveSAT)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TipoHoras)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.contabcontracuentacw)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.contabcuentacw)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.contracuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.formulaimporte1).HasColumnType("text");
            entity.Property(e => e.formulaimporte2).HasColumnType("text");
            entity.Property(e => e.formulaimporte3).HasColumnType("text");
            entity.Property(e => e.formulaimporte4).HasColumnType("text");
            entity.Property(e => e.formulaimportetotal).HasColumnType("text");
            entity.Property(e => e.leyendaimporte1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.leyendaimporte2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.leyendaimporte3)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.leyendaimporte4)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.leyendavalor)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipoconcepto)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.tipomovtocw)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10005>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.idconcepto });

            entity.HasIndex(e => e.idempleado, "IDXIDEMPLEADO");
        });

        modelBuilder.Entity<nom10006>(entity =>
        {
            entity.HasKey(e => e.idpuesto);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.numeropuesto, "IDXNUMEROPUESTO");

            entity.Property(e => e.Detalle)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10007>(entity =>
        {
            entity.HasKey(e => e.idmovtopdo);

            entity.HasIndex(e => new { e.idconcepto, e.idperiodo, e.idempleado }, "IDXCONPEREMP");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idconcepto }, "IDXEMPLEADOPERIODO").IsUnique();

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => new { e.idperiodo, e.idconcepto }, "IDXPERIODOCONCEPTO");

            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.valorReportado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<nom10008>(entity =>
        {
            entity.HasKey(e => e.idmovtopdo);

            entity.HasIndex(e => new { e.idconcepto, e.idperiodo, e.idempleado }, "IDXCONPEREMP");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idconcepto }, "IDXEMPLEADOPERIODO").IsUnique();

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => new { e.idperiodo, e.idconcepto }, "IDXPERIODOCONCEPTO");

            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.valorReportado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<nom10009>(entity =>
        {
            entity.HasKey(e => e.idmovtodyh);

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADOFECHA");

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADOFECHADESC").IsDescending();

            entity.HasIndex(e => new { e.idperiodo, e.idempleado }, "IDXEMPLEADOPERIODO");

            entity.HasIndex(e => new { e.idperiodo, e.fecha }, "IDXIDFECHA");

            entity.HasIndex(e => e.idmovtodyh, "IDXIDMOVTODYH").IsUnique();

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => e.idtarjetaincapacidad, "IDXIDTARJETAINCAPACIDAD");

            entity.HasIndex(e => e.idtcontrolvacaciones, "IDXIDTCONTROLVACACIONES");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idtipoincidencia }, "IDXPEREMPINC");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idtipoincidencia, e.fecha }, "IDXPEREMPINCFEC");

            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10010>(entity =>
        {
            entity.HasKey(e => e.idmovtodyh);

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADOFECHA");

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADOFECHADESC").IsDescending();

            entity.HasIndex(e => new { e.idperiodo, e.idempleado }, "IDXEMPLEADOPERIODO");

            entity.HasIndex(e => new { e.idperiodo, e.fecha }, "IDXIDFECHA");

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => e.idtarjetaincapacidad, "IDXIDTARJETAINCAPACIDAD");

            entity.HasIndex(e => e.idtcontrolvacaciones, "IDXIDTCONTROLVACACIONES");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idtipoincidencia }, "IDXPEREMPINC");

            entity.HasIndex(e => new { e.idperiodo, e.idempleado, e.idtipoincidencia, e.fecha }, "IDXPEREMPINCFEC");

            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10011>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.idtipoacumulado, e.ejercicio });

            entity.HasIndex(e => e.ejercicio, "IDXEJERCICIO");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.ejercicio }, "IDXEMPLEADOEJERCICIO");
        });

        modelBuilder.Entity<nom10012>(entity =>
        {
            entity.HasKey(e => new { e.idconcepto, e.idtipoacumulado, e.tipo });

            entity.HasIndex(e => e.idconcepto, "IDXIDCONCEPTO");

            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10013>(entity =>
        {
            entity.HasKey(e => new { e.idtipoincidencia, e.idtipoacumulado });
        });

        modelBuilder.Entity<nom10014>(entity =>
        {
            entity.HasKey(e => e.idtcontrolvacaciones);

            entity.HasIndex(e => new { e.ejercicio, e.idempleado }, "IDXEJERCICIOEMPLEADO");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.fechainicio }, "IDXEMPLEADOFECHAINICIO");

            entity.HasIndex(e => e.fechainicio, "IDXFECHAINICIO");

            entity.Property(e => e.diasdescanso)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.fechafin).HasColumnType("datetime");
            entity.Property(e => e.fechainicio).HasColumnType("datetime");
            entity.Property(e => e.fechapago).HasColumnType("datetime");
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10015>(entity =>
        {
            entity.HasKey(e => e.idpoliza);

            entity.Property(e => e.GUIDPoliza)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.concepto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.diario)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.estadocontab)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.fechapoliza).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10016>(entity =>
        {
            entity.HasKey(e => e.idmovtopoliza);

            entity.HasIndex(e => e.idpoliza, "IDXPOLIZA");

            entity.HasIndex(e => new { e.idpoliza, e.cuentacw, e.tipomovto }, "IDXPOLIZACUENTATIPO");

            entity.HasIndex(e => new { e.idpoliza, e.numeromovto }, "IDXPOLIZAMOVTO");

            entity.Property(e => e.GUIDMovtoPoliza)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.concepto)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.csegmentonegocio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.diario)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.tipomovto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<nom10017>(entity =>
        {
            entity.HasKey(e => e.idmovtopermanente);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.descripcion }, "IDXEMPLEADODESCRIPCION");

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.fechainiciotarjeta).HasColumnType("datetime");
            entity.Property(e => e.fecharegistro).HasColumnType("datetime");
            entity.Property(e => e.numerocontrol)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<nom10018>(entity =>
        {
            entity.HasKey(e => e.idtarjetaincapacidad);

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.folio }, "IDXEMPLEADOFOLIO");

            entity.HasIndex(e => new { e.idempleado, e.numerocaso }, "IDXEMPLEADONUMEROCASO");

            entity.HasIndex(e => e.folio, "IDXFOLIO");

            entity.Property(e => e.circunstancia)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.controlincapacidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.fechainicio).HasColumnType("datetime");
            entity.Property(e => e.folio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.incapacidadinicial)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.matriculamedico)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.nombremedico)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ramoseguro)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.secuelaconsecuencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tiporiesgo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10019>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.fecha, e.tiposueldo });

            entity.HasIndex(e => new { e.idempleado, e.fecha, e.tiposueldo }, "IDXEMPLEADOFECHA").IsDescending();

            entity.HasIndex(e => new { e.idempleado, e.tiposueldo }, "IDXEMPLEADOTIPO");

            entity.HasIndex(e => new { e.idempleado, e.cidtipoperiodo }, "IDXEMPLEADOTIPOPERIODO");

            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.tiposueldo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<nom10020>(entity =>
        {
            entity.HasKey(e => e.idbajareingreso);

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.fecha }, "IDXEMPLEADOFECHA").IsDescending();

            entity.HasIndex(e => new { e.idempleado, e.fecha, e.cidtipoperiodo }, "IDXEMPLEADOFECHATIPOPER");

            entity.HasIndex(e => new { e.fecha, e.clavebajareingreso, e.idempleado }, "IDXPRIMARYKEY").IsDescending();

            entity.Property(e => e.clavebajareingreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10021>(entity =>
        {
            entity.HasKey(e => new { e.idtipoacumulado, e.nombre, e.tipomovtoacumulado });

            entity.HasIndex(e => e.nombre, "IDXNOMBRE");

            entity.Property(e => e.idtipoacumulado).ValueGeneratedOnAdd();
            entity.Property(e => e.nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.tipomovtoacumulado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10022>(entity =>
        {
            entity.HasKey(e => e.idtipoincidencia);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.mnemonico, "IDXMNEMONICO");

            entity.HasIndex(e => e.tipoincidencia, "IDXTIPOINCIDENCIA");

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.mnemonico)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipoimss)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.tipoincidencia)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10023>(entity =>
        {
            entity.HasKey(e => e.idtipoperiodo);

            entity.HasIndex(e => e.diasdelperiodo, "IDXDIASDELPERIODO");

            entity.HasIndex(e => e.idtipoperiodo, "IDXIDTIPOPERIODO");

            entity.HasIndex(e => e.nombretipoperiodo, "IDXNOMBRETIPOPERIODO");

            entity.Property(e => e.PeriodicidadPago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.fechainicioejercicio).HasColumnType("datetime");
            entity.Property(e => e.nombretipoperiodo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.posicionseptimos)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10024>(entity =>
        {
            entity.HasKey(e => e.iddispfiscal);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.fechainicio, "IDXFECHAINICIO");

            entity.HasIndex(e => new { e.fechainicio, e.frecuencia }, "IDXFFRECUENCIA");

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.fechainicio)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.frecuencia)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ruta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10025>(entity =>
        {
            entity.HasKey(e => new { e.idperiodo, e.fecha });

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.Property(e => e.fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10026>(entity =>
        {
            entity.HasKey(e => new { e.mes, e.dia });

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10027>(entity =>
        {
            entity.HasKey(e => e.numerotabla);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10028>(entity =>
        {
            entity.HasKey(e => new { e.numerotabla, e.numerocolumna });

            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.tipocolumna)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10029>(entity =>
        {
            entity.HasKey(e => new { e.numerotabla, e.numerocolumna, e.numerorenglon });

            entity.Property(e => e.fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10030>(entity =>
        {
            entity.HasKey(e => e.idcategoria);

            entity.HasIndex(e => e.posicion, "IDXPOSICION");

            entity.Property(e => e.grupo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10031>(entity =>
        {
            entity.HasKey(e => e.idformula);

            entity.HasIndex(e => new { e.idcategoria, e.posicion }, "IDXCATEGORIAPOSICION");

            entity.HasIndex(e => e.nombre, "IDXNOMBRE");

            entity.HasIndex(e => e.posicion, "IDXPOSICION");

            entity.Property(e => e.ayuda).HasColumnType("text");
            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.expresion).HasColumnType("text");
            entity.Property(e => e.nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10032>(entity =>
        {
            entity.HasKey(e => e.idturno);

            entity.HasIndex(e => e.descripcion, "IDXDESCRIPCION");

            entity.HasIndex(e => e.numeroturno, "IDXNUMEROTURNO");

            entity.Property(e => e.TipoJornada)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10033>(entity =>
        {
            entity.HasKey(e => e.idmodelo);

            entity.Property(e => e.archivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10034>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.idtipoperiodo, e.cidperiodo });

            entity.HasIndex(e => new { e.iddepartamento, e.idempleado, e.cfechacorte }, "IDXIDDEPTOEMPLEADOFECHA");

            entity.HasIndex(e => new { e.idempleado, e.cfechacorte }, "IDXIDEMPLEADOFECHA");

            entity.HasIndex(e => new { e.cidperiodo, e.idempleado }, "IDXIDPERIODOEMPLEADO");

            entity.Property(e => e.ClabeInterbancaria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TipoPrestacion).HasDefaultValueSql("((1))");
            entity.Property(e => e.afectado).HasDefaultValueSql("((0))");
            entity.Property(e => e.afectadoextraordinario).HasDefaultValueSql("((0))");
            entity.Property(e => e.bancopagoelectronico)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.basecotizacionimss)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.basepago)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.campoextra1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.campoextra2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.campoextra3)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.causabaja)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.cestadoempleadoperiodo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.cfechacorte).HasColumnType("datetime");
            entity.Property(e => e.cfechasueldomixto).HasColumnType("datetime");
            entity.Property(e => e.codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.cuentapagoelectronico)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.estadocivil)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.estadoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.fechaalta).HasColumnType("datetime");
            entity.Property(e => e.fechabaja).HasColumnType("datetime");
            entity.Property(e => e.fechareingreso).HasColumnType("datetime");
            entity.Property(e => e.fechasueldodiario).HasColumnType("datetime");
            entity.Property(e => e.fechasueldointegrado).HasColumnType("datetime");
            entity.Property(e => e.fechasueldopromedio).HasColumnType("datetime");
            entity.Property(e => e.fechasueldovariable).HasColumnType("datetime");
            entity.Property(e => e.formapago)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.numeroafore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.poblacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.sucursalpagoelectronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipocontrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.tipoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.zonasalario)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10035>(entity =>
        {
            entity.HasKey(e => e.cidregistropatronal);

            entity.HasIndex(e => e.cregistroimss, "IDXREGISTROIMSS");

            entity.HasIndex(e => e.crfccompleto, "IDXRFCCOMPLETO");

            entity.Property(e => e.ClaseRiesgoTrabajo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.EntidadFederativa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FraccionRiesgoTrabajo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GUIDFirmaDSL)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LocalidadRegPatronal)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.cfechaconstitucion).HasColumnType("datetime");
            entity.Property(e => e.chomoclave)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.cregistroimss)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.crfc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.crfccompleto)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ctimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10036>(entity =>
        {
            entity.Property(e => e.activa).HasDefaultValueSql("((1))");
            entity.Property(e => e.nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.sentenciaSQL).HasColumnType("text");
        });

        modelBuilder.Entity<nom10037>(entity =>
        {
            entity.HasKey(e => new { e.iddim, e.idconcepto });
        });

        modelBuilder.Entity<nom10038>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.ejercicio });
        });

        modelBuilder.Entity<nom10039>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpleado, e.Ejercicio });

            entity.HasIndex(e => e.Ejercicio, "IDXEJERCICIO");

            entity.HasIndex(e => new { e.Ejercicio, e.IdEmpleado }, "IDXEJERCICIOEMPLEADO").IsUnique();

            entity.HasIndex(e => e.IdEmpleado, "IDXEMPLEADO");

            entity.Property(e => e.ClaveABR)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaABR).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10040>(entity =>
        {
            entity.HasKey(e => e.IdTarjetaCredito);

            entity.HasIndex(e => e.IdConcepto, "IDXCONCEPTO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdConcepto, e.NumeroControl, e.Estado }, "IDXEMPCONNUMEDO");

            entity.HasIndex(e => e.IdEmpleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdConcepto }, "IDXEMPLEADOCONCEPTO");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.NumeroControl)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10041>(entity =>
        {
            entity.HasKey(e => e.IdMovtoCredito);

            entity.HasIndex(e => e.IdEmpleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo }, "IDXEMPLEADOPERIODO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdTarjetaCredito }, "IDXEMPLEADOTARJETA");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo, e.IdConcepto }, "IDXEMPPERCON");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo, e.IdConcepto, e.IdTarjetaCredito }, "IDXEMPPERCONTAR").IsUnique();

            entity.HasIndex(e => e.IdPeriodo, "IDXPERIODO");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10042>(entity =>
        {
            entity.HasKey(e => e.IdMovtoCredito);

            entity.HasIndex(e => e.IdEmpleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo }, "IDXEMPLEADOPERIODO");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdTarjetaCredito }, "IDXEMPLEADOTARJETA");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo, e.IdConcepto }, "IDXEMPPERCON");

            entity.HasIndex(e => new { e.IdEmpleado, e.IdPeriodo, e.IdConcepto, e.IdTarjetaCredito }, "IDXEMPPERCONTAR").IsUnique();

            entity.HasIndex(e => e.IdPeriodo, "IDXPERIODO");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10043>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("PK_NOM10043");

            entity.HasIndex(e => new { e.IdEmpleado, e.FechaEmision }, "IDXEMPFE");

            entity.HasIndex(e => new { e.IdEmpleado, e.FechaPago }, "IDXEMPFP");

            entity.HasIndex(e => e.GUIDDocumento, "IDXGUIDDOC");

            entity.HasIndex(e => new { e.IdPeriodo, e.IdEmpleado, e.FechaEmision }, "IDXPEREMPFE");

            entity.HasIndex(e => new { e.IdPeriodo, e.IdEmpleado, e.FechaPago }, "IDXPEREMPFP");

            entity.Property(e => e.Confirmacion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalPago).HasColumnType("datetime");
            entity.Property(e => e.FechaInicialPago).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioRelLaboral).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.GUIDDocumento)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.GUIDDocumentoDSL)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HayRelacionCFDICancelado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumAnosServicio).HasDefaultValueSql("((0))");
            entity.Property(e => e.RelacionarCFDICancelado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.URLCaptcha)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.UUID)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.vComplemento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.vComprobante)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<nom10044>(entity =>
        {
            entity.HasKey(e => e.idmovtopdo).HasName("PK_NOM10044");

            entity.HasIndex(e => new { e.idconcepto, e.idperiodo, e.idempleado, e.idDocumento }, "IDXCONPEREMP");

            entity.HasIndex(e => e.idempleado, "IDXEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.idperiodo, e.idconcepto, e.idDocumento }, "IDXEMPLEADOPERIODO").IsUnique();

            entity.HasIndex(e => e.idDocumento, "IDXIDDOCUMENTO");

            entity.HasIndex(e => e.idperiodo, "IDXIDPERIODO");

            entity.HasIndex(e => new { e.idperiodo, e.idconcepto, e.idDocumento }, "IDXPERIODOCONCEPTO");

            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.valorReportado)
                .IsRequired()
                .HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<nom10045>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_NOM10045");

            entity.HasIndex(e => e.Tipo, "IDXTIPO");

            entity.HasIndex(e => new { e.Tipo, e.GUIDRef }, "IDXTIPOGUIDREF");

            entity.HasIndex(e => new { e.Tipo, e.UUID }, "IDXTIPOUUID");

            entity.Property(e => e.GUIDRef)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UUID)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10047>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IDConcepto, e.Porcentaje }, "IDXCONCEPTOPORCENTAJE").IsUnique();

            entity.Property(e => e.Porcentaje).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<nom10048>(entity =>
        {
            entity.HasKey(e => e.IDContratante);

            entity.HasIndex(e => new { e.IDContratante, e.RFC }, "IDXIDCONTRATANTERFC").IsUnique();

            entity.HasIndex(e => e.RFC, "IX_nom10048").IsUnique();

            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10049>(entity =>
        {
            entity.HasKey(e => e.IDRelacion);

            entity.HasIndex(e => new { e.IDEmpleado, e.IDContratante }, "IDXEMPLEADOCONTRATANTE");
        });

        modelBuilder.Entity<nom10050>(entity =>
        {
            entity.HasKey(e => e.IDTabla);

            entity.HasIndex(e => e.Nombre, "IDXNOMBRETABLA").IsUnique();

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10051>(entity =>
        {
            entity.HasKey(e => new { e.IDTablaPrestacion, e.Antiguedad });

            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10052>(entity =>
        {
            entity.HasKey(e => e.IdCambioTipoPer).HasName("IDXIDCAMBIOTIPOPER");

            entity.HasIndex(e => e.IdEmpleado, "IDXIDEMPLEADO");

            entity.HasIndex(e => new { e.IdTipoPeriodo, e.FechaInicioAplicacion, e.FechaFinAplicacion }, "IDXIDTIPOPERFECHASAPLICACION");

            entity.Property(e => e.FechaFinAplicacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioAplicacion).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10053>(entity =>
        {
            entity.HasKey(e => new { e.idempleado, e.cidperiodo }).HasName("IDXIDEMPLEADOPERIODO");

            entity.Property(e => e.timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10054>(entity =>
        {
            entity.HasKey(e => e.IdAviso).HasName("IDXIDAVISO");

            entity.Property(e => e.CURPTrabajador)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.EstatusCredito)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreaAviso).HasColumnType("datetime");
            entity.Property(e => e.FechaNotLinea).HasColumnType("datetime");
            entity.Property(e => e.FechaOtorgamiento).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimoAviso).HasColumnType("datetime");
            entity.Property(e => e.FolioAviso)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.NRP)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.NSS)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.NSSUnificado)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.NumCredito)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RFCTrabajador)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TipoAviso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TipoDescuento)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10055>(entity =>
        {
            entity.HasKey(e => e.IdModificacion).HasName("IDXIDMODIFICACION");

            entity.HasIndex(e => e.TipoModificacion, "IDXTIPOMODIFICACION");

            entity.Property(e => e.FechaEntradaEnVigor).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10056>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.IdAviso, "IDXAVISO");

            entity.HasIndex(e => e.IdModificacion, "IDXMODIFICACION");

            entity.HasIndex(e => e.IdMovtoPermanente, "IDXMOVTOPERMANENTE");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10057>(entity =>
        {
            entity.HasKey(e => e.IdAusentismoAjust).HasName("IDXIDAUSENTISMOAJUST");

            entity.HasIndex(e => e.IdEmpleado, "IDXIDEMPLEADO");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom10058>(entity =>
        {
            entity.HasKey(e => e.IdCertificado).HasName("IDXCERTIFICADO");

            entity.Property(e => e.NPIE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TipoCertificado)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10059>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Archivo).HasColumnType("image");
            entity.Property(e => e.IdLote)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10060>(entity =>
        {
            entity.HasKey(e => e.IdEnvio).HasName("IDXIDENVIO");

            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.IdLote)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.IdTransaccion)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10061>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.IdEnvio }).HasName("IDMOVIMIENTOENVIO");

            entity.HasIndex(e => e.Fecha, "IDXFECHA");

            entity.HasIndex(e => e.TipoMov, "IDXTIPOMOV");

            entity.Property(e => e.IdMovimiento).ValueGeneratedOnAdd();
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CURP)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.CausaBaja)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Error)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NRP)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.NSS)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TipoBasecotizacion)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoError)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoMov)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nom10062>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("IDXIDUSUARIO");

            entity.HasIndex(e => e.Identificador, "IDXIDENTIFICADOR");

            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Identificador)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<nom100xx>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClabeInterbancaria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TipoPrestacion).HasDefaultValueSql("((1))");
            entity.Property(e => e.bancopagoelectronico)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.basecotizacionimss)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.basepago)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.campoextra1)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.campoextra2)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.campoextra3)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.causabaja)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.cestadoempleadoperiodo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.cfechacorte).HasColumnType("datetime");
            entity.Property(e => e.cfechasueldomixto).HasColumnType("datetime");
            entity.Property(e => e.codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.cuentacw)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.cuentapagoelectronico)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.estadocivil)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.estadoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.fechaalta).HasColumnType("datetime");
            entity.Property(e => e.fechabaja).HasColumnType("datetime");
            entity.Property(e => e.fechareingreso).HasColumnType("datetime");
            entity.Property(e => e.fechasueldodiario).HasColumnType("datetime");
            entity.Property(e => e.fechasueldointegrado).HasColumnType("datetime");
            entity.Property(e => e.fechasueldopromedio).HasColumnType("datetime");
            entity.Property(e => e.fechasueldovariable).HasColumnType("datetime");
            entity.Property(e => e.formapago)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.numeroafore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.poblacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.sucursalpagoelectronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.timestamp).HasColumnType("datetime");
            entity.Property(e => e.tipocontrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.tipoempleado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.zonasalario)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nomblobs>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.codigoempleado, "IDXCODIGOEMPLEADO").IsUnique();

            entity.Property(e => e.codigoempleado)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.username)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nomdates>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.date).HasColumnType("datetime");
            entity.Property(e => e.table)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<nomsimul>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.idempleado, "IDXIDEMPLEADO");

            entity.HasIndex(e => new { e.idempleado, e.ids, e.tipo }, "IDXIDEMPLEADOIDSTIPO");

            entity.Property(e => e.consecutivo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.expresion).HasColumnType("text");
            entity.Property(e => e.idresultado).ValueGeneratedOnAdd();
            entity.Property(e => e.ids)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.nombre)
                .HasMaxLength(110)
                .IsUnicode(false);
            entity.Property(e => e.tipo)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
