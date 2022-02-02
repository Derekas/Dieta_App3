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
        private DesayunoVM dvm;
        public Desayuno()
        {
            InitializeComponent();
            dvm = new DesayunoVM();
            BindingContext = dvm;
            
        }

        
        async void TappedDesayuno(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
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
    }
}
