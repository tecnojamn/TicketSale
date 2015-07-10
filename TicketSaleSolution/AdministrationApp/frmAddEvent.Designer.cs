namespace AdministrationApp
{
    partial class frmAddEvent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbEventLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTicketType = new System.Windows.Forms.Button();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTicketType = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 37;
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(147, 166);
            this.cbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(55, 24);
            this.cbHour.TabIndex = 49;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(211, 166);
            this.cbMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(55, 24);
            this.cbMinutes.TabIndex = 48;
            // 
            // cbEventLocation
            // 
            this.cbEventLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventLocation.FormattingEnabled = true;
            this.cbEventLocation.Location = new System.Drawing.Point(147, 99);
            this.cbEventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbEventLocation.Name = "cbEventLocation";
            this.cbEventLocation.Size = new System.Drawing.Size(200, 24);
            this.cbEventLocation.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Time";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(147, 66);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 24);
            this.cbType.TabIndex = 36;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(211, 133);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(53, 24);
            this.cbMonth.TabIndex = 46;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 34);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 22);
            this.txtDescripcion.TabIndex = 38;
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(147, 133);
            this.cbDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(55, 24);
            this.cbDay.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(273, 133);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(73, 24);
            this.cbYear.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "EventLocation";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 47);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 47);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTicketType
            // 
            this.btnAddTicketType.Location = new System.Drawing.Point(178, 53);
            this.btnAddTicketType.Name = "btnAddTicketType";
            this.btnAddTicketType.Size = new System.Drawing.Size(74, 24);
            this.btnAddTicketType.TabIndex = 54;
            this.btnAddTicketType.Text = "Add";
            this.btnAddTicketType.UseVisualStyleBackColor = true;
            this.btnAddTicketType.Click += new System.EventHandler(this.btnAddTicketType_Click);
            // 
            // cbTicketType
            // 
            this.cbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Location = new System.Drawing.Point(135, 22);
            this.cbTicketType.Margin = new System.Windows.Forms.Padding(4);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(199, 24);
            this.cbTicketType.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTicketType);
            this.groupBox1.Controls.Add(this.btnAddTicketType);
            this.groupBox1.Controls.Add(this.cbTicketType);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 88);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket types";
            // 
            // btnDeleteTicketType
            // 
            this.btnDeleteTicketType.Location = new System.Drawing.Point(261, 53);
            this.btnDeleteTicketType.Name = "btnDeleteTicketType";
            this.btnDeleteTicketType.Size = new System.Drawing.Size(74, 24);
            this.btnDeleteTicketType.TabIndex = 56;
            this.btnDeleteTicketType.Text = "Delete";
            this.btnDeleteTicketType.UseVisualStyleBackColor = true;
            this.btnDeleteTicketType.Click += new System.EventHandler(this.btnDeleteTicketType_Click);
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.cbMinutes);
            this.Controls.Add(this.cbEventLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "frmAddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbEventLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTicketType;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTicketType;

    }
}