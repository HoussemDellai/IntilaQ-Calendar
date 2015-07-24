using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntilaQ.Calendar.Services.Models
{
    public class EventsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EventsContext() : base("name=EventsContext")
        {
            //if (Database.Exists())
            //{
            //    Database.Delete();

            //    Database.CreateIfNotExists();
            //}

            //Database.CreateIfNotExists();

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EventsContext>());
        }

        public DbSet<EventItem> EventItems { get; set; }
    }
}
