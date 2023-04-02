using System.Data;
using SwimmingCompetition.utils;
using log4net;

namespace project.repository
{
    public class UtilsDB
    {
        private IDbConnection? _connection;

        private static readonly ILog logger = LogManager.GetLogger("myLog");

        private readonly IDictionary<string, string> properties;

        public UtilsDB(IDictionary<string, string> properties)
        {
            this.properties = properties;
        }

        public IDbConnection? getConnection()
        {
            logger.Info("Trying to connect to database");
            if (_connection == null || _connection.State == ConnectionState.Closed)
            {
                _connection = getNewConnection();
                _connection.Open();
                logger.Info("Connection successfully established!");
            }

            return _connection;
        }

        private IDbConnection getNewConnection()
        {
            return ConnectionFactory.getInstance()!.createConnection(properties);
        }
    }
}