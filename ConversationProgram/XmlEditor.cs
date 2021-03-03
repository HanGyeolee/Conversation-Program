using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversationProgram
{
    public partial class XmlEditor : UserControl
    {
        protected Form parent;

        protected UndoRedo<TextBox> undoRedo = new UndoRedo<TextBox>();

        public Scripts scripts { get; private set; } = new Scripts();
        public string path;
        public bool 수정됨 = false;
        int selectedConversation = -1;

        public bool ChangedData = false;

        public XmlEditor(string filepath)
        {
            InitializeComponent();

            parent = FindForm();

            path = filepath;

            scripts = new Scripts();
            scripts.LoadXml(filepath);

            for (int i = 0; i < scripts.conversations.Count; i++)
            {
                var tmp = new ListViewItem(scripts.conversations[i].Key);
                tmp.SubItems.Add(scripts.conversations[i].Name);
                tmp.SubItems.Add(scripts.conversations[i].Type.ToString());
                tmp.SubItems.Add(scripts.conversations[i].Content);
                tmp.SubItems.Add(scripts.conversations[i].CanExit.ToString());
                if (scripts.conversations[i].Type == 'C')
                    tmp.SubItems.Add(scripts.conversations[i].Next_C_ID);
                else
                {
                    string opts_c = "";
                    for (int j = 0; j < scripts.conversations[i].Option_C_ID.Length; j++)
                    {
                        opts_c += scripts.conversations[i].Option_C_ID[j];
                        if (j < scripts.conversations[i].Option_C_ID.Length - 1)
                            opts_c += "::";
                    }
                    tmp.SubItems.Add(opts_c);
                }
                listView.Items.Add(tmp);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l = sender as ListView;
            int index;

            try
            {
                index = l.Items.IndexOf(l.SelectedItems[0]);
            }
            catch(Exception)
            {
                index = -1;
            }

            SetExtension(index);
        }

        private void SetExtension(int index)
        {
            if (index != -1)
            {
                var c = scripts.conversations[index];
                key.Text = c.Key;
                wait.Text = c.Wait.ToString();
                name.Text = c.Name;
                canexit.Checked = c.CanExit;
                dungeon.Text = c.DunGeon;
                anime.Text = c.Anime;
                condition.Text = c.Condition_ID;

                type.Text = c.Type.ToString();
                content.Text = c.Content;

                nextkey.Text = "";
                OptionList.Items.Clear();
                if (c.Type == 'C')
                {
                    nextkey.Text = c.Next_C_ID;
                }
                else
                {
                    for (int i = 0; i < c.Options.Length; i++)
                    {
                        var tmp = new ListViewItem(c.Options[i]);
                        tmp.SubItems.Add(c.Option_C_ID[i]);
                        OptionList.Items.Add(tmp);
                    }
                }
                selectedConversation = index;
            }
        }

        private void item_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(key.Text))
                MessageBox.Show("해당 대화의 ID 가 비어있습니다.\n추가할 수 없습니다.");
            else if (string.IsNullOrWhiteSpace(name.Text))
                MessageBox.Show("해당 대화의 화자가 비어있습니다.\n추가할 수 없습니다.");
            else if (string.IsNullOrWhiteSpace(content.Text))
                MessageBox.Show("해당 대화의 내용이 비어있습니다.\n추가할 수 없습니다.");
            else
            {
                var tmp = new ListViewItem(key.Text);
                tmp.SubItems.Add(name.Text);
                tmp.SubItems.Add((string)type.SelectedItem);
                tmp.SubItems.Add(content.Text);
                tmp.SubItems.Add(canexit.Checked.ToString());
                if (((string)type.SelectedItem)[0] == 'C')
                    tmp.SubItems.Add(nextkey.Text);
                else
                {
                    string opts_c = "";
                    for (int i = 0; i < OptionList.Items.Count; i++)
                    {
                        opts_c += OptionList.Items[i].SubItems[0].Text;
                        if (i < OptionList.Items.Count - 1)
                            opts_c += "::";
                    }
                    tmp.SubItems.Add(opts_c);
                }

                listView.Items.Add(tmp);

                var item = new Conversation(key.Text, 
                    name.Text,
                    content.Text, 
                    canexit.Checked, 
                    ((string)type.SelectedItem)[0],
                    string.IsNullOrWhiteSpace(dungeon.Text) ? null : dungeon.Text,
                    string.IsNullOrWhiteSpace(anime.Text) ? null : anime.Text,
                    int.Parse(string.IsNullOrWhiteSpace(wait.Text) ? "0" : wait.Text),
                    string.IsNullOrWhiteSpace(condition.Text) ? null : condition.Text);

                if(((string)type.SelectedItem)[0] == 'C')
                    item.SetNextConversationID(nextkey.Text);
                else
                {
                    List<string> opts = new List<string>();
                    List<string> opts_n = new List<string>();
                    
                    for(int i = 0; i<OptionList.Items.Count; i++)
                    {
                        opts.Add(OptionList.Items[i].Text);
                        opts_n.Add(OptionList.Items[i].SubItems[1].Text);
                    }

                    item.SetOptionsID(opts.ToArray(), opts_n.ToArray());
                }
                scripts.conversations.Add(item);
                CanSave();
            }
        }

        private void Item_modify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(key.Text))
                MessageBox.Show("해당 대화의 ID 가 비어있습니다.\n수정할 수 없습니다.");
            else if (string.IsNullOrWhiteSpace(name.Text))
                MessageBox.Show("해당 대화의 화자가 비어있습니다.\n수정할 수 없습니다.");
            else if (string.IsNullOrWhiteSpace(content.Text))
                MessageBox.Show("해당 대화의 내용이 비어있습니다.\n수정할 수 없습니다.");
            else
            {
                if (selectedConversation != -1)
                {
                    listView.Items[selectedConversation].SubItems[0].Text = key.Text;
                    listView.Items[selectedConversation].SubItems[1].Text = name.Text;
                    listView.Items[selectedConversation].SubItems[2].Text = ((string)type.SelectedItem);
                    listView.Items[selectedConversation].SubItems[3].Text = content.Text;
                    listView.Items[selectedConversation].SubItems[4].Text = canexit.Checked.ToString();
                    if (((string)type.SelectedItem)[0] == 'C')
                        listView.Items[selectedConversation].SubItems[5].Text = nextkey.Text;
                    else
                    {
                        string opts_c = "";
                        for (int i = 0; i < OptionList.Items.Count; i++)
                        {
                            opts_c += OptionList.Items[i].SubItems[1].Text;
                            if (i < OptionList.Items.Count - 1)
                                opts_c += "::";
                        }
                        listView.Items[selectedConversation].SubItems[5].Text = opts_c;
                    }

                    var item = new Conversation(key.Text,
                       name.Text,
                       content.Text,
                       canexit.Checked,
                       ((string)type.SelectedItem)[0],
                       string.IsNullOrWhiteSpace(dungeon.Text) ? null : dungeon.Text,
                       string.IsNullOrWhiteSpace(anime.Text) ? null : anime.Text,
                       int.Parse(string.IsNullOrWhiteSpace(wait.Text) ? "0" : wait.Text),
                       string.IsNullOrWhiteSpace(condition.Text)? null : condition.Text );

                    if (((string)type.SelectedItem)[0] == 'C')
                        item.SetNextConversationID(nextkey.Text);
                    else
                    {
                        List<string> opts = new List<string>();
                        List<string> opts_n = new List<string>();

                        for (int i = 0; i < OptionList.Items.Count; i++)
                        {
                            opts.Add(OptionList.Items[i].SubItems[0].Text);
                            opts_n.Add(OptionList.Items[i].SubItems[1].Text);
                        }

                        item.SetOptionsID(opts.ToArray(), opts_n.ToArray());
                    }

                    scripts.conversations[selectedConversation].Copy(item);
                    CanSave();
                }
            }
        }

        private void Item_delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("정말 지우시겠습니까?", "제거", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes && selectedConversation != -1)
            {
                scripts.conversations.RemoveAt(selectedConversation);
                listView.Items.RemoveAt(selectedConversation);
                selectedConversation = -1;
                CanSave();
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = (string)(sender as ComboBox).SelectedItem;
            if(tmp[0] == 'C')
            {
                nextkey.Enabled = true;
                panel2.Enabled = false;
                Select.Enabled = false;
                o_nextkey.Enabled = false;
                Spec_Add.Enabled = false;
                Spec_Delete.Enabled = false;
                Spec_modify.Enabled = false;
            }
            else
            {
                nextkey.Enabled = false;
                panel2.Enabled = true;
                Select.Enabled = true;
                o_nextkey.Enabled = true;
                Spec_Add.Enabled = true;
                Spec_Delete.Enabled = true;
                Spec_modify.Enabled = true;
            }
        }

        private void OptionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l = sender as ListView;
            try
            {
                Select.Text = l.SelectedItems[0].SubItems[0].Text;
                o_nextkey.Text = l.SelectedItems[0].SubItems[1].Text;
            }
            catch(Exception)
            {
                return;
            }
        }

        private void Spec_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Select.Text) &&
                !string.IsNullOrWhiteSpace(o_nextkey.Text))
            {
                var tmp = new ListViewItem(Select.Text);
                tmp.SubItems.Add(o_nextkey.Text);
                OptionList.Items.Add(tmp);
            }
        }

        private void Spec_modify_Click(object sender, EventArgs e)
        {
            try
            {
                OptionList.SelectedItems[0].SubItems[0].Text = Select.Text;
                OptionList.SelectedItems[0].SubItems[1].Text = o_nextkey.Text;
            }
            catch(Exception)
            {
                return;
            }
        }

        private void CanSave()
        {
            수정됨 = true;
            (Parent.Parent.Parent.Parent as ConversationEditor).CanSave();
        }

        private void Spec_Delete_Click(object sender, EventArgs e)
        {
            OptionList.Items.Remove(OptionList.SelectedItems[0]);
        }

        public override string ToString()
        {
            return scripts.ToString();
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            var c = sender as TextBox;
            c.ClearUndo();

            undoRedo.AddLastTask(ref c);
        }

        public void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control) // Redo
            {
                if (e.KeyCode == Keys.Z)
                {
                    try
                    {
                        var c = sender as TextBox;

                        (Parent.Parent.Parent.Parent as ConversationEditor).SetNotice("Redo");
                        undoRedo.Redo(this);
                    }
                    catch (Exception)
                    {
                        (Parent.Parent.Parent.Parent as ConversationEditor).SetNotice("CanNotRedo");
                    }
                }
            }
            else  if (e.Control) // Undo
            {
                if (e.KeyCode == Keys.Z)
                {
                    try
                    {
                        var c = sender as TextBox;

                        (Parent.Parent.Parent.Parent as ConversationEditor).SetNotice("Undo");
                        undoRedo.Undo(this);
                    }
                    catch (Exception)
                    {
                        (Parent.Parent.Parent.Parent as ConversationEditor).SetNotice("CanNotUndo");
                    }
                }
            }
        }
    }
}
