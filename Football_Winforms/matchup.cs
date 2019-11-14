using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Winforms
{
    public partial class Matchup : Form
    {
        public Matchup(string hometeam, string awayteam)
        {
            InitializeComponent();
            label1.Text = hometeam;
            label3.Text = awayteam;
        }
    }
}
