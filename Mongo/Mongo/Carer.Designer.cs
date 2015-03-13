namespace Mongo
{
    partial class Carer
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxCarer = new System.Windows.Forms.GroupBox();
            this.gbxCarers = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.gbxCarer.SuspendLayout();
            this.gbxCarers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 75);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(80, 72);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(21, 49);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 5;
            this.lblForename.Text = "Forename:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(80, 46);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(148, 20);
            this.txtForename.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(153, 107);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 8;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbxCarer
            // 
            this.gbxCarer.Controls.Add(this.btnDelete);
            this.gbxCarer.Controls.Add(this.btnCreate);
            this.gbxCarer.Controls.Add(this.lblId);
            this.gbxCarer.Controls.Add(this.txtId);
            this.gbxCarer.Controls.Add(this.btnClear);
            this.gbxCarer.Controls.Add(this.btnSave);
            this.gbxCarer.Controls.Add(this.btnPopulate);
            this.gbxCarer.Controls.Add(this.lblSurname);
            this.gbxCarer.Controls.Add(this.txtSurname);
            this.gbxCarer.Controls.Add(this.lblForename);
            this.gbxCarer.Controls.Add(this.txtForename);
            this.gbxCarer.Location = new System.Drawing.Point(14, 12);
            this.gbxCarer.Name = "gbxCarer";
            this.gbxCarer.Size = new System.Drawing.Size(267, 222);
            this.gbxCarer.TabIndex = 11;
            this.gbxCarer.TabStop = false;
            this.gbxCarer.Text = "Carer";
            // 
            // gbxCarers
            // 
            this.gbxCarers.Controls.Add(this.txtResults);
            this.gbxCarers.Controls.Add(this.btnFindAll);
            this.gbxCarers.Controls.Add(this.btnReset);
            this.gbxCarers.Location = new System.Drawing.Point(326, 12);
            this.gbxCarers.Name = "gbxCarers";
            this.gbxCarers.Size = new System.Drawing.Size(320, 222);
            this.gbxCarers.TabIndex = 12;
            this.gbxCarers.TabStop = false;
            this.gbxCarers.Text = "Carers";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 20);
            this.txtId.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(25, 107);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(239, 22);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(75, 23);
            this.btnFindAll.TabIndex = 13;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(24, 51);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(290, 161);
            this.txtResults.TabIndex = 14;
            // 
            // Carer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 251);
            this.Controls.Add(this.gbxCarers);
            this.Controls.Add(this.gbxCarer);
            this.Name = "Carer";
            this.Text = "Carer";
            this.gbxCarer.ResumeLayout(false);
            this.gbxCarer.PerformLayout();
            this.gbxCarers.ResumeLayout(false);
            this.gbxCarers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbxCarer;
        private System.Windows.Forms.GroupBox gbxCarers;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResults;
    }
}