using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> hometeams = TeamNames.TeamNamesList();
            List<string> awayteams = TeamNames.TeamNamesList();
 
            home_combo.DataSource = hometeams;
            away_combo.DataSource = awayteams;

            home_combo.DisplayMember = "tablename";
            away_combo.DisplayMember = "tablename";            
        }

        private void whichchoice_label_Click(object sender, EventArgs e)
        {

        }

        private void flip_button_Click(object sender, EventArgs e)
        {
            this.winnerselection_group.Visible = true;
            this.kickoff_button.Visible = true;
        }
    }
}
