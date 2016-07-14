namespace ProyectoLibreria
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVentasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVentasPorLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.listarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // listarClienteToolStripMenuItem
            // 
            this.listarClienteToolStripMenuItem.Name = "listarClienteToolStripMenuItem";
            this.listarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listarClienteToolStripMenuItem.Text = "Listar Cliente";
            this.listarClienteToolStripMenuItem.Click += new System.EventHandler(this.listarClienteToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibrosToolStripMenuItem,
            this.listarLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // agregarLibrosToolStripMenuItem
            // 
            this.agregarLibrosToolStripMenuItem.Name = "agregarLibrosToolStripMenuItem";
            this.agregarLibrosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.agregarLibrosToolStripMenuItem.Text = "Agregar Libros";
            this.agregarLibrosToolStripMenuItem.Click += new System.EventHandler(this.agregarLibrosToolStripMenuItem_Click);
            // 
            // listarLibrosToolStripMenuItem
            // 
            this.listarLibrosToolStripMenuItem.Name = "listarLibrosToolStripMenuItem";
            this.listarLibrosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listarLibrosToolStripMenuItem.Text = "Listar Libros";
            this.listarLibrosToolStripMenuItem.Click += new System.EventHandler(this.listarLibrosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVentasToolStripMenuItem,
            this.listarVentasPorClienteToolStripMenuItem,
            this.listarVentasPorLibroToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // agregarVentasToolStripMenuItem
            // 
            this.agregarVentasToolStripMenuItem.Name = "agregarVentasToolStripMenuItem";
            this.agregarVentasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarVentasToolStripMenuItem.Text = "Agregar Ventas";
            this.agregarVentasToolStripMenuItem.Click += new System.EventHandler(this.agregarVentasToolStripMenuItem_Click);
            // 
            // listarVentasPorClienteToolStripMenuItem
            // 
            this.listarVentasPorClienteToolStripMenuItem.Name = "listarVentasPorClienteToolStripMenuItem";
            this.listarVentasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listarVentasPorClienteToolStripMenuItem.Text = "Listar Ventas Por Cliente";
            this.listarVentasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.listarVentasPorClienteToolStripMenuItem_Click);
            // 
            // listarVentasPorLibroToolStripMenuItem
            // 
            this.listarVentasPorLibroToolStripMenuItem.Name = "listarVentasPorLibroToolStripMenuItem";
            this.listarVentasPorLibroToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listarVentasPorLibroToolStripMenuItem.Text = "Listar Ventas Por Libro";
            this.listarVentasPorLibroToolStripMenuItem.Click += new System.EventHandler(this.listarVentasPorLibroToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVentasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVentasPorLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

