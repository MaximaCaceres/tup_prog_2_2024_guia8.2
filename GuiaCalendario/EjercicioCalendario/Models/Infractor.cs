using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalendario.Models
{
    public class Infractor
    {
        public int Dni { get; set; }
        public string ApellidosyNombres { get; set; }
        public Infractor(int dni,string apenom)
        {
            Dni = dni;
            ApellidosyNombres = apenom;
        }
        public override string ToString()
        {
            string date = $"{Dni}:{ApellidosyNombres}";
            return date;
        }
    }
}
