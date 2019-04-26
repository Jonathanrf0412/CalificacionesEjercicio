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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalificaciones));
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.lblArchivoInfo = new System.Windows.Forms.Label();
            this.btnSelArchivo = new System.Windows.Forms.Button();
            this.ofdCargarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.lblMejorCal = new System.Windows.Forms.Label();
            this.grpbMejorCal = new System.Windows.Forms.GroupBox();
            this.grpbPeorCal = new System.Windows.Forms.GroupBox();
            this.lblPeorCal = new System.Windows.Forms.Label();
            this.grpbPromedio = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblNubes = new System.Windows.Forms.Label();
            this.lblMinMaxTemp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMejorGrupo = new System.Windows.Forms.Label();
            this.lblPeorGrupo = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecheNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAlumnos = new System.Windows.Forms.Label();
            this.timerActualizarClima = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.grpbMejorCal.SuspendLayout();
            this.grpbPeorCal.SuspendLayout();
            this.grpbPromedio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dgvInfo.Size = new System.Drawing.Size(661, 337);
            this.dgvInfo.TabIndex = 0;
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
            this.btnSelArchivo.Location = new System.Drawing.Point(363, 709);
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
            // lblMejorCal
            // 
            this.lblMejorCal.AutoSize = true;
            this.lblMejorCal.Location = new System.Drawing.Point(16, 33);
            this.lblMejorCal.Name = "lblMejorCal";
            this.lblMejorCal.Size = new System.Drawing.Size(0, 13);
            this.lblMejorCal.TabIndex = 4;
            // 
            // grpbMejorCal
            // 
            this.grpbMejorCal.BackColor = System.Drawing.Color.DimGray;
            this.grpbMejorCal.Controls.Add(this.lblMejorGrupo);
            this.grpbMejorCal.Controls.Add(this.lblMejorCal);
            this.grpbMejorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbMejorCal.ForeColor = System.Drawing.Color.White;
            this.grpbMejorCal.Location = new System.Drawing.Point(690, 127);
            this.grpbMejorCal.Name = "grpbMejorCal";
            this.grpbMejorCal.Size = new System.Drawing.Size(233, 75);
            this.grpbMejorCal.TabIndex = 5;
            this.grpbMejorCal.TabStop = false;
            this.grpbMejorCal.Text = "Mejor Calificación Global";
            // 
            // grpbPeorCal
            // 
            this.grpbPeorCal.BackColor = System.Drawing.Color.DimGray;
            this.grpbPeorCal.Controls.Add(this.lblPeorGrupo);
            this.grpbPeorCal.Controls.Add(this.lblPeorCal);
            this.grpbPeorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPeorCal.ForeColor = System.Drawing.Color.White;
            this.grpbPeorCal.Location = new System.Drawing.Point(690, 208);
            this.grpbPeorCal.Name = "grpbPeorCal";
            this.grpbPeorCal.Size = new System.Drawing.Size(233, 78);
            this.grpbPeorCal.TabIndex = 6;
            this.grpbPeorCal.TabStop = false;
            this.grpbPeorCal.Text = "Peor Calificación Global";
            // 
            // lblPeorCal
            // 
            this.lblPeorCal.AutoSize = true;
            this.lblPeorCal.Location = new System.Drawing.Point(16, 33);
            this.lblPeorCal.Name = "lblPeorCal";
            this.lblPeorCal.Size = new System.Drawing.Size(0, 13);
            this.lblPeorCal.TabIndex = 4;
            // 
            // grpbPromedio
            // 
            this.grpbPromedio.BackColor = System.Drawing.Color.DimGray;
            this.grpbPromedio.Controls.Add(this.lblTotalAlumnos);
            this.grpbPromedio.Controls.Add(this.lblPromedio);
            this.grpbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPromedio.ForeColor = System.Drawing.Color.White;
            this.grpbPromedio.Location = new System.Drawing.Point(690, 292);
            this.grpbPromedio.Name = "grpbPromedio";
            this.grpbPromedio.Size = new System.Drawing.Size(233, 84);
            this.grpbPromedio.TabIndex = 6;
            this.grpbPromedio.TabStop = false;
            this.grpbPromedio.Text = "Promedio Global";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(26, 38);
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
            this.lblFecha.Location = new System.Drawing.Point(10, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Ultima Actualizacion";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(117, 17);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(58, 29);
            this.lblTemperatura.TabIndex = 9;
            this.lblTemperatura.Text = "25.5";
            // 
            // lblNubes
            // 
            this.lblNubes.AutoSize = true;
            this.lblNubes.Location = new System.Drawing.Point(11, 45);
            this.lblNubes.Name = "lblNubes";
            this.lblNubes.Size = new System.Drawing.Size(43, 13);
            this.lblNubes.TabIndex = 10;
            this.lblNubes.Text = "Nubes";
            // 
            // lblMinMaxTemp
            // 
            this.lblMinMaxTemp.AutoSize = true;
            this.lblMinMaxTemp.Location = new System.Drawing.Point(88, 46);
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
            this.groupBox1.Size = new System.Drawing.Size(233, 91);
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
            chartArea5.Name = "AreaPrincipal";
            this.chartGrafico.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGrafico.Legends.Add(legend5);
            this.chartGrafico.Location = new System.Drawing.Point(12, 409);
            this.chartGrafico.Name = "chartGrafico";
            series5.ChartArea = "AreaPrincipal";
            series5.Legend = "Legend1";
            series5.Name = "Calificaciones";
            this.chartGrafico.Series.Add(series5);
            this.chartGrafico.Size = new System.Drawing.Size(911, 292);
            this.chartGrafico.TabIndex = 7;
            this.chartGrafico.Text = "Calificaciones";
            // 
            // lblMejorGrupo
            // 
            this.lblMejorGrupo.AutoSize = true;
            this.lblMejorGrupo.Location = new System.Drawing.Point(170, 33);
            this.lblMejorGrupo.Name = "lblMejorGrupo";
            this.lblMejorGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblMejorGrupo.TabIndex = 5;
            // 
            // lblPeorGrupo
            // 
            this.lblPeorGrupo.AutoSize = true;
            this.lblPeorGrupo.Location = new System.Drawing.Point(170, 33);
            this.lblPeorGrupo.Name = "lblPeorGrupo";
            this.lblPeorGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblPeorGrupo.TabIndex = 6;
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
            // lblTotalAlumnos
            // 
            this.lblTotalAlumnos.AutoSize = true;
            this.lblTotalAlumnos.Location = new System.Drawing.Point(96, 38);
            this.lblTotalAlumnos.Name = "lblTotalAlumnos";
            this.lblTotalAlumnos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAlumnos.TabIndex = 5;
            // 
            // timerActualizarClima
            // 
            this.timerActualizarClima.Interval = 60000;
            this.timerActualizarClima.Tick += new System.EventHandler(this.timerActualizarClima_Tick);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(935, 755);
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
            this.grpbMejorCal.PerformLayout();
            this.grpbPeorCal.ResumeLayout(false);
            this.grpbPeorCal.PerformLayout();
            this.grpbPromedio.ResumeLayout(false);
            this.grpbPromedio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lblArchivoInfo;
        private System.Windows.Forms.Button btnSelArchivo;
        private System.Windows.Forms.OpenFileDialog ofdCargarArchivo;
        private System.Windows.Forms.Label lblMejorCal;
        private System.Windows.Forms.GroupBox grpbMejorCal;
        private System.Windows.Forms.GroupBox grpbPeorCal;
        private System.Windows.Forms.Label lblPeorCal;
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
        private System.Windows.Forms.Label lblMejorGrupo;
        private System.Windows.Forms.Label lblPeorGrupo;
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
    }
}

