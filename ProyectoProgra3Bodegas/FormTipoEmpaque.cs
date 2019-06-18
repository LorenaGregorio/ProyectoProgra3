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
    public partial class FormTipoEmpaque : Form
    {
        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;


        public FormTipoEmpaque()
        {
            InitializeComponent();
        }

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "Select * from TipodeEmpaqueTBL");
        }


        private void FormTipoEmpaque_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update TipodeEmpaqueTBL set Descripcion = '" + textBox1.Text + "'    where IdEmpaque = " + Id + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

                editar = false;

            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into TipodeEmpaqueTBL (Descripcion) values ('" + textBox1.Text + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //La variable editar se agrega para que sea true
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // se agregan las campos de los datos por columna como un vector 
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from TipodeEmpaqueTBL where IdEmpaque = '" + Id + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }
    }
}
