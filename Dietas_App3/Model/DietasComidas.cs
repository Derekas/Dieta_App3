using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("DietasComida")]
    public class DietasComidas
    {
        [ForeignKey(typeof(Comida))]
        public int ComidaId { get; set; }

        [ForeignKey(typeof(Dieta))]
        public int DietaId { get; set; }

    }
}
