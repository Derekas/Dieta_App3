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
    public partial class HipocaloricaView : ContentPage
    {
        public HipocaloricaView()
        {
            InitializeComponent();
        }

        private void Añadirdesayuno(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Desayuno());
        }

        private void Añadircomida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Comida());
        }

        private void Añadirmerienda(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Merienda());
        }

        private void Añadircena(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cena());
        }
    }
}