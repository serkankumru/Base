namespace DAL
{
    using DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ETicaretDB : DbContext
    {
        // Your context has been configured to use a 'ETicaretDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.ETicaretDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ETicaretDB' 
        // connection string in the application configuration file.

        private static ETicaretDB _instance;

        public static ETicaretDB CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new ETicaretDB();
            }
            return _instance;
        }

        public ETicaretDB()
            : base("name=ETicaretDB")
        {
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        
    }
}
