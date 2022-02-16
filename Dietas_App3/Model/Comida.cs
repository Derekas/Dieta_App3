using Dietas_App3.Utils;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Comida")]
    public class Comida : NotifyPropertyBase
    {
        [PrimaryKey]
        public int id { get; set; }
        private String _nom;
        public String Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                OnPropertyChanged();
            }
        }

        public String cantidad { get; set; }
        public double calorias { get; set; }
        public double hidratos { get; set; }
        public double proteina { get; set; }
        public double grasas { get; set; }

        public int diaSemana { get; set; }
        [ManyToMany(typeof(DietasComidas))]
        public List<Dieta> dietas { get; set; }

        public String categoria { get; set; }
        [Ignore]
        public ObservableCollection<Comida> Desayuno { get; set; }

    }

}
