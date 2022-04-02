
namespace LiamCharles_BinaryTree
{
    partial class MainForm
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
            this.lblMovies = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblErrorMessageCreation = new System.Windows.Forms.Label();
            this.tbSearchPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrorMessageSearch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(558, 35);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(45, 15);
            this.lblMovies.TabIndex = 1;
            this.lblMovies.Text = "Movies";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 35);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 23);
            this.tbTitle.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(87, 65);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 23);
            this.tbPrice.TabIndex = 4;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(87, 95);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(100, 23);
            this.tbRating.TabIndex = 5;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(87, 125);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(100, 23);
            this.tbDirector.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Director";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 155);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblErrorMessageCreation
            // 
            this.lblErrorMessageCreation.AutoSize = true;
            this.lblErrorMessageCreation.Location = new System.Drawing.Point(28, 193);
            this.lblErrorMessageCreation.Name = "lblErrorMessageCreation";
            this.lblErrorMessageCreation.Size = new System.Drawing.Size(129, 15);
            this.lblErrorMessageCreation.TabIndex = 12;
            this.lblErrorMessageCreation.Text = "Error Message Creation";
            // 
            // tbSearchPrice
            // 
            this.tbSearchPrice.Location = new System.Drawing.Point(323, 65);
            this.tbSearchPrice.Name = "tbSearchPrice";
            this.tbSearchPrice.Size = new System.Drawing.Size(100, 23);
            this.tbSearchPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(323, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Create Movie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search Movie:";
            // 
            // lblErrorMessageSearch
            // 
            this.lblErrorMessageSearch.AutoSize = true;
            this.lblErrorMessageSearch.Location = new System.Drawing.Point(263, 133);
            this.lblErrorMessageSearch.Name = "lblErrorMessageSearch";
            this.lblErrorMessageSearch.Size = new System.Drawing.Size(119, 15);
            this.lblErrorMessageSearch.TabIndex = 20;
            this.lblErrorMessageSearch.Text = "Error Message Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Title";
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Location = new System.Drawing.Point(323, 35);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(100, 23);
            this.tbSearchTitle.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearchTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblErrorMessageSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSearchPrice);
            this.Controls.Add(this.lblErrorMessageCreation);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblMovies);
            this.Name = "MainForm";
            this.Text = "Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblErrorMessageCreation;
        private System.Windows.Forms.TextBox tbSearchPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrorMessageSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchTitle;
    }
}

