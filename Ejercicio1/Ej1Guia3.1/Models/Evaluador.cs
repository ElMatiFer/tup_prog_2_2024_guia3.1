using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Guia3._1.Models
{
    abstract class Evaluador
    {
        public Moto Vehiculo { get; set; }

        protected int añoACalcular;
        public int AñoACalcular 
        {
            get
            { 
                return añoACalcular; 
            }
        }
        public Evaluador(Moto vehiculo, int añoACalcular)
        {
            
            Vehiculo = vehiculo;
        }
        public abstract double CalcularDepresiacion();
        public virtual string VerDescripcion()
        {
            return $"{Vehiculo.VerDescripcion()}";
        }
    }
}
