using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3Bodegas.Clases
{
    public class ClaseUsuario
    {
        private string Nombre;
        private string Apellido;
        private string Usuario;
        private string Contraseña;
        private int Roll;

        public ClaseUsuario(string Nombre, string Apellido, string Usuario, string Contraseña, int Roll)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Usuario = Usuario;
            this.Contraseña = Contraseña;
            this.Roll = Roll;
        }

      

        public string nombre        
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }
        public string apellido
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }
        public string usuario
        {
            get
            {
                return Usuario;
            }

            set
            {
                Usuario = value;
            }
        }
        public string contraseña
        {
            get
            {
                return Contraseña;
            }

            set
            {
                Contraseña = value;
            }
        }
        public int roll 
        {
            get
            {
                return Roll;
            }

            set
            {
                Roll = value;
            }
        }
    }
}
