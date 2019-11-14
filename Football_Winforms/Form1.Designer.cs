namespace Football_Winforms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matchupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teamselect_groupbox = new System.Windows.Forms.GroupBox();
            this.away_combo = new System.Windows.Forms.ComboBox();
            this.home_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homelabel = new System.Windows.Forms.Label();
            this.coinflip_groupbox = new System.Windows.Forms.GroupBox();
            this.tails_radio = new System.Windows.Forms.RadioButton();
            this.heads_radio = new System.Windows.Forms.RadioButton();
            this.visitorselects_label = new System.Windows.Forms.Label();
            this.flip_button = new System.Windows.Forms.Button();
            this.kickoff_button = new System.Windows.Forms.Button();
            this.winnerselection_group = new System.Windows.Forms.GroupBox();
            this.comma_label = new System.Windows.Forms.Label();
            this.whichchoice_label = new System.Windows.Forms.Label();
            this.coinlandson_label = new System.Windows.Forms.Label();
            this.headsortails_label = new System.Windows.Forms.Label();
            this.winner_label = new System.Windows.Forms.Label();
            this.defer_radio = new System.Windows.Forms.RadioButton();
            this.kickoff_radio = new System.Windows.Forms.RadioButton();
            this.receive_radio = new System.Windows.Forms.RadioButton();
            this.period_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.teamselect_groupbox.SuspendLayout();
            this.coinflip_groupbox.SuspendLayout();
            this.winnerselection_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matchupToolStripMenuItem
            // 
            this.matchupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripMenuItem,
            this.secondToolStripMenuItem,
            this.thirdToolStripMenuItem,
            this.fourthToolStripMenuItem,
            this.completeToolStripMenuItem,
            this.gameStatsToolStripMenuItem});
            this.matchupToolStripMenuItem.Name = "matchupToolStripMenuItem";
            this.matchupToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.matchupToolStripMenuItem.Text = "Matchup";
            // 
            // firstToolStripMenuItem
            // 
            this.firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            this.firstToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.firstToolStripMenuItem.Text = "First";
            // 
            // secondToolStripMenuItem
            // 
            this.secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            this.secondToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.secondToolStripMenuItem.Text = "Second";
            // 
            // thirdToolStripMenuItem
            // 
            this.thirdToolStripMenuItem.Name = "thirdToolStripMenuItem";
            this.thirdToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.thirdToolStripMenuItem.Text = "Third";
            // 
            // fourthToolStripMenuItem
            // 
            this.fourthToolStripMenuItem.Name = "fourthToolStripMenuItem";
            this.fourthToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fourthToolStripMenuItem.Text = "Fourth";
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.completeToolStripMenuItem.Text = "Complete";
            // 
            // gameStatsToolStripMenuItem
            // 
            this.gameStatsToolStripMenuItem.Name = "gameStatsToolStripMenuItem";
            this.gameStatsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gameStatsToolStripMenuItem.Text = "Game Stats";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.teamselect_groupbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.coinflip_groupbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flip_button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kickoff_button, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.winnerselection_group, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 421);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // teamselect_groupbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.teamselect_groupbox, 2);
            this.teamselect_groupbox.Controls.Add(this.away_combo);
            this.teamselect_groupbox.Controls.Add(this.home_combo);
            this.teamselect_groupbox.Controls.Add(this.label2);
            this.teamselect_groupbox.Controls.Add(this.homelabel);
            this.teamselect_groupbox.Location = new System.Drawing.Point(3, 3);
            this.teamselect_groupbox.Name = "teamselect_groupbox";
            this.tableLayoutPanel1.SetRowSpan(this.teamselect_groupbox, 2);
            this.teamselect_groupbox.Size = new System.Drawing.Size(394, 162);
            this.teamselect_groupbox.TabIndex = 0;
            this.teamselect_groupbox.TabStop = false;
            this.teamselect_groupbox.Text = "Team Selection";
            // 
            // away_combo
            // 
            this.away_combo.FormattingEnabled = true;
            this.away_combo.Location = new System.Drawing.Point(187, 91);
            this.away_combo.Name = "away_combo";
            this.away_combo.Size = new System.Drawing.Size(137, 21);
            this.away_combo.TabIndex = 3;
            // 
            // home_combo
            // 
            this.home_combo.FormattingEnabled = true;
            this.home_combo.Location = new System.Drawing.Point(187, 57);
            this.home_combo.Name = "home_combo";
            this.home_combo.Size = new System.Drawing.Size(137, 21);
            this.home_combo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Away Team";
            // 
            // homelabel
            // 
            this.homelabel.AutoSize = true;
            this.homelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homelabel.Location = new System.Drawing.Point(85, 58);
            this.homelabel.Name = "homelabel";
            this.homelabel.Size = new System.Drawing.Size(96, 20);
            this.homelabel.TabIndex = 0;
            this.homelabel.Text = "Home Team";
            // 
            // coinflip_groupbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.coinflip_groupbox, 2);
            this.coinflip_groupbox.Controls.Add(this.tails_radio);
            this.coinflip_groupbox.Controls.Add(this.heads_radio);
            this.coinflip_groupbox.Controls.Add(this.visitorselects_label);
            this.coinflip_groupbox.Location = new System.Drawing.Point(403, 3);
            this.coinflip_groupbox.Name = "coinflip_groupbox";
            this.tableLayoutPanel1.SetRowSpan(this.coinflip_groupbox, 2);
            this.coinflip_groupbox.Size = new System.Drawing.Size(394, 162);
            this.coinflip_groupbox.TabIndex = 1;
            this.coinflip_groupbox.TabStop = false;
            this.coinflip_groupbox.Text = "Coin Flip ";
            // 
            // tails_radio
            // 
            this.tails_radio.AutoSize = true;
            this.tails_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tails_radio.Location = new System.Drawing.Point(201, 91);
            this.tails_radio.Name = "tails_radio";
            this.tails_radio.Size = new System.Drawing.Size(59, 24);
            this.tails_radio.TabIndex = 2;
            this.tails_radio.TabStop = true;
            this.tails_radio.Text = "Tails";
            this.tails_radio.UseVisualStyleBackColor = true;
            // 
            // heads_radio
            // 
            this.heads_radio.AutoSize = true;
            this.heads_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heads_radio.Location = new System.Drawing.Point(201, 61);
            this.heads_radio.Name = "heads_radio";
            this.heads_radio.Size = new System.Drawing.Size(74, 24);
            this.heads_radio.TabIndex = 1;
            this.heads_radio.TabStop = true;
            this.heads_radio.Text = "Heads";
            this.heads_radio.UseVisualStyleBackColor = true;
            // 
            // visitorselects_label
            // 
            this.visitorselects_label.AutoSize = true;
            this.visitorselects_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorselects_label.Location = new System.Drawing.Point(84, 76);
            this.visitorselects_label.Name = "visitorselects_label";
            this.visitorselects_label.Size = new System.Drawing.Size(111, 20);
            this.visitorselects_label.TabIndex = 0;
            this.visitorselects_label.Text = "Visitor selects:";
            // 
            // flip_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flip_button, 2);
            this.flip_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flip_button.Location = new System.Drawing.Point(203, 171);
            this.flip_button.Name = "flip_button";
            this.flip_button.Size = new System.Drawing.Size(394, 36);
            this.flip_button.TabIndex = 2;
            this.flip_button.Text = "Flip the Coin";
            this.flip_button.UseVisualStyleBackColor = true;
            // 
            // kickoff_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kickoff_button, 2);
            this.kickoff_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kickoff_button.Location = new System.Drawing.Point(203, 381);
            this.kickoff_button.Name = "kickoff_button";
            this.kickoff_button.Size = new System.Drawing.Size(394, 37);
            this.kickoff_button.TabIndex = 3;
            this.kickoff_button.Text = "Kickoff";
            this.kickoff_button.UseVisualStyleBackColor = true;
            // 
            // winnerselection_group
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.winnerselection_group, 4);
            this.winnerselection_group.Controls.Add(this.period_label);
            this.winnerselection_group.Controls.Add(this.comma_label);
            this.winnerselection_group.Controls.Add(this.whichchoice_label);
            this.winnerselection_group.Controls.Add(this.coinlandson_label);
            this.winnerselection_group.Controls.Add(this.headsortails_label);
            this.winnerselection_group.Controls.Add(this.winner_label);
            this.winnerselection_group.Controls.Add(this.defer_radio);
            this.winnerselection_group.Controls.Add(this.kickoff_radio);
            this.winnerselection_group.Controls.Add(this.receive_radio);
            this.winnerselection_group.Location = new System.Drawing.Point(3, 213);
            this.winnerselection_group.Name = "winnerselection_group";
            this.tableLayoutPanel1.SetRowSpan(this.winnerselection_group, 2);
            this.winnerselection_group.Size = new System.Drawing.Size(794, 162);
            this.winnerselection_group.TabIndex = 4;
            this.winnerselection_group.TabStop = false;
            this.winnerselection_group.Text = "Winner Selection";
            // 
            // comma_label
            // 
            this.comma_label.AutoSize = true;
            this.comma_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comma_label.Location = new System.Drawing.Point(406, 70);
            this.comma_label.Name = "comma_label";
            this.comma_label.Size = new System.Drawing.Size(13, 20);
            this.comma_label.TabIndex = 7;
            this.comma_label.Text = ",";
            // 
            // whichchoice_label
            // 
            this.whichchoice_label.AutoSize = true;
            this.whichchoice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichchoice_label.Location = new System.Drawing.Point(257, 92);
            this.whichchoice_label.Name = "whichchoice_label";
            this.whichchoice_label.Size = new System.Drawing.Size(162, 20);
            this.whichchoice_label.TabIndex = 6;
            this.whichchoice_label.Text = "which will you choose:";
            this.whichchoice_label.Click += new System.EventHandler(this.whichchoice_label_Click);
            // 
            // coinlandson_label
            // 
            this.coinlandson_label.AutoSize = true;
            this.coinlandson_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinlandson_label.Location = new System.Drawing.Point(257, 52);
            this.coinlandson_label.Name = "coinlandson_label";
            this.coinlandson_label.Size = new System.Drawing.Size(137, 20);
            this.coinlandson_label.TabIndex = 5;
            this.coinlandson_label.Text = "The coin lands on:";
            // 
            // headsortails_label
            // 
            this.headsortails_label.AutoSize = true;
            this.headsortails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsortails_label.Location = new System.Drawing.Point(257, 72);
            this.headsortails_label.Name = "headsortails_label";
            this.headsortails_label.Size = new System.Drawing.Size(41, 20);
            this.headsortails_label.TabIndex = 4;
            this.headsortails_label.Text = "Tails";
            // 
            // winner_label
            // 
            this.winner_label.AutoSize = true;
            this.winner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_label.Location = new System.Drawing.Point(315, 72);
            this.winner_label.Name = "winner_label";
            this.winner_label.Size = new System.Drawing.Size(94, 20);
            this.winner_label.TabIndex = 3;
            this.winner_label.Text = "Buccaneers";
            // 
            // defer_radio
            // 
            this.defer_radio.AutoSize = true;
            this.defer_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defer_radio.Location = new System.Drawing.Point(454, 107);
            this.defer_radio.Name = "defer_radio";
            this.defer_radio.Size = new System.Drawing.Size(67, 24);
            this.defer_radio.TabIndex = 2;
            this.defer_radio.TabStop = true;
            this.defer_radio.Text = "Defer";
            this.defer_radio.UseVisualStyleBackColor = true;
            // 
            // kickoff_radio
            // 
            this.kickoff_radio.AutoSize = true;
            this.kickoff_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kickoff_radio.Location = new System.Drawing.Point(454, 68);
            this.kickoff_radio.Name = "kickoff_radio";
            this.kickoff_radio.Size = new System.Drawing.Size(75, 24);
            this.kickoff_radio.TabIndex = 1;
            this.kickoff_radio.TabStop = true;
            this.kickoff_radio.Text = "Kickoff";
            this.kickoff_radio.UseVisualStyleBackColor = true;
            // 
            // receive_radio
            // 
            this.receive_radio.AutoSize = true;
            this.receive_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receive_radio.Location = new System.Drawing.Point(454, 32);
            this.receive_radio.Name = "receive_radio";
            this.receive_radio.Size = new System.Drawing.Size(84, 24);
            this.receive_radio.TabIndex = 0;
            this.receive_radio.TabStop = true;
            this.receive_radio.Text = "Receive";
            this.receive_radio.UseVisualStyleBackColor = true;
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_label.Location = new System.Drawing.Point(296, 72);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(13, 20);
            this.period_label.TabIndex = 8;
            this.period_label.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Football";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.teamselect_groupbox.ResumeLayout(false);
            this.teamselect_groupbox.PerformLayout();
            this.coinflip_groupbox.ResumeLayout(false);
            this.coinflip_groupbox.PerformLayout();
            this.winnerselection_group.ResumeLayout(false);
            this.winnerselection_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matchupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStatsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox teamselect_groupbox;
        private System.Windows.Forms.ComboBox away_combo;
        private System.Windows.Forms.ComboBox home_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label homelabel;
        private System.Windows.Forms.GroupBox coinflip_groupbox;
        private System.Windows.Forms.RadioButton tails_radio;
        private System.Windows.Forms.RadioButton heads_radio;
        private System.Windows.Forms.Label visitorselects_label;
        private System.Windows.Forms.Button flip_button;
        private System.Windows.Forms.Button kickoff_button;
        private System.Windows.Forms.GroupBox winnerselection_group;
        private System.Windows.Forms.Label comma_label;
        private System.Windows.Forms.Label whichchoice_label;
        private System.Windows.Forms.Label coinlandson_label;
        private System.Windows.Forms.Label headsortails_label;
        private System.Windows.Forms.Label winner_label;
        private System.Windows.Forms.RadioButton defer_radio;
        private System.Windows.Forms.RadioButton kickoff_radio;
        private System.Windows.Forms.RadioButton receive_radio;
        private System.Windows.Forms.Label period_label;
    }
}

