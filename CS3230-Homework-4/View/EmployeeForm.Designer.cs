namespace CS3230_Homework_4.View
{
    partial class Cs3230Homework4
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.superSSNTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGridViewlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 99);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(1047, 250);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter SSN of Supervisor";
            // 
            // superSSNTextBox
            // 
            this.superSSNTextBox.AllowDrop = true;
            this.superSSNTextBox.Location = new System.Drawing.Point(480, 32);
            this.superSSNTextBox.Name = "superSSNTextBox";
            this.superSSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.superSSNTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(596, 30);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dataGridViewlabel
            // 
            this.dataGridViewlabel.AutoSize = true;
            this.dataGridViewlabel.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewlabel.Name = "dataGridViewlabel";
            this.dataGridViewlabel.Size = new System.Drawing.Size(150, 13);
            this.dataGridViewlabel.TabIndex = 4;
            this.dataGridViewlabel.Text = "Employees that they supervise";
            // 
            // Cs3230Homework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 361);
            this.Controls.Add(this.dataGridViewlabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.superSSNTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "Cs3230Homework4";
            this.Text = "CS 3230 - Homework 4";
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox superSSNTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label dataGridViewlabel;
    }
}

