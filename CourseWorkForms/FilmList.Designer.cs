namespace CourseWorkForms
{
    partial class frmFilmList
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
            this.lblFilmList = new System.Windows.Forms.Label();
            this.lstFilms = new System.Windows.Forms.ListBox();
            this.btnFilmDescriptions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilmList
            // 
            this.lblFilmList.AutoSize = true;
            this.lblFilmList.Location = new System.Drawing.Point(196, 9);
            this.lblFilmList.Name = "lblFilmList";
            this.lblFilmList.Size = new System.Drawing.Size(154, 15);
            this.lblFilmList.TabIndex = 0;
            this.lblFilmList.Text = "Top 10 Greatest Films Of All ";
            // 
            // lstFilms
            // 
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.ItemHeight = 15;
            this.lstFilms.Items.AddRange(new object[] {
            "Top 10 films of all time according to IMDb:",
            "1. The Shawshank Redemption (1994)",
            "2. The Godfather (1972)",
            "3. The Dark Knight (2008)",
            "4. The Godfather Part II (1974) ",
            "5. 12 Angry Men (1957)",
            "6. Schindler\'s List (1993)",
            "7. The Lord of the Rings: The Return of the King (2003)",
            "8. Pulp Fiction (1994)",
            "9. The Lord of the Rings: The Fellowship of the Ring (2001)",
            "10. The Good, the Bad and the Ugly (1966)"});
            this.lstFilms.Location = new System.Drawing.Point(1, 43);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(493, 184);
            this.lstFilms.TabIndex = 1;
            // 
            // btnFilmDescriptions
            // 
            this.btnFilmDescriptions.Location = new System.Drawing.Point(161, 243);
            this.btnFilmDescriptions.Name = "btnFilmDescriptions";
            this.btnFilmDescriptions.Size = new System.Drawing.Size(189, 23);
            this.btnFilmDescriptions.TabIndex = 2;
            this.btnFilmDescriptions.Text = "More Details Here ";
            this.btnFilmDescriptions.UseVisualStyleBackColor = true;
            this.btnFilmDescriptions.Click += new System.EventHandler(this.btnFilmDescriptions_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 303);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnFilmDescriptions);
            this.Controls.Add(this.lstFilms);
            this.Controls.Add(this.lblFilmList);
            this.Name = "frmFilmList";
            this.Text = "Film List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFilmList;
        private ListBox lstFilms;
        private Button btnFilmDescriptions;
        private Button btnHome;
    }
}