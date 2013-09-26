namespace Campeonatos
{
    partial class ficha_equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ficha_equipo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid_bd_jugadores = new System.Windows.Forms.DataGridView();
            this.grid_lista_jugadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.cerrar_ficha_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_encargado = new System.Windows.Forms.Label();
            this.Label_telefono = new System.Windows.Forms.Label();
            this.nuevo_jugador_btn = new System.Windows.Forms.Button();
            this.quitar_btn = new System.Windows.Forms.Button();
            this.buscar_jugador_btn = new System.Windows.Forms.Button();
            this.buscar_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bd_jugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Campeonatos.Properties.Resources.camisola;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grid_bd_jugadores
            // 
            this.grid_bd_jugadores.AllowUserToAddRows = false;
            this.grid_bd_jugadores.AllowUserToDeleteRows = false;
            this.grid_bd_jugadores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_bd_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_bd_jugadores.Location = new System.Drawing.Point(563, 226);
            this.grid_bd_jugadores.Name = "grid_bd_jugadores";
            this.grid_bd_jugadores.ReadOnly = true;
            this.grid_bd_jugadores.Size = new System.Drawing.Size(317, 309);
            this.grid_bd_jugadores.TabIndex = 1;
            this.grid_bd_jugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_bd_jugadores_CellContentClick);
            // 
            // grid_lista_jugadores
            // 
            this.grid_lista_jugadores.AllowUserToAddRows = false;
            this.grid_lista_jugadores.AllowUserToDeleteRows = false;
            this.grid_lista_jugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_lista_jugadores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_lista_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lista_jugadores.Location = new System.Drawing.Point(12, 226);
            this.grid_lista_jugadores.Name = "grid_lista_jugadores";
            this.grid_lista_jugadores.ReadOnly = true;
            this.grid_lista_jugadores.Size = new System.Drawing.Size(290, 309);
            this.grid_lista_jugadores.TabIndex = 2;
            this.grid_lista_jugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lista_jugadores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ficha De Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "BD de Jugadores";
            // 
            // agregar_btn
            // 
            this.agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.Location = new System.Drawing.Point(368, 304);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(111, 23);
            this.agregar_btn.TabIndex = 5;
            this.agregar_btn.Text = "<<<";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // cerrar_ficha_btn
            // 
            this.cerrar_ficha_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar_ficha_btn.Location = new System.Drawing.Point(368, 226);
            this.cerrar_ficha_btn.Name = "cerrar_ficha_btn";
            this.cerrar_ficha_btn.Size = new System.Drawing.Size(111, 58);
            this.cerrar_ficha_btn.TabIndex = 6;
            this.cerrar_ficha_btn.Text = "Cerrar Ficha";
            this.cerrar_ficha_btn.UseVisualStyleBackColor = true;
            this.cerrar_ficha_btn.Click += new System.EventHandler(this.button_crear_equipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre Equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de Jugadores";
            // 
            // label_encargado
            // 
            this.label_encargado.AutoSize = true;
            this.label_encargado.BackColor = System.Drawing.Color.Transparent;
            this.label_encargado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_encargado.Location = new System.Drawing.Point(13, 63);
            this.label_encargado.Name = "label_encargado";
            this.label_encargado.Size = new System.Drawing.Size(96, 22);
            this.label_encargado.TabIndex = 11;
            this.label_encargado.Text = "Encargado:";
            // 
            // Label_telefono
            // 
            this.Label_telefono.AutoSize = true;
            this.Label_telefono.BackColor = System.Drawing.Color.Transparent;
            this.Label_telefono.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_telefono.Location = new System.Drawing.Point(13, 101);
            this.Label_telefono.Name = "Label_telefono";
            this.Label_telefono.Size = new System.Drawing.Size(83, 22);
            this.Label_telefono.TabIndex = 13;
            this.Label_telefono.Text = "Telefono:";
            // 
            // nuevo_jugador_btn
            // 
            this.nuevo_jugador_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_jugador_btn.Location = new System.Drawing.Point(368, 376);
            this.nuevo_jugador_btn.Name = "nuevo_jugador_btn";
            this.nuevo_jugador_btn.Size = new System.Drawing.Size(111, 58);
            this.nuevo_jugador_btn.TabIndex = 14;
            this.nuevo_jugador_btn.Text = "Nuevo Jugador";
            this.nuevo_jugador_btn.UseVisualStyleBackColor = true;
            this.nuevo_jugador_btn.Click += new System.EventHandler(this.button_nuevo_jugador_Click);
            // 
            // quitar_btn
            // 
            this.quitar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitar_btn.Location = new System.Drawing.Point(368, 347);
            this.quitar_btn.Name = "quitar_btn";
            this.quitar_btn.Size = new System.Drawing.Size(111, 23);
            this.quitar_btn.TabIndex = 15;
            this.quitar_btn.Text = ">>>";
            this.quitar_btn.UseVisualStyleBackColor = true;
            this.quitar_btn.Click += new System.EventHandler(this.button_quitar_Click);
            this.quitar_btn.MouseHover += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buscar_jugador_btn
            // 
            this.buscar_jugador_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_jugador_btn.Location = new System.Drawing.Point(368, 449);
            this.buscar_jugador_btn.Name = "buscar_jugador_btn";
            this.buscar_jugador_btn.Size = new System.Drawing.Size(111, 33);
            this.buscar_jugador_btn.TabIndex = 16;
            this.buscar_jugador_btn.Text = "Buscar";
            this.buscar_jugador_btn.UseVisualStyleBackColor = true;
            this.buscar_jugador_btn.Visible = false;
            this.buscar_jugador_btn.Click += new System.EventHandler(this.button_buscar_jugador_Click);
            // 
            // buscar_buscar
            // 
            this.buscar_buscar.Location = new System.Drawing.Point(368, 488);
            this.buscar_buscar.Name = "buscar_buscar";
            this.buscar_buscar.Size = new System.Drawing.Size(111, 20);
            this.buscar_buscar.TabIndex = 17;
            this.buscar_buscar.Visible = false;
            this.buscar_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_buscar_KeyPress);
            this.buscar_buscar.Leave += new System.EventHandler(this.buscar_buscar_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 20;
            // 
            // ficha_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscar_buscar);
            this.Controls.Add(this.buscar_jugador_btn);
            this.Controls.Add(this.quitar_btn);
            this.Controls.Add(this.nuevo_jugador_btn);
            this.Controls.Add(this.Label_telefono);
            this.Controls.Add(this.label_encargado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cerrar_ficha_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_lista_jugadores);
            this.Controls.Add(this.grid_bd_jugadores);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ficha_equipo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bd_jugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grid_bd_jugadores;
        private System.Windows.Forms.DataGridView grid_lista_jugadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button cerrar_ficha_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_encargado;
        private System.Windows.Forms.Label Label_telefono;
        private System.Windows.Forms.Button nuevo_jugador_btn;
        private System.Windows.Forms.Button quitar_btn;
        private System.Windows.Forms.Button buscar_jugador_btn;
        private System.Windows.Forms.TextBox buscar_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

