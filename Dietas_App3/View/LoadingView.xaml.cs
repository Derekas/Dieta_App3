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
    public partial class LoadingView : ContentPage
    {
        float maxValue = 1;
        float progressmax = 1;
        bool istimerRunning = true;
        float progress = 0;
        int counter = 1;
        public LoadingView()
        {
            
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                if (progress >= 1)
                {
                    istimerRunning = false;
                    Navigation.PushAsync(new PaginaPrincipal());
                }
                else
                {
                    progress += maxValue / progressmax;
                    Progressbar.ProgressTo(progress, 500, Easing.Linear);
                    
                }
                return istimerRunning;
            });
        }
    }
}