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
    public partial class FormReportes : Form
    {

        Conexion con = new Conexion();

        public FormReportes()
        {
            InitializeComponent();
        }
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
                "select  NombreBodega, Codigo, NombreProducto, Marca, DescripcionCategoria, Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
                "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
                "where((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)) order by NombreBodega asc");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Bodega")
            {
                ActualizarGrid();
            }







        }
    }
}
