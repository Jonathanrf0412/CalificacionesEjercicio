namespace CalificacionesEjercicio
{
    partial class frmCalificaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalificaciones));
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecheNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblArchivoInfo = new System.Windows.Forms.Label();
            this.btnSelArchivo = new System.Windows.Forms.Button();
            this.ofdCargarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.grpbMejorCal = new System.Windows.Forms.GroupBox();
            this.grpbPeorCal = new System.Windows.Forms.GroupBox();
            this.grpbPromedio = new System.Windows.Forms.GroupBox();
            this.lblTotalAlumnos = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblNubes = new System.Windows.Forms.Label();
            this.lblMinMaxTemp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerActualizarClima = new System.Windows.Forms.Timer(this.components);
            this.dgvPeorCalificacion = new System.Windows.Forms.DataGridView();
            this.dgvMejorCalificacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradoYGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbPromedioPorGrupo = new System.Windows.Forms.GroupBox();
            this.dgvPromedios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.grpbMejorCal.SuspendLayout();
            this.grpbPeorCal.SuspendLayout();
            this.grpbPromedio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeorCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMejorCalificacion)).BeginInit();
            this.grpbPromedioPorGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.ApellidoM,
            this.ApellidoP,
            this.FecheNacimiento,
            this.Grado,
            this.Grupo,
            this.Calificacion,
            this.Clave});
            this.dgvInfo.EnableHeadersVisualStyles = false;
            this.dgvInfo.Location = new System.Drawing.Point(12, 39);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo.Size = new System.Drawing.Size(661, 441);
            this.dgvInfo.TabIndex = 0;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 88;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "Apellido Materno";
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "Apellido Paterno";
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            // 
            // FecheNacimiento
            // 
            this.FecheNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FecheNacimiento.Name = "FecheNacimiento";
            this.FecheNacimiento.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 50;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 50;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            this.Calificacion.Width = 90;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 80;
            // 
            // lblArchivoInfo
            // 
            this.lblArchivoInfo.AutoSize = true;
            this.lblArchivoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoInfo.ForeColor = System.Drawing.Color.White;
            this.lblArchivoInfo.Location = new System.Drawing.Point(12, 19);
            this.lblArchivoInfo.Name = "lblArchivoInfo";
            this.lblArchivoInfo.Size = new System.Drawing.Size(144, 13);
            this.lblArchivoInfo.TabIndex = 1;
            this.lblArchivoInfo.Text = "Información del archivo:";
            // 
            // btnSelArchivo
            // 
            this.btnSelArchivo.BackColor = System.Drawing.Color.DarkGray;
            this.btnSelArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSelArchivo.Location = new System.Drawing.Point(394, 799);
            this.btnSelArchivo.Name = "btnSelArchivo";
            this.btnSelArchivo.Size = new System.Drawing.Size(218, 36);
            this.btnSelArchivo.TabIndex = 3;
            this.btnSelArchivo.Text = "Seleccionar Archivo...";
            this.btnSelArchivo.UseVisualStyleBackColor = false;
            this.btnSelArchivo.Click += new System.EventHandler(this.btnSelArchivo_Click);
            // 
            // ofdCargarArchivo
            // 
            this.ofdCargarArchivo.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            // 
            // grpbMejorCal
            // 
            this.grpbMejorCal.BackColor = System.Drawing.Color.DimGray;
            this.grpbMejorCal.Controls.Add(this.dgvMejorCalificacion);
            this.grpbMejorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbMejorCal.ForeColor = System.Drawing.Color.White;
            this.grpbMejorCal.Location = new System.Drawing.Point(690, 172);
            this.grpbMejorCal.Name = "grpbMejorCal";
            this.grpbMejorCal.Size = new System.Drawing.Size(276, 115);
            this.grpbMejorCal.TabIndex = 5;
            this.grpbMejorCal.TabStop = false;
            this.grpbMejorCal.Text = "Mejor Calificación Global";
            // 
            // grpbPeorCal
            // 
            this.grpbPeorCal.BackColor = System.Drawing.Color.DimGray;
            this.grpbPeorCal.Controls.Add(this.dgvPeorCalificacion);
            this.grpbPeorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPeorCal.ForeColor = System.Drawing.Color.White;
            this.grpbPeorCal.Location = new System.Drawing.Point(690, 296);
            this.grpbPeorCal.Name = "grpbPeorCal";
            this.grpbPeorCal.Size = new System.Drawing.Size(276, 115);
            this.grpbPeorCal.TabIndex = 6;
            this.grpbPeorCal.TabStop = false;
            this.grpbPeorCal.Text = "Peor Calificación Global";
            // 
            // grpbPromedio
            // 
            this.grpbPromedio.BackColor = System.Drawing.Color.DimGray;
            this.grpbPromedio.Controls.Add(this.lblTotalAlumnos);
            this.grpbPromedio.Controls.Add(this.lblPromedio);
            this.grpbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPromedio.ForeColor = System.Drawing.Color.White;
            this.grpbPromedio.Location = new System.Drawing.Point(690, 422);
            this.grpbPromedio.Name = "grpbPromedio";
            this.grpbPromedio.Size = new System.Drawing.Size(276, 58);
            this.grpbPromedio.TabIndex = 6;
            this.grpbPromedio.TabStop = false;
            this.grpbPromedio.Text = "Promedio Global";
            // 
            // lblTotalAlumnos
            // 
            this.lblTotalAlumnos.AutoSize = true;
            this.lblTotalAlumnos.Location = new System.Drawing.Point(96, 28);
            this.lblTotalAlumnos.Name = "lblTotalAlumnos";
            this.lblTotalAlumnos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAlumnos.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(26, 28);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 13);
            this.lblPromedio.TabIndex = 4;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(10, 22);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(10, 94);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Ultima Actualizacion";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(171, 24);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(58, 29);
            this.lblTemperatura.TabIndex = 9;
            this.lblTemperatura.Text = "25.5";
            // 
            // lblNubes
            // 
            this.lblNubes.AutoSize = true;
            this.lblNubes.Location = new System.Drawing.Point(10, 44);
            this.lblNubes.Name = "lblNubes";
            this.lblNubes.Size = new System.Drawing.Size(43, 13);
            this.lblNubes.TabIndex = 10;
            this.lblNubes.Text = "Nubes";
            // 
            // lblMinMaxTemp
            // 
            this.lblMinMaxTemp.AutoSize = true;
            this.lblMinMaxTemp.Location = new System.Drawing.Point(10, 69);
            this.lblMinMaxTemp.Name = "lblMinMaxTemp";
            this.lblMinMaxTemp.Size = new System.Drawing.Size(92, 13);
            this.lblMinMaxTemp.TabIndex = 11;
            this.lblMinMaxTemp.Text = "Minima Maxima";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMinMaxTemp);
            this.groupBox1.Controls.Add(this.lblNubes);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.lblTemperatura);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(690, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clima Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // chartGrafico
            // 
            chartArea1.Name = "AreaPrincipal";
            this.chartGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrafico.Legends.Add(legend1);
            this.chartGrafico.Location = new System.Drawing.Point(12, 499);
            this.chartGrafico.Name = "chartGrafico";
            series1.ChartArea = "AreaPrincipal";
            series1.Legend = "Legend1";
            series1.Name = "Calificaciones";
            this.chartGrafico.Series.Add(series1);
            this.chartGrafico.Size = new System.Drawing.Size(661, 292);
            this.chartGrafico.TabIndex = 7;
            this.chartGrafico.Text = "Calificaciones";
            // 
            // timerActualizarClima
            // 
            this.timerActualizarClima.Interval = 60000;
            this.timerActualizarClima.Tick += new System.EventHandler(this.timerActualizarClima_Tick);
            // 
            // dgvPeorCalificacion
            // 
            this.dgvPeorCalificacion.AllowUserToAddRows = false;
            this.dgvPeorCalificacion.AllowUserToDeleteRows = false;
            this.dgvPeorCalificacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeorCalificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeorCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeorCalificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeorCalificacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPeorCalificacion.EnableHeadersVisualStyles = false;
            this.dgvPeorCalificacion.Location = new System.Drawing.Point(6, 18);
            this.dgvPeorCalificacion.Name = "dgvPeorCalificacion";
            this.dgvPeorCalificacion.RowHeadersVisible = false;
            this.dgvPeorCalificacion.Size = new System.Drawing.Size(264, 90);
            this.dgvPeorCalificacion.TabIndex = 8;
            // 
            // dgvMejorCalificacion
            // 
            this.dgvMejorCalificacion.AllowUserToAddRows = false;
            this.dgvMejorCalificacion.AllowUserToDeleteRows = false;
            this.dgvMejorCalificacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMejorCalificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMejorCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMejorCalificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.GradoYGrupo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMejorCalificacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMejorCalificacion.EnableHeadersVisualStyles = false;
            this.dgvMejorCalificacion.Location = new System.Drawing.Point(6, 17);
            this.dgvMejorCalificacion.Name = "dgvMejorCalificacion";
            this.dgvMejorCalificacion.RowHeadersVisible = false;
            this.dgvMejorCalificacion.Size = new System.Drawing.Size(264, 90);
            this.dgvMejorCalificacion.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Cal.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cal.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // GradoYGrupo
            // 
            this.GradoYGrupo.HeaderText = "Grupo";
            this.GradoYGrupo.Name = "GradoYGrupo";
            this.GradoYGrupo.ReadOnly = true;
            this.GradoYGrupo.Width = 60;
            // 
            // grpbPromedioPorGrupo
            // 
            this.grpbPromedioPorGrupo.BackColor = System.Drawing.Color.DimGray;
            this.grpbPromedioPorGrupo.Controls.Add(this.dgvPromedios);
            this.grpbPromedioPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPromedioPorGrupo.ForeColor = System.Drawing.Color.White;
            this.grpbPromedioPorGrupo.Location = new System.Drawing.Point(690, 493);
            this.grpbPromedioPorGrupo.Name = "grpbPromedioPorGrupo";
            this.grpbPromedioPorGrupo.Size = new System.Drawing.Size(276, 298);
            this.grpbPromedioPorGrupo.TabIndex = 7;
            this.grpbPromedioPorGrupo.TabStop = false;
            this.grpbPromedioPorGrupo.Text = "Promedio por Grupos";
            // 
            // dgvPromedios
            // 
            this.dgvPromedios.AllowUserToAddRows = false;
            this.dgvPromedios.AllowUserToDeleteRows = false;
            this.dgvPromedios.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.NumeroDeAlumnos,
            this.Promedio});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromedios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPromedios.EnableHeadersVisualStyles = false;
            this.dgvPromedios.Location = new System.Drawing.Point(6, 19);
            this.dgvPromedios.Name = "dgvPromedios";
            this.dgvPromedios.RowHeadersVisible = false;
            this.dgvPromedios.Size = new System.Drawing.Size(264, 273);
            this.dgvPromedios.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 65;
            // 
            // NumeroDeAlumnos
            // 
            this.NumeroDeAlumnos.HeaderText = "# de Alumnos";
            this.NumeroDeAlumnos.Name = "NumeroDeAlumnos";
            this.NumeroDeAlumnos.ReadOnly = true;
            this.NumeroDeAlumnos.Width = 120;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 75;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(978, 843);
            this.Controls.Add(this.grpbPromedioPorGrupo);
            this.Controls.Add(this.chartGrafico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbPromedio);
            this.Controls.Add(this.grpbPeorCal);
            this.Controls.Add(this.grpbMejorCal);
            this.Controls.Add(this.btnSelArchivo);
            this.Controls.Add(this.lblArchivoInfo);
            this.Controls.Add(this.dgvInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalificaciones";
            this.Text = "Ejercicio Conduent";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.grpbMejorCal.ResumeLayout(false);
            this.grpbPeorCal.ResumeLayout(false);
            this.grpbPromedio.ResumeLayout(false);
            this.grpbPromedio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeorCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMejorCalificacion)).EndInit();
            this.grpbPromedioPorGrupo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lblArchivoInfo;
        private System.Windows.Forms.Button btnSelArchivo;
        private System.Windows.Forms.OpenFileDialog ofdCargarArchivo;
        private System.Windows.Forms.GroupBox grpbMejorCal;
        private System.Windows.Forms.GroupBox grpbPeorCal;
        private System.Windows.Forms.GroupBox grpbPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblNubes;
        private System.Windows.Forms.Label lblMinMaxTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecheNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.Label lblTotalAlumnos;
        private System.Windows.Forms.Timer timerActualizarClima;
        private System.Windows.Forms.DataGridView dgvMejorCalificacion;
        private System.Windows.Forms.DataGridView dgvPeorCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoYGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox grpbPromedioPorGrupo;
        private System.Windows.Forms.DataGridView dgvPromedios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}

