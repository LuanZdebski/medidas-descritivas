using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_de_medidas_descritivas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
           
            float peso = SomarPesos();
            float soma = 0;
            float resultado;
            List<float> numeros = CriarLista();

            foreach (int numero in numeros)
            {
                soma += numero;
            }
           

            resultado = soma / peso;
            MessageBox.Show("Média: " + resultado);
            
        }
        private void btnMediana_Click(object sender, EventArgs e)
        {
            float resultado = 0;

            List<float> numeros = CriarLista();
            numeros.Sort();         
            if (numeros.Count % 2 == 0)
            {
                int i = numeros.Count / 2;          
                resultado = (numeros[i-1] + numeros[i]) / 2;
            }
            else
            {
                int i = (numeros.Count / 2);
                resultado = numeros[i];
            }


            MessageBox.Show("Mediana: " + resultado);
        }
        private void btnVariancia_Click(object sender, EventArgs e)
        {

            MessageBox.Show("variancia: " + Variancia());
        }
        private void btnDesvio_Click(object sender, EventArgs e)
        {
            double resultado = Math.Sqrt(Variancia());

            MessageBox.Show("Desvio padrão: " + resultado);
        }
        private void btnCoeficiente_Click(object sender, EventArgs e)
        {
            List<float> numeros = CriarLista();
            float soma = 0;
            float media = 0;
            float variancia = 0;
            

            foreach (int numero in numeros)
            {
                soma += numero;
            }
            media = soma / numeros.Count;

            foreach (int numero in numeros)
            {
                variancia += Math.Abs(numero - media) * Math.Abs(numero - media);
            }

            variancia = variancia / (numeros.Count - 1);

            double s = Math.Sqrt(variancia);
            MessageBox.Show(Math.Round((s / media * 100), 2) + "%");

        }

        private void btnConjunto_Click(object sender, EventArgs e)
        {
            List<float> numeros = CriarLista();
            float soma = 0;
            float media = 0;
            float variancia = 0;


            foreach (int numero in numeros)
            {
                soma += numero;
            }
            media = soma / numeros.Count;

            foreach (int numero in numeros)
            {
                variancia += Math.Abs(numero - media) * Math.Abs(numero - media);
            }

            variancia = variancia / (numeros.Count - 1);

            double s = Math.Sqrt(variancia);
            double conj = Math.Round((s / media * 100), 2);

            if (conj > 30) { MessageBox.Show("Heterogêneo"); }
            else { MessageBox.Show("Homogêneo"); }
            

        }

        //metodos
        private List<float> CriarLista()
        {
            List<float> numeros = new List<float>();
            for (int i = 0; i < dataNumero.RowCount - 1; i++)
            {
                float peso;
               
                peso = Convert.ToSingle(dataNumero.Rows[i].Cells[1].Value);
                if (peso == 0) { peso = 1; }

                
                numeros.Add(Convert.ToSingle(dataNumero.Rows[i].Cells[0].Value) * peso);

            }
            return numeros;

        }
        private float SomarPesos()
        {
            float resultado = 0;
            for (int i = 0; i < dataNumero.RowCount - 1; i++)
            {
                float peso;
                peso = Convert.ToSingle(dataNumero.Rows[i].Cells[1].Value);
                if (peso == 0) { peso = 1; }

                resultado += peso;

            }
            return resultado;

        }
        private float Variancia()
        {
            List<float> numeros = CriarLista();
            float soma = 0;
            float media = 0;
            float variancia = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            media = soma / numeros.Count;

            foreach (int numero in numeros)
            {
                variancia += Math.Abs(numero - media) * Math.Abs(numero - media);
            }

            variancia = variancia / (numeros.Count - 1);

            return variancia;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataNumero.Rows.Clear();
        }
    }
}
