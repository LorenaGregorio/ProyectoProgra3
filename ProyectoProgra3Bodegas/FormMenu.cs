using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra3Bodegas
{
    public partial class FormMenu : Form
    {

       
        public FormMenu()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnombre fm = new txtnombre();
            fm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductos2 fproducto = new FormProductos2();
            fproducto.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
         
        }
    }
}
