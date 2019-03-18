using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public static int finalKills, finalScore, finalTime;
        public Form1()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            StartScreen ss = new StartScreen();
            this.Controls.Add(ss);
        }
    }
}
