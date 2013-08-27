namespace equipos
{
    partial class crear_equipo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bd_equipos_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.equipo_seleccionado_text = new System.Windows.Forms.TextBox();
            this.ver_jugadores_btn = new System.Windows.Forms.Button();
            this.nombre_equipo_text = new System.Windows.Forms.TextBox();
            this.encargado_text = new System.Windows.Forms.TextBox();
            this.telefono_text = new System.Windows.Forms.TextBox();
            this.Label_telefono = new System.Windows.Forms.Label();
            this.label_encargado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crear_equipo_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_equipos_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::equipos.Properties.Resources.camisola;
            this.pictureBox1.Location = new System.Drawing.Point(474, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Equipos";
            // 
            // bd_equipos_grid
            // 
            this.bd_equipos_grid.AllowUserToAddRows = false;
            this.bd_equipos_grid.AllowUserToDeleteRows = false;
            this.bd_equipos_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bd_equipos_grid.Location = new System.Drawing.Point(19, 287);
            this.bd_equipos_grid.Name = "bd_equipos_grid";
            this.bd_equipos_grid.ReadOnly = true;
            this.bd_equipos_grid.Size = new System.Drawing.Size(418, 246);
            this.bd_equipos_grid.TabIndex = 2;
            this.bd_equipos_grid.Click += new System.EventHandler(this.grid_bd_equipos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado de Equipos";
            // 
            // equipo_seleccionado_text
            // 
            this.equipo_seleccionado_text.BackColor = System.Drawing.Color.GreenYellow;
            this.equipo_seleccionado_text.Enabled = false;
            this.equipo_seleccionado_text.Location = new System.Drawing.Point(537, 251);
            this.equipo_seleccionado_text.Name = "equipo_seleccionado_text";
            this.equipo_seleccionado_text.Size = new System.Drawing.Size(100, 20);
            this.equipo_seleccionado_text.TabIndex = 4;
            // 
            // ver_jugadores_btn
            // 
            this.ver_jugadores_btn.Location = new System.Drawing.Point(537, 277);
            this.ver_jugadores_btn.Name = "ver_jugadores_btn";
            this.ver_jugadores_btn.Size = new System.Drawing.Size(153, 21);
            this.ver_jugadores_btn.TabIndex = 5;
            this.ver_jugadores_btn.Text = "Ver Jugadores";
            this.ver_jugadores_btn.UseVisualStyleBackColor = true;
            this.ver_jugadores_btn.Click += new System.EventHandler(this.button_ver_jugadores_Click);
            // 
            // nombre_equipo_text
            // 
            this.nombre_equipo_text.BackColor = System.Drawing.Color.GreenYellow;
            this.nombre_equipo_text.Location = new System.Drawing.Point(166, 88);
            this.nombre_equipo_text.Name = "nombre_equipo_text";
            this.nombre_equipo_text.Size = new System.Drawing.Size(100, 20);
            this.nombre_equipo_text.TabIndex = 6;
            // 
            // encargado_text
            // 
            this.encargado_text.BackColor = System.Drawing.Color.GreenYellow;
            this.encargado_text.Location = new System.Drawing.Point(166, 125);
            this.encargado_text.Name = "encargado_text";
            this.encargado_text.Size = new System.Drawing.Size(100, 20);
            this.encargado_text.TabIndex = 7;
            // 
            // telefono_text
            // 
            this.telefono_text.BackColor = System.Drawing.Color.GreenYellow;
            this.telefono_text.Location = new System.Drawing.Point(166, 172);
            this.telefono_text.Name = "telefono_text";
            this.telefono_text.Size = new System.Drawing.Size(100, 20);
            this.telefono_text.TabIndex = 8;
            // 
            // Label_telefono
            // 
            this.Label_telefono.AutoSize = true;
            this.Label_telefono.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_telefono.Location = new System.Drawing.Point(28, 160);
            this.Label_telefono.Name = "Label_telefono";
            this.Label_telefono.Size = new System.Drawing.Size(83, 22);
            this.Label_telefono.TabIndex = 16;
            this.Label_telefono.Text = "Telefono:";
            // 
            // label_encargado
            // 
            this.label_encargado.AutoSize = true;
            this.label_encargado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_encargado.Location = new System.Drawing.Point(28, 123);
            this.label_encargado.Name = "label_encargado";
            this.label_encargado.Size = new System.Drawing.Size(96, 22);
            this.label_encargado.TabIndex = 15;
            this.label_encargado.Text = "Encargado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre Equipo:";
            // 
            // crear_equipo_btn
            // 
            this.crear_equipo_btn.Location = new System.Drawing.Point(285, 89);
            this.crear_equipo_btn.Name = "crear_equipo_btn";
            this.crear_equipo_btn.Size = new System.Drawing.Size(110, 23);
            this.crear_equipo_btn.TabIndex = 17;
            this.crear_equipo_btn.Text = "Crear Equipo";
            this.crear_equipo_btn.UseVisualStyleBackColor = true;
            this.crear_equipo_btn.Click += new System.EventHandler(this.button_crear_equipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Equipo Seleccionado";
            // 
            // crear_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::equipos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crear_equipo_btn);
            this.Controls.Add(this.Label_telefono);
            this.Controls.Add(this.label_encargado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefono_text);
            this.Controls.Add(this.encargado_text);
            this.Controls.Add(this.nombre_equipo_text);
            this.Controls.Add(this.ver_jugadores_btn);
            this.Controls.Add(this.equipo_seleccionado_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bd_equipos_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "crear_equipo";
            this.Text = "crear_equipo";
            this.Load += new System.EventHandler(this.crear_equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_equipos_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bd_equipos_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox equipo_seleccionado_text;
        private System.Windows.Forms.Button ver_jugadores_btn;
        private System.Windows.Forms.TextBox nombre_equipo_text;
        private System.Windows.Forms.TextBox encargado_text;
        private System.Windows.Forms.TextBox telefono_text;
        private System.Windows.Forms.Label Label_telefono;
        private System.Windows.Forms.Label label_encargado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button crear_equipo_btn;
        private System.Windows.Forms.Label label4;
    }
}