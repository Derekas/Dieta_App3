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
    public partial class TiposDietas : ContentPage
    {
        public TiposDietas()
        {
            InitializeComponent();
        }

        private void IrHipocalorica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HipocaloricaView());
        }

        private void IrMusculo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MusculoView());
        }

        private void IrMantenerse(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MantenerseView());
        }

        private void Atras(object sender, EventArgs e)
        {

        }
    }
}