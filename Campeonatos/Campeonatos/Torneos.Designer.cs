namespace Campeonatos
{
    partial class Torneos
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
            this.lbltorneo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.lblfechafinal = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.lblfechainicio = new System.Windows.Forms.Label();
            this.txtnombretorneo = new System.Windows.Forms.TextBox();
            this.btnnuevocalendario = new System.Windows.Forms.Button();
            this.tblcalendario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltorneo
            // 
            this.lbltorneo.AutoSize = true;
            this.lbltorneo.Location = new System.Drawing.Point(13, 11);
            this.lbltorneo.Name = "lbltorneo";
            this.lbltorneo.Size = new System.Drawing.Size(130, 17);
            this.lbltorneo.TabIndex = 0;
            this.lbltorneo.Text = "Nombre del torneo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtfechafinal);
            this.panel1.Controls.Add(this.lblfechafinal);
            this.panel1.Controls.Add(this.txtfechainicio);
            this.panel1.Controls.Add(this.lblfechainicio);
            this.panel1.Controls.Add(this.txtnombretorneo);
            this.panel1.Controls.Add(this.lbltorneo);
            this.panel1.Location = new System.Drawing.Point(13, 430);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 114);
            this.panel1.TabIndex = 1;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(457, 62);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 37);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(457, 20);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(85, 37);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Location = new System.Drawing.Point(159, 73);
            this.txtfechafinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(273, 22);
            this.txtfechafinal.TabIndex = 5;
            // 
            // lblfechafinal
            // 
            this.lblfechafinal.AutoSize = true;
            this.lblfechafinal.Location = new System.Drawing.Point(13, 73);
            this.lblfechafinal.Name = "lblfechafinal";
            this.lblfechafinal.Size = new System.Drawing.Size(81, 17);
            this.lblfechafinal.TabIndex = 4;
            this.lblfechafinal.Text = "Fecha final:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Checked = false;
            this.txtfechainicio.Location = new System.Drawing.Point(159, 41);
            this.txtfechainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(273, 22);
            this.txtfechainicio.TabIndex = 3;
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.AutoSize = true;
            this.lblfechainicio.Location = new System.Drawing.Point(13, 41);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(107, 17);
            this.lblfechainicio.TabIndex = 2;
            this.lblfechainicio.Text = "Fecha de inicio:";
            // 
            // txtnombretorneo
            // 
            this.txtnombretorneo.Location = new System.Drawing.Point(159, 11);
            this.txtnombretorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombretorneo.Name = "txtnombretorneo";
            this.txtnombretorneo.Size = new System.Drawing.Size(273, 22);
            this.txtnombretorneo.TabIndex = 1;
            // 
            // btnnuevocalendario
            // 
            this.btnnuevocalendario.Location = new System.Drawing.Point(719, 416);
            this.btnnuevocalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnuevocalendario.Name = "btnnuevocalendario";
            this.btnnuevocalendario.Size = new System.Drawing.Size(96, 34);
            this.btnnuevocalendario.TabIndex = 2;
            this.btnnuevocalendario.Text = "Nuevo";
            this.btnnuevocalendario.UseVisualStyleBackColor = true;
            this.btnnuevocalendario.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblcalendario
            // 
            this.tblcalendario.AllowUserToAddRows = false;
            this.tblcalendario.AllowUserToDeleteRows = false;
            this.tblcalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblcalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblcalendario.Location = new System.Drawing.Point(13, 42);
            this.tblcalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblcalendario.Name = "tblcalendario";
            this.tblcalendario.ReadOnly = true;
            this.tblcalendario.RowTemplate.Height = 24;
            this.tblcalendario.Size = new System.Drawing.Size(805, 369);
            this.tblcalendario.TabIndex = 3;
            this.tblcalendario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tblcalendario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 551);
            this.Controls.Add(this.tblcalendario);
            this.Controls.Add(this.btnnuevocalendario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Torneos";
            this.Text = "Torneos";
            this.Load += new System.EventHandler(this.Torneos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltorneo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DateTimePicker txtfechafinal;
        private System.Windows.Forms.Label lblfechafinal;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.TextBox txtnombretorneo;
        private System.Windows.Forms.Button btnnuevocalendario;
        private System.Windows.Forms.DataGridView tblcalendario;
        private System.Windows.Forms.Button btncancelar;
    }
}