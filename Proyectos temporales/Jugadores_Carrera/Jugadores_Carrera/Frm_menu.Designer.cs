namespace WindowsFormsApplication1
{
    partial class Frm_menu_jugadores
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titulo = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_Insercion = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(342, 27);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(195, 24);
            this.label_titulo.TabIndex = 3;
            this.label_titulo.Text = "Modulo de jugadores";
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(57, 169);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(175, 63);
            this.btn_consulta.TabIndex = 4;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_Insercion
            // 
            this.btn_Insercion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insercion.Location = new System.Drawing.Point(346, 169);
            this.btn_Insercion.Name = "btn_Insercion";
            this.btn_Insercion.Size = new System.Drawing.Size(175, 63);
            this.btn_Insercion.TabIndex = 5;
            this.btn_Insercion.Text = "Inserción";
            this.btn_Insercion.UseVisualStyleBackColor = true;
            this.btn_Insercion.Click += new System.EventHandler(this.btn_Insercion_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(622, 169);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(175, 63);
            this.btn_Editar.TabIndex = 6;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Frm_menu_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondodestas;
            this.ClientSize = new System.Drawing.Size(867, 510);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Insercion);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.label_titulo);
            this.Name = "Frm_menu_jugadores";
            this.Text = "FRM_Menu_Jugadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_Insercion;
        private System.Windows.Forms.Button btn_Editar;

    }
}

