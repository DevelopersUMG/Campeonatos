namespace Campeonatos
{
    partial class Configuración
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
            this.tab_configuraciones = new System.Windows.Forms.TabControl();
            this.tab_bienvenida = new System.Windows.Forms.TabPage();
            this.btn_sig_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_administrador = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar_admin = new System.Windows.Forms.Button();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.lbl_pass2_admin = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass_admin = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario_admin = new System.Windows.Forms.Label();
            this.lbl_titulo_admin = new System.Windows.Forms.Label();
            this.tab_basededatos = new System.Windows.Forms.TabPage();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sig_3 = new System.Windows.Forms.Button();
            this.tab_empresa = new System.Windows.Forms.TabPage();
            this.btn_examinar_logo = new System.Windows.Forms.Button();
            this.txt_logotipo = new System.Windows.Forms.TextBox();
            this.txt_direccion_emp = new System.Windows.Forms.TextBox();
            this.txt_nombre_emp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.Abrir_archivo = new System.Windows.Forms.OpenFileDialog();
            this.tab_configuraciones.SuspendLayout();
            this.tab_bienvenida.SuspendLayout();
            this.tab_administrador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_basededatos.SuspendLayout();
            this.tab_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_configuraciones
            // 
            this.tab_configuraciones.Controls.Add(this.tab_bienvenida);
            this.tab_configuraciones.Controls.Add(this.tab_administrador);
            this.tab_configuraciones.Controls.Add(this.tab_basededatos);
            this.tab_configuraciones.Controls.Add(this.tab_empresa);
            this.tab_configuraciones.Location = new System.Drawing.Point(0, -1);
            this.tab_configuraciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_configuraciones.Name = "tab_configuraciones";
            this.tab_configuraciones.SelectedIndex = 0;
            this.tab_configuraciones.Size = new System.Drawing.Size(475, 462);
            this.tab_configuraciones.TabIndex = 0;
            // 
            // tab_bienvenida
            // 
            this.tab_bienvenida.BackgroundImage = global::Campeonatos.Properties.Resources._1600_1200_201006100948001125787;
            this.tab_bienvenida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_bienvenida.Controls.Add(this.btn_sig_1);
            this.tab_bienvenida.Controls.Add(this.label1);
            this.tab_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_bienvenida.Location = new System.Drawing.Point(4, 25);
            this.tab_bienvenida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_bienvenida.Name = "tab_bienvenida";
            this.tab_bienvenida.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_bienvenida.Size = new System.Drawing.Size(467, 433);
            this.tab_bienvenida.TabIndex = 0;
            this.tab_bienvenida.Text = "Bienvenida";
            this.tab_bienvenida.UseVisualStyleBackColor = true;
            // 
            // btn_sig_1
            // 
            this.btn_sig_1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sig_1.Location = new System.Drawing.Point(357, 377);
            this.btn_sig_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sig_1.Name = "btn_sig_1";
            this.btn_sig_1.Size = new System.Drawing.Size(106, 42);
            this.btn_sig_1.TabIndex = 1;
            this.btn_sig_1.Text = "Siguiente >>";
            this.btn_sig_1.UseVisualStyleBackColor = true;
            this.btn_sig_1.Click += new System.EventHandler(this.btn_sig_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // tab_administrador
            // 
            this.tab_administrador.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.tab_administrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_administrador.Controls.Add(this.groupBox1);
            this.tab_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_administrador.Location = new System.Drawing.Point(4, 22);
            this.tab_administrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_administrador.Name = "tab_administrador";
            this.tab_administrador.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_administrador.Size = new System.Drawing.Size(467, 436);
            this.tab_administrador.TabIndex = 1;
            this.tab_administrador.Text = "Administrador";
            this.tab_administrador.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar_admin);
            this.groupBox1.Controls.Add(this.txt_pass2);
            this.groupBox1.Controls.Add(this.lbl_pass2_admin);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.lbl_pass_admin);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.lbl_usuario_admin);
            this.groupBox1.Controls.Add(this.lbl_titulo_admin);
            this.groupBox1.Location = new System.Drawing.Point(5, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_guardar_admin
            // 
            this.btn_guardar_admin.Location = new System.Drawing.Point(338, 254);
            this.btn_guardar_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar_admin.Name = "btn_guardar_admin";
            this.btn_guardar_admin.Size = new System.Drawing.Size(111, 36);
            this.btn_guardar_admin.TabIndex = 7;
            this.btn_guardar_admin.Text = "Guardar";
            this.btn_guardar_admin.UseVisualStyleBackColor = true;
            this.btn_guardar_admin.Click += new System.EventHandler(this.btn_guardar_admin_Click);
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(10, 207);
            this.txt_pass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '*';
            this.txt_pass2.Size = new System.Drawing.Size(440, 26);
            this.txt_pass2.TabIndex = 6;
            // 
            // lbl_pass2_admin
            // 
            this.lbl_pass2_admin.AutoSize = true;
            this.lbl_pass2_admin.Location = new System.Drawing.Point(6, 178);
            this.lbl_pass2_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass2_admin.Name = "lbl_pass2_admin";
            this.lbl_pass2_admin.Size = new System.Drawing.Size(161, 20);
            this.lbl_pass2_admin.TabIndex = 5;
            this.lbl_pass2_admin.Text = "Confirme contraseña:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(10, 146);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(440, 26);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_pass_admin
            // 
            this.lbl_pass_admin.AutoSize = true;
            this.lbl_pass_admin.Location = new System.Drawing.Point(6, 114);
            this.lbl_pass_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass_admin.Name = "lbl_pass_admin";
            this.lbl_pass_admin.Size = new System.Drawing.Size(96, 20);
            this.lbl_pass_admin.TabIndex = 3;
            this.lbl_pass_admin.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(10, 82);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(440, 26);
            this.txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario_admin
            // 
            this.lbl_usuario_admin.AutoSize = true;
            this.lbl_usuario_admin.Location = new System.Drawing.Point(6, 54);
            this.lbl_usuario_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario_admin.Name = "lbl_usuario_admin";
            this.lbl_usuario_admin.Size = new System.Drawing.Size(64, 20);
            this.lbl_usuario_admin.TabIndex = 1;
            this.lbl_usuario_admin.Text = "Usuario";
            // 
            // lbl_titulo_admin
            // 
            this.lbl_titulo_admin.AutoSize = true;
            this.lbl_titulo_admin.Location = new System.Drawing.Point(6, 18);
            this.lbl_titulo_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo_admin.Name = "lbl_titulo_admin";
            this.lbl_titulo_admin.Size = new System.Drawing.Size(382, 20);
            this.lbl_titulo_admin.TabIndex = 0;
            this.lbl_titulo_admin.Text = "Establezca su usuario y contraseña de administrador";
            // 
            // tab_basededatos
            // 
            this.tab_basededatos.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.tab_basededatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_basededatos.Controls.Add(this.btn_examinar);
            this.tab_basededatos.Controls.Add(this.txt_path);
            this.tab_basededatos.Controls.Add(this.label2);
            this.tab_basededatos.Controls.Add(this.btn_sig_3);
            this.tab_basededatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_basededatos.Location = new System.Drawing.Point(4, 22);
            this.tab_basededatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_basededatos.Name = "tab_basededatos";
            this.tab_basededatos.Size = new System.Drawing.Size(467, 436);
            this.tab_basededatos.TabIndex = 2;
            this.tab_basededatos.Text = "Base de datos";
            this.tab_basededatos.UseVisualStyleBackColor = true;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(359, 119);
            this.btn_examinar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(104, 32);
            this.btn_examinar.TabIndex = 6;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 82);
            this.txt_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(452, 26);
            this.txt_path.TabIndex = 5;
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "La dirección donde está localizada la base de datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_sig_3
            // 
            this.btn_sig_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sig_3.Location = new System.Drawing.Point(359, 385);
            this.btn_sig_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sig_3.Name = "btn_sig_3";
            this.btn_sig_3.Size = new System.Drawing.Size(106, 42);
            this.btn_sig_3.TabIndex = 3;
            this.btn_sig_3.Text = "Siguiente >>";
            this.btn_sig_3.UseVisualStyleBackColor = true;
            this.btn_sig_3.Click += new System.EventHandler(this.btn_sig_3_Click);
            // 
            // tab_empresa
            // 
            this.tab_empresa.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.tab_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_empresa.Controls.Add(this.btn_examinar_logo);
            this.tab_empresa.Controls.Add(this.txt_logotipo);
            this.tab_empresa.Controls.Add(this.txt_direccion_emp);
            this.tab_empresa.Controls.Add(this.txt_nombre_emp);
            this.tab_empresa.Controls.Add(this.label5);
            this.tab_empresa.Controls.Add(this.label4);
            this.tab_empresa.Controls.Add(this.label3);
            this.tab_empresa.Controls.Add(this.btn_finalizar);
            this.tab_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_empresa.Location = new System.Drawing.Point(4, 22);
            this.tab_empresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_empresa.Name = "tab_empresa";
            this.tab_empresa.Size = new System.Drawing.Size(467, 436);
            this.tab_empresa.TabIndex = 3;
            this.tab_empresa.Text = "Empresa";
            this.tab_empresa.UseVisualStyleBackColor = true;
            // 
            // btn_examinar_logo
            // 
            this.btn_examinar_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_logo.Location = new System.Drawing.Point(358, 203);
            this.btn_examinar_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_examinar_logo.Name = "btn_examinar_logo";
            this.btn_examinar_logo.Size = new System.Drawing.Size(106, 30);
            this.btn_examinar_logo.TabIndex = 10;
            this.btn_examinar_logo.Text = "Examinar...";
            this.btn_examinar_logo.UseVisualStyleBackColor = true;
            this.btn_examinar_logo.Click += new System.EventHandler(this.btn_examinar_logo_Click);
            // 
            // txt_logotipo
            // 
            this.txt_logotipo.Location = new System.Drawing.Point(7, 167);
            this.txt_logotipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_logotipo.Name = "txt_logotipo";
            this.txt_logotipo.Size = new System.Drawing.Size(457, 26);
            this.txt_logotipo.TabIndex = 9;
            // 
            // txt_direccion_emp
            // 
            this.txt_direccion_emp.Location = new System.Drawing.Point(7, 106);
            this.txt_direccion_emp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_direccion_emp.Name = "txt_direccion_emp";
            this.txt_direccion_emp.Size = new System.Drawing.Size(457, 26);
            this.txt_direccion_emp.TabIndex = 8;
            // 
            // txt_nombre_emp
            // 
            this.txt_nombre_emp.Location = new System.Drawing.Point(7, 46);
            this.txt_nombre_emp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombre_emp.Name = "txt_nombre_emp";
            this.txt_nombre_emp.Size = new System.Drawing.Size(457, 26);
            this.txt_nombre_emp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Logotipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(358, 385);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(106, 42);
            this.btn_finalizar.TabIndex = 3;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // Abrir_archivo
            // 
            this.Abrir_archivo.FileName = "openFileDialog1";
            this.Abrir_archivo.FileOk += new System.ComponentModel.CancelEventHandler(this.Abrir_archivo_FileOk);
            // 
            // Configuración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(478, 463);
            this.Controls.Add(this.tab_configuraciones);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuración";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.tab_configuraciones.ResumeLayout(false);
            this.tab_bienvenida.ResumeLayout(false);
            this.tab_bienvenida.PerformLayout();
            this.tab_administrador.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_basededatos.ResumeLayout(false);
            this.tab_basededatos.PerformLayout();
            this.tab_empresa.ResumeLayout(false);
            this.tab_empresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_configuraciones;
        private System.Windows.Forms.TabPage tab_bienvenida;
        private System.Windows.Forms.TabPage tab_administrador;
        private System.Windows.Forms.TabPage tab_basededatos;
        private System.Windows.Forms.TabPage tab_empresa;
        private System.Windows.Forms.Button btn_sig_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sig_3;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guardar_admin;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label lbl_pass2_admin;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass_admin;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario_admin;
        private System.Windows.Forms.Label lbl_titulo_admin;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_examinar_logo;
        private System.Windows.Forms.TextBox txt_logotipo;
        private System.Windows.Forms.TextBox txt_direccion_emp;
        private System.Windows.Forms.TextBox txt_nombre_emp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog Abrir_archivo;
    }
}