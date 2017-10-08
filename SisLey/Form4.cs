using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLey
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Parlamentario pr1 = new Parlamentario();
            String nombre;
            String Apellido;
            nombre = textBox1.Text;
            Apellido = textBox2.Text;
            pr1.setNombre(nombre);
            pr1.setApellidp(Apellido);
            pr1.insertarParlamentario(pr1);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
