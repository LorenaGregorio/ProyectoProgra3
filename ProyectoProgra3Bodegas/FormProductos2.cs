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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBodega fbodega = new FormBodega();
            fbodega.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormProductos2_Load(object sender, EventArgs e)
        {
            con.ComboCategoria(combcategoria);
            con.ComboBodega(combodega);
            con.ComboProveedor(combproveedor);
            con.ComboTipoEmpaque(combtipoempaque);

        }
    }
}
