using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversationProgram
{
    public partial class ConversationEditor : Form
    {
        public static string SavedPath;
        public static TabPage SavedTab;

        private string File_Name;

        public static Dictionary<string, TabPage> tabs = new Dictionary<string, TabPage>();

        public ConversationEditor()
        {
            InitializeComponent();

            CanSave(false);
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 저장될 위치 지정, 저장될 파일 이름 지정
            // 저장될 위치에 이미 존재하는 파일 이름들 가져오기

            var path = Path.GetDirectoryName(Application.ExecutablePath);

            var FileDialog = new SaveFileDialog()
            {
                Filter = "script file (*.xml)|*.xml",
                Title = "열기",
            };

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string File_Exe = null;
                try
                {
                    File_Name = FileDialog.FileName;
                    File_Exe = Path.GetExtension(File_Name);


                    XmlEditor control = new XmlEditor(File_Name)
                    {
                        Dock = DockStyle.Fill
                    };
                    var tab = new TabPage(Path.GetFileName(File_Name));
                    tab.Controls.Add(control);

                    Setvalue(tab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File Load Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog()
            {
                Filter = "script file (*.xml)|*.xml",
                Title = "열기",
                AddExtension = true
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                string File_Exe = null;
                try
                {
                    File_Name = open.FileName;
                    File_Exe = Path.GetExtension(File_Name);

                    XmlEditor control = new XmlEditor(File_Name)
                    {
                        Dock = DockStyle.Fill
                    };
                    var tab = new TabPage(Path.GetFileName(File_Name));
                    tab.Controls.Add(control);
                    SetNotice("파일을 열었습니다.");

                    Setvalue(tab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File Load Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        public void Setvalue(TabPage tab)
        {
            tabs.Add(File_Name, tab);
            MainPanel.TabPages.Add(tab);

            SavedPath = File_Name;
            SavedTab = tab;
            MainPanel.SelectTab(SavedTab);
        }

        private void 저장하기SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(null, null);
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool close = true;

            if (SavedTab != null)
            {
                var extension = Path.GetFileName(SavedPath);

                if ((SavedTab.Controls[0] as XmlEditor).수정됨)
                {
                    var result = MessageBox.Show("변경 사항이 있습니다. 저장하시겠습니까?", extension.ToString(), MessageBoxButtons.YesNoCancel);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            var stream = new StreamWriter(SavedPath, false, Encoding.UTF8);
                            stream.Write((SavedTab.Controls[0] as XmlEditor).ToString());
                            stream.Close();
                            close = true;
                            break;
                        case DialogResult.No:
                            close = true;
                            break;
                        case DialogResult.Cancel:
                            close = false;
                            break;
                    }
                }

                if (close)
                {
                    tabs.Remove(SavedPath);
                    MainPanel.TabPages.Remove(SavedTab);
                    CanSave(false);
                }
            }
        }

        private bool called = false;
        public void SetNotice(string s)
        {
            notice.Text = s;
            count = 0;
            called = true;
            timer1.Start();
        }

        private int MaxCount = 50;
        private int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(called)
            {
                count++;

                if(count > MaxCount)
                {
                    called = false;
                    notice.Text = "";
                    timer1.Stop();
                }
            }
        }

        private void MainPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SavedTab = MainPanel.SelectedTab;
            if (SavedTab != null)
            {
                SavedPath = tabs.Where((arg) => arg.Value == SavedTab).Select((arg) => arg.Key).ToArray()[0];
                CanSave((SavedTab.Controls[0] as XmlEditor).수정됨);
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (SavedTab != null)
            {
                var extension = Path.GetFileName(SavedPath);

                if (string.IsNullOrEmpty((SavedTab.Controls[0] as XmlEditor).path))
                {
                    SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Filter = "script file (*.xml)|*.xml",
                        Title = "저장"
                    };

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        SavedPath = saveFile.FileName;
                        (SavedTab.Controls[0] as XmlEditor).path = saveFile.FileName;

                        (SavedTab).Text = Path.GetFileName(SavedPath);

                        tabs.Add(SavedPath, SavedTab);
                    }
                }

                var stream = new StreamWriter(SavedPath, false, Encoding.UTF8);
                stream.Write((SavedTab.Controls[0] as XmlEditor).ToString());
                stream.Close();

                SetNotice( "저장되었습니다.");
                
                (SavedTab.Controls[0] as XmlEditor).수정됨 = false;

                CanSave(false);
            }
        }

        public void CanSave(bool can = true)
        {
            저장하기SToolStripMenuItem.Enabled = can;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S)) // 저장
            {
                SaveFile(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bool close = true;

            if (SavedTab != null)
            {
                var extension = Path.GetFileName(SavedPath);

                if ((SavedTab.Controls[0] as XmlEditor).수정됨)
                {
                    var result = MessageBox.Show("변경 사항이 있습니다. 저장하시겠습니까?", extension.ToString(), MessageBoxButtons.YesNoCancel);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            var stream = new StreamWriter(SavedPath, false, Encoding.UTF8);
                            stream.Write((SavedTab.Controls[0] as XmlEditor).ToString());
                            stream.Close();
                            close = true;
                            break;
                        case DialogResult.No:
                            close = true;
                            break;
                        case DialogResult.Cancel:
                            close = false;
                            break;
                    }
                }

            }
            e.Cancel = !close;

            if (close)
                base.OnFormClosing(e);
        }
    }
}
