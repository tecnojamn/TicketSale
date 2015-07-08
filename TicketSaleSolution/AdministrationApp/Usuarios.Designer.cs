namespace AdministrationApp
{
    partial class frmUsuarios
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
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUsers
            // 
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.Birthday,
            this.Mail,
            this.Active});
            this.gvUsers.Location = new System.Drawing.Point(-2, 10);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(544, 261);
            this.gvUsers.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(557, 10);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(557, 39);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Width = 50;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 283);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gvUsers);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}

