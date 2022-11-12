namespace Singleton
{
    public sealed class DbConnection
    {
        private  static DbConnection Connection;

        private DbConnection() { }

        public static DbConnection GetConnnection()
        {
            if (Connection == null)
                Connection = new DbConnection();

            return Connection;
        }
    }
}
