using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Dieta")]
    public class Dieta
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }
        public double calorias_Limite { get; set; }
        public double hidratos_Limite { get; set; }
        public double proteina_Limite { get; set; }
        public double grasas_Limite { get; set; }

        [ManyToMany(typeof(DietasComidas))]
        public List<Comida> comidas { get; set; }

    }

}