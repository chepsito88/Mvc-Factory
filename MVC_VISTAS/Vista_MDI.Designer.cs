namespace MVC_VISTAS
{
    partial class Vista_MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCuadrado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTriangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCuadrado,
            this.mnuRectangulo,
            this.mnuCirculo,
            this.mnuTriangulo,
            this.btnSalir});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCuadrado
            // 
            this.mnuCuadrado.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("mnuCuadrado.Image")));
            this.mnuCuadrado.Name = "mnuCuadrado";
            this.mnuCuadrado.Size = new System.Drawing.Size(158, 44);
            this.mnuCuadrado.Text = "Cuadrado";
            // 
            // mnuRectangulo
            // 
            this.mnuRectangulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("mnuRectangulo.Image")));
            this.mnuRectangulo.Name = "mnuRectangulo";
            this.mnuRectangulo.Size = new System.Drawing.Size(168, 44);
            this.mnuRectangulo.Text = "Rectangulo";
            // 
            // mnuCirculo
            // 
            this.mnuCirculo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCirculo.Image = ((System.Drawing.Image)(resources.GetObject("mnuCirculo.Image")));
            this.mnuCirculo.Name = "mnuCirculo";
            this.mnuCirculo.Size = new System.Drawing.Size(128, 44);
            this.mnuCirculo.Text = "Circulo";
            // 
            // mnuTriangulo
            // 
            this.mnuTriangulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("mnuTriangulo.Image")));
            this.mnuTriangulo.Name = "mnuTriangulo";
            this.mnuTriangulo.Size = new System.Drawing.Size(146, 44);
            this.mnuTriangulo.Text = "Triangulo";
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 44);
            // 
            // Vista_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vista_MDI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Figuras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mnuCuadrado;
        public System.Windows.Forms.ToolStripMenuItem mnuRectangulo;
        public System.Windows.Forms.ToolStripMenuItem mnuCirculo;
        public System.Windows.Forms.ToolStripMenuItem mnuTriangulo;
        public System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}