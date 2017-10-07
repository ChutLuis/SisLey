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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion conect = new Conexion();
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Sistem sis1 = new Sistem();
            String nombre;
            nombre = txtNombre.Text;
            MessageBox.Show(nombre);
            sis1.setNombre(nombre);
            sis1.insertarSistema(sis1);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
