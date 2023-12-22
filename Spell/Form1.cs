using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;

namespace Spell
{
    public partial class Form1 : Form
    {
        XmlNode bani;
        XmlNode raag;
        XmlNode audio;
        XmlNode video;
        XmlNode swaralipi;
        XmlNode english;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeEditor();
            //string[] docs = System.IO.File.ReadAllLines("TestDoc.txt", Encoding.UTF8);
            //this.rtfAnswer.Text = string.Join("", docs);
            //this.rtfAnswer.Text = String.Join(System.Environment.NewLine, docs);
            LoadXML();
            FillTextBox();
        }

        private void LoadXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Sample.xml");

            bani = doc.DocumentElement.SelectSingleNode("bani");
            raag = doc.DocumentElement.SelectSingleNode("raag");
            audio = doc.DocumentElement.SelectSingleNode("audio");
            video = doc.DocumentElement.SelectSingleNode("video");
            swaralipi = doc.DocumentElement.SelectSingleNode("swaralipi");
            english = doc.DocumentElement.SelectSingleNode("english");
        }

        private void FillTextBox(bool reset = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(bani["title"].InnerXml.Trim());
            string existing = "";

            if (rtfAnswer.Text.IndexOf("<pre>") > 0)
            {
                int firstPrePosition = rtfAnswer.Text.IndexOf("<pre>");
                int secondPrePosition = rtfAnswer.Text.IndexOf("</pre>");
                existing= rtfAnswer.Text.Substring(firstPrePosition,secondPrePosition-firstPrePosition+6);
            }

            if(existing.Length == 0)
                sb.AppendLine(bani["matter"].InnerXml.Trim());
            else
                sb.AppendLine(existing);
                        
            if (chkRaagTaal.Checked == true)
            {
                sb.AppendLine(raag["title"].InnerXml.Trim());

                if (!reset)
                {
                    sb.Append("<p>");
                    sb.Append(raag["matter"]["raag"]["title"].InnerText.Trim());
                    sb.Append(" ");
                    sb.Append(raag["matter"]["raag"]["value"].InnerText.Trim());
                    sb.AppendLine("</p>");
                }
                else
                {
                    sb.Append("<p>");
                    sb.Append(raag["matter"]["raag"]["title"].InnerText.Trim());
                    sb.AppendLine("</p>");
                }

                if (!reset)
                {
                    sb.Append("<p>");
                    sb.Append(raag["matter"]["taal"]["title"].InnerText.Trim());
                    sb.Append(" ");
                    sb.Append(raag["matter"]["taal"]["value"].InnerText.Trim());
                    sb.AppendLine("</p>");
                }
                else
                {
                    sb.Append("<p>");
                    sb.Append(raag["matter"]["taal"]["title"].InnerText.Trim());
                    sb.AppendLine("</p>");
                }
            }
            if (chkAudio.Checked == true)
            {
                sb.AppendLine(audio["title"].InnerXml.Trim());
                sb.AppendLine(audio["matter"].InnerXml.Trim());
            }
            if (chkVideo.Checked == true)
            {
                sb.AppendLine(video["title"].InnerXml.Trim());
                sb.AppendLine(video["matter"].InnerXml.Trim());
            }
            if (chkSwaralipi.Checked == true)
            {
                sb.AppendLine(swaralipi["title"].InnerXml.Trim());
                sb.AppendLine(swaralipi["matter"].InnerXml.Trim());
            }
            if (chkEnglish.Checked == true)
            {
                sb.AppendLine(english["title"].InnerXml.Trim());
                sb.AppendLine(english["matter"].InnerText.Trim());
            }
            sb.Append("{/tabs}");
            rtfAnswer.Text = sb.ToString();
        }
        private void InitializeEditor()
        {
            string Sel_story_font = "Bangla";
            //string Sel_story_font = "BenSen";
            //string Sel_story_font = "Nikosh";
            //string Sel_story_font = "Kalpurush";
            //string Sel_story_font = "Solaimanlipi";
            rtfAnswer.AcceptsTab = true;
            rtfAnswer.AllowDrop = true;
            rtfAnswer.EnableAutoDragDrop = true;
            //rtfAnswer.SelectionRightIndent = 20;
            //rtfAnswer.SelectionIndent = 30;
            //rtfAnswer.SelectionHangingIndent = -20;
            rtfAnswer.Font = new Font(Sel_story_font, 18, FontStyle.Regular);
            rtfAnswer.SelectionFont = new Font(Sel_story_font, 18, FontStyle.Regular);
            rtfAnswer.LanguageOption = RichTextBoxLanguageOptions.DualFont;
            rtfAnswer.SelectionStart = 0;
            rtfAnswer.SelectionLength = 0;
            rtfAnswer.SelectedText = "क";
            rtfAnswer.SelectionStart = 0;
            rtfAnswer.SelectionLength = 1;
            rtfAnswer.SelectedText = "";
            rtfAnswer.ClearUndo();
        }

        public static string RemoveIllegalCharacters(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            text = text.Replace("য়", "য়");
            text = text.Replace("ড়", "ড়");
            text = text.Replace("ঢ়", "ঢ়");
            text = text.Replace("ো", "ো");
            text = text.Replace("॥", "।।");
            text = text.Replace(" ॥", "।।");
            text = text.Replace("॥ ", "।।");
            text = text.Replace(" ॥ ", "।।");
            text = text.Replace(" ।।", "।।");
            text = text.Replace(" ।। ", "।।");
            text = text.Replace("।। ", "।।");
            text = text.Replace(" ।", "।");
            text = text.Replace(" । ", "।");
            text = text.Replace("। ", "।");
            text = text.Replace(" -", " —");
            text = text.Replace(" –", " —");
            text = text.Replace(" - ", " — ");
            text = text.Replace(" – ", " — ");            
            text = text.Replace(" ?", "?");
            text = text.Replace(" !", "!");
            text = text.Replace("কাহারবা", "কাহার্‌বা");
            text = text.Replace("দাদরা", "দাদ্‌রা");
            text = text.Replace("তাল :", "তালঃ");
            text = text.Replace("রাগ :", "রাগঃ");
            text = text.Replace("তাল:", "তালঃ");
            text = text.Replace("রাগ:", "রাগঃ");
            //text = text.Replace("https", "http");

            return text;
        }

        public static string RemoveExtraSpaces(string str1)
        {
            string result = Regex.Replace(str1, "[\r\n]+", "\r\n"); //remove multiple line feed  
            result = Regex.Replace(result, " {2,}", " ");
            return result;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.rtfAnswer.Text = RemoveExtraSpaces(RemoveIllegalCharacters(rtfAnswer.Text.Trim()));
            TrimText();
        }

        private void TrimText()
        {
            string[] tempArray;
            tempArray = rtfAnswer.Lines;

            for (int i = 0, loopTo = tempArray.Length - 1; i <= loopTo; i++)
            {
                if (tempArray[i].StartsWith(" "))
                {
                    tempArray[i] = tempArray[i].Trim();
                }
            }

            rtfAnswer.Lines = tempArray;
        }

        private void chkAudio_CheckedChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void chkVideo_CheckedChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void chkSwaralipi_CheckedChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void chkEnglish_CheckedChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void chkRaagTaal_CheckedChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void btnResetRaag_Click(object sender, EventArgs e)
        {
            FillTextBox(true);
        }
    }
}
