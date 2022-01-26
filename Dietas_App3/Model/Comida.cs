using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    [Table("Comida")]
    public class Comida
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }

        public String cantidad { get; set; }
        public int calorias { get; set; }
        public int hidratos { get; set; }
        public int proteina { get; set; }
        public int grasas { get; set; }

        [ForeignKey(typeof(Dieta))]
        public int dieta_id { get; set; }


    }
}
