
namespace LinhThongMinh.GUI
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
            this.tbDB = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(532, 30);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(158, 20);
            this.tbDB.TabIndex = 70;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(424, 461);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(90, 30);
            this.btNew.TabIndex = 69;
            this.btNew.Text = "Add";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(520, 461);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 30);
            this.btDelete.TabIndex = 68;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(616, 461);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 30);
            this.btEdit.TabIndex = 67;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Department";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Place of birth";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date of birth";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(712, 461);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 30);
            this.btExit.TabIndex = 66;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvEmployee.Location = new System.Drawing.Point(42, 122);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(758, 307);
            this.dgvEmployee.TabIndex = 65;
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(712, 33);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(87, 17);
            this.cbGender.TabIndex = 64;
            this.cbGender.Text = "Gender Male";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Date of birth";
            // 
            // tbPB
            // 
            this.tbPB.Location = new System.Drawing.Point(291, 68);
            this.tbPB.Name = "tbPB";
            this.tbPB.Size = new System.Drawing.Size(509, 20);
            this.tbPB.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Place of birth";
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(90, 68);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(122, 21);
            this.cbMajor.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Major";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(291, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(158, 20);
            this.tbName.TabIndex = 58;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(90, 30);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(122, 20);
            this.tbId.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 545);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

