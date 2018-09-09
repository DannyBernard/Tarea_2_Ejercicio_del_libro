using RegistroLibros.Entidades;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros.DAL
{
   class Contexto : DbContext
    {
      public DbSet<Libros> Libro { get; set; }  
        public Contexto() : base("ConStr")
        { }

        
    }
}
