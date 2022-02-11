using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    
    public class DesayunoVM: NotifyPropertyBase
    {
        
        public ObservableCollection<Comida> Comidas { get; set; }

        
        public DesayunoVM()
        {
            Task<List<Comida>> t = ComidaDAO.GetAllAsync();
            List<Comida> ll = t.Result;
            Comidas = new ObservableCollection<Comida>(t.Result);
            OnPropertyChanged("Comidas");
        }
        
        


    }
}
