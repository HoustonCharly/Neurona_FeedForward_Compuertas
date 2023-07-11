using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_6_Feedforward
{
    public partial class Form1 : Form
    {
        double peso111 = 5.191129;  double peso112 = 2.758669;
        double peso121 = 5.473012;  double peso122 = 2.769596;
        double peso21 = 5.839709;   double peso22 = -6.186834;

        double umbral10 = -1.90289; double umbral11 = -4.127002;
        double umbral20 = -2.570539;

        float W2 = 1;
        double U2 = 0.5;

        private void checkXOR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkXOR.Checked)
            {
                TablaGridView1.ClearSelection();
                TablaGridView1.Columns.Clear();
                lBsalida.Items.Clear();
                TablaGridView1.Columns.Add("x1", "X1");
                TablaGridView1.Columns.Add("x2", "X2");
                TablaGridView1.Columns.Add("ye", "Yesperada");
                TablaGridView1.Columns.Add("y0", "Yobt");
                TablaGridView1.Columns[3].DefaultCellStyle.BackColor =Color.Cyan;
                TablaGridView1.Columns[2].DefaultCellStyle.BackColor =Color.Lavender;


                TablaGridView1.Rows.Add("0", "0", "1");
                TablaGridView1.Rows.Add("0", "1", "0");
                TablaGridView1.Rows.Add("1", "0", "0");
                TablaGridView1.Rows.Add("1", "1", "1");
            }
        }
        private void checkEjercicio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEjercicio.Checked)
            {
                TablaGridView1.ClearSelection();
                TablaGridView1.Columns.Clear();
                lBsalida.Items.Clear();
                TablaGridView1.Columns.Add("x1", "X1");
                TablaGridView1.Columns.Add("x2", "X2");
                TablaGridView1.Columns.Add("y1", "Y1");
                TablaGridView1.Columns.Add("y1", "Y2");
                TablaGridView1.Columns[3].DefaultCellStyle.BackColor =Color.Lavender;
                TablaGridView1.Columns[2].DefaultCellStyle.BackColor =Color.Lavender;
                TablaGridView1.Rows.Add("0", "0");
                TablaGridView1.Rows.Add("0", "1");
                TablaGridView1.Rows.Add("1", "0");
                TablaGridView1.Rows.Add("1", "1");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lBsalida.Items.Clear();
            if (checkXOR.Checked)
            {

                lBsalida.Items.Add("\nPatron 1");
                lBsalida.Items.Add("\n");
                
                TablaGridView1.Rows[0].Cells[3].Value = entradaXOR(0, 0);

                lBsalida.Items.Add("\nPatron 2");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[1].Cells[3].Value = entradaXOR(0, 1);

                lBsalida.Items.Add("\nPatron 3");
                lBsalida.Items.Add("\n"); 
                TablaGridView1.Rows[2].Cells[3].Value = entradaXOR(1, 0);

                lBsalida.Items.Add("\nPatron 4");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[3].Cells[3].Value = entradaXOR(1, 1);
            }
            else if (checkEjercicio.Checked)
            {
                lBsalida.Items.Add("Patron 1");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[0].Cells[2].Value =ejercicio11(0, 0);
                TablaGridView1.Rows[0].Cells[3].Value =ejercicio22(0, 0);
                lBsalida.Items.Add("Patron 2");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[1].Cells[2].Value =ejercicio11(0, 1);
                TablaGridView1.Rows[1].Cells[3].Value =ejercicio22(0, 1);
                lBsalida.Items.Add("Patron 3");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[2].Cells[2].Value =ejercicio11(1, 0);
                TablaGridView1.Rows[2].Cells[3].Value =ejercicio22(1, 0);
                lBsalida.Items.Add("Patron 4");
                lBsalida.Items.Add("\n");
                TablaGridView1.Rows[3].Cells[2].Value =ejercicio11(1, 1);
                TablaGridView1.Rows[3].Cells[3].Value =ejercicio22(1, 1);

            }
        }
        double entradaXOR(double entrada1, double entrada2)
        {   
            double salidaneurona11 = 1/(1+(Math.Exp(-(((entrada1*peso111)+(entrada2*peso121))+umbral10))));
            lBsalida.Items.Add("Capa: 1 Activ:1  "+salidaneurona11);

            double salidaneurona12 = 1/(1+(Math.Exp(-(((entrada1*peso112)+(entrada2*peso122))+umbral11))));
            lBsalida.Items.Add("Capa: 1 Activ:2  "+salidaneurona12);

            double salidaneuronay11 = 1/(1+(Math.Exp(-(((peso21*salidaneurona11)+(peso22*salidaneurona12))+umbral20))));
            
            lBsalida.Items.Add("\nCapa: 2 Activ:1  "+salidaneuronay11);
            lBsalida.Items.Add("\n"); 

            lBsalida.Items.Add("\nSalida : "+salidaneuronay11);
            lBsalida.Items.Add("\n");

            return salidaneuronay11;
        }

        double A11, A12, A21, A22, A31, A32;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("\tRivera Rivera Juan Carlos");
        }

        double ejercicio11(double entrada1, double entrada2)
        {   
            //Capa 1
            A11=A12=1/(1+(Math.Exp(-(((entrada1*W2)+(entrada2*W2)+U2)))));
            lBsalida.Items.Add("Capa: 1 Activ:0  "+A11);
            lBsalida.Items.Add("Capa: 1 Activ:1  "+A12);

            lBsalida.Items.Add("\n");
            //Capa2
            A21=A22=1/(1+(Math.Exp(-(((A11*W2)+(A12*W2)+U2)))));
            lBsalida.Items.Add("Capa: 2 Activ:0  "+A21);
            lBsalida.Items.Add("Capa: 2 Activ:1  "+A22);

            lBsalida.Items.Add("\n");
            //Capa 3
            A31=A32=1/(1+(Math.Exp(-(((A21*W2)+(A22*W2)+U2)))));
            lBsalida.Items.Add("Capa: 3 Activ:0  "+A31);
            lBsalida.Items.Add("Capa: 3 Activ:1  "+A32);

            lBsalida.Items.Add("\n");

            lBsalida.Items.Add("\nSalida Y1: "+A31);
            lBsalida.Items.Add("\nSalida Y1: "+A32);
            lBsalida.Items.Add("\n");

            return A31;
         
        }
        double ejercicio22(double entrada1, double entrada2)
        {
            //Capa 1
            A12=A11=1/(1+(Math.Exp(-(((entrada1*W2)+(entrada2*W2)+U2)))));
            //Capa2
            A22=A21=1/(1+(Math.Exp(-(((A11*W2)+(A12*W2)+U2)))));
            //Capa 3
            A32=A31=1/(1+(Math.Exp(-(((A21*W2)+(A22*W2)+U2)))));
            return A32;

        }
    }
}
