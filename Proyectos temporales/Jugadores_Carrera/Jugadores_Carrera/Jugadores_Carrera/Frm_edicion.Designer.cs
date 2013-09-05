namespace WindowsFormsApplication1
{
    partial class Frm_edicion
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.label_titulo = new System.Windows.Forms.Label();
            this.grp_criterio = new System.Windows.Forms.GroupBox();
            this.rdb_nombre = new System.Windows.Forms.RadioButton();
            this.rdb_direccion = new System.Windows.Forms.RadioButton();
            this.rdb_telefono = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.grp_criterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(28, 133);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(804, 315);
            this.grid1.TabIndex = 0;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(24, 31);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(197, 24);
            this.label_titulo.TabIndex = 6;
            this.label_titulo.Text = "Edicion de jugadores";
            // 
            // grp_criterio
            // 
            this.grp_criterio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_criterio.Controls.Add(this.rdb_nombre);
            this.grp_criterio.Controls.Add(this.rdb_direccion);
            this.grp_criterio.Controls.Add(this.rdb_telefono);
            this.grp_criterio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_criterio.Location = new System.Drawing.Point(28, 79);
            this.grp_criterio.Name = "grp_criterio";
            this.grp_criterio.Size = new System.Drawing.Size(312, 48);
            this.grp_criterio.TabIndex = 16;
            this.grp_criterio.TabStop = false;
            this.grp_criterio.Text = "Seleccione un criterio de orden";
            // 
            // rdb_nombre
            // 
            this.rdb_nombre.AutoSize = true;
            this.rdb_nombre.Location = new System.Drawing.Point(6, 20);
            this.rdb_nombre.Name = "rdb_nombre";
            this.rdb_nombre.Size = new System.Drawing.Size(70, 22);
            this.rdb_nombre.TabIndex = 11;
            this.rdb_nombre.TabStop = true;
            this.rdb_nombre.Text = "Nombre";
            this.rdb_nombre.UseVisualStyleBackColor = true;
            this.rdb_nombre.CheckedChanged += new System.EventHandler(this.rdb_nombre_CheckedChanged);
            // 
            // rdb_direccion
            // 
            this.rdb_direccion.AutoSize = true;
            this.rdb_direccion.Location = new System.Drawing.Point(164, 20);
            this.rdb_direccion.Name = "rdb_direccion";
            this.rdb_direccion.Size = new System.Drawing.Size(80, 22);
            this.rdb_direccion.TabIndex = 13;
            this.rdb_direccion.TabStop = true;
            this.rdb_direccion.Text = "Dirección";
            this.rdb_direccion.UseVisualStyleBackColor = true;
            this.rdb_direccion.CheckedChanged += new System.EventHandler(this.rdb_direccion_CheckedChanged);
            // 
            // rdb_telefono
            // 
            this.rdb_telefono.AutoSize = true;
            this.rdb_telefono.Location = new System.Drawing.Point(82, 20);
            this.rdb_telefono.Name = "rdb_telefono";
            this.rdb_telefono.Size = new System.Drawing.Size(76, 22);
            this.rdb_telefono.TabIndex = 12;
            this.rdb_telefono.TabStop = true;
            this.rdb_telefono.Text = "Teléfono";
            this.rdb_telefono.UseVisualStyleBackColor = true;
            this.rdb_telefono.CheckedChanged += new System.EventHandler(this.rdb_telefono_CheckedChanged);
            // 
            // Frm_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondodestas;
            this.ClientSize = new System.Drawing.Size(1011, 529);
            this.Controls.Add(this.grp_criterio);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.grid1);
            this.Name = "Frm_edicion";
            this.Text = "Frm_edicion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.grp_criterio.ResumeLayout(false);
            this.grp_criterio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.GroupBox grp_criterio;
        private System.Windows.Forms.RadioButton rdb_nombre;
        private System.Windows.Forms.RadioButton rdb_direccion;
        private System.Windows.Forms.RadioButton rdb_telefono;
    }
}