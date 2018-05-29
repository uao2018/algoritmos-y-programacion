namespace GUIPractica3
{
    partial class frPrincipal
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
            this.btIniciar = new System.Windows.Forms.Button();
            this.btLeer = new System.Windows.Forms.Button();
            this.btProcesar = new System.Windows.Forms.Button();
            this.btReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(64, 130);
            this.btIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(134, 36);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(277, 136);
            this.btLeer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(138, 40);
            this.btLeer.TabIndex = 1;
            this.btLeer.Text = "Leer";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // btProcesar
            // 
            this.btProcesar.Location = new System.Drawing.Point(63, 206);
            this.btProcesar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btProcesar.Name = "btProcesar";
            this.btProcesar.Size = new System.Drawing.Size(135, 32);
            this.btProcesar.TabIndex = 2;
            this.btProcesar.Text = "Procesar";
            this.btProcesar.UseVisualStyleBackColor = true;
            this.btProcesar.Click += new System.EventHandler(this.btProcesar_Click);
            // 
            // btReporte
            // 
            this.btReporte.Location = new System.Drawing.Point(277, 199);
            this.btReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReporte.Name = "btReporte";
            this.btReporte.Size = new System.Drawing.Size(149, 40);
            this.btReporte.TabIndex = 3;
            this.btReporte.Text = "Reporte";
            this.btReporte.UseVisualStyleBackColor = true;
            this.btReporte.Click += new System.EventHandler(this.btReporte_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 274);
            this.Controls.Add(this.btReporte);
            this.Controls.Add(this.btProcesar);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.btIniciar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btLeer;
        private System.Windows.Forms.Button btProcesar;
        private System.Windows.Forms.Button btReporte;
    }
}

