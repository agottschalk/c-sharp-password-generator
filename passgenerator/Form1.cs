using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGenerator
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private RNGCryptoServiceProvider _secureRandom = new RNGCryptoServiceProvider();

        
        private AboutBox1 aboutBox = new AboutBox1();

        private Generator g;

        //short array for testing
        //in the finished build this will be replaced with a larger list of words
        private string[] defaultWords =
            { "pass", "word", "generator", "csharp", "button", "code", "check", "box", "click" };


        public Form1()
        {
            InitializeComponent();

            //load word list
            string[] wordList = loadWords();

            //if word list fails to load, the default list is used and a warning is displayed
            notLoadedWarning.Visible = (wordList == defaultWords);

            //initialize class that holds password generating algorithm
            g = new Generator(wordList, _random, _secureRandom);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //gernerates password based on user selections
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (SecureCB.Checked)
            {
                passBox.Text = (g.generateSecure(Properties.Settings.Default.numCharactersInSecure,
                            Properties.Settings.Default.useSpecialsInSecure));
            }
            else
            {
                //if 'secure' is not checked, makes a custom string based on user selections
                int words = 0;
                int letters = 0;
                int numbers = 0;
                int specials = 0;

                //gets proper numbers of each element type based on user selections
                if (wordsCB.Checked)
                {
                    words = (int)wordAmtUD.Value;
                }

                if (lettersCB.Checked)
                {
                    letters = (int)letAmtUD.Value;
                }

                if (numCB.Checked)
                {
                    numbers = (int)numAmtUD.Value;
                }

                if (specCB.Checked)
                {
                    specials = (int)specAmtUD.Value;
                }

                
                if (words == 0 &&
                    letters == 0 &&
                    numbers == 0 &&
                    specials == 0)
                {
                    //inform user if they haven't selected anything
                    passBox.Text = "Please make a selection";
                }
                else
                { 
                    //otherwise create password
                    passBox.Text = g.generatePassword(words, letters, numbers, specials);
                }
            }
        }

        #region Element enable and disable controls


        //checking the 'secure' option deactivates all other options, unchecking reactivates them
        private void SecureCB_CheckedChanged(object sender, EventArgs e)
        {
            wordsCB.Enabled = !SecureCB.Checked;
            wordsCB_CheckedChanged(SecureCB, EventArgs.Empty);

            lettersCB.Enabled = !SecureCB.Checked;
            lettersCB_CheckedChanged(SecureCB, EventArgs.Empty);

            numCB.Enabled = !SecureCB.Checked;
            numCB_CheckedChanged(SecureCB, EventArgs.Empty);

            specCB.Enabled = !SecureCB.Checked;
            specCB_CheckedChanged(SecureCB, EventArgs.Empty);

        }

        //the next four methods control the numberupdown elements so that they are always activated
        //or deactivated along with their corresponding checkbox
        private void wordsCB_CheckedChanged(object sender, EventArgs e)
        {
            if (wordsCB.Enabled)
            {
                wordAmtUD.Enabled = wordsCB.Checked;
            }
            else
            {
                wordAmtUD.Enabled = false;
            }
        }

        private void lettersCB_CheckedChanged(object sender, EventArgs e)
        {
            if (lettersCB.Enabled)
            {
                letAmtUD.Enabled = lettersCB.Checked;
            }
            else
            {
                letAmtUD.Enabled = false;
            }
        }

        private void numCB_CheckedChanged(object sender, EventArgs e)
        {
            if (numCB.Enabled)
            {
                numAmtUD.Enabled = numCB.Checked;
            }
            else
            {
                numAmtUD.Enabled = false;
            }
        }

        private void specCB_CheckedChanged(object sender, EventArgs e)
        {
            if (specCB.Enabled)
            {
                specAmtUD.Enabled = specCB.Checked;
            }
            else
            {
                specAmtUD.Enabled = false;
            }
        }

        #endregion


        //reads file containing words and returns them as an array
        //returns the default array instead if the file can't be read
        private string[] loadWords()
        {
            string[] wordList;

            try
            {
                //put word file in 'PassGenerator\bin\debug' folder
                //Console.WriteLine(
                //    "checking path {0}", Path.Combine(Environment.CurrentDirectory, @"wordlist.txt"));

                wordList = File.ReadAllLines(
                    Path.Combine(Environment.CurrentDirectory, @"wordlist.txt"));
            }
            catch (Exception e)
            {
                wordList = defaultWords;
                Console.WriteLine("error: {0}", e);
            }

            return wordList;
        }


        #region Tool Strip Menu Events

        //this method is actually called by the 'generate' menu item, it has the wrong name bc
        //it was autogenerated by visual studio that way (I do plan to fix it eventually)
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateButton_Click(generateToolStripMenuItem, EventArgs.Empty);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraSettingsForm settingsForm = new ExtraSettingsForm();
            settingsForm.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            //Console.WriteLine("FormClosing event called");
        }
    }

}
