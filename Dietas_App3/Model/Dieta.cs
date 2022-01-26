using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    [Table("Dieta")]
    public class Dieta
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }
        public int calorias_Limite { get; set; }
        public int hidratos_Limite { get; set; }
        public int proteina_Limite { get; set; }
        public int grasas_Limite { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Comida> comidas { get; set; }
    }
}