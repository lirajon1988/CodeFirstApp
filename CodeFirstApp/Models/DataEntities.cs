using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models{

    public class DataEntities :DbContext{

        public DbSet<Clientes> Clientes { get; set; }

    }
}