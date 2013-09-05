namespace WindowsFormsApplication1
{
    partial class Frm_consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_titulo = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.grp_criterio = new System.Windows.Forms.GroupBox();
            this.rdb_nombre = new System.Windows.Forms.RadioButton();
            this.rdb_direccion = new System.Windows.Forms.RadioButton();
            this.rdb_telefono = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.grp_criterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(14, 12);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(208, 24);
            this.label_titulo.TabIndex = 4;
            this.label_titulo.Text = "Consulta de jugadores";
            // 
            // grid1
            // 
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid1.Location = new System.Drawing.Point(19, 112);
            this.grid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(815, 315);
            this.grid1.TabIndex = 5;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(747, 435);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(87, 32);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_criterio
            // 
            this.grp_criterio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_criterio.Controls.Add(this.rdb_nombre);
            this.grp_criterio.Controls.Add(this.rdb_direccion);
            this.grp_criterio.Controls.Add(this.rdb_telefono);
            this.grp_criterio.Location = new System.Drawing.Point(18, 57);
            this.grp_criterio.Name = "grp_criterio";
            this.grp_criterio.Size = new System.Drawing.Size(312, 48);
            this.grp_criterio.TabIndex = 15;
            this.grp_criterio.TabStop = false;
            this.grp_criterio.Text = "Seleccione un criterio de orden";
           // this.grp_criterio.Enter += new System.EventHandler(this.grp_criterio_Enter);
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
            // Frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondodestas;
            this.ClientSize = new System.Drawing.Size(1011, 529);
            this.Controls.Add(this.grp_criterio);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label_titulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_consulta";
            this.Text = "Frm_Consulta_Jugador";
            this.Load += new System.EventHandler(this.Frm_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.grp_criterio.ResumeLayout(false);
            this.grp_criterio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox grp_criterio;
        private System.Windows.Forms.RadioButton rdb_nombre;
        private System.Windows.Forms.RadioButton rdb_direccion;
        private System.Windows.Forms.RadioButton rdb_telefono;
    }
}