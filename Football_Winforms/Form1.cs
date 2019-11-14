using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Football_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> hometeams = TeamNames.TeamNamesList();
            List<string> awayteams = TeamNames.TeamNamesList();

            hometeams.Insert(0, "Home Team");
            awayteams.Insert(0, "Away Team");

            home_combo.DataSource = hometeams;
            away_combo.DataSource = awayteams;

            home_combo.DisplayMember = "tablename";
            away_combo.DisplayMember = "tablename";

        }

        private static Boolean hometeamselected = false;
        private static Boolean awayteamselected = false;
        private static Boolean coinflipselected = false;
        private static string hometeam;
        private static string awayteam;

        private void whichchoice_label_Click(object sender, EventArgs e)
        {

        }

        private void flip_button_Click(object sender, EventArgs e)
        {
            if (hometeamselected && awayteamselected && coinflipselected)
            {
                this.coinflipresult_group.Visible = true;
                this.winnerselect_group.Visible = true;
                this.kickoff_button.Visible = true;
                CoinFlip();
            }
            else
            {
                string message = "Please select home and away teams as well as heads or tails";
                MessageBox.Show(message);
            }
        }

        private void home_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.selectedindexchanged?view=netframework-4.8
            //ComboBox comboBox = (ComboBox)sender;
            if ((string)home_combo.SelectedItem != "Home Team")
            {
                hometeamselected = true;
                hometeam = (string)home_combo.SelectedItem;
            }
        }

        private void away_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)away_combo.SelectedItem != "Away Team")
            {
                awayteamselected = true;
                awayteam = (string)away_combo.SelectedItem;
            }
        }

        private void heads_radio_CheckedChanged(object sender, EventArgs e)
        {
            coinflipselected = true;
        }

        private void tails_radio_CheckedChanged(object sender, EventArgs e)
        {
            coinflipselected = true;
        }

        private void CoinFlip()      // also implemented in overtime situations
        {
            Random rand = new Random();
            string[] coin_sides = { "heads", "tails" };
            //string[] possession_options = { "Kick", "Receive", "Defer" };

            //var choice_index = rand.Next(coin_sides.Length);
            var flip_index = rand.Next(coin_sides.Length);

            //var visitor_coin_flip = coin_sides[choice_index];
            var flip_result = coin_sides[flip_index];

            string flipresult_statement = "The coin lands on ";
            flipresult_statement = String.Concat(flipresult_statement, flip_result);

            flipresult_label.Text = flipresult_statement;

            if (heads_radio.Checked && flip_result == "heads" || tails_radio.Checked && flip_result == "tails")
            {
                string winnerselect_statement = " select:";
                winnerselect_statement = String.Concat(awayteam, winnerselect_statement);
                winnerselect_label.Text = winnerselect_statement;
            }

            else
            {
                string winnerselect_statement = " select:";
                winnerselect_statement = String.Concat(hometeam, winnerselect_statement);
                winnerselect_label.Text = winnerselect_statement;
            }
                //var possession_index = rand.Next(possession_options.Length);
                //var winner_choice = possession_options[possession_index];

                //Console.Write("Visitor chooses {0}. ", visitor_coin_flip);
                //Console.Write("The coin lands on {0}. ", flip_result);

                //if (visitor_coin_flip == flip_result)
                //{
                //    Console.WriteLine("Visitor chooses to {0}.", winner_choice);
                //    if (winner_choice == "Receive")
                //    {
                //        awayteam.FirstHalfPossession = true;
                //        awayteam.SecondHalfPossession = false;
                //        hometeam.FirstHalfPossession = false;
                //        hometeam.SecondHalfPossession = true;
                //    }
                //    else if (winner_choice == "Kick" || winner_choice == "Defer")
                //    {
                //        awayteam.FirstHalfPossession = false;
                //        awayteam.SecondHalfPossession = true;
                //        hometeam.FirstHalfPossession = true;
                //        hometeam.SecondHalfPossession = false;
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Home team chooses to {0}.", winner_choice);
                //if (winner_choice == "Receive")
                //{
                //    awayteam.FirstHalfPossession = false;
                //    awayteam.SecondHalfPossession = true;
                //    hometeam.FirstHalfPossession = true;
                //    hometeam.SecondHalfPossession = false;
                //}
                //else if (winner_choice == "Kick" || winner_choice == "Defer")
                //{
                //    awayteam.FirstHalfPossession = true;
                //    awayteam.SecondHalfPossession = false;
                //    hometeam.FirstHalfPossession = false;
                //    hometeam.SecondHalfPossession = true;

                //}
                //}
            }
    }
}
