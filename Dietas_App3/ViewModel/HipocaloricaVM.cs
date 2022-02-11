using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dietas_App3.ViewModel
{
    public class HipocaloricaVM: NotifyPropertyBase
    {
        public Comida Comida { get; set; }
        public ObservableCollection<Comida> Desayunos { get; set; }
       
        public HipocaloricaVM()
        {
            Desayunos = new ObservableCollection<Comida>();
        }
        internal void AddDesayuno(Comida comidaseleccionada)
        {
            

            Boolean encontrado = false;
            foreach (Comida element in Desayunos)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Desayunos.Add(comidaseleccionada);
            OnPropertyChanged("Desayunos");
        }

    }
}
