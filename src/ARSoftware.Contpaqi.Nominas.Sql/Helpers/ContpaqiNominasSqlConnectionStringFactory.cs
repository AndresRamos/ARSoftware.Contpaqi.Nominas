using Microsoft.Data.SqlClient;

namespace ARSoftware.Contpaqi.Nominas.Sql.Helpers;

public static class ContpaqiNominasSqlConnectionStringFactory
{
    public const string ContpaqiNominasGeneralesDabaseName = "nomGenerales";

    public static string CreateContpaqiNominasGeneralesConnectionString(string connectionString)
    {
        var sqlConnectionStringBuilder =
            new SqlConnectionStringBuilder(connectionString) { InitialCatalog = ContpaqiNominasGeneralesDabaseName };
        return sqlConnectionStringBuilder.ToString();
    }

    public static string CreateContpaqiNominasEmpresaConnectionString(string contpaqiConnectionString, string empresaDatabaseName)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = empresaDatabaseName };
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
