using Dietas_App3.Helpers;
using Dietas_App3.Model;
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
        

        private void Añadirdesayuno(object sender, EventArgs e)
         {

            Desayuno des=  new Desayuno();
            des.comEvents.HandlerAdd += OnAddDesayuno;
            Navigation.PushAsync(des);
        }

        private void Añadircomida(object sender, EventArgs e)
        {
            ComidaView com = new ComidaView();
            com.comEvents.HandlerAdd += OnAddComidas;
            Navigation.PushAsync(com);
            
        }

        private void Añadirmerienda(object sender, EventArgs e)
        {

            Merienda merien = new Merienda();
            merien.comEvents.HandlerAdd += OnAddMerienda;
            Navigation.PushAsync(merien);
        }

        private void Añadircena(object sender, EventArgs e)
        {
            Cena cen = new Cena();
            cen.comEvents.HandlerAdd += OnAddCena;
            Navigation.PushAsync(cen);
        }
        public void OnAddDesayuno(object sender, ComidaEventArgs e)
        {
            hvm.AddDesayuno(e.Comida);
        }
        public void OnAddComidas(object sender, ComidaEventArgs e)
        {
            hvm.AddComidas(e.Comida);
        }
        public void OnAddCena(object sender, ComidaEventArgs e)
        {
            hvm.AddCenas(e.Comida);
        }
        public void OnAddMerienda(object sender, ComidaEventArgs e)
        {
            hvm.AddMerienda(e.Comida);
        }
        public void OnAddAlmuerso(object sender, ComidaEventArgs e)
        {
            hvm.AddAlmuerso(e.Comida);
        }

        private void Añadiralmuerso(object sender, EventArgs e)
        {
            Almuerso al = new Almuerso();
            al.comEvents.HandlerAdd += OnAddAlmuerso;
            Navigation.PushAsync(al);
        }

        private void Delcena(object sender, EventArgs e)
        {
            Comida nomcena = (Comida)((Button)sender).CommandParameter;
            hvm.DelCena(nomcena);
            DisplayAlert("Eliminado", nomcena.Nom, "Acceptar");
        }

        private void Delmerienda(object sender, EventArgs e)
        {
            Comida nommerienda = (Comida)((Button)sender).CommandParameter;
            hvm.DelMerienda(nommerienda);
            DisplayAlert("Eliminado", nommerienda.Nom, "Acceptar");
        }

        private void Delcomida(object sender, EventArgs e)
        {
            Comida nomcomida = (Comida)((Button)sender).CommandParameter;
            hvm.DelComida(nomcomida);
            DisplayAlert("Eliminado", nomcomida.Nom, "Acceptar");
        }

        private void Delalmuerso(object sender, EventArgs e)
        {
            Comida nomalmuerso = (Comida)((Button)sender).CommandParameter;
            hvm.DelAlmuerso(nomalmuerso);
            DisplayAlert("Eliminado", nomalmuerso.Nom, "Acceptar");
        }

        private void Deldesayuno(object sender, EventArgs e)
        {
            Comida nomdesayuno = (Comida)((Button)sender).CommandParameter;
            hvm.DelDesayuno(nomdesayuno);
            DisplayAlert("Eliminado", nomdesayuno.Nom, "Acceptar");
        }
    }
}