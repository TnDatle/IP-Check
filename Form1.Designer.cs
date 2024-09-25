namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIP = new TextBox();
            label1 = new Label();
            btCheck = new Button();
            txtResult = new RichTextBox();
            SuspendLayout();
            // 
            // txtIP
            // 
            txtIP.Location = new Point(199, 39);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(333, 27);
            txtIP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập IP:";
            // 
            // btCheck
            // 
            btCheck.Location = new Point(305, 114);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(162, 44);
            btCheck.TabIndex = 2;
            btCheck.Text = "Kiểm tra";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(78, 192);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(708, 263);
            txtResult.TabIndex = 3;
            txtResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 481);
            Controls.Add(txtResult);
            Controls.Add(btCheck);
            Controls.Add(label1);
            Controls.Add(txtIP);
            Name = "Form1";
            Text = "Kiểm tra IP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIP;
        private Label label1;
        private Button btCheck;
        private RichTextBox txtResult;
    }
}
