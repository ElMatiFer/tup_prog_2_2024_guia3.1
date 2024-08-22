using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Guia3._1.Models
{
    internal class EvaluadorLineal : Evaluador
    {
        public int VidaUtil { get; set; }
        public EvaluadorLineal(Moto vehiculo, int añoACalcular, int vidaUtil) : base(vehiculo, añoACalcular)
        { 
            VidaUtil = vidaUtil;
            this.añoACalcular = añoACalcular;
        }
        public override double CalcularDepresiacion()
        {
            int añoUso = AñoACalcular - Vehiculo.Modelo;

            double valor = 0;

            if (VidaUtil > 0 && añoUso > 0)
            {
                valor = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añoUso / VidaUtil);
            }

            return valor;
        }
        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} Depresiación lineal: {CalcularDepresiacion()}";  
        }
    }
}
