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
using Microsoft.VisualBasic;

namespace ProyectoProgra3Bodegas
{
    public partial class FormTraslados : Form
    {
        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar,editar2;
        int Id,Id2;
        int d1, d2,d3, residuo  ;

        public object Interaction { get; private set; }

        public FormTraslados()
        {
            InitializeComponent();
        }

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "select IdProducto, NombreProducto,  NombreBodega, Existencia, FechaIngreso, bodega from  ProductoTBL, BodegaTBL where dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega order by FechaIngreso");
        }



        public void ActualizarGrid2()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView2,
                "select IdProducto, NombreProducto,  NombreBodega, Existencia, FechaIngreso, bodega from  ProductoTBL, BodegaTBL where dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega order by FechaIngreso");
        }





        private void FormTraslados_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            ActualizarGrid2();

            editar = false;
            editar2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           textBox7.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = Convert.ToInt32(textBox3.Text);
            d2 = Convert.ToInt32(textBox4.Text);

            string dtos = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de Traladar");

             d3 = Convert.ToInt32(dtos.ToString());

            if (d3 > d1)
            {
                MessageBox.Show("No hay esa cantidad en existencias");
            }
            else
            {
                textBox4.Text = (d2 + d3).ToString();
                textBox3.Text = (d1 - d3).ToString();
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se realiza un update
            con.Conectar();
            string consulta = "update ProductoTBL set Existencia = '" + textBox3.Text + "' where IdProducto = " + Id + " ;";
            con.EjecutarSql(consulta);
            this.ActualizarGrid();
            con.Desconectar();

            editar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id2 = int.Parse(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
            textBox6.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
