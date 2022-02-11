using Dietas_App3.Helpers;
using Dietas_App3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HipocaloricaView : ContentPage
    {
        private HipocaloricaVM hvm;
        public HipocaloricaView()
        {
            InitializeComponent();
            hvm = new HipocaloricaVM();

            BindingContext = hvm;
        }
        public InformacionEvents<UsuarioEventArgs> events = new InformacionEvents<UsuarioEventArgs>();

        private void Añadirdesayuno(object sender, EventArgs e)
         {
            Navigation.PushAsync(new Desayuno());
        }

        private void Añadircomida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ComidaView());
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