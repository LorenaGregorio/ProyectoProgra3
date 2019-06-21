using ProyectoProgra3Bodegas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra3Bodegas
{
    public partial class FormUbicacion : Form
    {

        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int Id;

        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "Select * from UbicacionTBL");
        }


        public FormUbicacion()
        {
            InitializeComponent();
        }



        private void FormUbicacion_Load(object sender, EventArgs e)
        {
            ActualizarGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update UbicacionTBL set Direccion = '" + textBox1.Text + "', Departamento ='" + textBox2.Text + "'    where IdUbicacion = " + Id + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();

                editar = false;

            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into UbicacionTBL (Direccion, Departamento) values ('" + textBox1.Text + "','" + textBox2.Text + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=BodegasAltoValyrioDB;Integrated Security=True");


     

        private void button3_Click(object sender, EventArgs e)
        {
            Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());



            con2.Open();

            // se crea consulta
            SqlCommand cmd = new SqlCommand("Select  IdUbicacion FROM BodegaTBL  WHERE IdUbicacion = @ubi ", con2);

            //se ejecuta comando para la evaluacion de la consulta con los textbox
            cmd.Parameters.AddWithValue("ubi", Id);

            // la siguiente linea de codigo realiza una adatacion de los datos extraidos e ingresado
            //para generar como una tabla virtual para que se valla a buscar los datos segun la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("No " + Id);


            // este if evalua si hay datos en la base de datos
            if ((dt.Rows.Count == 1))
            {


                MessageBox.Show("No se puede eliminar la Ubicaicon ");
            }
            else
            {
                var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    con.Conectar();
                    string consulta = "delete from UbicacionTBL where IdUbicacion = '" + Id + "' ; ";
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
}
