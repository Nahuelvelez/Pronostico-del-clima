using PronosticoClimatico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evalucion_N3
{
    public partial class Form1 : Form
    {
        private Clima clima;
        public Form1()
        {
            InitializeComponent();
            clima = new Clima(); 

        }
     



        private void button1_Click(object sender, EventArgs e)
        {
     
            if (int.TryParse(textBox1.Text, out int dias) && dias > 0)
            {

                lstClima.Items.Clear();

               
                string[] pronosticos = clima.GenerarPronostico(dias);

                foreach (var pronostico in pronosticos)
                {
                    lstClima.Items.Add(pronostico);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de días.");
            }
        }

 
    }
}

