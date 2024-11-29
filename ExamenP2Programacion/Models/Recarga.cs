using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP2Programacion.Models
{
    public class Recarga
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }

      
        public Recarga(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            Fecha = DateTime.Now;  
        }

        
        public string ToText()
        {
            return $"Recarga realizada por: {Nombre}\nTeléfono: {Telefono}\nFecha: {Fecha}";
        }
    }
}
