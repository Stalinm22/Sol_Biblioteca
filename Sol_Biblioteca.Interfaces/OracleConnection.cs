namespace Sol_Biblioteca.Interfaces
{
    internal class OracleConnection
    {
        private string connectionString;

        public OracleConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}