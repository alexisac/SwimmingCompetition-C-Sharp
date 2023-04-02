using System.Data;
using System.Data.SQLite;

namespace SwimmingCompetition.utils
{
    public class SqliteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection(IDictionary<string, string> properties)
        {
            string relativePath = properties["FilenameDB"];
            string connectionString = getConnectionString(relativePath);
            return new SQLiteConnection(connectionString);
        }
        
        private string getConnectionString(string relativePath)
        {
            string? currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = Path.Combine(currentPath!, relativePath);
            absolutePath = absolutePath.Remove(0, 6);
            return $"Data Source={absolutePath}";
        }
    }
}