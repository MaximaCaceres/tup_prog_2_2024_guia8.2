using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalendario.Models
{
    public class Cuota
    {
        #region Cuotas
        public int Cuotas { get; private set; }
        #endregion
        #region Atributos
        private double montoB = 0;
        #endregion
        //DateTime
        public DateTime FechaPrimerVencimiento { get; set; }
        public DateTime FechaSegundoVencimiento { get; set; }
        #region Porcentajes
        public double PorcentajeVoluntario { get; set; }
        public double PorcentajePrimerVenci { get; set; }
        public double PorcentajeSegundVenci { get; set; }
        #endregion

        #region Propiedades Largas
        public double MontoBase
        {
            get
            {
                double mb = montoB / Cuotas;
                return mb;
            }
            set
            {

            }
        }


        public double MontoVoluntario
        {
            get
            {
                double mv = MontoBase + (MontoBase * PorcentajeVoluntario);
                return mv;
            }
        }
        #endregion

    }
}
