using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema_De_Prestamos.Data
{
    public class Sistema_De_PrestamosContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Sistema_De_PrestamosContext() : base("name=Sistema_De_PrestamosContext")
        {
        }

        public System.Data.Entity.DbSet<Sistema_De_Prestamos.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Sistema_De_Prestamos.Models.Prestamos> Prestamos { get; set; }
    }
}
