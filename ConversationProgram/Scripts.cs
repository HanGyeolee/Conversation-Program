using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversationProgram
{
    public class Scripts
    {
        public string ID;
        public string First_Conversation;

        public List<Conversation> conversations = new List<Conversation>();

        private XmlDocument xmlDoc;

        public void LoadXml(string filepath)
        {
            if (File.Exists(filepath))
            {
                xmlDoc = new XmlDocument();

                using (var reader = new StreamReader(filepath, Encoding.UTF8))
                    xmlDoc.Load(reader);

                XmlNode root = xmlDoc.DocumentElement;
                XmlNode node = root.FirstChild;

                node = GetInnerText(ref node, out ID);
                node = GetInnerText(ref node, out First_Conversation);

                for (int i = 0; node != null; i++)
                {
                    conversations.Add(new Conversation(node.Name));
                    node = conversations[i].LoadConversation(ref node);
                }
            }
            else
            {
                ID = Path.GetFileName(filepath).Split('.')[0];
            }
        }

        /// <summary>
        /// 안에 있는 문자열을 반환합니다.
        /// </summary>
        /// <param name="node">현재 노드</param>
        /// <param name="innertext">문자열을 얻어올 변수</param>
        /// <returns>다음 노드</returns>
        public XmlNode GetInnerText(ref XmlNode node, out string innertext)
        {
            innertext = node.InnerText;
            return node.NextSibling;
        }

        /// <summary>
        /// 안에 있는 문자열과 속성을 반환합니다.
        /// </summary>
        /// <param name="node">현재 노드</param>
        /// <param name="innertext">문자열을 얻어올 변수</param>
        /// <param name="key">노드 속 속성</param>
        /// <param name="attribute">속성을 얻어올 변수</param>
        /// <returns>다음 노드</returns>
        public XmlNode GetInnerText(ref XmlNode node, out string innertext, out string attribute, string key = "key")
        {
            innertext = node.InnerText;
            attribute = node.Attributes?.GetNamedItem(key)?.Value ?? null;
            return node.NextSibling;
        }

        public override string ToString()
        {
            var result = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\n";
            if (string.IsNullOrWhiteSpace(First_Conversation))
                First_Conversation = conversations[0].Key;
            result += $"<{ID}>\n"
                    + $"\t<ID>{ID}</ID>\n"
                    + $"\t<FirstC>{First_Conversation}</FirstC>\n";

            for(int i = 0; i < conversations.Count; i++)
            {
                result += conversations[i].ToString();
            }
            result += $"</{ID}>";

            return result;
        }
    }

    public class Conversation
    {
        public string Key { get; private set; }         // 대사 키

        public int Wait { get; private set; }           // 대사 나오기 전 기다리는 시간
        public string Name { get; private set; }        // 화자 이름
        public bool CanExit { get; private set; }       // 대사 종료 이후, 대사 창을 끌 것인가
        public string DunGeon { get; private set; }     // 대사 종료 이후, 던전으로 이동할 것인가.
        public string Anime { get; private set; }       // 현재 대사에서 실행시킬 에니메이션 혹은 음악
        public string Condition_ID { get; private set; }// 현재 대사가 실행될 때 만족해야하는 조건키
        public char Type { get; private set; }          // 대사의 타입
        public string Content { get; private set; }     // 대사
        public string Next_C_ID { get; private set; }   // 다음 대사 키
        public string[] Options { get; private set; }     // 선택지 종류
        public string[] Option_C_ID { get; private set; } // 선택지에 따른 다음 대사

        public Conversation(string key, string name = null, string content = null, bool canexit = false,
            char type = 'C', string dungeon = null, string anime = null, int wait = 0, string condi = null)
        {
            Key = key;

            Name = name;
            Wait = wait;
            Type = type;
            Content = content;
            CanExit = canexit;
            DunGeon = dungeon;
            Anime = anime;
            Condition_ID = condi;
        }
     
        public void Copy(Conversation conversation)
        {
            Key = conversation.Key;

            Name = string.IsNullOrWhiteSpace(conversation.Name) ? null : conversation.Name;
            Wait = conversation.Wait;
            Type = conversation.Type;
            Content = string.IsNullOrWhiteSpace(conversation.Content) ? null : conversation.Content;
            CanExit = conversation.CanExit;
            DunGeon = string.IsNullOrWhiteSpace(conversation.DunGeon) ? null : conversation.DunGeon;
            Anime = string.IsNullOrWhiteSpace(conversation.Anime) ? null : conversation.Anime;
            Condition_ID = string.IsNullOrWhiteSpace(conversation.Condition_ID) ? null : conversation.Condition_ID;

            SetNextConversationID(string.IsNullOrWhiteSpace(conversation.Next_C_ID) ? null : conversation.Next_C_ID);
            SetOptionsID(conversation.Options, conversation.Option_C_ID);
        }

        public XmlNode LoadConversation(ref XmlNode node)
        {
            Key = node.Name;

            Name = node.SelectSingleNode("Name").InnerText;
            Wait = int.Parse(node.SelectSingleNode("Wait").InnerText);
            Type = node.SelectSingleNode("Type").InnerText[0];
            Content = node.SelectSingleNode("Content")?.InnerText ?? null;
            CanExit = node.SelectSingleNode("CanExit").InnerText.Equals("true");
            DunGeon = node.SelectSingleNode("DunGeon")?.InnerText ?? null;
            Anime = node.SelectSingleNode("Anime")?.InnerText ?? null;
            Condition_ID = node.SelectSingleNode("Condition")?.InnerText ?? null;

            if (Type == 'C')
                Next_C_ID = node.SelectSingleNode("Next_C_ID")?.InnerText ?? null;
            else
            {
                var opts = node.SelectSingleNode("Options").InnerText.Split(new string[] { "::" }, StringSplitOptions.None );
                Options = new string[opts.Length];
                for (int i = 0; i < opts.Length; i++)
                    Options[i] = opts[i];

                var opts_c = node.SelectSingleNode("Option_C_ID").InnerText.Split(new string[] { "::" }, StringSplitOptions.None);
                Option_C_ID = new string[opts_c.Length];
                for (int i = 0; i < opts_c.Length; i++)
                    Option_C_ID[i] = opts_c[i];
            }

            return node.NextSibling;
        }

        public void SetNextConversationID(string next_c_id)
        {
            if(next_c_id != null)
                if(Type == 'C')
                {
                    Next_C_ID = next_c_id;
                    Options = null;
                    Option_C_ID = null;
                }
        }

        public void SetOptionsID(string options, string option_c_id)
        {
            if (Type != 'C')
            {
                Next_C_ID = null;

                var opts = options.Split(new string[] { "::" }, StringSplitOptions.None);
                Options = new string[opts.Length];
                for (int i = 0; i < opts.Length; i++)
                    Options[i] = opts[i];

                var opts_c = option_c_id.Split(new string[] { "::" }, StringSplitOptions.None);
                Option_C_ID = new string[opts_c.Length];
                for (int i = 0; i < opts_c.Length; i++)
                    Option_C_ID[i] = opts_c[i];
            }
        }

        public void SetOptionsID(string[] options, string[] option_c_id)
        {
            if(options != null && option_c_id != null)
                if (Type != 'C')
                {
                    Next_C_ID = null;

                    if (options.Length > 0)
                    {
                        Options = new string[options.Length];
                        for (int i = 0; i < options.Length; i++)
                            Options[i] = options[i];
                    }

                    if (option_c_id.Length > 0)
                    {
                        Option_C_ID = new string[option_c_id.Length];
                        for (int i = 0; i < option_c_id.Length; i++)
                            Option_C_ID[i] = option_c_id[i];
                    }
                }
        }

        private void MakeNull()
        {
            Name = string.IsNullOrWhiteSpace(Name) ? null : Name;
            DunGeon = string.IsNullOrWhiteSpace(DunGeon) ? null : DunGeon;
            Anime = string.IsNullOrWhiteSpace(Anime) ? null : Anime;
            Condition_ID = string.IsNullOrWhiteSpace(Condition_ID) ? null : Condition_ID;
            Content = string.IsNullOrWhiteSpace(Content) ? null : Content;
            Next_C_ID = string.IsNullOrWhiteSpace(Next_C_ID) ? null : Next_C_ID;
        }

        public override string ToString()
        {
            MakeNull();
            var result= $"\t<{Key}>\n" ;
            result +=       $"\t\t<Name>{Name}</Name>\n"
                    +       $"\t\t<Wait>{Wait}</Wait>\n"
                    +       $"\t\t<Type>{Type}</Type>\n"
                    +       $"\t\t<Content>{Content}</Content>\n";
            if(CanExit)
                result +=   $"\t\t<CanExit>true</CanExit>\n";
            else
                result +=   $"\t\t<CanExit>false</CanExit>\n";
            if(CanExit)
                if(!string.IsNullOrWhiteSpace(DunGeon))
                    result +=   $"\t\t<DunGeon>{DunGeon}</DunGeon>\n";
            if (!string.IsNullOrWhiteSpace(Anime))
                result +=   $"\t\t<Anime>{Anime}</Anime>\n";
            if (!string.IsNullOrWhiteSpace(Condition_ID))
                result += $"\t\t<Condition>{Condition_ID}</Condition>\n";

            if (Type == 'C')
            {
                if (!string.IsNullOrWhiteSpace(Next_C_ID))
                    result += $"\t\t<Next_C_ID>{Next_C_ID}</Next_C_ID>\n";
            }
            else
            {
                string opts = "";
                for (int i = 0; i < Options.Length; i++)
                {
                    opts += Options[i];
                    if (i < Options.Length - 1)
                        opts += "::";
                }
                if (!string.IsNullOrWhiteSpace(opts))
                    result += $"\t\t<Options>{opts}</Options>\n";

                string opts_c = "";
                for (int i = 0; i < Option_C_ID.Length; i++)
                {
                    opts_c += Option_C_ID[i];
                    if (i < Option_C_ID.Length - 1)
                        opts_c += "::";
                }
                if (!string.IsNullOrWhiteSpace(opts_c))
                    result += $"\t\t<Option_C_ID>{opts_c}</Option_C_ID>\n";
            }
            result += $"\t</{Key}>\n";
            return result;
        }
    }

    public class UndoRedo<TKey> where TKey : Control
    {
        private const int MAX_COUNT = 300;
        protected List<CustomTask<string>> UndoTask = new List<CustomTask<string>>();
        protected List<CustomTask<string>> RedoTask = new List<CustomTask<string>>();

        /// <summary>
        /// textchanged 마다 호출
        /// </summary>
        /// <param name="control">저장할 컨트롤</param>
        /// <returns></returns>
        public int AddLastTask(ref TKey control)
        {
            try
            {
                UndoTask.Add(new CustomTask<string>(control.Name, control.Text));
                CheckMax();
            }
            catch (Exception)
            {
                return 1;
            }

            return 0;
        }

        private void CheckMax()
        {
            if (UndoTask.Count > MAX_COUNT)
                UndoTask.RemoveRange(0, 1);
            if (RedoTask.Count > MAX_COUNT)
                RedoTask.RemoveRange(0, 1);
        }

        /// <summary>
        /// 되돌린다.
        /// </summary>
        /// <param name="control">부모 컨트롤</param>
        public void Undo(Control control)
        {
            try
            {
                if (UndoTask.Count > 1)
                {
                    var last = UndoTask.LastOrDefault();
                    TKey c = control.Controls.Find(last.ControlName, true).FirstOrDefault() as TKey;

                    RedoTask.Add(new CustomTask<string>(c.Name, c.Text));
                    CheckMax();

                    c.Focus();
                    c.Text = last.Content;

                    UndoTask.Remove(last);
                }
            }
            catch(ArgumentNullException)
            {
                return ;
            }
        }

        /// <summary>
        /// 다시쓴다.
        /// </summary>
        /// <param name="control">부모 컨트롤</param>
        public void Redo(Control control)
        {
            try
            {
                if (RedoTask.Count > 1)
                {
                    var last = RedoTask.LastOrDefault();
                    TKey c = control.Controls.Find(last.ControlName, true).FirstOrDefault() as TKey;

                    UndoTask.Add(new CustomTask<string>(c.Name, c.Text));
                    CheckMax();

                    c.Focus();
                    c.Text = last.Content;

                    RedoTask.Remove(last);
                }
            }
            catch(ArgumentNullException)
            {
                return ;
            }
        }
    }

    public class CustomTask<TValue>
    {
        public string ControlName { get; private set; }
        public TValue Content { get; private set; }

        public CustomTask(string name, TValue value) { ControlName = name; Content = value; }
    }
}
