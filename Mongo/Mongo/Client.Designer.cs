namespace Mongo
{
    partial class Client
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
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txForename = new System.Windows.Forms.TextBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(23, 23);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 1;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(23, 59);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // txForename
            // 
            this.txForename.Location = new System.Drawing.Point(101, 20);
            this.txForename.Name = "txForename";
            this.txForename.Size = new System.Drawing.Size(100, 20);
            this.txForename.TabIndex = 4;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(101, 56);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 20);
            this.txSurname.TabIndex = 5;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 104);
            this.Controls.Add(this.txSurname);
            this.Controls.Add(this.txForename);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txForename;
        private System.Windows.Forms.TextBox txSurname;
    }
}

