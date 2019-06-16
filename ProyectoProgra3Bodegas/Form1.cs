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
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=BodegasAltoValyrioDB;Integrated Security=True");



        public Form1()
        {
            InitializeComponent();
        }


        public void validarUsuario(string USUARIO, string CONTRASEÑA)
        {
            con.Open();

            // se crea consulta
            SqlCommand cmd = new SqlCommand("Select Nombre , RollUsuario FROM UsuarioTBL  WHERE Usuario = @user AND Contraseña = @pass ", con);


            //se ejecuta comando para la evaluacion de la consulta con los textbox

            cmd.Parameters.AddWithValue("user", USUARIO);
            cmd.Parameters.AddWithValue("pass", CONTRASEÑA);
            // la siguiente linea de codigo realiza una adatacion de los datos extraidos e ingresado
            //para generar como una tabla virtual para que se valla a buscar los datos segun la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {

                // este if evalua si hay datos en la base de datos
                if (dt.Rows.Count == 1)
                {
                    // este if realiza una compracion de tipo de usuairo
                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        FormMenu fm = new FormMenu();
                    
                        fm.Show();

                        MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Usuario / Contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            validarUsuario(this.txtusuario.Text, this.txtcontraseña.Text);
        }
    }
}
