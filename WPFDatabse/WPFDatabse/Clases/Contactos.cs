using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WPFDatabse.Clases
{
    class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Skool { get; set; }
        public string Grupo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Regalo { get; set; }


        public override string ToString()
        {
            return $" {Nombre} - {Skool} - {Grupo} - {Direccion} - {Telefono} - {Regalo}";
        }
    }
}
