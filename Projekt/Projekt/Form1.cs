using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Speech.Synthesis;
namespace Projekt
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsMediaPlayer grajek = new WindowsMediaPlayer();
            grajek.URL = "nokia_arabian.mp3";
            grajek.settings.volume = 100;
            grajek.controls.play();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            List<int> lt = new List<int>();
            int[] tab = new int[10];
            int x = rnd.Next(this.Width - button1.Width);
            int y = rnd.Next(this.Height - button1.Height);
            button1.Left = x;
            button1.Top = y;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Dlaczego mnie zamykasz?");
            MessageBox.Show("Czy jesteś tego pewny?");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Do zobaczenia?????");
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //sp.SelectVoice("Microsoft Server Speech Text to Speech Voice (en-GB, Hazel)");
            sp.Speak(textBox1.Text);
        }
    }
}
