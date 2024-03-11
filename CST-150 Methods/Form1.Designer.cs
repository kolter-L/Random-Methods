namespace CST_150_Methods
{
    partial class FrmMain
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
            btnMain = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // btnMain
            // 
            btnMain.Location = new Point(239, 78);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(160, 23);
            btnMain.TabIndex = 0;
            btnMain.Text = "Execute_Methods";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += button1_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(297, 161);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(58, 18);
            lblResults.TabIndex = 1;
            lblResults.Text = "label1";
            lblResults.Click += label1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 540);
            Controls.Add(lblResults);
            Controls.Add(btnMain);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmMain";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMain;
        private Label lblResults;
    }
}
