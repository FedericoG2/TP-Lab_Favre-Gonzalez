using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_Lab_Favre_Gonzalez
{
    public partial class Form1 : Form
    {

        public struct REPUESTO
        {
            public int numeroRepuesto;
            public string marca;
            public string origen;
            public string descripcion;
            public float precio;
        }

        REPUESTO[] repuestos;

        int posicion;

        string marcaFiltro;
        string origenFiltro;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
            }
            

            if (txtNumRepuesto.Text.Length >= 6 && e.KeyChar != 8)
            {
                e.Handled = true; 
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (txtDescripcion.Text.Length >= 50 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
            }
            

            if (txtPrecio.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Clear();

            cmbMarca.Items.Add("P");
            cmbMarca.Items.Add("F");
            cmbMarca.Items.Add("R");
            cmbMarca.SelectedIndex = 0;

            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbOrigen.Items.Clear();

            cmbOrigen.Items.Add("N");
            cmbOrigen.Items.Add("I");

            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOrigen.SelectedIndex = 0;

            repuestos = new REPUESTO[100];

           
            cmbMarcaFiltro.Items.Clear();
           
            cmbMarcaFiltro.Items.Add("P");
            cmbMarcaFiltro.Items.Add("F");
            cmbMarcaFiltro.Items.Add("R");
            

            cmbMarcaFiltro.SelectedIndex = 0;

            cmbMarcaFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            optNacional.Checked = true;
           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool numeroRepuestoRepetido = false;

            if (txtNumRepuesto.Text.Length > 0 && cmbMarca.SelectedItem.ToString().Length > 0 && cmbOrigen.SelectedItem.ToString().Length> 0 && txtDescripcion.Text.Length > 0 && txtPrecio.Text.Length > 0  ) {

                for( int i = 0; i < posicion;i++)
                {
                    if (repuestos[i].numeroRepuesto == int.Parse(txtNumRepuesto.Text))
                    {
                        numeroRepuestoRepetido = true;
                        break;

                    }
                }
                
                if (numeroRepuestoRepetido)
                {
                    MessageBox.Show("El numero de repuesto ya existe,ingrese otro");
                    

                } else {

                    repuestos[posicion].numeroRepuesto = int.Parse(txtNumRepuesto.Text);
                    repuestos[posicion].marca = cmbMarca.SelectedItem.ToString();
                    repuestos[posicion].origen = cmbOrigen.SelectedItem.ToString();
                    repuestos[posicion].descripcion = txtDescripcion.Text;
                    repuestos[posicion].precio = float.Parse(txtPrecio.Text);
                    posicion++;


                    if (posicion >= 100)
                    {
                        MessageBox.Show("Se llego al limite de registros");
                        btnRegistrar.Enabled = false;
                        txtNumRepuesto.Enabled = false;
                        txtDescripcion.Enabled = false;
                        txtPrecio.Enabled = false;
                    }

                    txtNumRepuesto.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";


                }

               








            }
            else
            {
                MessageBox.Show("Complete correctamente los datos");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            

            if(cmbMarcaFiltro.Text.Length > 0 && (optNacional.Checked || optImportado.Checked))
            {
                
                marcaFiltro = cmbMarcaFiltro.Text;

                
                if (optNacional.Checked)
                {
                    origenFiltro = "N";
                } else
                {
                    origenFiltro = "I";
                }

                

                for (int i = 0; i < posicion; i++)
                {
                    if (repuestos[i].marca == marcaFiltro && repuestos[i].origen == origenFiltro)
                    {
                        dataGridView1.Rows.Add(repuestos[i].numeroRepuesto.ToString(),
                repuestos[i].marca, repuestos[i].origen, repuestos[i].descripcion,
                repuestos[i].precio.ToString());
                    }
                }

            }

           

        


            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
           



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTodos_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            for(int i = 0;i < posicion; i++)
            {
                dataGridView1.Rows.Add(repuestos[i].numeroRepuesto.ToString(),
               repuestos[i].marca, repuestos[i].origen, repuestos[i].descripcion,
               repuestos[i].precio.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
