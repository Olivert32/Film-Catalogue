namespace CourseWorkForms
{
    partial class frmActorList
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
            this.lblActorsList = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActorsList
            // 
            this.lblActorsList.AutoSize = true;
            this.lblActorsList.Location = new System.Drawing.Point(189, 9);
            this.lblActorsList.Name = "lblActorsList";
            this.lblActorsList.Size = new System.Drawing.Size(132, 15);
            this.lblActorsList.TabIndex = 0;
            this.lblActorsList.Text = "Highest Paid Actors list ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Highest paid actors as of 2020:",
            "1.Dwayne Johnson ($87.5 M)",
            "2.Ryan Reynolds ($58 M)",
            "3.Mark Wahlberg ($55 M)",
            "4.Ben Affleck ($55 M)",
            "5. Vin Diesel ($54 M)",
            "6.Akshahy Kumar ($48.5 M)",
            "7.Lin-Manuek Miranda ($45.5 M)",
            "8.Will Smith ($44.5 M)",
            "9.Sofia Vergara ($43 M)",
            "10.Adam Sandler ($41 M)"});
            this.listBox1.Location = new System.Drawing.Point(12, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 319);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmActorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 397);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblActorsList);
            this.Name = "frmActorList";
            this.Text = "Actors List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblActorsList;
        private ListBox listBox1;
        private Button btnHome;
    }
}