﻿namespace Campeonatos
{
    partial class Ventana
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
            this.Menu_principal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contenedor = new System.Windows.Forms.SplitContainer();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.btn_partidos = new System.Windows.Forms.Button();
            this.btn_jugador = new System.Windows.Forms.Button();
            this.btn_equipos = new System.Windows.Forms.Button();
            this.btn_campeonatos = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.Menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.Contenedor.Panel1.SuspendLayout();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Menu_principal.Size = new System.Drawing.Size(1408, 28);
            this.Menu_principal.TabIndex = 0;
            this.Menu_principal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.IsSplitterFixed = true;
            this.Contenedor.Location = new System.Drawing.Point(0, 28);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(4);
            this.Contenedor.Name = "Contenedor";
            // 
            // Contenedor.Panel1
            // 
            this.Contenedor.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Contenedor.Panel1.BackgroundImage = global::Campeonatos.Properties.Resources.url;
            this.Contenedor.Panel1.Controls.Add(this.btn_estadisticas);
            this.Contenedor.Panel1.Controls.Add(this.btn_partidos);
            this.Contenedor.Panel1.Controls.Add(this.btn_jugador);
            this.Contenedor.Panel1.Controls.Add(this.btn_equipos);
            this.Contenedor.Panel1.Controls.Add(this.btn_campeonatos);
            this.Contenedor.Panel1.Controls.Add(this.pic_logo);
            // 
            // Contenedor.Panel2
            // 
            this.Contenedor.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Contenedor.Panel2.BackgroundImage = global::Campeonatos.Properties.Resources.Balones_de_Futbol;
            this.Contenedor.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Contenedor.Size = new System.Drawing.Size(1408, 734);
            this.Contenedor.SplitterDistance = 351;
            this.Contenedor.SplitterWidth = 5;
            this.Contenedor.TabIndex = 1;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.Location = new System.Drawing.Point(50, 232);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(251, 47);
            this.btn_estadisticas.TabIndex = 11;
            this.btn_estadisticas.Text = "Estadísticas";
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            // 
            // btn_partidos
            // 
            this.btn_partidos.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_partidos.Location = new System.Drawing.Point(50, 179);
            this.btn_partidos.Name = "btn_partidos";
            this.btn_partidos.Size = new System.Drawing.Size(251, 47);
            this.btn_partidos.TabIndex = 10;
            this.btn_partidos.Text = "Partidos";
            this.btn_partidos.UseVisualStyleBackColor = true;
            // 
            // btn_jugador
            // 
            this.btn_jugador.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugador.Location = new System.Drawing.Point(50, 126);
            this.btn_jugador.Name = "btn_jugador";
            this.btn_jugador.Size = new System.Drawing.Size(251, 47);
            this.btn_jugador.TabIndex = 9;
            this.btn_jugador.Text = "Jugadores";
            this.btn_jugador.UseVisualStyleBackColor = true;
            // 
            // btn_equipos
            // 
            this.btn_equipos.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equipos.Location = new System.Drawing.Point(50, 73);
            this.btn_equipos.Name = "btn_equipos";
            this.btn_equipos.Size = new System.Drawing.Size(251, 47);
            this.btn_equipos.TabIndex = 8;
            this.btn_equipos.Text = "Equipos";
            this.btn_equipos.UseVisualStyleBackColor = true;
            // 
            // btn_campeonatos
            // 
            this.btn_campeonatos.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_campeonatos.Location = new System.Drawing.Point(50, 20);
            this.btn_campeonatos.Name = "btn_campeonatos";
            this.btn_campeonatos.Size = new System.Drawing.Size(251, 47);
            this.btn_campeonatos.TabIndex = 7;
            this.btn_campeonatos.Text = "Campeonatos";
            this.btn_campeonatos.UseVisualStyleBackColor = true;
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Image = global::Campeonatos.Properties.Resources._709_logo_de_futeca;
            this.pic_logo.Location = new System.Drawing.Point(38, 560);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(253, 174);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 762);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menu_principal);
            this.MainMenuStrip = this.Menu_principal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.SizeChanged += new System.EventHandler(this.Ventana_SizeChanged);
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            this.Contenedor.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer Contenedor;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Button btn_partidos;
        private System.Windows.Forms.Button btn_jugador;
        private System.Windows.Forms.Button btn_equipos;
        private System.Windows.Forms.Button btn_campeonatos;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
    }
}