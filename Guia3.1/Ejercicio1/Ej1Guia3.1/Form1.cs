using Ej1Guia3._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1Guia3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(upModelo.Value);

            double valorFabricacion = Convert.ToDouble(tbValorFabricacion.Text);
            int añoACalcular = Convert.ToInt32(upAñoACalcular.Value);

            Moto motito = new Moto(marca, modelo, valorFabricacion);

            Evaluador evaluador = null;

            if (rdLineal.Checked == true)
            {    
                int vidaUtil = Convert.ToInt32(tbValorFabricacion.Text);

                evaluador = new EvaluadorLineal(motito,añoACalcular,vidaUtil);       
               
            }
            else if(rdAnual.Checked== true)
            {
                double tasaDepre = Convert.ToDouble(tbTasaDepre.Text);
                evaluador = new EvaluadorAnual(motito,añoACalcular,tasaDepre);
            }
            if (evaluador != null)
            {
                fResultados v = new fResultados();
                v.tbResultados.Text = $"{evaluador.VerDescripcion()}";
                v.ShowDialog();
            }
                
        }

        private void rdLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbVidaUtil.Enabled = rdLineal.Checked;
            tbTasaDepre.Enabled = rdAnual.Checked;
        }
    }
}
