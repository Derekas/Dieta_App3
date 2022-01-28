using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public double peso { get; set; }
        public int edad { get; set; }
        public double altura { get; set; }
        public String sexo { get; set; }
        public String actividad { get; set; }
        
    }
}
