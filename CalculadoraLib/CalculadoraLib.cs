using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_Libreria;
namespace CalculadoraLib
{
    public partial class CalculadoraLib : Form
    {
        public CalculadoraLib()
        {
            InitializeComponent();
        }

        private void btnCora_Click(object sender, EventArgs e)
        {

        }

        double numero1, numero2, respuesta;
        bool banderaNumero1 = false;
        bool banderaOperacion = false;
        string operacionSeleccionada;

        private void btn0_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "9";
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + ".";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = "";
            limpiar();
        }



        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "suma";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "resta";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "mult";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "div";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (banderaOperacion)
            {
                numero2 = Convert.ToDouble(tbPantalla.Text);

                respuesta = Operacion(operacionSeleccionada);
                tbPantalla.Text = respuesta.ToString();
                limpiar();
            }
        }

        private double Operacion(string operacion)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "suma":
                 resultado = Operaciones.suma(numero1, numero2);
                    break;
                case "resta":
                    resultado = Operaciones.resta(numero1, numero2);
                    break;
                case "mult":
                    resultado = Operaciones.multiplicacion(numero1, numero2);
                    break;
                case "div":
                    resultado = Operaciones.division(numero1, numero2);
                    break;
            }

            return resultado;
        }
        private void limpiar()
        {
            banderaNumero1 = false;
            banderaOperacion = false;
        }

    }
}
