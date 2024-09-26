using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjercicioCalendario.Models
{
    public class Calendario
    {
        List<Feriado> CantidadFeriados = new List<Feriado>();
        public int CantidadF
        {
            get
            {
                return CantidadFeriados.Count;
            }
        }
        public Feriado this[DateTime dia]
        {
            get
            {
                Feriado f = null;
                for (int i = 0; i <CantidadFeriados.Count; i++)
                {
                    f = CantidadFeriados[i];
                    if (f.Fecha.Year ==dia.Year && f.Fecha.Month == dia.Month && f.Fecha.Day == dia.Day)//vemos que el dia que nos dan sea un feriado.
                    {
                        return f;
                    }
                }
                return f;
            }
        }
        public Feriado this[int idx]
        {
            get //
            {
                if (idx > 0 && idx < CantidadFeriados.Count)
                    return CantidadFeriados[idx];
                return null;
            }
        }
        #region Metodos
        public Feriado AgregarFeriado(DateTime dia,string desc)
        {
            Feriado f = new Feriado(dia, desc);
            CantidadFeriados.Add(f);
            return f;
        }
        #endregion
    }
}
