using System.IO;
using System.Threading.Tasks;
using ExamenP2Programacion.Interfaces;
using ExamenP2Programacion.Models;
using Microsoft.Maui.Storage;

namespace ExamenP2Programacion.Repository
{
    public class RecargaRepository : IRecargaRepository
    {
        private readonly string _directorioRecargas;

        public RecargaRepository()
        {
            _directorioRecargas = FileSystem.AppDataDirectory;
        }

        
        public async Task GuardarRecargaAsync(string nombre, string telefono)
        {
           
            var recarga = new Recarga(nombre, telefono);
            string archivoRecarga = Path.Combine(_directorioRecargas, $"{nombre}.txt");
            await File.WriteAllTextAsync(archivoRecarga, recarga.ToText());
        }

        
        public async Task<string> ObtenerUltimaRecargaAsync(string nombre)
        {
            string archivoRecarga = Path.Combine(_directorioRecargas, $"{nombre}.txt");

            if (File.Exists(archivoRecarga))
            {
                return await File.ReadAllTextAsync(archivoRecarga);
            }
            else
            {
                return "No se ha realizado ninguna recarga aún.";
            }
        }
    }
}
