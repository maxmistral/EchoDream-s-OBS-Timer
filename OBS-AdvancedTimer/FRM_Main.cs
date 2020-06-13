using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;

namespace OBS_AdvancedTimer
{
    public partial class FRM_Main : Form
    {
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        string filePath = null;
        string[] fileElements;
        string timeFormat = "";
        string endMessage = "";
        int lang = 0;
        bool timerEnded = false;
        public FRM_Main()
        {
            InitializeComponent();
            UpdateConfig();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
            }
            else if (minutes > 0)
            {
                minutes--;
                seconds = 59;
            }
            else if (hours > 0)
            {
                hours--;
                minutes = 59;
                seconds = 60;
            }
            else
            {
                timerEnded = true;
                timer.Stop();
                StreamWriter SW = new StreamWriter(@filePath + @"\data.txt");
                string messageToPaste = endMessage;
                if (!String.IsNullOrEmpty(messageToPaste))
                {
                    messageToPaste = messageToPaste.Replace("%h", TBX_Hour.Text);
                    messageToPaste = messageToPaste.Replace("%m", TBX_Minutes.Text);
                    messageToPaste = messageToPaste.Replace("%s", TBX_Seconds.Text);
                }
                else
                {
                    messageToPaste = TBX_Hour.Text + ":" + TBX_Minutes.Text + ":" + TBX_Seconds.Text;
                }
                SW.Write(messageToPaste);
                SW.Close();
                TBX_Hour.ReadOnly = false;
                TBX_Minutes.ReadOnly = false;
                TBX_Seconds.ReadOnly = false;
            }
            if (hours < 10)
            {
                TBX_Hour.Text = "0" + hours.ToString();
            }
            else
            {
                TBX_Hour.Text = hours.ToString();
            }
            if (minutes < 10)
            {
                TBX_Minutes.Text = "0" + minutes.ToString();
            }
            else
            {
                TBX_Minutes.Text = minutes.ToString();
            }
            if (seconds < 10)
            {
                TBX_Seconds.Text = "0" + seconds.ToString();
            }
            else
            {
                TBX_Seconds.Text = seconds.ToString();
            }
            try
            {
                if(timerEnded == false)
                {
                    StreamWriter SW = new StreamWriter(@filePath + @"\data.txt");
                    string timeToPaste = timeFormat;
                    if (!String.IsNullOrEmpty(timeFormat))
                    {
                        timeToPaste = timeToPaste.Replace("%h", TBX_Hour.Text);
                        timeToPaste = timeToPaste.Replace("%m", TBX_Minutes.Text);
                        timeToPaste = timeToPaste.Replace("%s", TBX_Seconds.Text);
                    }
                    else
                    {
                        timeToPaste = TBX_Hour.Text + ":" + TBX_Minutes.Text + ":" + TBX_Seconds.Text;
                    }
                    SW.Write(timeToPaste);
                    SW.Close();
                }
            }
            catch (Exception ex)
            {
                LBL_Error.Text = ex.Message;
                LBL_Error.Visible = true;
            }
        }
        private void BTN_StartTimer_Click(object sender, EventArgs e)
        {
            if (LBL_Error.Visible)
            {
                LBL_Error.Visible = false;
            }
            seconds = Convert.ToInt16(TBX_Seconds.Text);
            minutes = Convert.ToInt16(TBX_Minutes.Text);
            hours = Convert.ToInt16(TBX_Hour.Text);
            TBX_Hour.ReadOnly = true;
            TBX_Minutes.ReadOnly = true;
            TBX_Seconds.ReadOnly = true;
            timer.Start();
            timerEnded = false;
        }

        private void BTN_FileBrowser_Click(object sender, EventArgs e)
        {
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = FolderDialog.SelectedPath.ToString();
                TBX_FilePath.Text = filePath;
                FileStream file = File.Create(@filePath + @"\data.txt");
                file.Close();
                UpdateDataFile();
                BTN_StartTimer.Enabled = true;
                BTN_StopTimer.Enabled = true;
                BTN_ResetTimer.Enabled = true;
                if (LBL_Error.Visible)
                {
                    LBL_Error.Visible = false;
                }
            }
        }

        private void UpdateConfig()
        {
            if (File.Exists(@"config.ecd"))
            {
                try
                {
                    StreamReader SR = new StreamReader(@"config.ecd");
                    fileElements = SR.ReadLine().Split('|');
                    SR.Close();
                    TBX_FilePath.Text = fileElements[0];
                    filePath = fileElements[0];
                    timeFormat = fileElements[1];
                    TBX_Format.Text = timeFormat;
                    BTN_StartTimer.Enabled = true;
                    BTN_StopTimer.Enabled = true;
                    BTN_ResetTimer.Enabled = true;
                    if (!String.IsNullOrEmpty(fileElements[2]) && fileElements[2] != "-1")
                    {
                        lang = Convert.ToInt16(fileElements[2]);
                    }
                    CBX_Lang.SelectedIndex = lang;
                    UpdateLangague((Lang)lang);
                    endMessage = fileElements[3];
                    TBX_EndMessage.Text = endMessage;
                }
                catch (Exception ex)
                {
                    LBL_Error.Text = ex.Message;
                }

            }
        }
        private void UpdateLangague(Lang language)
        {
            string lang = language.ToString();
            byte[] data = (byte[])Properties.Resources.ResourceManager.GetObject(lang);
            MemoryStream MS = new MemoryStream(data);
            StreamReader SR = new StreamReader(MS);

            var yaml = new YamlStream();
            yaml.Load(SR);
            // Examine the stream
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            foreach (var entry in mapping.Children)
            {
                try
                {
                    this.Controls.Find(((YamlScalarNode)entry.Key).Value, false).ElementAt(0).Text = ((YamlScalarNode)entry.Value).Value;
                    AutoSize(this.Controls.Find(((YamlScalarNode)entry.Key).Value, false).ElementAt(0));
                }
                catch
                {

                }

            }
        }

        //======================= Border ===================================

        private void FRM_Main_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen DrawBorder = new Pen(Color.FromArgb(150, 150, 150), 5);
            e.Graphics.DrawRectangle(DrawBorder, 0, 0, width, height);
        }

        //=============================== Move Windows ===================================

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        private void OnStayClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private new void AutoSize(Control control)
        {
            Font font = control.Font;
            Image bitmap = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            SizeF size = graphics.MeasureString(control.Text, font);
            if (control.Size.Width - 20 <= size.Width)
            {
                control.Font = new Font(font.FontFamily, font.Size - 1, font.Style);
                AutoSize(control);
            }
        }

        private void CBX_Lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLangague((Lang)CBX_Lang.SelectedIndex);
            UpdateDataFile();
        }

        private void BTN_EditFormat_Click(object sender, EventArgs e)
        {
            if (!TBX_Format.Enabled)
            {
                TBX_Format.Enabled = true;
                TBX_EndMessage.Enabled = true;
                BTN_EditFormat.Text = "✔";
                BTN_EditFormat.BackColor = Color.OliveDrab;
            }
            else
            {
                timeFormat = TBX_Format.Text;
                endMessage = TBX_EndMessage.Text;
                TBX_Format.Enabled = false;
                TBX_EndMessage.Enabled = false;
                BTN_EditFormat.BackColor = Color.Chocolate;
                UpdateLangague((Lang)lang);
                UpdateDataFile();
            }
        }

        private void BTN_StopTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            TBX_Hour.ReadOnly = false;
            TBX_Minutes.ReadOnly = false;
            TBX_Seconds.ReadOnly = false;
        }

        private bool UpdateDataFile()
        {
            try
            {
                StreamWriter SW = new StreamWriter("config.ecd");
                SW.WriteLine($"{filePath}|{timeFormat}|{CBX_Lang.SelectedIndex}|{endMessage}");
                SW.Close();
                return true;
            }
            catch (Exception ex)
            {
                LBL_Error.Text = ex.Message;
                return false;
            }
        }

        private void BTN_ResetTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            TBX_Hour.Text = "00";
            TBX_Minutes.Text = "00";
            TBX_Seconds.Text = "00";
            TBX_Hour.ReadOnly = false;
            TBX_Minutes.ReadOnly = false;
            TBX_Seconds.ReadOnly = false;
        }

        private void BTN_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developped by Maxmistral and published under MIT license.\n\n For any questions or propositions you can contact me on Discord : https://discord.gg/pQkvy6P.");
        }

        private void TBX_Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void TBX_Minutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void TBX_Secondes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to quit this application? Otherwise, this application will be reduced.", "Do you want to quit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GC.Collect();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Hide();
                notifIcon.Visible = true;
                notifIcon.ShowBalloonTip(1000);
                GC.Collect();
            }
        }

        private void BTN_Reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void notifIcon_Click(object sender, EventArgs e)
        {
           Show();
        }
    }
}
