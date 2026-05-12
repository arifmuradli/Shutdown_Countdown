namespace Final_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WarningTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.reject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningTimer
            // 
            this.WarningTimer.Interval = 1000;
            this.WarningTimer.Tick += new System.EventHandler(this.warningTimer_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(53, 353);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(110, 50);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "15:00";
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(12, 26);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(765, 277);
            this.warning.TabIndex = 1;
            this.warning.Text = resources.GetString("warning.Text");
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reject
            // 
            this.reject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reject.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reject.Location = new System.Drawing.Point(497, 344);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(248, 59);
            this.reject.TabIndex = 2;
            this.reject.Text = "REJECT";
            this.reject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reject.UseVisualStyleBackColor = true;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.reject;
            this.ClientSize = new System.Drawing.Size(804, 439);
            this.ControlBox = false;
            this.Controls.Add(this.reject);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.countdownLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer WarningTimer;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button reject;
    }
}

