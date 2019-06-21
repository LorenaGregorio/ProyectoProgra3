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
            //// Aca se hace una funcion (select) para mostrar los datos
            //con.ActualizarGrid(this.dataGridView1,
            //    "select  NombreBodega, Codigo, NombreProducto, Marca, DescripcionCategoria, Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
            //    "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
            //    "where((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)) ");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           







        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Codigo")
            {
                //con.ActualizarGrid(this.dataGridView1, "select *  from ProductoTBL where (Codigo like '" + textBox1.Text + "%') and (); ");

                con.ActualizarGrid(this.dataGridView1,
               "select Codigo, NombreProducto, Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((Codigo like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                comboBox1.SelectedItem.Equals("");
            }
            if (comboBox1.SelectedItem == "Nombre Producto")
            {
                con.ActualizarGrid(this.dataGridView1,
               "select  NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((NombreProducto like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                comboBox1.SelectedItem.Equals("");
            }
            if (comboBox1.SelectedItem == "Marca")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select  Marca,NombreProducto, Codigo, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((Marca like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");


            }
            if (comboBox1.SelectedItem == "Categoria")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select  DescripcionCategoria, NombreProducto, Codigo,Marca, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((DescripcionCategoria like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

            }
            if (comboBox1.SelectedItem == "Fecha de Caducidad")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select FechadeCaducidad, NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((FechadeCaducidad like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

            }
            if (comboBox1.SelectedItem == "Tipo de Empaque")
            {
                con.ActualizarGrid(this.dataGridView1,
               "select DescripcionEm, NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((DescripcionEm like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

            }
            if (comboBox1.SelectedItem == "Proveedor")
            {
                con.ActualizarGrid(this.dataGridView1,
               "select  Descripcion,NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((Descripcion like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

            }
            if (comboBox1.SelectedItem == "Fecha de Ingreso")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select  FechaIngreso,NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((FechaIngreso like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (comboBox1.SelectedItem == "Codigo")
            {
                textBox1.Clear();
                //con.ActualizarGrid(this.dataGridView1, "select *  from ProductoTBL where (Codigo like '" + textBox1.Text + "%') and (); ");
        
                con.ActualizarGrid(this.dataGridView1,
               "select Codigo, NombreProducto, Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((Codigo like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Nombre Producto")
            {
                textBox1.Clear();
                con.ActualizarGrid(this.dataGridView1,
               "select  NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((NombreProducto like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Marca")
            {
                textBox1.Clear();
                con.ActualizarGrid(this.dataGridView1,
              "select  Marca,NombreProducto, Codigo, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((Marca like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();

            }
            if (comboBox1.SelectedItem == "Categoria")
            {

                textBox1.Clear();
                con.ActualizarGrid(this.dataGridView1,
              "select  DescripcionCategoria, NombreProducto, Codigo,Marca, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((DescripcionCategoria like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Fecha de Caducidad")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select FechadeCaducidad, NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado,  Peso, DescripcionEm, Existencia, Descripcion, FechaIngreso " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((FechadeCaducidad like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Tipo de Empaque")
            {
                con.ActualizarGrid(this.dataGridView1,
               "select DescripcionEm, NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, Existencia, Descripcion, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((DescripcionEm like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Proveedor")
            {
                con.ActualizarGrid(this.dataGridView1,
               "select  Descripcion,NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, FechaIngreso " +
               "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
               "where ((Descripcion like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }
            if (comboBox1.SelectedItem == "Fecha de Ingreso")
            {
                con.ActualizarGrid(this.dataGridView1,
              "select  FechaIngreso,NombreProducto, Codigo,Marca, DescripcionCategoria, NombreBodega,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion " +
              "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
              "where ((FechaIngreso like '" + textBox1.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");
                textBox1.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.ActualizarGrid(this.dataGridView1,
            "select  NombreBodega,NombreProducto, Codigo,Marca, DescripcionCategoria,  Precio, Refrigerado, FechadeCaducidad,  Peso, DescripcionEm, Existencia, Descripcion " +
            "from ProductoTBL, CategoriaTBL, BodegaTBL, TipodeEmpaqueTBL, ProveedorTBL " +
            "where ((NombreBodega like '" + textBox2.Text + "%') and ((dbo.ProductoTBL.Categoria = dbo.CategoriaTBL.IdCategoria and dbo.ProductoTBL.Bodega = dbo.BodegaTBL.IdBodega)and(dbo.ProductoTBL.TipodeEmpaque = dbo.TipodeEmpaqueTBL.IdEmpaque and dbo.ProductoTBL.Proveedor = dbo.ProveedorTBL.IdProveedor))) ");

        }
    }
}
