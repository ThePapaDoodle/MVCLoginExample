using System;
using Xamarin.Forms;

namespace ViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(2019, 1, 1);
            dtp.MaximumDate = new DateTime(2023, 9, 1);
            dtp.DateSelected += Dtp_DateSelected;

            editor.Completed += Editor_Completed;
            editor.TextChanged += Editor_TextChanged;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elementoSeleccionado = picker.SelectedItem as String;
            DisplayAlert("Elemento Seleccionado", elementoSeleccionado, "Ok");
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Modificado", e.NewTextValue, "Ok");
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Completado", "Finalizado", "Ok");
        }

        private void Dtp_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Fecha Seleccionada", e.NewDate.ToString(), "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje Alerta", "Clic", "Ok");
        }

        private void btnSimular_Clicked(object sender, EventArgs e)
        {
            progress.ProgressTo(0.60, 250, Easing.Linear);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Buscando...", "Resultados...", "Ok");
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Texto Cambio", "Valor Anterior" + e.OldTextValue + "Valor Nuevo" + e.NewTextValue, "Ok");
        }
    }
}
