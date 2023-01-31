namespace Currency_Exchange_Office
{
    partial class Desposit_Form
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DespositeBtn = new System.Windows.Forms.Button();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Client_id = new System.Windows.Forms.MaskedTextBox();
            this.Despt_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Despt_money_now = new System.Windows.Forms.TextBox();
            this.Despt_money_add = new System.Windows.Forms.TextBox();
            this.Despt_money_prv = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetDataClientBtn = new System.Windows.Forms.Button();
            this.DataClientGroup_Comp = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Controls.Add(this.DespositeBtn);
            this.panel3.Controls.Add(this.withdrawalBtn);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(9, 288);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 97);
            this.panel3.TabIndex = 5;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoEllipsis = true;
            this.BackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.Red;
            this.BackBtn.Location = new System.Drawing.Point(9, 50);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(185, 34);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "رجوع";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // DespositeBtn
            // 
            this.DespositeBtn.AutoEllipsis = true;
            this.DespositeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DespositeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DespositeBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DespositeBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DespositeBtn.Location = new System.Drawing.Point(232, 9);
            this.DespositeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DespositeBtn.Name = "DespositeBtn";
            this.DespositeBtn.Size = new System.Drawing.Size(229, 34);
            this.DespositeBtn.TabIndex = 2;
            this.DespositeBtn.Text = "ايداع";
            this.DespositeBtn.UseVisualStyleBackColor = false;
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.AutoEllipsis = true;
            this.withdrawalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.withdrawalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.withdrawalBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawalBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.withdrawalBtn.Location = new System.Drawing.Point(232, 50);
            this.withdrawalBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(229, 34);
            this.withdrawalBtn.TabIndex = 1;
            this.withdrawalBtn.Text = "سحب";
            this.withdrawalBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button2.Location = new System.Drawing.Point(9, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "تعديل وحفظ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Client_id);
            this.panel2.Controls.Add(this.Despt_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Despt_money_now);
            this.panel2.Controls.Add(this.Despt_money_add);
            this.panel2.Controls.Add(this.Despt_money_prv);
            this.panel2.Location = new System.Drawing.Point(9, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 212);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(413, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "الكود";
            // 
            // Client_id
            // 
            this.Client_id.BackColor = System.Drawing.Color.Cornsilk;
            this.Client_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Client_id.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_id.Location = new System.Drawing.Point(10, 20);
            this.Client_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Client_id.Name = "Client_id";
            this.Client_id.ReadOnly = true;
            this.Client_id.Size = new System.Drawing.Size(263, 28);
            this.Client_id.TabIndex = 9;
            this.Client_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Despt_date
            // 
            this.Despt_date.CalendarFont = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Despt_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Despt_date.Enabled = false;
            this.Despt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Despt_date.Location = new System.Drawing.Point(10, 167);
            this.Despt_date.Name = "Despt_date";
            this.Despt_date.Size = new System.Drawing.Size(263, 28);
            this.Despt_date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(399, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(352, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "القيمة الحالية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "القيمة المضافة/الماخوذة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "القيمة السابقة";
            // 
            // Despt_money_now
            // 
            this.Despt_money_now.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Despt_money_now.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Despt_money_now.Location = new System.Drawing.Point(10, 129);
            this.Despt_money_now.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Despt_money_now.Name = "Despt_money_now";
            this.Despt_money_now.Size = new System.Drawing.Size(263, 28);
            this.Despt_money_now.TabIndex = 2;
            this.Despt_money_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Despt_money_add
            // 
            this.Despt_money_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Despt_money_add.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Despt_money_add.Location = new System.Drawing.Point(10, 94);
            this.Despt_money_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Despt_money_add.Name = "Despt_money_add";
            this.Despt_money_add.Size = new System.Drawing.Size(263, 28);
            this.Despt_money_add.TabIndex = 1;
            this.Despt_money_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Despt_money_add.TextChanged += new System.EventHandler(this.Despt_money_add_TextChanged);
            // 
            // Despt_money_prv
            // 
            this.Despt_money_prv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Despt_money_prv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Despt_money_prv.Location = new System.Drawing.Point(10, 58);
            this.Despt_money_prv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Despt_money_prv.Name = "Despt_money_prv";
            this.Despt_money_prv.Size = new System.Drawing.Size(263, 28);
            this.Despt_money_prv.TabIndex = 0;
            this.Despt_money_prv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.GetDataClientBtn);
            this.panel1.Controls.Add(this.DataClientGroup_Comp);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 141);
            this.panel1.TabIndex = 3;
            // 
            // GetDataClientBtn
            // 
            this.GetDataClientBtn.AutoEllipsis = true;
            this.GetDataClientBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GetDataClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GetDataClientBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetDataClientBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.GetDataClientBtn.Location = new System.Drawing.Point(306, 10);
            this.GetDataClientBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetDataClientBtn.Name = "GetDataClientBtn";
            this.GetDataClientBtn.Size = new System.Drawing.Size(156, 38);
            this.GetDataClientBtn.TabIndex = 4;
            this.GetDataClientBtn.Text = "استدعاء";
            this.GetDataClientBtn.UseVisualStyleBackColor = false;
            this.GetDataClientBtn.Click += new System.EventHandler(this.GetDataClientBtn_Click);
            // 
            // DataClientGroup_Comp
            // 
            this.DataClientGroup_Comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataClientGroup_Comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataClientGroup_Comp.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataClientGroup_Comp.FormattingEnabled = true;
            this.DataClientGroup_Comp.Location = new System.Drawing.Point(10, 11);
            this.DataClientGroup_Comp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataClientGroup_Comp.Name = "DataClientGroup_Comp";
            this.DataClientGroup_Comp.Size = new System.Drawing.Size(263, 33);
            this.DataClientGroup_Comp.TabIndex = 0;
            // 
            // Desposit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Desposit_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الودائع";
            this.Load += new System.EventHandler(this.Desposit_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox DataClientGroup_Comp;
        private Panel panel2;
        private Panel panel3;
        private Button GetDataClientBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Despt_money_now;
        private TextBox Despt_money_add;
        private MaskedTextBox Despt_money_prv;
        private Button BackBtn;
        private Button DespositeBtn;
        private Button withdrawalBtn;
        private Button button2;
        private Label label4;
        private DateTimePicker Despt_date;
        private Label label5;
        private MaskedTextBox Client_id;
    }
}
