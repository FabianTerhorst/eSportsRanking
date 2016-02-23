namespace eSportsRanking
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("TestTeam");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("TestSpiel");
            this.lvLadder = new System.Windows.Forms.ListView();
            this.teamNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesWon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesLost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGames = new System.Windows.Forms.ListView();
            this.gameTeam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameTeam2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxWon = new System.Windows.Forms.TextBox();
            this.txtbxLost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTeam1 = new System.Windows.Forms.ComboBox();
            this.cbxTeam2 = new System.Windows.Forms.ComboBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLadder
            // 
            this.lvLadder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamNames,
            this.gamesWon,
            this.gamesLost,
            this.gamesCount});
            this.lvLadder.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvLadder.Location = new System.Drawing.Point(12, 12);
            this.lvLadder.Name = "lvLadder";
            this.lvLadder.Size = new System.Drawing.Size(389, 377);
            this.lvLadder.TabIndex = 0;
            this.lvLadder.UseCompatibleStateImageBehavior = false;
            this.lvLadder.View = System.Windows.Forms.View.Details;
            // 
            // teamNames
            // 
            this.teamNames.Text = "Teamname";
            this.teamNames.Width = 106;
            // 
            // gamesWon
            // 
            this.gamesWon.Text = "Gewonnene Spiele";
            this.gamesWon.Width = 102;
            // 
            // gamesLost
            // 
            this.gamesLost.Text = "Verlorene Spiele";
            this.gamesLost.Width = 89;
            // 
            // gamesCount
            // 
            this.gamesCount.Text = "Gespielte Spiele";
            this.gamesCount.Width = 88;
            // 
            // lvGames
            // 
            this.lvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameTeam1,
            this.gameTeam2});
            this.lvGames.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lvGames.Location = new System.Drawing.Point(409, 12);
            this.lvGames.Name = "lvGames";
            this.lvGames.Size = new System.Drawing.Size(389, 377);
            this.lvGames.TabIndex = 1;
            this.lvGames.UseCompatibleStateImageBehavior = false;
            this.lvGames.View = System.Windows.Forms.View.Details;
            // 
            // gameTeam1
            // 
            this.gameTeam1.Text = "Team 1";
            this.gameTeam1.Width = 193;
            // 
            // gameTeam2
            // 
            this.gameTeam2.Text = "Team 2";
            this.gameTeam2.Width = 192;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(12, 419);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(228, 23);
            this.btnAddTeam.TabIndex = 2;
            this.btnAddTeam.Text = "Team hinzufügen";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(50, 395);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(177, 20);
            this.txtbxName.TabIndex = 4;
            // 
            // txtbxWon
            // 
            this.txtbxWon.Location = new System.Drawing.Point(351, 395);
            this.txtbxWon.Name = "txtbxWon";
            this.txtbxWon.Size = new System.Drawing.Size(50, 20);
            this.txtbxWon.TabIndex = 5;
            // 
            // txtbxLost
            // 
            this.txtbxLost.Location = new System.Drawing.Point(351, 421);
            this.txtbxLost.Name = "txtbxLost";
            this.txtbxLost.Size = new System.Drawing.Size(50, 20);
            this.txtbxLost.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gewonnene Spiele:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Verlorene Spiele:";
            // 
            // cbxTeam1
            // 
            this.cbxTeam1.FormattingEnabled = true;
            this.cbxTeam1.Location = new System.Drawing.Point(409, 395);
            this.cbxTeam1.Name = "cbxTeam1";
            this.cbxTeam1.Size = new System.Drawing.Size(193, 21);
            this.cbxTeam1.TabIndex = 9;
            // 
            // cbxTeam2
            // 
            this.cbxTeam2.FormattingEnabled = true;
            this.cbxTeam2.Location = new System.Drawing.Point(605, 395);
            this.cbxTeam2.Name = "cbxTeam2";
            this.cbxTeam2.Size = new System.Drawing.Size(193, 21);
            this.cbxTeam2.TabIndex = 10;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(409, 419);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(389, 23);
            this.btnAddGame.TabIndex = 11;
            this.btnAddGame.Text = "Spiel hinzufügen";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 454);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.cbxTeam2);
            this.Controls.Add(this.cbxTeam1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxLost);
            this.Controls.Add(this.txtbxWon);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lvGames);
            this.Controls.Add(this.lvLadder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLadder;
        private System.Windows.Forms.ListView lvGames;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxWon;
        private System.Windows.Forms.TextBox txtbxLost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTeam1;
        private System.Windows.Forms.ComboBox cbxTeam2;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.ColumnHeader teamNames;
        private System.Windows.Forms.ColumnHeader gamesWon;
        private System.Windows.Forms.ColumnHeader gamesLost;
        private System.Windows.Forms.ColumnHeader gamesCount;
        private System.Windows.Forms.ColumnHeader gameTeam1;
        private System.Windows.Forms.ColumnHeader gameTeam2;
    }
}

