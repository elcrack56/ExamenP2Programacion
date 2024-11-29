using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP2Programacion.Interfaces
{
    public interface IRecargaRepository
    {
        Task GuardarRecargaAsync(string nombre, string telefono);
        Task<string> ObtenerUltimaRecargaAsync(string nombre);
    }
}

