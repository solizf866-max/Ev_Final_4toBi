using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int producto = Var1 * Var2;
            MessageBox.Show("El resultado del producto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int suma = Var1 + Var2;
            MessageBox.Show("El resultado de la sunma es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int Var3 = 1;
            int potencia = 1;
            while (Var1!= Var2)
            {
                potencia = potencia * Var1;
                Var3++;
            }
            MessageBox.Show("El resultado es" + potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Var1 = float.Parse(TextVar1.Text);
            float Var2 = float.Parse(TextVar2.Text);

            if (Var2 > 0)
            {
                float divicion = Var1 / Var2;
                MessageBox.Show("El resultado es " + divicion);
            }
            else
            {
                MessageBox.Show("La divicion es Indefinida ");
            }
        }
    }
}