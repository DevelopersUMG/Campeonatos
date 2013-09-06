namespace Campeonatos
{
    partial class Ruta_base
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
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.Abrir_archivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_examinar
            // 
            this.btn_examinar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar.Location = new System.Drawing.Point(614, 178);
            this.btn_examinar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(166, 47);
            this.btn_examinar.TabIndex = 9;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(56, 124);
            this.txt_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(724, 25);
            this.txt_path.TabIndex = 8;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(50, 81);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(408, 20);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Específique la ruta donde se encuentra la base de datos";
            this.lbl_titulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.Location = new System.Drawing.Point(232, 259);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(166, 45);
            this.cancelar_btn.TabIndex = 10;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.Location = new System.Drawing.Point(56, 259);
            this.guardar_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(166, 45);
            this.guardar_btn.TabIndex = 11;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // Abrir_archivo
            // 
            this.Abrir_archivo.FileName = "openFileDialog1";
            // 
            // Ruta_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 651);
            this.ControlBox = false;
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ruta_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.OpenFileDialog Abrir_archivo;
    }
}