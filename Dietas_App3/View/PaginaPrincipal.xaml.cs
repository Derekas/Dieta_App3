using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        string pickeractividad;
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void IrTipos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TiposDietas());
        }

        private void picker(object sender, EventArgs e)
        {
            pickeractividad = Actividad.SelectedItem as String;
        }
        void SexoRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }

        private void OnSliderValueChangedPeso(object sender, ValueChangedEventArgs e)
        {
           
            double value = e.NewValue;
            
            displayLabel.Text = MainSlider.Value.ToString()+ " kg";
            
        }

        private void OnSliderValueChangedAltura(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;

            altura.Text = AlturaSlider.Value.ToString()+" cm";
        }
    }
}