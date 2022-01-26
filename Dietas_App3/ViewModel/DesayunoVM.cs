using Dietas_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App.ViewModel
{
    
    public class DesayunoVM
    {
        public ObservableCollection<Comida> Comidas { get; set; }

        public DesayunoVM()
        {
            Task<List<Comida>> t = ComidaDAO.GetAllAsync();
            List<Comida> ll = t.Result;
            Comidas = new ObservableCollection<Comida>(t.Result);
        }
        
    }
}
