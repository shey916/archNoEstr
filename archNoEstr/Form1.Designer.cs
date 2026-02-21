namespace archNoEstr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewArchivo = new System.Windows.Forms.ListView();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.groupBoxEdicion = new System.Windows.Forms.GroupBox();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxEdicion.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewArchivo
            // 
            this.listViewArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewArchivo.HideSelection = false;
            this.listViewArchivo.Location = new System.Drawing.Point(12, 12);
            this.listViewArchivo.Name = "listViewArchivo";
            this.listViewArchivo.Size = new System.Drawing.Size(760, 350);
            this.listViewArchivo.TabIndex = 0;
            this.listViewArchivo.UseCompatibleStateImageBehavior = false;
            this.listViewArchivo.SelectedIndexChanged += new System.EventHandler(this.listViewArchivo_SelectedIndexChanged);
            // 
            // txtContenido
            // 
            this.txtContenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContenido.Location = new System.Drawing.Point(9, 42);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(335, 60);
            this.txtContenido.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(335, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(15, 28);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(100, 35);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "1. Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(121, 28);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "2. Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(227, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "3. Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(333, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "4. Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "5. Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(121, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "6. Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(227, 69);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 35);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "7. Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(333, 69);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(100, 35);
            this.btnImportar.TabIndex = 10;
            this.btnImportar.Text = "8. Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(6, 22);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(158, 16);
            this.lblContenido.TabIndex = 11;
            this.lblContenido.Text = "Contenido de la línea:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(91, 16);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar texto:";
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOperaciones.Controls.Add(this.btnAbrir);
            this.groupBoxOperaciones.Controls.Add(this.btnModificar);
            this.groupBoxOperaciones.Controls.Add(this.btnAgregar);
            this.groupBoxOperaciones.Controls.Add(this.btnEliminar);
            this.groupBoxOperaciones.Controls.Add(this.btnGuardar);
            this.groupBoxOperaciones.Controls.Add(this.btnBuscar);
            this.groupBoxOperaciones.Controls.Add(this.btnExportar);
            this.groupBoxOperaciones.Controls.Add(this.btnImportar);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(12, 368);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(448, 115);
            this.groupBoxOperaciones.TabIndex = 13;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // groupBoxEdicion
            // 
            this.groupBoxEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEdicion.Controls.Add(this.lblContenido);
            this.groupBoxEdicion.Controls.Add(this.txtContenido);
            this.groupBoxEdicion.Location = new System.Drawing.Point(12, 489);
            this.groupBoxEdicion.Name = "groupBoxEdicion";
            this.groupBoxEdicion.Size = new System.Drawing.Size(760, 115);
            this.groupBoxEdicion.TabIndex = 14;
            this.groupBoxEdicion.TabStop = false;
            this.groupBoxEdicion.Text = "Edición";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusqueda.Controls.Add(this.lblBuscar);
            this.groupBoxBusqueda.Controls.Add(this.txtBuscar);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(466, 368);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(306, 115);
            this.groupBoxBusqueda.TabIndex = 15;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Búsqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 616);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.groupBoxEdicion);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.listViewArchivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 655);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Archivos No Estructurados";
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxEdicion.ResumeLayout(false);
            this.groupBoxEdicion.PerformLayout();
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewArchivo;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.GroupBox groupBoxEdicion;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
    }
}
