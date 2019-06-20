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
    public partial class FormBodega : Form
    {

        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;
        string cadena, car, numero;

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "select IdBodega, NombreBodega, Departamento from BodegaTBL, UbicacionTBL where dbo.BodegaTBL.Ubicacion = dbo.UbicacionTBL.IdUbicacion");
        }


        public FormBodega()
        {
            InitializeComponent();
        }

        private void FormBodega_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            con.ComboUbicacion(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //La variable editar se agrega para que sea true
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // se agregan las campos de los datos por columna como un vector 
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from BodegaTBL where IdBodega = '" + Id + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUbicacion fubicacion = new FormUbicacion();
            fubicacion.Show();
            //ComboUbicacion.Items.Clear();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.Items.Clear();

            con.ComboUbicacion(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update BodegaTBL set NombreBodega  = '" + textBox1.Text+ "', Ubicacion  =" + textBox2.Text + "    where IdBodega = " + Id + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

                editar = false;

            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into BodegaTBL (NombreBodega, Ubicacion) values ('" + textBox1.Text + "','" + textBox2.Text + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = comboBox1.SelectedItem.ToString().Trim();
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
    }
}
