using ProyectoProgra3Bodegas.Clases;
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
    public partial class FormAltayBajaProducto : Form
    {
        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;

        public FormAltayBajaProducto()
        {
            InitializeComponent();
        }

        public void ActualizarGrid2()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid2(this.dataGridView1,
                "Select * from AltaBajaProductoTBL order by Fecha asc ");
        }


        private void FormAltayBajaProducto_Load(object sender, EventArgs e)
        {
            ActualizarGrid2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos2 Produ = new FormProductos2();
            Produ.Show();
            Produ.Controls["button2"].Visible = false;
            Produ.Controls["button3"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductos2 Produ = new FormProductos2();
            Produ.Show();
            Produ.Controls["button3"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarGrid2();
        }
    }


}
