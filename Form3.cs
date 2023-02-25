using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRNIII_U1_EA_MAZM
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            lblFolioSeguimiento.Visible = false;
            txtFolio.Visible = false;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblFolioSeguimiento.Visible = true;
            txtFolio.Visible = true;
            
            Form2 componentes = new Form2();
            Random folioReporte = new Random();
            int folio = folioReporte.Next(1500, 1900);
            txtFolio.Text = Convert.ToString(folio);
            salvarInformacion guardarDatosUsuario = new salvarInformacion();
            guardarDatosUsuario.insertarInformacionUsuario(txtNombreUsuario.Text, fechaReporte.Value, txtLugarEvento.Text, cboStatus.SelectedItem, txtFolio.Text);
            guardarDatosUsuario.insertarInformacionUnidad(cboApoyo.SelectedItem, fechaReporte.Value, txtReporteFinal.Text, txtComentariosUnidad.Text, cboDron.SelectedItem, txtPlacaUnidad.Text, txtOficialAsignado.Text);
            guardarDatosUsuario.insertarInformacionOperador(txtNombreOperador.Text, txtCtroMonitoreo.Text, txtIDOperador.Text, txtReporteFinal.Text, txtComentariosUnidad.Text, txtFolio.Text);

            this.Close();
        }

      
    }
}
