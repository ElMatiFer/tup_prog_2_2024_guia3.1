using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Guia3._1.Models
{
    internal class Moto
    {
        public string Marca {  get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }
        public Moto(string marca, int modelo, double valorFabricacion) 
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
        public string VerDescripcion()
        {
            return $"| Marca: {Marca,7} | Modelo: {Modelo,4} | Valor de fabricación: {ValorFabricacion,10:c2} |";
        }
    }
}
