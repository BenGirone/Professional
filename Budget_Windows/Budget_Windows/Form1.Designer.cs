namespace Budget_Windows
{
    partial class bmg_mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmg_mainForm));
            this.bmg_expenser = new System.Windows.Forms.TextBox();
            this.bmg_recordButton = new System.Windows.Forms.Button();
            this.bmg_dater = new System.Windows.Forms.DateTimePicker();
            this.bmg_list = new System.Windows.Forms.ListView();
            this.bmg_dates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bmg_expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bmg_label1 = new System.Windows.Forms.Label();
            this.bmg_label2 = new System.Windows.Forms.Label();
            this.bmg_monthSelector = new System.Windows.Forms.ComboBox();
            this.bmg_monthLabel = new System.Windows.Forms.Label();
            this.bmg_yearLabel = new System.Windows.Forms.Label();
            this.bmg_yearSelector = new System.Windows.Forms.ComboBox();
            this.calc_label_1 = new System.Windows.Forms.Label();
            this.calc_header = new System.Windows.Forms.Label();
            this.calc_label_2 = new System.Windows.Forms.Label();
            this.bmg_calc_1 = new System.Windows.Forms.TextBox();
            this.bmg_calc_2 = new System.Windows.Forms.TextBox();
            this.bmg_calc_3 = new System.Windows.Forms.TextBox();
            this.calc_label_3 = new System.Windows.Forms.Label();
            this.calc_label_4 = new System.Windows.Forms.Label();
            this.bmg_surplus_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmg_expenser
            // 
            this.bmg_expenser.Location = new System.Drawing.Point(41, 118);
            this.bmg_expenser.Name = "bmg_expenser";
            this.bmg_expenser.Size = new System.Drawing.Size(100, 20);
            this.bmg_expenser.TabIndex = 1;
            this.bmg_expenser.Text = "0.00";
            this.bmg_expenser.Click += new System.EventHandler(this.bmg_expenser_Click);
            // 
            // bmg_recordButton
            // 
            this.bmg_recordButton.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_recordButton.Location = new System.Drawing.Point(41, 62);
            this.bmg_recordButton.Name = "bmg_recordButton";
            this.bmg_recordButton.Size = new System.Drawing.Size(75, 23);
            this.bmg_recordButton.TabIndex = 2;
            this.bmg_recordButton.Text = "Add Record";
            this.bmg_recordButton.UseVisualStyleBackColor = true;
            this.bmg_recordButton.Click += new System.EventHandler(this.bmg_recordButton_Click);
            // 
            // bmg_dater
            // 
            this.bmg_dater.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_dater.Location = new System.Drawing.Point(41, 91);
            this.bmg_dater.Name = "bmg_dater";
            this.bmg_dater.Size = new System.Drawing.Size(216, 22);
            this.bmg_dater.TabIndex = 4;
            // 
            // bmg_list
            // 
            this.bmg_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bmg_dates,
            this.bmg_expenses});
            this.bmg_list.FullRowSelect = true;
            this.bmg_list.GridLines = true;
            this.bmg_list.Location = new System.Drawing.Point(41, 206);
            this.bmg_list.Name = "bmg_list";
            this.bmg_list.Size = new System.Drawing.Size(179, 270);
            this.bmg_list.TabIndex = 5;
            this.bmg_list.UseCompatibleStateImageBehavior = false;
            this.bmg_list.View = System.Windows.Forms.View.Details;
            // 
            // bmg_dates
            // 
            this.bmg_dates.Text = "Dates";
            this.bmg_dates.Width = 101;
            // 
            // bmg_expenses
            // 
            this.bmg_expenses.Text = "Expenses";
            this.bmg_expenses.Width = 76;
            // 
            // bmg_label1
            // 
            this.bmg_label1.AutoSize = true;
            this.bmg_label1.BackColor = System.Drawing.Color.Transparent;
            this.bmg_label1.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_label1.Location = new System.Drawing.Point(36, 177);
            this.bmg_label1.Name = "bmg_label1";
            this.bmg_label1.Size = new System.Drawing.Size(116, 26);
            this.bmg_label1.TabIndex = 6;
            this.bmg_label1.Text = "Full Records";
            // 
            // bmg_label2
            // 
            this.bmg_label2.AutoSize = true;
            this.bmg_label2.BackColor = System.Drawing.Color.Transparent;
            this.bmg_label2.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_label2.Location = new System.Drawing.Point(36, 33);
            this.bmg_label2.Name = "bmg_label2";
            this.bmg_label2.Size = new System.Drawing.Size(130, 26);
            this.bmg_label2.TabIndex = 7;
            this.bmg_label2.Text = "Add A Record";
            // 
            // bmg_monthSelector
            // 
            this.bmg_monthSelector.FormattingEnabled = true;
            this.bmg_monthSelector.Location = new System.Drawing.Point(245, 250);
            this.bmg_monthSelector.Name = "bmg_monthSelector";
            this.bmg_monthSelector.Size = new System.Drawing.Size(121, 21);
            this.bmg_monthSelector.TabIndex = 8;
            this.bmg_monthSelector.TextChanged += new System.EventHandler(this.bmg_monthSelector_TextChanged);
            // 
            // bmg_monthLabel
            // 
            this.bmg_monthLabel.AutoSize = true;
            this.bmg_monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.bmg_monthLabel.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_monthLabel.Location = new System.Drawing.Point(242, 232);
            this.bmg_monthLabel.Name = "bmg_monthLabel";
            this.bmg_monthLabel.Size = new System.Drawing.Size(73, 15);
            this.bmg_monthLabel.TabIndex = 9;
            this.bmg_monthLabel.Text = "Select Month\r\n";
            // 
            // bmg_yearLabel
            // 
            this.bmg_yearLabel.AutoSize = true;
            this.bmg_yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.bmg_yearLabel.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_yearLabel.Location = new System.Drawing.Point(242, 291);
            this.bmg_yearLabel.Name = "bmg_yearLabel";
            this.bmg_yearLabel.Size = new System.Drawing.Size(62, 15);
            this.bmg_yearLabel.TabIndex = 10;
            this.bmg_yearLabel.Text = "Select Year";
            // 
            // bmg_yearSelector
            // 
            this.bmg_yearSelector.FormattingEnabled = true;
            this.bmg_yearSelector.Location = new System.Drawing.Point(245, 309);
            this.bmg_yearSelector.Name = "bmg_yearSelector";
            this.bmg_yearSelector.Size = new System.Drawing.Size(121, 21);
            this.bmg_yearSelector.TabIndex = 11;
            this.bmg_yearSelector.TextChanged += new System.EventHandler(this.bmg_yearSelector_TextChanged);
            // 
            // calc_label_1
            // 
            this.calc_label_1.AutoSize = true;
            this.calc_label_1.BackColor = System.Drawing.Color.Transparent;
            this.calc_label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_label_1.Location = new System.Drawing.Point(374, 72);
            this.calc_label_1.Name = "calc_label_1";
            this.calc_label_1.Size = new System.Drawing.Size(82, 13);
            this.calc_label_1.TabIndex = 12;
            this.calc_label_1.Text = "Initial Budget";
            // 
            // calc_header
            // 
            this.calc_header.AutoSize = true;
            this.calc_header.BackColor = System.Drawing.Color.Transparent;
            this.calc_header.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_header.Location = new System.Drawing.Point(372, 33);
            this.calc_header.Name = "calc_header";
            this.calc_header.Size = new System.Drawing.Size(118, 26);
            this.calc_header.TabIndex = 13;
            this.calc_header.Text = "Your Budget";
            // 
            // calc_label_2
            // 
            this.calc_label_2.AutoSize = true;
            this.calc_label_2.BackColor = System.Drawing.Color.Transparent;
            this.calc_label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_label_2.Location = new System.Drawing.Point(374, 98);
            this.calc_label_2.Name = "calc_label_2";
            this.calc_label_2.Size = new System.Drawing.Size(92, 13);
            this.calc_label_2.TabIndex = 14;
            this.calc_label_2.Text = "Current Budget";
            // 
            // bmg_calc_1
            // 
            this.bmg_calc_1.Location = new System.Drawing.Point(494, 72);
            this.bmg_calc_1.Name = "bmg_calc_1";
            this.bmg_calc_1.Size = new System.Drawing.Size(100, 20);
            this.bmg_calc_1.TabIndex = 15;
            this.bmg_calc_1.TextChanged += new System.EventHandler(this.bmg_calc_1_TextChanged);
            // 
            // bmg_calc_2
            // 
            this.bmg_calc_2.Location = new System.Drawing.Point(494, 98);
            this.bmg_calc_2.Name = "bmg_calc_2";
            this.bmg_calc_2.ReadOnly = true;
            this.bmg_calc_2.Size = new System.Drawing.Size(100, 20);
            this.bmg_calc_2.TabIndex = 16;
            // 
            // bmg_calc_3
            // 
            this.bmg_calc_3.Location = new System.Drawing.Point(494, 124);
            this.bmg_calc_3.Name = "bmg_calc_3";
            this.bmg_calc_3.Size = new System.Drawing.Size(100, 20);
            this.bmg_calc_3.TabIndex = 17;
            this.bmg_calc_3.TextChanged += new System.EventHandler(this.bmg_calc_3_TextChanged);
            // 
            // calc_label_3
            // 
            this.calc_label_3.AutoSize = true;
            this.calc_label_3.BackColor = System.Drawing.Color.Transparent;
            this.calc_label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_label_3.Location = new System.Drawing.Point(374, 124);
            this.calc_label_3.Name = "calc_label_3";
            this.calc_label_3.Size = new System.Drawing.Size(93, 13);
            this.calc_label_3.TabIndex = 18;
            this.calc_label_3.Text = "Daily Expenses";
            // 
            // calc_label_4
            // 
            this.calc_label_4.AutoSize = true;
            this.calc_label_4.BackColor = System.Drawing.Color.Transparent;
            this.calc_label_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_label_4.ForeColor = System.Drawing.Color.ForestGreen;
            this.calc_label_4.Location = new System.Drawing.Point(393, 177);
            this.calc_label_4.Name = "calc_label_4";
            this.calc_label_4.Size = new System.Drawing.Size(49, 13);
            this.calc_label_4.TabIndex = 19;
            this.calc_label_4.Text = "Surplus";
            // 
            // bmg_surplus_label
            // 
            this.bmg_surplus_label.AutoSize = true;
            this.bmg_surplus_label.BackColor = System.Drawing.Color.Transparent;
            this.bmg_surplus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmg_surplus_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.bmg_surplus_label.Location = new System.Drawing.Point(448, 172);
            this.bmg_surplus_label.Name = "bmg_surplus_label";
            this.bmg_surplus_label.Size = new System.Drawing.Size(19, 20);
            this.bmg_surplus_label.TabIndex = 20;
            this.bmg_surplus_label.Text = "0";
            // 
            // bmg_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Budget_Windows.Properties.Resources.piggy;
            this.ClientSize = new System.Drawing.Size(957, 513);
            this.Controls.Add(this.bmg_surplus_label);
            this.Controls.Add(this.calc_label_4);
            this.Controls.Add(this.calc_label_3);
            this.Controls.Add(this.bmg_calc_3);
            this.Controls.Add(this.bmg_calc_2);
            this.Controls.Add(this.bmg_calc_1);
            this.Controls.Add(this.calc_label_2);
            this.Controls.Add(this.calc_header);
            this.Controls.Add(this.calc_label_1);
            this.Controls.Add(this.bmg_yearSelector);
            this.Controls.Add(this.bmg_yearLabel);
            this.Controls.Add(this.bmg_monthLabel);
            this.Controls.Add(this.bmg_monthSelector);
            this.Controls.Add(this.bmg_label2);
            this.Controls.Add(this.bmg_label1);
            this.Controls.Add(this.bmg_list);
            this.Controls.Add(this.bmg_dater);
            this.Controls.Add(this.bmg_recordButton);
            this.Controls.Add(this.bmg_expenser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bmg_mainForm";
            this.Text = "Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bmg_expenser;
        private System.Windows.Forms.Button bmg_recordButton;
        private System.Windows.Forms.DateTimePicker bmg_dater;
        private System.Windows.Forms.ListView bmg_list;
        private System.Windows.Forms.ColumnHeader bmg_dates;
        private System.Windows.Forms.ColumnHeader bmg_expenses;
        private System.Windows.Forms.Label bmg_label1;
        private System.Windows.Forms.Label bmg_label2;
        private System.Windows.Forms.ComboBox bmg_monthSelector;
        private System.Windows.Forms.Label bmg_monthLabel;
        private System.Windows.Forms.Label bmg_yearLabel;
        private System.Windows.Forms.ComboBox bmg_yearSelector;
        private System.Windows.Forms.Label calc_label_1;
        private System.Windows.Forms.Label calc_header;
        private System.Windows.Forms.Label calc_label_2;
        private System.Windows.Forms.TextBox bmg_calc_1;
        private System.Windows.Forms.TextBox bmg_calc_2;
        private System.Windows.Forms.TextBox bmg_calc_3;
        private System.Windows.Forms.Label calc_label_3;
        private System.Windows.Forms.Label calc_label_4;
        private System.Windows.Forms.Label bmg_surplus_label;
    }
}

