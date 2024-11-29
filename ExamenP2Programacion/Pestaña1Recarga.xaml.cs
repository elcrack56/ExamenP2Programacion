using ExamenP2Programacion.Interfaces;
using ExamenP2Programacion.Repository;
using Microsoft.Maui.Controls;

namespace ExamenP2Programacion
{
    public partial class Pestaña1Recarga : ContentPage
    {
        private readonly IRecargaRepository _recargaRepository;

        public Pestaña1Recarga()
        {
            InitializeComponent();
            _recargaRepository = new RecargaRepository();
        }

            private async void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = nombre1.Text;
            string telefono = telefono1.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono))
            {
                await DisplayAlert("Error", "Por favor ingrese nombre y teléfono", "OK");
                return;
            }

        
            await _recargaRepository.GuardarRecargaAsync(nombre, telefono);         
            await DisplayAlert("Éxito", "Recarga realizada con éxito", "OK");
            await CargarUltimaRecarga(nombre);
        }

        private async Task CargarUltimaRecarga(string nombre)
        {
            string ultimaRecarga = await _recargaRepository.ObtenerUltimaRecargaAsync(nombre);
            ultimaRecargaLabel.Text = ultimaRecarga;
        }
    }
}

