namespace AdministrationApp
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugarDeEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsPreferencialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peorEspectáculoDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.usuariosToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.lugarDeEventoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioSesiónToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(58, 20);
            this.fileMenu.Text = "&Session";
            // 
            // inicioSesiónToolStripMenuItem
            // 
            this.inicioSesiónToolStripMenuItem.Name = "inicioSesiónToolStripMenuItem";
            this.inicioSesiónToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.inicioSesiónToolStripMenuItem.Text = "&Log Out";
            this.inicioSesiónToolStripMenuItem.Click += new System.EventHandler(this.inicioSesiónToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.usuariosToolStripMenuItem.Text = "&User";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventosToolStripMenuItem.Text = "&Event";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // lugarDeEventoToolStripMenuItem
            // 
            this.lugarDeEventoToolStripMenuItem.Name = "lugarDeEventoToolStripMenuItem";
            this.lugarDeEventoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.lugarDeEventoToolStripMenuItem.Text = "&Event location";
            this.lugarDeEventoToolStripMenuItem.Click += new System.EventHandler(this.lugarDeEventoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsPreferencialesToolStripMenuItem,
            this.peorEspectáculoDelMesToolStripMenuItem,
            this.ventaDeEntradasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportesToolStripMenuItem.Text = "&Reports";
            // 
            // clientsPreferencialesToolStripMenuItem
            // 
            this.clientsPreferencialesToolStripMenuItem.Name = "clientsPreferencialesToolStripMenuItem";
            this.clientsPreferencialesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clientsPreferencialesToolStripMenuItem.Text = "&Preferential user";
            this.clientsPreferencialesToolStripMenuItem.Click += new System.EventHandler(this.clientsPreferencialesToolStripMenuItem_Click);
            // 
            // peorEspectáculoDelMesToolStripMenuItem
            // 
            this.peorEspectáculoDelMesToolStripMenuItem.Name = "peorEspectáculoDelMesToolStripMenuItem";
            this.peorEspectáculoDelMesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.peorEspectáculoDelMesToolStripMenuItem.Text = "&Best and worst event";
            this.peorEspectáculoDelMesToolStripMenuItem.Click += new System.EventHandler(this.peorEspectáculoDelMesToolStripMenuItem_Click);
            // 
            // ventaDeEntradasToolStripMenuItem
            // 
            this.ventaDeEntradasToolStripMenuItem.Name = "ventaDeEntradasToolStripMenuItem";
            this.ventaDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ventaDeEntradasToolStripMenuItem.Text = "&Sold ticket";
            this.ventaDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.ventaDeEntradasToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "Main menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugarDeEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsPreferencialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peorEspectáculoDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeEntradasToolStripMenuItem;
    }
}



