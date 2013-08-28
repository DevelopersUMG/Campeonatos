namespace Campeonatos
{
    partial class Partidos
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
            this.torneo_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equipos_data = new System.Windows.Forms.DataGridView();
            this.total_eq_lbl = new System.Windows.Forms.Label();
            this.calendario_panel = new System.Windows.Forms.Panel();
            this.calendario_grid = new System.Windows.Forms.DataGridView();
            this.generar_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.torneo_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipos_data)).BeginInit();
            this.calendario_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendario_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // torneo_lbl
            // 
            this.torneo_lbl.AutoSize = true;
            this.torneo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.torneo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torneo_lbl.Location = new System.Drawing.Point(16, 16);
            this.torneo_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.torneo_lbl.Name = "torneo_lbl";
            this.torneo_lbl.Size = new System.Drawing.Size(82, 24);
            this.torneo_lbl.TabIndex = 0;
            this.torneo_lbl.Text = "Torneo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipos:";
            // 
            // equipos_data
            // 
            this.equipos_data.AllowUserToAddRows = false;
            this.equipos_data.AllowUserToDeleteRows = false;
            this.equipos_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.equipos_data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equipos_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipos_data.Location = new System.Drawing.Point(26, 99);
            this.equipos_data.Margin = new System.Windows.Forms.Padding(4);
            this.equipos_data.Name = "equipos_data";
            this.equipos_data.ReadOnly = true;
            this.equipos_data.RowTemplate.Height = 24;
            this.equipos_data.Size = new System.Drawing.Size(244, 571);
            this.equipos_data.TabIndex = 2;
            // 
            // total_eq_lbl
            // 
            this.total_eq_lbl.AutoSize = true;
            this.total_eq_lbl.BackColor = System.Drawing.Color.White;
            this.total_eq_lbl.Location = new System.Drawing.Point(35, 674);
            this.total_eq_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_eq_lbl.Name = "total_eq_lbl";
            this.total_eq_lbl.Size = new System.Drawing.Size(142, 20);
            this.total_eq_lbl.TabIndex = 3;
            this.total_eq_lbl.Text = "Total de equipos: ";
            // 
            // calendario_panel
            // 
            this.calendario_panel.BackColor = System.Drawing.Color.Transparent;
            this.calendario_panel.Controls.Add(this.calendario_grid);
            this.calendario_panel.Location = new System.Drawing.Point(277, 99);
            this.calendario_panel.Name = "calendario_panel";
            this.calendario_panel.Size = new System.Drawing.Size(612, 595);
            this.calendario_panel.TabIndex = 4;
            // 
            // calendario_grid
            // 
            this.calendario_grid.AllowUserToAddRows = false;
            this.calendario_grid.AllowUserToDeleteRows = false;
            this.calendario_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendario_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendario_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendario_grid.Location = new System.Drawing.Point(3, 3);
            this.calendario_grid.Name = "calendario_grid";
            this.calendario_grid.ReadOnly = true;
            this.calendario_grid.RowTemplate.Height = 24;
            this.calendario_grid.Size = new System.Drawing.Size(606, 589);
            this.calendario_grid.TabIndex = 0;
            // 
            // generar_btn
            // 
            this.generar_btn.Location = new System.Drawing.Point(305, 16);
            this.generar_btn.Name = "generar_btn";
            this.generar_btn.Size = new System.Drawing.Size(184, 35);
            this.generar_btn.TabIndex = 5;
            this.generar_btn.Text = "Generar calendario";
            this.generar_btn.UseVisualStyleBackColor = true;
            this.generar_btn.Click += new System.EventHandler(this.generar_btn_Click);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.Transparent;
            this.info_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.Location = new System.Drawing.Point(302, 54);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(291, 17);
            this.info_lbl.TabIndex = 6;
            this.info_lbl.Text = "El calendario de juegos no ha sido generado";
            // 
            // torneo_cmb
            // 
            this.torneo_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.torneo_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.torneo_cmb.FormattingEnabled = true;
            this.torneo_cmb.Location = new System.Drawing.Point(706, 12);
            this.torneo_cmb.Name = "torneo_cmb";
            this.torneo_cmb.Size = new System.Drawing.Size(180, 28);
            this.torneo_cmb.TabIndex = 7;
            this.torneo_cmb.SelectedIndexChanged += new System.EventHandler(this.torneo_cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(625, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Torneos:";
            // 
            // Partidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.fondodestas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 715);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.torneo_cmb);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.generar_btn);
            this.Controls.Add(this.calendario_panel);
            this.Controls.Add(this.total_eq_lbl);
            this.Controls.Add(this.equipos_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.torneo_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Partidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidos";
            this.Load += new System.EventHandler(this.Partidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipos_data)).EndInit();
            this.calendario_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendario_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label torneo_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView equipos_data;
        private System.Windows.Forms.Label total_eq_lbl;
        private System.Windows.Forms.Panel calendario_panel;
        private System.Windows.Forms.Button generar_btn;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.DataGridView calendario_grid;
        private System.Windows.Forms.ComboBox torneo_cmb;
        private System.Windows.Forms.Label label2;
    }
}