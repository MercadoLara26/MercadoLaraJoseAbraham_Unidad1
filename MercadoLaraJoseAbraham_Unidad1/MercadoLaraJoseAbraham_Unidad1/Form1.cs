using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoLaraJoseAbraham_Unidad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.MouseHover += new EventHandler(FOCO);
            textBox1.MouseHover += new EventHandler(FOCO);
            radioButton1.MouseHover += new EventHandler(FOCO);
            button1.MouseHover += new EventHandler(FOCO);
            checkBox1.MouseHover += new EventHandler(FOCO);
        }

        private void FOCO(object sender, EventArgs e)
        {
            if (sender == comboBox1)
            {
                label1.Text = "ComboBox1: Selecciona un ítem de una lista.";
            }
            else if (sender == textBox1)
            {
                label1.Text = "TextBox1: Entrada de texto.";
            }
            else if (sender == radioButton1)
            {
                label1.Text = "RadioButton1: Selecciona una opción entre varias.";
            }
            else if (sender == button1)
            {
                label1.Text = "Button1: Ejecuta una acción al presionar.";
            }
            else if (sender == checkBox1)
            {
                label1.Text = "CheckBox1: Permite seleccionar o deseleccionar una opción.";
            }
        }
    }
}
