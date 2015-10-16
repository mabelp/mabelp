namespace MabelpTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProtobufTarget = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProtobuf = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProtobufType = new System.Windows.Forms.ComboBox();
            this.ProbufResultFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtProtobufTarget
            // 
            this.txtProtobufTarget.Location = new System.Drawing.Point(66, 99);
            this.txtProtobufTarget.Name = "txtProtobufTarget";
            this.txtProtobufTarget.Size = new System.Drawing.Size(296, 151);
            this.txtProtobufTarget.TabIndex = 6;
            this.txtProtobufTarget.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probuf";
            // 
            // btnProtobuf
            // 
            this.btnProtobuf.Location = new System.Drawing.Point(388, 109);
            this.btnProtobuf.Name = "btnProtobuf";
            this.btnProtobuf.Size = new System.Drawing.Size(127, 23);
            this.btnProtobuf.TabIndex = 8;
            this.btnProtobuf.Text = "转换";
            this.btnProtobuf.UseVisualStyleBackColor = true;
            this.btnProtobuf.Click += new System.EventHandler(this.btnProtobuf_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(545, 99);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(302, 143);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "结果";
            // 
            // ProtobufType
            // 
            this.ProtobufType.FormattingEnabled = true;
            this.ProtobufType.Items.AddRange(new object[] {
            "CanBooking",
            "ResourceSearch",
            "FlightMarkInfo",
            "CheckHotel"});
            this.ProtobufType.Location = new System.Drawing.Point(388, 163);
            this.ProtobufType.Name = "ProtobufType";
            this.ProtobufType.Size = new System.Drawing.Size(121, 20);
            this.ProtobufType.TabIndex = 11;
            this.ProtobufType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ProbufResultFormat
            // 
            this.ProbufResultFormat.FormattingEnabled = true;
            this.ProbufResultFormat.Items.AddRange(new object[] {
            "XML",
            "JSON"});
            this.ProbufResultFormat.Location = new System.Drawing.Point(578, 73);
            this.ProbufResultFormat.Name = "ProbufResultFormat";
            this.ProbufResultFormat.Size = new System.Drawing.Size(121, 20);
            this.ProbufResultFormat.TabIndex = 12;
            this.ProbufResultFormat.Text = "XML";
            this.ProbufResultFormat.SelectedIndexChanged += new System.EventHandler(this.ProbufResultFormat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "接口";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "是否加密";
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.Location = new System.Drawing.Point(466, 195);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(36, 16);
            this.chkCompress.TabIndex = 16;
            this.chkCompress.Text = "是";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 532);
            this.Controls.Add(this.chkCompress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProbufResultFormat);
            this.Controls.Add(this.ProtobufType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnProtobuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProtobufTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtProtobufTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProtobuf;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProtobufType;
        private System.Windows.Forms.ComboBox ProbufResultFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCompress;
    }
}

