using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;


namespace BotJarvis
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer botSpeech = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            botSpeech.Speak("Hello");
            lbChat.Items.Add("Jarvis: Hello");
            txtSend.Select();
        }

        public void speakNow(string botName, string txt)
        {
            lbChat.Items.Add("Me: " + txt);
            string botAnswer;
            botAnswer = think(txtSend.Text.ToLower());
            botSpeech.Speak(botAnswer);
            lbChat.Items.Add(botName + botAnswer);

        }

        private void filePlayer(string url)
        {
            WMPLib.WindowsMediaPlayer winPlayer = new WMPLib.WindowsMediaPlayer();
            winPlayer.URL = url;
            winPlayer.controls.play();
        }

        public string think(string txt)
        {
            if (txt.Contains("bored"))
            {
                return ("I'm bored too");
            }

            else if (txt.Contains("morning"))
            {
                return ("Good morning");
            }

            else if (txt.Contains("start calculator") || txt.Contains("calc") || txt.Contains("calculator"))
            {
                openThing("calc.exe", "");
                return ("Starting calculator");
                
            }

            else if (txt.Contains("start wordpad") || txt.Contains("word") || txt.Contains("wordpad"))
            {
                openThing("wordpad.exe", "");
                return ("Starting wordpad");
                
            }

            else if (txt.Contains("start chrome") || txt.Contains("chrome") || txt.Contains("browser"))
            {
                openThing("chrome.exe", "www.google.com");
                return ("Starting chrome");
                
            }

            else if (txt.Contains("start facebook") || txt.Contains("facebook") || txt.Contains("fb"))
            {
                openThing("chrome.exe", "www.facebook.com");
                return ("Starting facebook");
                
            }

            else if (txt.Contains("play music") || txt.Contains("music") || txt.Contains("sound"))
            {
                return ("Playing music");
                
            }

            else if (txt.Contains("bye") || txt.Contains("exit") || txt.Contains("go away"))
            {
                Close();
                return ("Goodbye");
                
            }

            else if (txt.Contains("sing"))
            {
                return ("Mary had a little lamb, little lamb, little lamb. alright, I can't sing");
            }

            else if (txt.Contains("time"))
            {
                DateTime timeDate = new DateTime();
                return ("The time is " + timeDate.ToString("hh:mm tt"));
            }

            else if (txt.Contains("date"))
            {
                DateTime dateTime = new DateTime();
                return ("The date is " + dateTime.ToString("MMMM dd"));
            }

            else
            {
                return ("Sorry, I cannot understand");
            }
        }

        public void openThing(string path, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = args;
            start.FileName = path;
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            int exitCode;
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
                exitCode = proc.ExitCode;
            }

        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            speakNow("Jarvis: ", txtSend.Text);
        
        }

        private void bntClearChat_Click(object sender, EventArgs e)
        {
            lbChat.Items.Clear();
        }
    }
}
