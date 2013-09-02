namespace Campeonatos
{
    partial class Equipos
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblencargado = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtnombrequipo = new System.Windows.Forms.TextBox();
            this.txtencargado = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.edicion_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tblequipo = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.edicion_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblequipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(9, 9);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(99, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre del equipo:";
            // 
            // lblencargado
            // 
            this.lblencargado.AutoSize = true;
            this.lblencargado.Location = new System.Drawing.Point(8, 34);
            this.lblencargado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblencargado.Name = "lblencargado";
            this.lblencargado.Size = new System.Drawing.Size(62, 13);
            this.lblencargado.TabIndex = 1;
            this.lblencargado.Text = "Encargado:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(11, 57);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 2;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // txtnombrequipo
            // 
            this.txtnombrequipo.Location = new System.Drawing.Point(113, 9);
            this.txtnombrequipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombrequipo.Name = "txtnombrequipo";
            this.txtnombrequipo.Size = new System.Drawing.Size(175, 20);
            this.txtnombrequipo.TabIndex = 3;
            // 
            // txtencargado
            // 
            this.txtencargado.Location = new System.Drawing.Point(113, 32);
            this.txtencargado.Margin = new System.Windows.Forms.Padding(2);
            this.txtencargado.Name = "txtencargado";
            this.txtencargado.Size = new System.Drawing.Size(175, 20);
            this.txtencargado.TabIndex = 4;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(113, 54);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(175, 20);
            this.txttelefono.TabIndex = 5;
            // 
            // edicion_pnl
            // 
            this.edicion_pnl.Controls.Add(this.cancelar_btn);
            this.edicion_pnl.Controls.Add(this.btnguardar);
            this.edicion_pnl.Controls.Add(this.lblnombre);
            this.edicion_pnl.Controls.Add(this.txttelefono);
            this.edicion_pnl.Controls.Add(this.lblencargado);
            this.edicion_pnl.Controls.Add(this.txtencargado);
            this.edicion_pnl.Controls.Add(this.lbltelefono);
            this.edicion_pnl.Controls.Add(this.txtnombrequipo);
            this.edicion_pnl.Location = new System.Drawing.Point(9, 330);
            this.edicion_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.edicion_pnl.Name = "edicion_pnl";
            this.edicion_pnl.Size = new System.Drawing.Size(449, 81);
            this.edicion_pnl.TabIndex = 6;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(325, 51);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(69, 19);
            this.cancelar_btn.TabIndex = 9;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(325, 19);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(69, 19);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblequipo
            // 
            this.tblequipo.AllowUserToAddRows = false;
            this.tblequipo.AllowUserToDeleteRows = false;
            this.tblequipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequipo.Location = new System.Drawing.Point(9, 34);
            this.tblequipo.Margin = new System.Windows.Forms.Padding(2);
            this.tblequipo.Name = "tblequipo";
            this.tblequipo.ReadOnly = true;
            this.tblequipo.RowTemplate.Height = 24;
            this.tblequipo.Size = new System.Drawing.Size(449, 278);
            this.tblequipo.TabIndex = 7;
            this.tblequipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tblequipo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblequipo_CellPainting);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(404, 3);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(57, 27);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.ClientSize = new System.Drawing.Size(472, 442);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.tblequipo);
            this.Controls.Add(this.edicion_pnl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            this.edicion_pnl.ResumeLayout(false);
            this.edicion_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblequipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblencargado;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtnombrequipo;
        private System.Windows.Forms.TextBox txtencargado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Panel edicion_pnl;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView tblequipo;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button cancelar_btn;
    }
}