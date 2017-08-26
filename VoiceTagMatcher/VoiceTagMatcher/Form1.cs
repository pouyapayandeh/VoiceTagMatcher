using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;

namespace VoiceTagMatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string audioPath = "";
        private void VoiceFileOpenBtn_Click(object sender, EventArgs e)
        {
            GetFilePath(voiceFileTextBox);
        }

        private void GetFilePath(TextBox textBox)
        {
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                textBox.Text = openFileDialog.FileName;
            }
        }

        private void TagFileOpenBtn_Click(object sender, EventArgs e)
        {
            GetFilePath(tagFileTextBox);
        }

        
        private void processBtn_Click(object sender, EventArgs e)
        {
            if (voiceFileTextBox.Text == "")
            {
                MessageBox.Show(this, "Please Selecte A Audio File","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (tagFileTextBox.Text == "")
            {
                MessageBox.Show(this, "Please Selecte A Tag File", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            tagComboBox.Items.Clear();
            audioPath = voiceFileTextBox.Text;
            System.IO.StreamReader file = new System.IO.StreamReader(tagFileTextBox.Text);
            string line;
            List<String> words = new List<string>();
            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    var parts = line.Split(' ');
                    AudioTag tag = new AudioTag();
                    tag.Start = (int)(Convert.ToDouble(parts[0]) / 10000);
                    tag.End = (int)(Convert.ToDouble(parts[1]) / 10000);
                    tag.Tag = parts[2];
                    tag.Confidence = Convert.ToDouble(parts[3]);
                    tagComboBox.Items.Add(tag);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, "Input is not in correct format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tagComboBox.SelectedIndex = 0;

        }

        private void tagComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AudioTag tag = (AudioTag) tagComboBox.SelectedItem;
            startTxtBox.Text = tag.Start.ToString();
            endTxtBox.Text = tag.End.ToString();
            confidenceTxtBox.Text = tag.Confidence.ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (tagComboBox.SelectedIndex < tagComboBox.Items.Count - 1)
                tagComboBox.SelectedIndex += 1;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (tagComboBox.SelectedIndex > 0)
                tagComboBox.SelectedIndex -= 1;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            AudioTag tag = (AudioTag)tagComboBox.SelectedItem;
            if (tag != null && audioPath!="")
            {
                int margine = (int) margineNumerical.Value;
                var start = new TimeSpan(0, 0, 0, 0, tag.Start - margine);
                var end = new TimeSpan(0, 0, 0, 0, tag.End + margine);
                AudioPlayback.TrimPlayWAvFile(audioPath,start, end);
            }

        }
    }
}
