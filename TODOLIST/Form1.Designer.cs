﻿namespace TODOLIST
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you need to do?";
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(18, 41);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(525, 20);
            this.txtNewToDo.TabIndex = 1;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(646, 41);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDo.TabIndex = 2;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Remove checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(18, 111);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(598, 94);
            this.clsToDo.TabIndex = 5;
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(18, 343);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(610, 95);
            this.lstDone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deleted Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Things to do";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(566, 13);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(58, 17);
            this.chkUrgent.TabIndex = 9;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.clsToDo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUrgent;
    }
}

