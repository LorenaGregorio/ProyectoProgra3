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
    public partial class FormProductos2 : Form
    {

        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;
        string cadena, car, numero;

     


        public FormProductos2()
        {
            InitializeComponent();
        }

        private void combcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cadena = combcategoria.SelectedItem.ToString().Trim();

            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox1.Clear();
            textBox1.Text = numero;
            numero = "";
        
        }

        private void combodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combodega.SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox2.Clear();
            textBox2.Text = numero;
            numero = "";
        }

        private void combtipoempaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combtipoempaque.SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox3.Clear();
            textBox3.Text = numero;
            numero = "";
        }

        private void combproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combproveedor.SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox4.Clear();
            textBox4.Text = numero;
            numero = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCategoria fcategoria = new FormCategoria();
            fcategoria.Show();
            combcategoria.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBodega fbodega = new FormBodega();
            fbodega.Show();
            combodega.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTipoEmpaque fempaque = new FormTipoEmpaque();
            fempaque.Show();
            combtipoempaque.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormProveedor fproveedor = new FormProveedor();
            fproveedor.Show();
            combproveedor.Items.Clear();

        }

        private void combcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            combcategoria.Items.Clear();
           
            con.ComboCategoria(combcategoria);
        }

        private void combodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            combodega.Items.Clear();

            con.ComboBodega(combodega);
        }

        private void combtipoempaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            combtipoempaque.Items.Clear();

            con.ComboEmpaque(combtipoempaque);

        }

        private void combproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            combproveedor.Items.Clear();

            con.ComboProveedor(combproveedor);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "select  Codigo, NombreProducto, Marca, DescripcionCategoria, Precio, Refrigerado, FechadeCaducidad, NombreBodega, Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
                "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
                "where((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))");
        }

        private void FormProductos2_Load(object sender, EventArgs e)
        {
            ActualizarGrid();

            con.ComboCategoria(combcategoria);
            con.ComboBodega(combodega);
            con.ComboProveedor(combproveedor);
            con.ComboTipoEmpaque(combtipoempaque);

            //Dar formato a dateTimePicker

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-mm-dd";

        }
    }
}
