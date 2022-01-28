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
        void OnBtnPressed(object sender, EventArgs ea)
        {
            var keyword = MainSearchBar.Text;
            //ListaComidas.ItemsSource = dvm.Comidas.Where(nom => nom.Contains(keyword));
        }
    }
}
