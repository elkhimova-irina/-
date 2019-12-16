namespace lab4
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
            this.buttonExact = new System.Windows.Forms.Button();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(54, 45);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(190, 79);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "buttonLoadFile";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(54, 151);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(190, 70);
            this.buttonExact.TabIndex = 1;
            this.buttonExact.Text = "buttonExact";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click_1);
            // 
            // buttonApprox
            // 
            this.buttonApprox.Location = new System.Drawing.Point(54, 250);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(190, 70);
            this.buttonApprox.TabIndex = 2;
            this.buttonApprox.Text = "buttonApprox";
            this.buttonApprox.UseVisualStyleBackColor = true;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(517, 30);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(490, 179);
            this.listBoxResult.TabIndex = 3;
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(299, 45);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(168, 31);
            this.textBoxFileReadTime.TabIndex = 4;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(311, 151);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(156, 31);
            this.textBoxFind.TabIndex = 5;
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(311, 190);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(156, 31);
            this.textBoxExactTime.TabIndex = 6;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(311, 289);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(156, 31);
            this.textBoxApproxTime.TabIndex = 7;
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(311, 250);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(156, 31);
            this.textBoxMaxDist.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(639, 377);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(149, 48);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(383, 377);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(210, 48);
            this.buttonSaveReport.TabIndex = 10;
            this.buttonSaveReport.Text = "buttonSaveReport";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
    }
}

