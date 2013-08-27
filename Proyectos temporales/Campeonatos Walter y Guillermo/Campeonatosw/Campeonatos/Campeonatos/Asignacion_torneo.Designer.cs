namespace Campeonatos
{
    partial class Asignacion_torneo
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
            this.lblequipoizq = new System.Windows.Forms.Label();
            this.lblequipoder = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tblequiposizq = new System.Windows.Forms.DataGridView();
            this.tblequiposder = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltorneo
            // 
            this.lbltorneo.AutoSize = true;
            this.lbltorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltorneo.Location = new System.Drawing.Point(9, 7);
            this.lbltorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltorneo.Name = "lbltorneo";
            this.lbltorneo.Size = new System.Drawing.Size(123, 31);
            this.lbltorneo.TabIndex = 0;
            this.lbltorneo.Text = "Torneo: ";
            // 
            // lblequipoizq
            // 
            this.lblequipoizq.AutoSize = true;
            this.lblequipoizq.Location = new System.Drawing.Point(12, 58);
            this.lblequipoizq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoizq.Name = "lblequipoizq";
            this.lblequipoizq.Size = new System.Drawing.Size(96, 13);
            this.lblequipoizq.TabIndex = 2;
            this.lblequipoizq.Text = "Todos los equipos:";
            // 
            // lblequipoder
            // 
            this.lblequipoder.AutoSize = true;
            this.lblequipoder.Location = new System.Drawing.Point(320, 58);
            this.lblequipoder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoder.Name = "lblequipoder";
            this.lblequipoder.Size = new System.Drawing.Size(107, 13);
            this.lblequipoder.TabIndex = 4;
            this.lblequipoder.Text = "Equipos en el torneo:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(322, 397);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 13);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total: ";
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(220, 124);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(56, 19);
            this.btnquitar.TabIndex = 6;
            this.btnquitar.Text = ">>";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(220, 148);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(56, 19);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "<<";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(14, 397);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(56, 19);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo equipo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblequiposizq
            // 
            this.tblequiposizq.AllowUserToAddRows = false;
            this.tblequiposizq.AllowUserToDeleteRows = false;
            this.tblequiposizq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposizq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequiposizq.Location = new System.Drawing.Point(14, 75);
            this.tblequiposizq.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposizq.Name = "tblequiposizq";
            this.tblequiposizq.ReadOnly = true;
            this.tblequiposizq.RowTemplate.Height = 24;
            this.tblequiposizq.Size = new System.Drawing.Size(180, 317);
            this.tblequiposizq.TabIndex = 9;
            this.tblequiposizq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblequiposder
            // 
            this.tblequiposder.AllowUserToAddRows = false;
            this.tblequiposder.AllowUserToDeleteRows = false;
            this.tblequiposder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequiposder.Location = new System.Drawing.Point(322, 75);
            this.tblequiposder.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposder.Name = "tblequiposder";
            this.tblequiposder.ReadOnly = true;
            this.tblequiposder.RowTemplate.Height = 24;
            this.tblequiposder.Size = new System.Drawing.Size(180, 317);
            this.tblequiposder.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(220, 397);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 19);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Asignacion_torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 457);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tblequiposder);
            this.Controls.Add(this.tblequiposizq);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblequipoder);
            this.Controls.Add(this.lblequipoizq);
            this.Controls.Add(this.lbltorneo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Asignacion_torneo";
            this.Text = "Asignacion de equipos";
            this.Load += new System.EventHandler(this.Asignacion_torneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltorneo;
        private System.Windows.Forms.Label lblequipoizq;
        private System.Windows.Forms.Label lblequipoder;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView tblequiposizq;
        private System.Windows.Forms.DataGridView tblequiposder;
        private System.Windows.Forms.Button btnguardar;
    }
}