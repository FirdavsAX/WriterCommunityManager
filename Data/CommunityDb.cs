using System;
using System.Data.Entity;
using System.Linq;
using WriterCommunityManager.Models;

namespace WriterCommunityManager.Data
{
    public class CommunityDb : DbContext
    {
        // Your context has been configured to use a 'CommunityDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WriterCommunityManager.Data.CommunityDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CommunityDb' 
        // connection string in the application configuration file.
        public CommunityDb()
            : base("Data Source=DESKTOP-I4DJQII;Initial Catalog=WritersCommunity;Integrated Security=True;Pooling=False")
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}