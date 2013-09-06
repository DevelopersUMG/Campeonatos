namespace Campeonatos
{
    partial class Ficha_partido
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
            this.local_lbl = new System.Windows.Forms.Label();
            this.gol_loc_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visita_lbl = new System.Windows.Forms.Label();
            this.gol_vis_tbx = new System.Windows.Forms.TextBox();
            this.local_dgw = new System.Windows.Forms.DataGridView();
            this.visita_dgw = new System.Windows.Forms.DataGridView();
            this.guardar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.local_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visita_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // local_lbl
            // 
            this.local_lbl.AutoSize = true;
            this.local_lbl.BackColor = System.Drawing.Color.Transparent;
            this.local_lbl.Location = new System.Drawing.Point(131, 77);
            this.local_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_lbl.Name = "local_lbl";
            this.local_lbl.Size = new System.Drawing.Size(60, 24);
            this.local_lbl.TabIndex = 0;
            this.local_lbl.Text = "label1";
            this.local_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gol_loc_tbx
            // 
            this.gol_loc_tbx.Enabled = false;
            this.gol_loc_tbx.Location = new System.Drawing.Point(331, 77);
            this.gol_loc_tbx.Name = "gol_loc_tbx";
            this.gol_loc_tbx.Size = new System.Drawing.Size(65, 28);
            this.gol_loc_tbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(419, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // visita_lbl
            // 
            this.visita_lbl.AutoSize = true;
            this.visita_lbl.BackColor = System.Drawing.Color.Transparent;
            this.visita_lbl.Location = new System.Drawing.Point(655, 77);
            this.visita_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visita_lbl.Name = "visita_lbl";
            this.visita_lbl.Size = new System.Drawing.Size(60, 24);
            this.visita_lbl.TabIndex = 4;
            this.visita_lbl.Text = "label2";
            this.visita_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gol_vis_tbx
            // 
            this.gol_vis_tbx.Enabled = false;
            this.gol_vis_tbx.Location = new System.Drawing.Point(461, 77);
            this.gol_vis_tbx.Name = "gol_vis_tbx";
            this.gol_vis_tbx.Size = new System.Drawing.Size(63, 28);
            this.gol_vis_tbx.TabIndex = 3;
            // 
            // local_dgw
            // 
            this.local_dgw.AllowUserToAddRows = false;
            this.local_dgw.AllowUserToDeleteRows = false;
            this.local_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.local_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.local_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.local_dgw.Location = new System.Drawing.Point(12, 126);
            this.local_dgw.Name = "local_dgw";
            this.local_dgw.RowTemplate.Height = 24;
            this.local_dgw.Size = new System.Drawing.Size(384, 633);
            this.local_dgw.TabIndex = 5;
            this.local_dgw.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.local_dgw_CellBeginEdit);
            //this.local_dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.local_dgw_CellContentClick);
            this.local_dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.local_dgw_CellEndEdit);
            // 
            // visita_dgw
            // 
            this.visita_dgw.AllowUserToAddRows = false;
            this.visita_dgw.AllowUserToDeleteRows = false;
            this.visita_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visita_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visita_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visita_dgw.Location = new System.Drawing.Point(461, 126);
            this.visita_dgw.Name = "visita_dgw";
            this.visita_dgw.RowTemplate.Height = 24;
            this.visita_dgw.Size = new System.Drawing.Size(384, 633);
            this.visita_dgw.TabIndex = 6;
            this.visita_dgw.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.visita_dgw_CellBeginEdit);
            //this.visita_dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visita_dgw_CellContentClick);
            this.visita_dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.visita_dgw_CellEndEdit);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Location = new System.Drawing.Point(354, 765);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(144, 37);
            this.guardar_btn.TabIndex = 7;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // Ficha_partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonatos.Properties.Resources.skateboard_you_can_free_abstract_soccer_frame_ppt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 814);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.visita_dgw);
            this.Controls.Add(this.local_dgw);
            this.Controls.Add(this.visita_lbl);
            this.Controls.Add(this.gol_vis_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gol_loc_tbx);
            this.Controls.Add(this.local_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ficha_partido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha del partido";
            this.Load += new System.EventHandler(this.Ficha_partido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.local_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visita_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label local_lbl;
        private System.Windows.Forms.TextBox gol_loc_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label visita_lbl;
        private System.Windows.Forms.TextBox gol_vis_tbx;
        private System.Windows.Forms.DataGridView local_dgw;
        private System.Windows.Forms.DataGridView visita_dgw;
        private System.Windows.Forms.Button guardar_btn;
    }
}