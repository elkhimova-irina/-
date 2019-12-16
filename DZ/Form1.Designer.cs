namespace ДЗ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(43, 25);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(178, 51);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "buttonLoadFile";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(277, 63);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(100, 31);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(406, 63);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(100, 31);
            this.textBoxFind.TabIndex = 4;
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(43, 124);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(178, 49);
            this.buttonExact.TabIndex = 5;
            this.buttonExact.Text = "buttonExact";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(277, 152);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(100, 31);
            this.textBoxExactTime.TabIndex = 7;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(575, 39);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(617, 329);
            this.listBoxResult.TabIndex = 8;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(277, 217);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(100, 31);
            this.textBoxApproxTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // buttonApprox
            // 
            this.buttonApprox.Location = new System.Drawing.Point(43, 210);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(178, 48);
            this.buttonApprox.TabIndex = 11;
            this.buttonApprox.Text = "buttonApprox";
            this.buttonApprox.UseVisualStyleBackColor = true;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(277, 265);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(100, 31);
            this.textBoxMaxDist.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(845, 574);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 45);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(575, 574);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(201, 45);
            this.buttonSaveReport.TabIndex = 15;
            this.buttonSaveReport.Text = "buttonSaveReport";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(277, 337);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(100, 31);
            this.textBoxFileReadCount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(277, 394);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(100, 31);
            this.textBoxThreadCount.TabIndex = 18;
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(277, 449);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(100, 31);
            this.textBoxThreadCountAll.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 678);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

