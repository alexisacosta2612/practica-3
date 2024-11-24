using practica_3.datos;
using practica_3.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato= new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            limpiar();
            Consultar();    
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
limpiar();
        }
        private void Iniciar()
        {
tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("edad");
            grilla.DataSource= tabla;   
        }
        private void Guardar()
        {
            UsuarioModelo modelo = new UsuarioModelo()
            {
                Nombre = textnom.Text,
                Edad = int.Parse(textedad.Text)
            };
            dato.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }
            private void limpiar()
        {
            textnom.Text = "";
            textedad.Text = "";
        }
        }
    }

