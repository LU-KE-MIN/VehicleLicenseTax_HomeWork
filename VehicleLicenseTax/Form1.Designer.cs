
namespace VehicleLicenseTax
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_SendData = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MotorCC_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SelectCarType = new System.Windows.Forms.ComboBox();
            this.DayGroup = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ShowResult = new System.Windows.Forms.TextBox();
            this.DayGroup.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SendData.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Btn_SendData.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SendData.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_SendData.Location = new System.Drawing.Point(238, 492);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(75, 34);
            this.Btn_SendData.TabIndex = 10;
            this.Btn_SendData.Text = "確定送出";
            this.Btn_SendData.UseVisualStyleBackColor = false;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Btn_Reset.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Reset.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_Reset.Location = new System.Drawing.Point(377, 492);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 34);
            this.Btn_Reset.TabIndex = 11;
            this.Btn_Reset.Text = "取消重填";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MotorCC_Type
            // 
            this.MotorCC_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorCC_Type.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MotorCC_Type.FormattingEnabled = true;
            this.MotorCC_Type.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)"});
            this.MotorCC_Type.Location = new System.Drawing.Point(153, 285);
            this.MotorCC_Type.Name = "MotorCC_Type";
            this.MotorCC_Type.Size = new System.Drawing.Size(287, 27);
            this.MotorCC_Type.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(141, 170);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 23);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全年度";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(226, 170);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 23);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "依期間";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SelectCarType
            // 
            this.SelectCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCarType.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectCarType.FormattingEnabled = true;
            this.SelectCarType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.SelectCarType.Location = new System.Drawing.Point(153, 228);
            this.SelectCarType.Name = "SelectCarType";
            this.SelectCarType.Size = new System.Drawing.Size(287, 27);
            this.SelectCarType.TabIndex = 0;
            this.SelectCarType.SelectedIndexChanged += new System.EventHandler(this.SelectCarType_SelectedIndexChanged);
            // 
            // DayGroup
            // 
            this.DayGroup.Controls.Add(this.dateTimePicker2);
            this.DayGroup.Controls.Add(this.dateTimePicker1);
            this.DayGroup.Controls.Add(this.label6);
            this.DayGroup.Controls.Add(this.label5);
            this.DayGroup.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DayGroup.Location = new System.Drawing.Point(308, 148);
            this.DayGroup.Name = "DayGroup";
            this.DayGroup.Size = new System.Drawing.Size(477, 53);
            this.DayGroup.TabIndex = 8;
            this.DayGroup.TabStop = false;
            this.DayGroup.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 30);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(203, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "從";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "汽缸CC數／馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(0, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "貼心小叮嚀：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(28, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(809, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "1.本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(2, 19);
            this.linkLabel1.Location = new System.Drawing.Point(31, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(398, 29);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2.使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.ShowResult);
            this.MainPanel.Controls.Add(this.linkLabel1);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.DayGroup);
            this.MainPanel.Controls.Add(this.SelectCarType);
            this.MainPanel.Controls.Add(this.radioButton2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.radioButton1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.MotorCC_Type);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(872, 474);
            this.MainPanel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(50, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "使用牌照稅應納稅額試算";
            // 
            // ShowResult
            // 
            this.ShowResult.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowResult.Location = new System.Drawing.Point(158, 323);
            this.ShowResult.Multiline = true;
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.ReadOnly = true;
            this.ShowResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowResult.Size = new System.Drawing.Size(512, 148);
            this.ShowResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 577);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DayGroup.ResumeLayout(false);
            this.DayGroup.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_SendData;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MotorCC_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox SelectCarType;
        private System.Windows.Forms.GroupBox DayGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox ShowResult;
        private System.Windows.Forms.Label label9;
    }
}

