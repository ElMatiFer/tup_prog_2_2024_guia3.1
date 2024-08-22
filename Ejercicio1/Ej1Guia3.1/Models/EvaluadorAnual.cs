using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Guia3._1.Models
{
    internal class EvaluadorAnual : Evaluador
    {
        public double TasaDepresiacion { get; set; }

        public EvaluadorAnual(Moto vehiculo, int añoACalcular, double tasaDepresiacion) : base (vehiculo, añoACalcular)
        {
            TasaDepresiacion = tasaDepresiacion;
        }
        public override double CalcularDepresiacion()
        {
            int añouso = base.AñoACalcular - Vehiculo.Modelo;
            return Vehiculo.ValorFabricacion * (Math.Pow((1 - TasaDepresiacion),añouso));
        }
        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} Depresiación anual: {CalcularDepresiacion()}";
        }
    }
}
