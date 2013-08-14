namespace MDI
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mprueba = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.SplitContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            this.contenedor.Panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1300, 47);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mprueba});
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(57, 43);
            this.pruebaToolStripMenuItem.Text = "Inicio";
            // 
            // mprueba
            // 
            this.mprueba.Name = "mprueba";
            this.mprueba.Size = new System.Drawing.Size(124, 24);
            this.mprueba.Text = "Prueba";
            this.mprueba.Click += new System.EventHandler(this.mprueba_Click);
            // 
            // contenedor
            // 
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 47);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenedor.Name = "contenedor";
            // 
            // contenedor.Panel1
            // 
            this.contenedor.Panel1.Controls.Add(this.button6);
            this.contenedor.Panel1.Controls.Add(this.button5);
            this.contenedor.Panel1.Controls.Add(this.button4);
            this.contenedor.Panel1.Controls.Add(this.button3);
            this.contenedor.Panel1.Controls.Add(this.button2);
            this.contenedor.Panel1.Controls.Add(this.button1);
            this.contenedor.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Panel1_Paint);
            // 
            // contenedor.Panel2
            // 
            this.contenedor.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contenedor.Panel2.BackgroundImage = global::MDI.Properties.Resources.fondo;
            this.contenedor.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contenedor.Size = new System.Drawing.Size(1300, 698);
            this.contenedor.SplitterDistance = 138;
            this.contenedor.SplitterWidth = 5;
            this.contenedor.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(0, 185);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(0, 148);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(0, 111);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(0, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 745);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.Panel1.ResumeLayout(false);
            this.contenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            this.contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mprueba;
        private System.Windows.Forms.SplitContainer contenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

