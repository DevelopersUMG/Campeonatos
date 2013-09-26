namespace Campeonatos
{
    partial class Estadisticas
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
            this.tab_Suspendidos = new System.Windows.Forms.TabControl();
            this.Equipos = new System.Windows.Forms.TabPage();
            this.equipos_dgw = new System.Windows.Forms.DataGridView();
            this.Jugadores = new System.Windows.Forms.TabPage();
            this.equipos_cmb = new System.Windows.Forms.ComboBox();
            this.jugadores_dgw = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cambiar_btn = new System.Windows.Forms.Button();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.grid_suspendidos = new System.Windows.Forms.DataGridView();
            this.tab_Suspendidos.SuspendLayout();
            this.Equipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipos_dgw)).BeginInit();
            this.Jugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jugadores_dgw)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_suspendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Suspendidos
            // 
            this.tab_Suspendidos.Controls.Add(this.Equipos);
            this.tab_Suspendidos.Controls.Add(this.Jugadores);
            this.tab_Suspendidos.Controls.Add(this.tabPage1);
            this.tab_Suspendidos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Suspendidos.Location = new System.Drawing.Point(10, 34);
            this.tab_Suspendidos.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Suspendidos.Name = "tab_Suspendidos";
            this.tab_Suspendidos.SelectedIndex = 0;
            this.tab_Suspendidos.Size = new System.Drawing.Size(642, 529);
            this.tab_Suspendidos.TabIndex = 0;
            // 
            // Equipos
            // 
            this.Equipos.Controls.Add(this.equipos_dgw);
            this.Equipos.Location = new System.Drawing.Point(4, 27);
            this.Equipos.Margin = new System.Windows.Forms.Padding(2);
            this.Equipos.Name = "Equipos";
            this.Equipos.Padding = new System.Windows.Forms.Padding(2);
            this.Equipos.Size = new System.Drawing.Size(634, 498);
            this.Equipos.TabIndex = 0;
            this.Equipos.Text = "Equipos";
            this.Equipos.UseVisualStyleBackColor = true;
            // 
            // equipos_dgw
            // 
            this.equipos_dgw.AllowUserToAddRows = false;
            this.equipos_dgw.AllowUserToDeleteRows = false;
            this.equipos_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.equipos_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equipos_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipos_dgw.Location = new System.Drawing.Point(5, 13);
            this.equipos_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.equipos_dgw.Name = "equipos_dgw";
            this.equipos_dgw.ReadOnly = true;
            this.equipos_dgw.RowTemplate.Height = 24;
            this.equipos_dgw.Size = new System.Drawing.Size(626, 435);
            this.equipos_dgw.TabIndex = 0;
            // 
            // Jugadores
            // 
            this.Jugadores.Controls.Add(this.equipos_cmb);
            this.Jugadores.Controls.Add(this.jugadores_dgw);
            this.Jugadores.Location = new System.Drawing.Point(4, 27);
            this.Jugadores.Margin = new System.Windows.Forms.Padding(2);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Padding = new System.Windows.Forms.Padding(2);
            this.Jugadores.Size = new System.Drawing.Size(634, 498);
            this.Jugadores.TabIndex = 1;
            this.Jugadores.Text = "Jugadores";
            this.Jugadores.UseVisualStyleBackColor = true;
            // 
            // equipos_cmb
            // 
            this.equipos_cmb.FormattingEnabled = true;
            this.equipos_cmb.Location = new System.Drawing.Point(472, 12);
            this.equipos_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.equipos_cmb.Name = "equipos_cmb";
            this.equipos_cmb.Size = new System.Drawing.Size(145, 26);
            this.equipos_cmb.TabIndex = 1;
            this.equipos_cmb.SelectedIndexChanged += new System.EventHandler(this.equipos_cmb_SelectedIndexChanged);
            // 
            // jugadores_dgw
            // 
            this.jugadores_dgw.AllowUserToAddRows = false;
            this.jugadores_dgw.AllowUserToDeleteRows = false;
            this.jugadores_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jugadores_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jugadores_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jugadores_dgw.Location = new System.Drawing.Point(19, 48);
            this.jugadores_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.jugadores_dgw.Name = "jugadores_dgw";
            this.jugadores_dgw.ReadOnly = true;
            this.jugadores_dgw.RowTemplate.Height = 24;
            this.jugadores_dgw.Size = new System.Drawing.Size(598, 431);
            this.jugadores_dgw.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_suspendidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 498);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Jugadores Suspendidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cambiar_btn
            // 
            this.cambiar_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiar_btn.Location = new System.Drawing.Point(10, 3);
            this.cambiar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cambiar_btn.Name = "cambiar_btn";
            this.cambiar_btn.Size = new System.Drawing.Size(142, 27);
            this.cambiar_btn.TabIndex = 1;
            this.cambiar_btn.Text = "Cambiar campeonato";
            this.cambiar_btn.UseVisualStyleBackColor = true;
            this.cambiar_btn.Click += new System.EventHandler(this.cambiar_btn_Click);
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.AutoSize = true;
            this.nombre_lbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre_lbl.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.Location = new System.Drawing.Point(166, 10);
            this.nombre_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(43, 18);
            this.nombre_lbl.TabIndex = 2;
            this.nombre_lbl.Text = "label1";
            // 
            // grid_suspendidos
            // 
            this.grid_suspendidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_suspendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_suspendidos.Location = new System.Drawing.Point(30, 36);
            this.grid_suspendidos.Name = "grid_suspendidos";
            this.grid_suspendidos.Size = new System.Drawing.Size(301, 150);
            this.grid_suspendidos.TabIndex = 0;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.fondodestas;
            this.ClientSize = new System.Drawing.Size(660, 569);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.cambiar_btn);
            this.Controls.Add(this.tab_Suspendidos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.tab_Suspendidos.ResumeLayout(false);
            this.Equipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipos_dgw)).EndInit();
            this.Jugadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jugadores_dgw)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_suspendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Suspendidos;
        private System.Windows.Forms.TabPage Equipos;
        private System.Windows.Forms.TabPage Jugadores;
        private System.Windows.Forms.Button cambiar_btn;
        private System.Windows.Forms.Label nombre_lbl;
        private System.Windows.Forms.DataGridView equipos_dgw;
        private System.Windows.Forms.ComboBox equipos_cmb;
        private System.Windows.Forms.DataGridView jugadores_dgw;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grid_suspendidos;
    }
}