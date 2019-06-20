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
            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update ProductoTBL set  Codigo ='" + txtcodigo.Text + "', NombreProducto ='" + txtnombreproducto.Text + "', Marca ='" + txtmarca.Text + "', " +
                    "Categoria ='" + textBox1.Text + "', Precio = '" + txtprecio.Text + "', Refrigerado = '" + comboBox1.Text + "', " +
                    " FechadeCaducidad = '" + textBox5.Text + "', Bodega = '" + textBox2.Text + "', Peso = '" + txtprecio.Text + "', " +
                    "TipodeEmpaque = '" + textBox3.Text + "', Existencia = '" + txtexistencia.Text + "', Proveedor = '" + textBox4.Text + "', FechaIngreso = '" + textBox6.Text + "'  where IdProducto = " + Id + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

                editar = false;

            }
            else
            {

                con.Conectar();
            
                //Se crea una consulta para insertar los datos (Guardar)

            string consulta = "INSERT INTO ProductoTBL (Codigo ,NombreProducto ,Marca,Categoria ,Precio,Refrigerado,FechadeCaducidad,Bodega,Peso,TipodeEmpaque,Existencia,Proveedor,FechaIngreso) VALUES ('"+txtcodigo.Text+"', '"+txtnombreproducto.Text+"', '"+txtmarca.Text+"', "+Convert.ToInt32(textBox1.Text) +", "+Convert.ToDouble(txtprecio.Text)+", '"+comboBox1.SelectedItem+"', '"+ textBox5.Text + "', "+Convert.ToInt32(textBox2.Text)+", '"+txtpeso.Text+"', "+Convert.ToInt32(textBox3.Text)+", '"+txtexistencia.Text+"', "+Convert.ToInt32(textBox4.Text)+", '"+textBox6.Text+"');";


             
            ////con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtcodigo.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtnombreproducto.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmarca.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combcategoria.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtprecio.Text = (this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            comboBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();//refrigerado
            combodega.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();//bodega
            txtpeso.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();//peso
            combtipoempaque.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();//tipo de empaque
            txtexistencia.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            combproveedor.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
    


    




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from ProductoTBL where IdProducto = '" + Id + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "select  IdProducto, Codigo, NombreProducto, Marca, DescripcionCategoria, Precio, Refrigerado, FechadeCaducidad, NombreBodega, Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
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
            //con.ComboUbicacion(comboubicacion);

            

        }
    }
}
