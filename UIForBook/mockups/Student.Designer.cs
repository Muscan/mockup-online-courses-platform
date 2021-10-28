
namespace UIForBook
{
    partial class Student
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(80, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome...";
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(25, 50);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(106, 20);
            this.lblCourses.TabIndex = 1;
            this.lblCourses.Text = "Cursuri inscrise";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(266, 50);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(111, 20);
            this.lblBooks.TabIndex = 2;
            this.lblBooks.Text = "Carti biblioteca";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(618, 50);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(53, 20);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Detalii";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(507, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(603, 73);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(94, 29);
            this.btnEditDetails.TabIndex = 6;
            this.btnEditDetails.Text = "Details Edit";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(266, 73);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(94, 29);
            this.btnBooks.TabIndex = 7;
            this.btnBooks.Text = "View Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(37, 72);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(94, 29);
            this.btnCourses.TabIndex = 8;
            this.btnCourses.Text = "View Cursuri";
            this.btnCourses.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Student";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnCourses;
    }
}