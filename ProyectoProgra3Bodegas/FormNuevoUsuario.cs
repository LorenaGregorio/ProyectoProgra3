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
    public partial class txtnombre : Form
    {
        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;

        string cadena, car, numero;
        public txtnombre()
        {
            InitializeComponent();
        }
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "Select IdUsuario, Nombre, Apellido, Usuario, Contraseña, Descripcion from UsuarioTBL, RollUsuarioTBL where dbo.UsuarioTBl.RollUsuario = dbo.RollUsuarioTBL.IdRollUsuario");
        }

       

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            con.ComboRoll(comboroll);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ClaseUsuario u1 = new ClaseUsuario(
                txtnom.Text,
                txtapellido.Text,
                txtusuario.Text,
                txtcontra.Text,
                Convert.ToInt32(textBox1.Text)
                );


            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update UsuarioTBL set Nombre = '" + u1.nombre + "', Apellido ='" + u1.apellido + "', Usuario ='" + u1.usuario + "', Contraseña ='" + u1.contraseña + "', RollUsuario  =" + u1.roll + "    where IdUsuario = " + Id + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

                editar = false;

            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into UsuarioTBL (Nombre, Apellido, Usuario, Contraseña, RollUsuario) values ('" + u1.nombre + "','" + u1.apellido + "','" + u1.usuario + "','" + u1.contraseña + "'," + u1.roll + " );";
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
            txtnom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtusuario.Text  = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcontra.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboroll.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // se agregan las campos de los datos por columna como un vector 
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from UsuarioTBL where IdUsuario = '" + Id + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboroll_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = comboroll.SelectedItem.ToString().Trim();
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
    }
}
