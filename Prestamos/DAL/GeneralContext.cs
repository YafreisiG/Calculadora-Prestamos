using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Prestamos.Models;

namespace Prestamos.DAL
{
    public class GeneralContext : DbContext
    {
        public  GeneralContext(): base("conexion") {  }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

    }
}