namespace CourseWorkForms
{
    partial class frmUserList
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
            this.lstUserData = new System.Windows.Forms.ListBox();
            this.lblFavouriteFilms = new System.Windows.Forms.Label();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnToFile = new System.Windows.Forms.Button();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUserData
            // 
            this.lstUserData.FormattingEnabled = true;
            this.lstUserData.ItemHeight = 15;
            this.lstUserData.Location = new System.Drawing.Point(79, 50);
            this.lstUserData.Name = "lstUserData";
            this.lstUserData.Size = new System.Drawing.Size(337, 229);
            this.lstUserData.TabIndex = 0;
            this.lstUserData.SelectedIndexChanged += new System.EventHandler(this.lstUserData_SelectedIndexChanged);
            // 
            // lblFavouriteFilms
            // 
            this.lblFavouriteFilms.AutoSize = true;
            this.lblFavouriteFilms.Location = new System.Drawing.Point(122, 9);
            this.lblFavouriteFilms.Name = "lblFavouriteFilms";
            this.lblFavouriteFilms.Size = new System.Drawing.Size(200, 15);
            this.lblFavouriteFilms.TabIndex = 1;
            this.lblFavouriteFilms.Text = "Create Your Own Favourite Films List";
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(122, 337);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(184, 23);
            this.btnUpdateList.TabIndex = 2;
            this.btnUpdateList.Text = "Add to List";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(122, 366);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove From List";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(106, 285);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(337, 23);
            this.txtUserInput.TabIndex = 4;
            // 
            // btnToFile
            // 
            this.btnToFile.Location = new System.Drawing.Point(341, 343);
            this.btnToFile.Name = "btnToFile";
            this.btnToFile.Size = new System.Drawing.Size(75, 53);
            this.btnToFile.TabIndex = 6;
            this.btnToFile.Text = "Save To Pc";
            this.btnToFile.UseVisualStyleBackColor = true;
            this.btnToFile.Click += new System.EventHandler(this.btnToFile_Click);
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(106, 314);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(337, 23);
            this.txtReleaseDate.TabIndex = 7;
            this.txtReleaseDate.TextChanged += new System.EventHandler(this.txtReleaseDate_TextChanged);
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Location = new System.Drawing.Point(12, 293);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(65, 15);
            this.lblFilmName.TabIndex = 8;
            this.lblFilmName.Text = "Film Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(12, 322);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(70, 15);
            this.lblReleaseDate.TabIndex = 9;
            this.lblReleaseDate.Text = "ReleaseDate";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(2, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 401);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblFilmName);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.btnToFile);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.lblFavouriteFilms);
            this.Controls.Add(this.lstUserData);
            this.Name = "frmUserList";
            this.Text = "Create Your Own List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstUserData;
        private Label lblFavouriteFilms;
        private Button btnUpdateList;
        private Button btnRemove;
        private TextBox txtUserInput;
        private Button btnToFile;
        private TextBox txtReleaseDate;
        private Label lblFilmName;
        private Label lblReleaseDate;
        private Button btnHome;
    }
}