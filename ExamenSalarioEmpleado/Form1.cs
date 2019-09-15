using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularsalario_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txthorastrabajadas.Text);
            double valorhora = double.Parse(txtvalorhora.Text);
            double salario = horastrabajadas * valorhora;
            double incremento;
            double descuento;
            double total;
            if(salario <= 700000) {

                incremento = salario * 0.10;
                total = salario + incremento;
                MessageBox.Show("El salario del empleado incrementa en 10% ("+incremento+")");


            } else {
                if (salario<=1000000)
                {
                    incremento = salario * 0.02;
                    total = salario - incremento;
                    MessageBox.Show("El salario del empleado descuenta en 2% (" + incremento + ")");
                }
                else
                {
                    if (salario >= 1000001)
                    {

                        incremento = salario * 0.02;
                        descuento = salario * 0.05;
                        total = (salario + incremento)-descuento;
                        MessageBox.Show("El salario del empleado descuenta en 5% (" + descuento + ") e incrementa en 2% ("+incremento+")");

                    }
                    else
                    {

                        total = (salario * 0.20) + salario;

                    }
                    
                }
                

            }
            lbltotalsalario.Text = "$" + Convert.ToDecimal(total).ToString("N0");
            lbltotalsalario.Visible = true;
            
        }
    }
}
