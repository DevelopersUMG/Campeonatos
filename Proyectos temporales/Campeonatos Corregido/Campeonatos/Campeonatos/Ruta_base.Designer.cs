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
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.Abrir_archivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(546, 151);
            this.btn_examinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(148, 40);
            this.btn_examinar.TabIndex = 9;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(50, 105);
            this.txt_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(644, 27);
            this.txt_path.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Específique la ruta donde se encuentra la base de datos";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(206, 220);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(148, 38);
            this.cancelar_btn.TabIndex = 10;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Location = new System.Drawing.Point(50, 220);
            this.guardar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(148, 38);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 553);
            this.ControlBox = false;
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ruta_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.OpenFileDialog Abrir_archivo;
    }
}