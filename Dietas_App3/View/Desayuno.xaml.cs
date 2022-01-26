using Dietas_App.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desayuno : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        private DesayunoVM dvm;
        public Desayuno()
        {
            InitializeComponent();
            dvm = new DesayunoVM();
            BindingContext = dvm;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
        private void TappedDesayuno(object sender, ItemTappedEventArgs e)
        {
            
        }
    }
}
