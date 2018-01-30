namespace Spare5___Task_Checker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrompt2 = new System.Windows.Forms.Label();
            this.lblPrompt3 = new System.Windows.Forms.Label();
            this.txtPageDelay = new System.Windows.Forms.TextBox();
            this.txtRefreshDelay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(75, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(450, 20);
            this.txtURL.TabIndex = 0;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 15);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(57, 13);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Task Link:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(75, 486);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(166, 491);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: ";
            // 
            // lblPrompt2
            // 
            this.lblPrompt2.AutoSize = true;
            this.lblPrompt2.Location = new System.Drawing.Point(12, 72);
            this.lblPrompt2.Name = "lblPrompt2";
            this.lblPrompt2.Size = new System.Drawing.Size(123, 13);
            this.lblPrompt2.TabIndex = 4;
            this.lblPrompt2.Text = "Page Load Delay (Sec): ";
            // 
            // lblPrompt3
            // 
            this.lblPrompt3.AutoSize = true;
            this.lblPrompt3.Location = new System.Drawing.Point(12, 142);
            this.lblPrompt3.Name = "lblPrompt3";
            this.lblPrompt3.Size = new System.Drawing.Size(105, 13);
            this.lblPrompt3.TabIndex = 5;
            this.lblPrompt3.Text = "Refresh Delay (Sec):";
            // 
            // txtPageDelay
            // 
            this.txtPageDelay.Location = new System.Drawing.Point(138, 69);
            this.txtPageDelay.Name = "txtPageDelay";
            this.txtPageDelay.Size = new System.Drawing.Size(387, 20);
            this.txtPageDelay.TabIndex = 2;
            // 
            // txtRefreshDelay
            // 
            this.txtRefreshDelay.Location = new System.Drawing.Point(126, 139);
            this.txtRefreshDelay.Name = "txtRefreshDelay";
            this.txtRefreshDelay.Size = new System.Drawing.Size(399, 20);
            this.txtRefreshDelay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 537);
            this.Controls.Add(this.txtRefreshDelay);
            this.Controls.Add(this.txtPageDelay);
            this.Controls.Add(this.lblPrompt3);
            this.Controls.Add(this.lblPrompt2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spare 5 - Task Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrompt2;
        private System.Windows.Forms.Label lblPrompt3;
        private System.Windows.Forms.TextBox txtPageDelay;
        private System.Windows.Forms.TextBox txtRefreshDelay;
    }
}

