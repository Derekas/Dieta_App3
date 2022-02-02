using Dietas_App3.Utils;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Comida")]
    public class Comida: NotifyPropertyBase
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
        public int calorias { get; set; }
        public int hidratos { get; set; }
        public int proteina { get; set; }
        public int grasas { get; set; }

        [ForeignKey(typeof(Dieta))]
        public int dieta_id { get; set; }
        public String categoria { get; set; }
    }
}
