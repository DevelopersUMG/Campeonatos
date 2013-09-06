namespace Campeonatos
{
    partial class Seleccion_campeonato
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
            this.label1 = new System.Windows.Forms.Label();
            this.campeonato_dgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.campeonato_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doble click para seleccionar un campeonato";
            // 
            // campeonato_dgw
            // 
            this.campeonato_dgw.AllowUserToAddRows = false;
            this.campeonato_dgw.AllowUserToDeleteRows = false;
            this.campeonato_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.campeonato_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.campeonato_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.campeonato_dgw.Location = new System.Drawing.Point(12, 32);
            this.campeonato_dgw.Name = "campeonato_dgw";
            this.campeonato_dgw.ReadOnly = true;
            this.campeonato_dgw.RowTemplate.Height = 24;
            this.campeonato_dgw.Size = new System.Drawing.Size(328, 257);
            this.campeonato_dgw.TabIndex = 3;
            this.campeonato_dgw.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.campeonato_dgw_CellContentDoubleClick);
            // 
            // Seleccion_campeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 301);
            this.Controls.Add(this.campeonato_dgw);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion_campeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Seleccion_campeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campeonato_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView campeonato_dgw;
    }
}