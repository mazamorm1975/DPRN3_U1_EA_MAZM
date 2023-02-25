using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace DPRNIII_U1_EA_MAZM
{
   
    public partial class Form2 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaSeleccionadas = 0;
        Double LatInicial;
        Double LngInicial;

        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(20.90500300, -89.467163085);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            
            LatInicial = Convert.ToDouble(txtLatitud.Text);
            LngInicial = Convert.ToDouble(txtLongitud.Text);
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Se implementa un marcador para verificar la zona del siniestro
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicacion Del Reporte: \n Latitud:{0} \n Longitud{1}", LatInicial, LngInicial);

            //Se agrega el overlay al mapa
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LatInicial = 19.28488;
            LngInicial = -99.14264;
            Double Latfinal = Convert.ToDouble(txtLatitud.Text);
            Double LngFinal = Convert.ToDouble(txtLongitud.Text);
            
                                 
            double distancia = GeoLocation.DistanceTo(LatInicial, LngInicial, Latfinal, LngFinal, 'K');
            DateTime fecha = GeoLocation.AjusteDeTiempo(Convert.ToInt32(cboAnio.SelectedItem),
                Convert.ToInt32(cboMes.SelectedItem),
                Convert.ToInt32(cboDia.SelectedItem),
                Convert.ToInt32(cboHora.SelectedItem),
                Convert.ToInt32(cboMin.SelectedItem), distancia);
            txtTiempo.Text = fecha.ToString("yyyy-MM-dd HH:mm");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            salvarInformacion guardar = new salvarInformacion();
            guardar.insertarInformacionEvento(txtEvento.Text, txtApoyo.Text, txtLatitud.Text, txtLongitud.Text, txtComentarios.Text);
            
            //Se redirige al formulario 3 para guardar información del usuario
            Form3 guardarDatos = new Form3();
            guardarDatos.Show();
           
        }
    }
}
