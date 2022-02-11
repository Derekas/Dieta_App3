using Dietas_App3.Model;
using Dietas_App3.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desayuno : ContentPage
    {
        String nom;
        private Comida comseleccionat;
        private DesayunoVM dvm;
        private HipocaloricaVM hvm;
        public Desayuno()
        {
            InitializeComponent();
            dvm = new DesayunoVM();
            hvm = new HipocaloricaVM();
            BindingContext = dvm;
            
        }

        
        void TappedDesayuno(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.categoria.Equals("Desayuno"))
            {
                DisplayAlert("Item Tapped", "Porfavor seleccione un desayuno para añadirlo.", "OK");
            }
            else
            {
                HipocaloricaView v = new HipocaloricaView();

                hvm.AddDesayuno(comseleccionat);

                Navigation.PopAsync();
            }
            

        }
        void OnBtnPressed(object sender, TextChangedEventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = dvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = dvm.Comidas.Where(x => x.Nom.StartsWith(e.NewTextValue));
            }
        }

        private void MainSearchBar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = dvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = dvm.Comidas.Where(x => x.categoria.StartsWith(e.NewTextValue));
            }
        }
        public void OnAddDesayuno(object sender, EventArgs e)
        {
            hvm.AddDesayuno(comseleccionat);
        }
    }
}
