namespace AdministrationApp
{
    partial class frmSoldTickets
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
            this.gvEvents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDate2Year = new System.Windows.Forms.ComboBox();
            this.cbDate1Year = new System.Windows.Forms.ComboBox();
            this.cbDate2Month = new System.Windows.Forms.ComboBox();
            this.cbDate1Month = new System.Windows.Forms.ComboBox();
            this.cbDate1Day = new System.Windows.Forms.ComboBox();
            this.cbDate2Day = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEvents
            // 
            this.gvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventName,
            this.Date,
            this.EventLoc,
            this.Description,
            this.Type,
            this.SoldTickets});
            this.gvEvents.Location = new System.Drawing.Point(1, 73);
            this.gvEvents.Name = "gvEvents";
            this.gvEvents.Size = new System.Drawing.Size(895, 232);
            this.gvEvents.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Name";
            this.EventName.Name = "EventName";
            this.EventName.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // EventLoc
            // 
            this.EventLoc.HeaderText = "Event Location";
            this.EventLoc.Name = "EventLoc";
            this.EventLoc.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Event Type";
            this.Type.Name = "Type";
            // 
            // SoldTickets
            // 
            this.SoldTickets.HeaderText = "Sold Tickets";
            this.SoldTickets.Name = "SoldTickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date between";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(614, 17);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 35);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "And";
            // 
            // cbDate2Year
            // 
            this.cbDate2Year.FormattingEnabled = true;
            this.cbDate2Year.Location = new System.Drawing.Point(534, 25);
            this.cbDate2Year.Name = "cbDate2Year";
            this.cbDate2Year.Size = new System.Drawing.Size(63, 21);
            this.cbDate2Year.TabIndex = 6;
            // 
            // cbDate1Year
            // 
            this.cbDate1Year.FormattingEnabled = true;
            this.cbDate1Year.Location = new System.Drawing.Point(349, 25);
            this.cbDate1Year.Name = "cbDate1Year";
            this.cbDate1Year.Size = new System.Drawing.Size(63, 21);
            this.cbDate1Year.TabIndex = 7;
            // 
            // cbDate2Month
            // 
            this.cbDate2Month.FormattingEnabled = true;
            this.cbDate2Month.Location = new System.Drawing.Point(492, 25);
            this.cbDate2Month.Name = "cbDate2Month";
            this.cbDate2Month.Size = new System.Drawing.Size(36, 21);
            this.cbDate2Month.TabIndex = 8;
            // 
            // cbDate1Month
            // 
            this.cbDate1Month.FormattingEnabled = true;
            this.cbDate1Month.Location = new System.Drawing.Point(307, 25);
            this.cbDate1Month.Name = "cbDate1Month";
            this.cbDate1Month.Size = new System.Drawing.Size(36, 21);
            this.cbDate1Month.TabIndex = 9;
            // 
            // cbDate1Day
            // 
            this.cbDate1Day.FormattingEnabled = true;
            this.cbDate1Day.Location = new System.Drawing.Point(265, 25);
            this.cbDate1Day.Name = "cbDate1Day";
            this.cbDate1Day.Size = new System.Drawing.Size(36, 21);
            this.cbDate1Day.TabIndex = 10;
            // 
            // cbDate2Day
            // 
            this.cbDate2Day.FormattingEnabled = true;
            this.cbDate2Day.Location = new System.Drawing.Point(450, 25);
            this.cbDate2Day.Name = "cbDate2Day";
            this.cbDate2Day.Size = new System.Drawing.Size(36, 21);
            this.cbDate2Day.TabIndex = 11;
            // 
            // frmSoldTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 308);
            this.Controls.Add(this.cbDate2Day);
            this.Controls.Add(this.cbDate1Day);
            this.Controls.Add(this.cbDate1Month);
            this.Controls.Add(this.cbDate2Month);
            this.Controls.Add(this.cbDate1Year);
            this.Controls.Add(this.cbDate2Year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvEvents);
            this.Name = "frmSoldTickets";
            this.Text = "frmSoldTickets";
            this.Load += new System.EventHandler(this.frmSoldTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDate2Year;
        private System.Windows.Forms.ComboBox cbDate1Year;
        private System.Windows.Forms.ComboBox cbDate2Month;
        private System.Windows.Forms.ComboBox cbDate1Month;
        private System.Windows.Forms.ComboBox cbDate1Day;
        private System.Windows.Forms.ComboBox cbDate2Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldTickets;
    }
}