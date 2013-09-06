namespace Campeonatos
{
    partial class frm_insertar_jugador
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_jugador = new System.Windows.Forms.TextBox();
            this.txt_tel_jugador = new System.Windows.Forms.TextBox();
            this.txt_direccion_jugador = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.panel_insercion = new System.Windows.Forms.Panel();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.grp_criterio = new System.Windows.Forms.GroupBox();
            this.rdb_nombre = new System.Windows.Forms.RadioButton();
            this.rdb_direccion = new System.Windows.Forms.RadioButton();
            this.rdb_telefono = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.panel_insercion.SuspendLayout();
            this.grp_criterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(18, 31);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(176, 24);
            this.label_titulo.TabIndex = 5;
            this.label_titulo.Text = "Modulo  Jugadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Jugador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefono del Jugador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion del Jugador:";
            // 
            // txt_nombre_jugador
            // 
            this.txt_nombre_jugador.Location = new System.Drawing.Point(154, 9);
            this.txt_nombre_jugador.Name = "txt_nombre_jugador";
            this.txt_nombre_jugador.Size = new System.Drawing.Size(173, 20);
            this.txt_nombre_jugador.TabIndex = 9;
            // 
            // txt_tel_jugador
            // 
            this.txt_tel_jugador.Location = new System.Drawing.Point(154, 37);
            this.txt_tel_jugador.Name = "txt_tel_jugador";
            this.txt_tel_jugador.Size = new System.Drawing.Size(173, 20);
            this.txt_tel_jugador.TabIndex = 10;
            // 
            // txt_direccion_jugador
            // 
            this.txt_direccion_jugador.Location = new System.Drawing.Point(154, 66);
            this.txt_direccion_jugador.Name = "txt_direccion_jugador";
            this.txt_direccion_jugador.Size = new System.Drawing.Size(173, 20);
            this.txt_direccion_jugador.TabIndex = 11;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(333, 40);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 33);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(22, 85);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.Size = new System.Drawing.Size(821, 340);
            this.grid1.TabIndex = 13;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(721, 432);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(122, 32);
            this.btn_actualizar.TabIndex = 14;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // panel_insercion
            // 
            this.panel_insercion.BackColor = System.Drawing.Color.Transparent;
            this.panel_insercion.Controls.Add(this.label1);
            this.panel_insercion.Controls.Add(this.txt_nombre_jugador);
            this.panel_insercion.Controls.Add(this.label2);
            this.panel_insercion.Controls.Add(this.btn_guardar);
            this.panel_insercion.Controls.Add(this.txt_tel_jugador);
            this.panel_insercion.Controls.Add(this.label3);
            this.panel_insercion.Controls.Add(this.txt_direccion_jugador);
            this.panel_insercion.Location = new System.Drawing.Point(12, 435);
            this.panel_insercion.Name = "panel_insercion";
            this.panel_insercion.Size = new System.Drawing.Size(459, 116);
            this.panel_insercion.TabIndex = 15;
            this.panel_insercion.Visible = false;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.Location = new System.Drawing.Point(593, 432);
            this.btn_insertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(122, 32);
            this.btn_insertar.TabIndex = 16;
            this.btn_insertar.Text = "Insertar Jugador";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // grp_criterio
            // 
            this.grp_criterio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_criterio.Controls.Add(this.rdb_nombre);
            this.grp_criterio.Controls.Add(this.rdb_direccion);
            this.grp_criterio.Controls.Add(this.rdb_telefono);
            this.grp_criterio.Location = new System.Drawing.Point(525, 31);
            this.grp_criterio.Name = "grp_criterio";
            this.grp_criterio.Size = new System.Drawing.Size(312, 48);
            this.grp_criterio.TabIndex = 17;
            this.grp_criterio.TabStop = false;
            this.grp_criterio.Text = "Seleccione un criterio de orden";
            // 
            // rdb_nombre
            // 
            this.rdb_nombre.AutoSize = true;
            this.rdb_nombre.Location = new System.Drawing.Point(6, 20);
            this.rdb_nombre.Name = "rdb_nombre";
            this.rdb_nombre.Size = new System.Drawing.Size(62, 17);
            this.rdb_nombre.TabIndex = 11;
            this.rdb_nombre.TabStop = true;
            this.rdb_nombre.Text = "Nombre";
            this.rdb_nombre.UseVisualStyleBackColor = true;
            // 
            // rdb_direccion
            // 
            this.rdb_direccion.AutoSize = true;
            this.rdb_direccion.Location = new System.Drawing.Point(164, 20);
            this.rdb_direccion.Name = "rdb_direccion";
            this.rdb_direccion.Size = new System.Drawing.Size(70, 17);
            this.rdb_direccion.TabIndex = 13;
            this.rdb_direccion.TabStop = true;
            this.rdb_direccion.Text = "Dirección";
            this.rdb_direccion.UseVisualStyleBackColor = true;
            // 
            // rdb_telefono
            // 
            this.rdb_telefono.AutoSize = true;
            this.rdb_telefono.Location = new System.Drawing.Point(82, 20);
            this.rdb_telefono.Name = "rdb_telefono";
            this.rdb_telefono.Size = new System.Drawing.Size(67, 17);
            this.rdb_telefono.TabIndex = 12;
            this.rdb_telefono.TabStop = true;
            this.rdb_telefono.Text = "Teléfono";
            this.rdb_telefono.UseVisualStyleBackColor = true;
            // 
            // frm_insertar_jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.fondodestas;
            this.ClientSize = new System.Drawing.Size(867, 531);
            this.Controls.Add(this.grp_criterio);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.panel_insercion);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label_titulo);
            this.Name = "frm_insertar_jugador";
            this.ShowInTaskbar = false;
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.frm_insertar_jugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.panel_insercion.ResumeLayout(false);
            this.panel_insercion.PerformLayout();
            this.grp_criterio.ResumeLayout(false);
            this.grp_criterio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_jugador;
        private System.Windows.Forms.TextBox txt_tel_jugador;
        private System.Windows.Forms.TextBox txt_direccion_jugador;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Panel panel_insercion;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.GroupBox grp_criterio;
        private System.Windows.Forms.RadioButton rdb_nombre;
        private System.Windows.Forms.RadioButton rdb_direccion;
        private System.Windows.Forms.RadioButton rdb_telefono;
    }
}