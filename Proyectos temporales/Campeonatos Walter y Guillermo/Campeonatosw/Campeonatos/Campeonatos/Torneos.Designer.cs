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
            this.lbltorneo.Location = new System.Drawing.Point(10, 9);
            this.lbltorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltorneo.Name = "lbltorneo";
            this.lbltorneo.Size = new System.Drawing.Size(97, 13);
            this.lbltorneo.TabIndex = 0;
            this.lbltorneo.Text = "Nombre del torneo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtfechafinal);
            this.panel1.Controls.Add(this.lblfechafinal);
            this.panel1.Controls.Add(this.txtfechainicio);
            this.panel1.Controls.Add(this.lblfechainicio);
            this.panel1.Controls.Add(this.txtnombretorneo);
            this.panel1.Controls.Add(this.lbltorneo);
            this.panel1.Location = new System.Drawing.Point(10, 349);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 93);
            this.panel1.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(340, 33);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 45);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Location = new System.Drawing.Point(119, 59);
            this.txtfechafinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(206, 20);
            this.txtfechafinal.TabIndex = 5;
            // 
            // lblfechafinal
            // 
            this.lblfechafinal.AutoSize = true;
            this.lblfechafinal.Location = new System.Drawing.Point(10, 59);
            this.lblfechafinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechafinal.Name = "lblfechafinal";
            this.lblfechafinal.Size = new System.Drawing.Size(62, 13);
            this.lblfechafinal.TabIndex = 4;
            this.lblfechafinal.Text = "Fecha final:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Checked = false;
            this.txtfechainicio.Location = new System.Drawing.Point(119, 33);
            this.txtfechainicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(206, 20);
            this.txtfechainicio.TabIndex = 3;
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.AutoSize = true;
            this.lblfechainicio.Location = new System.Drawing.Point(10, 33);
            this.lblfechainicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(82, 13);
            this.lblfechainicio.TabIndex = 2;
            this.lblfechainicio.Text = "Fecha de inicio:";
            // 
            // txtnombretorneo
            // 
            this.txtnombretorneo.Location = new System.Drawing.Point(119, 9);
            this.txtnombretorneo.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombretorneo.Name = "txtnombretorneo";
            this.txtnombretorneo.Size = new System.Drawing.Size(206, 20);
            this.txtnombretorneo.TabIndex = 1;
            // 
            // btnnuevocalendario
            // 
            this.btnnuevocalendario.Location = new System.Drawing.Point(10, 11);
            this.btnnuevocalendario.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevocalendario.Name = "btnnuevocalendario";
            this.btnnuevocalendario.Size = new System.Drawing.Size(56, 19);
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
            this.tblcalendario.Location = new System.Drawing.Point(10, 34);
            this.tblcalendario.Margin = new System.Windows.Forms.Padding(2);
            this.tblcalendario.Name = "tblcalendario";
            this.tblcalendario.ReadOnly = true;
            this.tblcalendario.RowTemplate.Height = 24;
            this.tblcalendario.Size = new System.Drawing.Size(604, 300);
            this.tblcalendario.TabIndex = 3;
            this.tblcalendario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tblcalendario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 448);
            this.Controls.Add(this.tblcalendario);
            this.Controls.Add(this.btnnuevocalendario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}