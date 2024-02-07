namespace CourseWorkForms
{
    partial class frmFilmTrivia
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
            this.lblFilmTrivia = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnReveal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilmTrivia
            // 
            this.lblFilmTrivia.AutoSize = true;
            this.lblFilmTrivia.Location = new System.Drawing.Point(130, 9);
            this.lblFilmTrivia.Name = "lblFilmTrivia";
            this.lblFilmTrivia.Size = new System.Drawing.Size(200, 15);
            this.lblFilmTrivia.TabIndex = 0;
            this.lblFilmTrivia.Text = "How Well Do You Know This Movie ?";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(24, 298);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(414, 23);
            this.btnSubmitAnswer.TabIndex = 1;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Location = new System.Drawing.Point(24, 269);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(414, 23);
            this.txtUserAnswer.TabIndex = 2;
            this.txtUserAnswer.TextChanged += new System.EventHandler(this.txtUserAnswer_TextChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(95, 107);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 15);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(24, 240);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(414, 23);
            this.btnReveal.TabIndex = 4;
            this.btnReveal.Text = "Reveal Question";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // frmFilmTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 355);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblFilmTrivia);
            this.Name = "frmFilmTrivia";
            this.Text = "Film Trivia";
            this.Load += new System.EventHandler(this.frmFilmTrivia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFilmTrivia;
        private Button btnSubmitAnswer;
        private TextBox txtUserAnswer;
        private Label lblQuestion;
        private Button btnReveal;
    }
}