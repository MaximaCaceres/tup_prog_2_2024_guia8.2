using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalendario.Models
{
    public class Feriado
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Feriado(DateTime fech,string des)
        {
            Fecha = fech;
            Descripcion = des;
        }
    }
}
