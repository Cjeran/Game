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
        public static int finalKills, finalScore, finalTime, highScore;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            StartScreen ns = new StartScreen();
            ns.Location = new Point((this.Width - ns.Width) / 2, (this.Height - ns.Height) / 2);
            this.Controls.Add(ns);
            Cursor.Hide();
            ns.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public static void ChangeScreen(UserControl current, string next)
        {
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            switch (next)
            {
                case "StartScreen":
                    ns = new StartScreen();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "EndScreen":
                    ns = new EndScreen();
                    break;
            }

            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            Cursor.Hide();
            f.Controls.Add(ns);
            ns.Focus();

            current.Dispose();

        }
    }
}
