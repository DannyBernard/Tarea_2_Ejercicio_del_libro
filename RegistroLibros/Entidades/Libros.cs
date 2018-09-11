using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros.Entidades
{
    public class Libros
    {
        [key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descricion { get; set; }
        public string Siglas { get; set; }
        public string Tipo { get; set; }


        public Libros()
        {
            Id = 0;
            Nombre = string.Empty;
            Descricion = string.Empty;
            Siglas = string.Empty;
            Tipo = string.Empty;


        }
    }
}
