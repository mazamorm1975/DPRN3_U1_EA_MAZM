
namespace DPRNIII_U1_EA_MAZM
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtLugarEvento = new System.Windows.Forms.TextBox();
            this.fechaReporte = new System.Windows.Forms.DateTimePicker();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblFolioSeguimiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentariosUnidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlacaUnidad = new System.Windows.Forms.TextBox();
            this.cboDron = new System.Windows.Forms.ComboBox();
            this.txtReporteFinal = new System.Windows.Forms.TextBox();
            this.txtOficialAsignado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDOperador = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCtroMonitoreo = new System.Windows.Forms.TextBox();
            this.txtNombreOperador = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboApoyo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.txtLugarEvento);
            this.groupBox1.Controls.Add(this.fechaReporte);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.lblFolioSeguimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro De Información General";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(151, 171);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(173, 20);
            this.txtFolio.TabIndex = 11;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "In  Progress",
            "Pendient",
            "Closed"});
            this.cboStatus.Location = new System.Drawing.Point(151, 133);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(173, 21);
            this.cboStatus.TabIndex = 10;
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.Location = new System.Drawing.Point(124, 97);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(200, 20);
            this.txtLugarEvento.TabIndex = 9;
            // 
            // fechaReporte
            // 
            this.fechaReporte.Location = new System.Drawing.Point(124, 64);
            this.fechaReporte.Name = "fechaReporte";
            this.fechaReporte.Size = new System.Drawing.Size(200, 20);
            this.fechaReporte.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(124, 29);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // lblFolioSeguimiento
            // 
            this.lblFolioSeguimiento.AutoSize = true;
            this.lblFolioSeguimiento.Location = new System.Drawing.Point(16, 174);
            this.lblFolioSeguimiento.Name = "lblFolioSeguimiento";
            this.lblFolioSeguimiento.Size = new System.Drawing.Size(107, 13);
            this.lblFolioSeguimiento.TabIndex = 5;
            this.lblFolioSeguimiento.Text = "Folio De Seguimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status De Seguimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lugar Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Y Fecha Evento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre_Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(330, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboApoyo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtComentariosUnidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPlacaUnidad);
            this.groupBox2.Controls.Add(this.cboDron);
            this.groupBox2.Controls.Add(this.txtReporteFinal);
            this.groupBox2.Controls.Add(this.txtOficialAsignado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 252);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Unidad De Apoyo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Comentarios";
            // 
            // txtComentariosUnidad
            // 
            this.txtComentariosUnidad.Location = new System.Drawing.Point(124, 97);
            this.txtComentariosUnidad.Name = "txtComentariosUnidad";
            this.txtComentariosUnidad.Size = new System.Drawing.Size(200, 20);
            this.txtComentariosUnidad.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Reporte Final";
            // 
            // txtPlacaUnidad
            // 
            this.txtPlacaUnidad.Location = new System.Drawing.Point(124, 168);
            this.txtPlacaUnidad.Name = "txtPlacaUnidad";
            this.txtPlacaUnidad.Size = new System.Drawing.Size(102, 20);
            this.txtPlacaUnidad.TabIndex = 11;
            // 
            // cboDron
            // 
            this.cboDron.FormattingEnabled = true;
            this.cboDron.Items.AddRange(new object[] {
            "AXS-14785",
            "AXS-14786",
            "AXS-14787",
            "AXS-14788",
            "AXS-14789",
            "AXS-14790",
            "AXS-14791",
            "AXS-14792",
            "AXS-14793",
            "AXS-14794",
            "AXS-14795",
            "AXS-14796",
            "AXS-14797",
            "AXS-14798",
            "AXS-14799",
            "AXS-14800",
            "AXS-14801",
            "AXS-14802",
            "AXS-14803",
            "AXS-14804",
            "AXS-14805",
            "AXS-14806",
            "AXS-14807",
            "AXS-14808",
            "AXS-14809",
            "AXS-14810",
            "AXS-14811",
            "AXS-14812",
            "AXS-14813",
            "AXS-14814",
            "AXS-14815",
            "AXS-14816",
            "AXS-14817",
            "AXS-14818",
            "AXS-14819",
            "AXS-14820",
            "AXS-14821",
            "AXS-14822",
            "AXS-14823",
            "AXS-14824",
            "AXS-14825",
            "AXS-14826",
            "AXS-14827",
            "AXS-14828",
            "AXS-14829",
            "AXS-14830",
            "AXS-14831",
            "AXS-14832",
            "AXS-14833",
            "AXS-14834",
            "AXS-14835",
            "AXS-14836",
            "AXS-14837",
            "AXS-14838",
            "AXS-14839",
            "AXS-14840",
            "AXS-14841",
            "AXS-14842",
            "AXS-14843",
            "AXS-14844",
            "AXS-14845",
            "AXS-14846",
            "AXS-14847",
            "AXS-14848",
            "AXS-14849",
            "AXS-14850",
            "AXS-14851",
            "AXS-14852",
            "AXS-14853",
            "AXS-14854",
            "AXS-14855",
            "AXS-14856",
            "AXS-14857",
            "AXS-14858",
            "AXS-14859",
            "AXS-14860",
            "AXS-14861",
            "AXS-14862",
            "AXS-14863",
            "AXS-14864",
            "AXS-14865",
            "AXS-14866",
            "AXS-14867",
            "AXS-14868",
            "AXS-14869",
            "AXS-14870",
            "AXS-14871",
            "AXS-14872",
            "AXS-14873",
            "AXS-14874",
            "AXS-14875",
            "AXS-14876",
            "AXS-14877",
            "AXS-14878",
            "AXS-14879",
            "AXS-14880",
            "AXS-14881",
            "AXS-14882",
            "AXS-14883",
            "AXS-14884",
            "AXS-14885",
            "AXS-14886",
            "AXS-14887",
            "AXS-14888",
            "AXS-14889",
            "AXS-14890",
            "AXS-14891",
            "AXS-14892",
            "AXS-14893",
            "AXS-14894",
            "AXS-14895",
            "AXS-14896",
            "AXS-14897",
            "AXS-14898",
            "AXS-14899",
            "AXS-14900",
            "AXS-14901",
            "AXS-14902",
            "AXS-14903",
            "AXS-14904",
            "AXS-14905",
            "AXS-14906",
            "AXS-14907",
            "AXS-14908",
            "AXS-14909",
            "AXS-14910",
            "AXS-14911",
            "AXS-14912",
            "AXS-14913",
            "AXS-14914",
            "AXS-14915",
            "AXS-14916",
            "AXS-14917",
            "AXS-14918",
            "AXS-14919",
            "AXS-14920",
            "AXS-14921",
            "AXS-14922",
            "AXS-14923",
            "AXS-14924",
            "AXS-14925",
            "AXS-14926",
            "AXS-14927",
            "AXS-14928",
            "AXS-14929",
            "AXS-14930",
            "AXS-14931",
            "AXS-14932",
            "AXS-14933",
            "AXS-14934",
            "AXS-14935"});
            this.cboDron.Location = new System.Drawing.Point(124, 133);
            this.cboDron.Name = "cboDron";
            this.cboDron.Size = new System.Drawing.Size(102, 21);
            this.cboDron.TabIndex = 10;
            // 
            // txtReporteFinal
            // 
            this.txtReporteFinal.Location = new System.Drawing.Point(124, 64);
            this.txtReporteFinal.Name = "txtReporteFinal";
            this.txtReporteFinal.Size = new System.Drawing.Size(200, 20);
            this.txtReporteFinal.TabIndex = 9;
            // 
            // txtOficialAsignado
            // 
            this.txtOficialAsignado.Location = new System.Drawing.Point(124, 29);
            this.txtOficialAsignado.Name = "txtOficialAsignado";
            this.txtOficialAsignado.Size = new System.Drawing.Size(200, 20);
            this.txtOficialAsignado.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Placa Unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "No. Dron";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre_Oficial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIDOperador);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtCtroMonitoreo);
            this.groupBox3.Controls.Add(this.txtNombreOperador);
            this.groupBox3.Location = new System.Drawing.Point(693, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 218);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operador_Receptor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id";
            // 
            // txtIDOperador
            // 
            this.txtIDOperador.Location = new System.Drawing.Point(124, 97);
            this.txtIDOperador.Name = "txtIDOperador";
            this.txtIDOperador.Size = new System.Drawing.Size(200, 20);
            this.txtIDOperador.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Centro Monitoreo";
            // 
            // txtCtroMonitoreo
            // 
            this.txtCtroMonitoreo.Location = new System.Drawing.Point(124, 64);
            this.txtCtroMonitoreo.Name = "txtCtroMonitoreo";
            this.txtCtroMonitoreo.Size = new System.Drawing.Size(200, 20);
            this.txtCtroMonitoreo.TabIndex = 9;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Location = new System.Drawing.Point(124, 29);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Size = new System.Drawing.Size(200, 20);
            this.txtNombreOperador.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nombre_Operador";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Apoyo Requerido";
            // 
            // cboApoyo
            // 
            this.cboApoyo.FormattingEnabled = true;
            this.cboApoyo.Items.AddRange(new object[] {
            "Ambulancia",
            "Helicoptero",
            "Patrulla"});
            this.cboApoyo.Location = new System.Drawing.Point(124, 205);
            this.cboApoyo.Name = "cboApoyo";
            this.cboApoyo.Size = new System.Drawing.Size(121, 21);
            this.cboApoyo.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 276);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "SISTEMA DE SALVAMENTO CETRAM 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolioSeguimiento;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.DateTimePicker fechaReporte;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtLugarEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlacaUnidad;
        private System.Windows.Forms.ComboBox cboDron;
        private System.Windows.Forms.TextBox txtReporteFinal;
        private System.Windows.Forms.TextBox txtOficialAsignado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentariosUnidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDOperador;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCtroMonitoreo;
        private System.Windows.Forms.TextBox txtNombreOperador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboApoyo;
        private System.Windows.Forms.Label label13;
    }
}