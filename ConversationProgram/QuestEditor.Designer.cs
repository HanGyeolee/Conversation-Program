namespace ConversationProgram
{
    partial class QuestEditor
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.대화_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.화자 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.대화형식 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.내용 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.대화종료 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.다음 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Item_modify = new System.Windows.Forms.Button();
            this.Item_delete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.item_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Spec_Delete = new System.Windows.Forms.Button();
            this.Spec_modify = new System.Windows.Forms.Button();
            this.Spec_Add = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.o_nextkey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.OptionList = new System.Windows.Forms.ListView();
            this.SelectContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nextkey = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dungeon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wait = new System.Windows.Forms.TextBox();
            this.canexit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.condition);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.nextkey);
            this.splitContainer1.Panel2.Controls.Add(this.content);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.type);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.anime);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.dungeon);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.name);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.key);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.wait);
            this.splitContainer1.Panel2.Controls.Add(this.canexit);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(1259, 544);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.대화_ID,
            this.화자,
            this.대화형식,
            this.내용,
            this.대화종료,
            this.다음});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1259, 304);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // 대화_ID
            // 
            this.대화_ID.Text = "대화_ID";
            this.대화_ID.Width = 128;
            // 
            // 화자
            // 
            this.화자.Text = "화자               ";
            this.화자.Width = 128;
            // 
            // 대화형식
            // 
            this.대화형식.Text = "대화형식";
            this.대화형식.Width = 64;
            // 
            // 내용
            // 
            this.내용.Text = "내용";
            this.내용.Width = 256;
            // 
            // 대화종료
            // 
            this.대화종료.Text = "대화종료";
            this.대화종료.Width = 64;
            // 
            // 다음
            // 
            this.다음.Text = "다음";
            this.다음.Width = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label11.Size = new System.Drawing.Size(90, 36);
            this.label11.TabIndex = 1912;
            this.label11.Text = "조건";
            this.toolTip.SetToolTip(this.label11, "대사가 진행될 때, 진행되어야하는\r\n애니메이션 혹은 카메라 무빙 혹은 음악재생등의\r\nID를 작성하면 됩니다.\r\n반드시 영어로 작성되어야 합니다.");
            // 
            // condition
            // 
            this.condition.Font = new System.Drawing.Font("굴림", 12F);
            this.condition.Location = new System.Drawing.Point(111, 194);
            this.condition.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(247, 26);
            this.condition.TabIndex = 6;
            this.condition.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.condition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Item_modify);
            this.panel6.Controls.Add(this.Item_delete);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.item_Add);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1114, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 236);
            this.panel6.TabIndex = 1910;
            // 
            // Item_modify
            // 
            this.Item_modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.Item_modify.Location = new System.Drawing.Point(0, 64);
            this.Item_modify.Name = "Item_modify";
            this.Item_modify.Size = new System.Drawing.Size(145, 43);
            this.Item_modify.TabIndex = 16;
            this.Item_modify.Text = "수정";
            this.Item_modify.UseVisualStyleBackColor = true;
            this.Item_modify.Click += new System.EventHandler(this.Item_modify_Click);
            // 
            // Item_delete
            // 
            this.Item_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Item_delete.Location = new System.Drawing.Point(0, 193);
            this.Item_delete.Name = "Item_delete";
            this.Item_delete.Size = new System.Drawing.Size(145, 43);
            this.Item_delete.TabIndex = 17;
            this.Item_delete.Text = "삭제";
            this.Item_delete.UseVisualStyleBackColor = true;
            this.Item_delete.Click += new System.EventHandler(this.Item_delete_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 21);
            this.panel7.TabIndex = 1010;
            // 
            // item_Add
            // 
            this.item_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.item_Add.Location = new System.Drawing.Point(0, 0);
            this.item_Add.Name = "item_Add";
            this.item_Add.Size = new System.Drawing.Size(145, 43);
            this.item_Add.TabIndex = 15;
            this.item_Add.Text = "추가";
            this.item_Add.UseVisualStyleBackColor = true;
            this.item_Add.Click += new System.EventHandler(this.item_Add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.OptionList);
            this.panel2.Location = new System.Drawing.Point(766, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(342, 227);
            this.panel2.TabIndex = 1018;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Spec_Delete);
            this.panel3.Controls.Add(this.Spec_modify);
            this.panel3.Controls.Add(this.Spec_Add);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.o_nextkey);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Select);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(170, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 217);
            this.panel3.TabIndex = 108;
            // 
            // Spec_Delete
            // 
            this.Spec_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spec_Delete.Location = new System.Drawing.Point(0, 180);
            this.Spec_Delete.Name = "Spec_Delete";
            this.Spec_Delete.Size = new System.Drawing.Size(167, 29);
            this.Spec_Delete.TabIndex = 14;
            this.Spec_Delete.Text = "삭제";
            this.Spec_Delete.UseVisualStyleBackColor = true;
            this.Spec_Delete.Click += new System.EventHandler(this.Spec_Delete_Click);
            // 
            // Spec_modify
            // 
            this.Spec_modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spec_modify.Location = new System.Drawing.Point(0, 151);
            this.Spec_modify.Name = "Spec_modify";
            this.Spec_modify.Size = new System.Drawing.Size(167, 29);
            this.Spec_modify.TabIndex = 13;
            this.Spec_modify.Text = "수정";
            this.Spec_modify.UseVisualStyleBackColor = true;
            this.Spec_modify.Click += new System.EventHandler(this.Spec_modify_Click);
            // 
            // Spec_Add
            // 
            this.Spec_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spec_Add.Location = new System.Drawing.Point(0, 122);
            this.Spec_Add.Name = "Spec_Add";
            this.Spec_Add.Size = new System.Drawing.Size(167, 29);
            this.Spec_Add.TabIndex = 12;
            this.Spec_Add.Text = "추가";
            this.Spec_Add.UseVisualStyleBackColor = true;
            this.Spec_Add.Click += new System.EventHandler(this.Spec_Add_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 10);
            this.panel4.TabIndex = 105;
            // 
            // o_nextkey
            // 
            this.o_nextkey.Dock = System.Windows.Forms.DockStyle.Top;
            this.o_nextkey.Font = new System.Drawing.Font("굴림", 10F);
            this.o_nextkey.Location = new System.Drawing.Point(0, 89);
            this.o_nextkey.Name = "o_nextkey";
            this.o_nextkey.Size = new System.Drawing.Size(167, 23);
            this.o_nextkey.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(0, 54);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label9.Size = new System.Drawing.Size(167, 35);
            this.label9.TabIndex = 103;
            this.label9.Text = "NextKey";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label9, "해당 선택지를 선택했을 때\r\n이어질 다음 대사 ID를 작성합니다.");
            // 
            // Select
            // 
            this.Select.Dock = System.Windows.Forms.DockStyle.Top;
            this.Select.Font = new System.Drawing.Font("굴림", 10F);
            this.Select.Location = new System.Drawing.Point(0, 31);
            this.Select.MaxLength = 200;
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(167, 23);
            this.Select.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label10.Size = new System.Drawing.Size(167, 31);
            this.label10.TabIndex = 100;
            this.label10.Text = "선택지";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label10, "해당 대사에 따라 선택을 해야하는\r\n선택지를 작성합니다.");
            // 
            // OptionList
            // 
            this.OptionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectContent,
            this.NKey});
            this.OptionList.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionList.HideSelection = false;
            this.OptionList.Location = new System.Drawing.Point(5, 5);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(165, 217);
            this.OptionList.TabIndex = 107;
            this.OptionList.UseCompatibleStateImageBehavior = false;
            this.OptionList.View = System.Windows.Forms.View.Details;
            this.OptionList.SelectedIndexChanged += new System.EventHandler(this.OptionList_SelectedIndexChanged);
            // 
            // SelectContent
            // 
            this.SelectContent.Text = "선택지";
            this.SelectContent.Width = 70;
            // 
            // NKey
            // 
            this.NKey.Text = "NextKey";
            this.NKey.Width = 94;
            // 
            // nextkey
            // 
            this.nextkey.Font = new System.Drawing.Font("굴림", 12F);
            this.nextkey.Location = new System.Drawing.Point(496, 166);
            this.nextkey.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.nextkey.Name = "nextkey";
            this.nextkey.Size = new System.Drawing.Size(264, 26);
            this.nextkey.TabIndex = 9;
            this.nextkey.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.nextkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.content.Location = new System.Drawing.Point(377, 51);
            this.content.MaxLength = 500;
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(383, 111);
            this.content.TabIndex = 8;
            this.content.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(364, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label7.Size = new System.Drawing.Size(116, 36);
            this.label7.TabIndex = 1013;
            this.label7.Text = "Content";
            this.toolTip.SetToolTip(this.label7, "화자가 이야기할 대사입니다.");
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("굴림", 12F);
            this.type.FormattingEnabled = true;
            this.type.ItemHeight = 16;
            this.type.Items.AddRange(new object[] {
            "C",
            "O"});
            this.type.Location = new System.Drawing.Point(486, 18);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 24);
            this.type.TabIndex = 7;
            this.type.Text = "Type";
            this.toolTip.SetToolTip(this.type, "대사의 형식입니다.\r\nC는 직선적인 대사이며,\r\nO는 선택지가 존재하는 대사입니다.");
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 1010;
            this.label6.Text = "CanExit";
            this.toolTip.SetToolTip(this.label6, "체크가 되면 현재 대화\r\n이후 대화창이 꺼집니다.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label5.Size = new System.Drawing.Size(106, 36);
            this.label5.TabIndex = 108;
            this.label5.Text = "애니메";
            this.toolTip.SetToolTip(this.label5, "대사가 진행될 때, 진행되어야하는\r\n애니메이션 혹은 카메라 무빙 혹은 음악재생등의\r\nID를 작성하면 됩니다.\r\n반드시 영어로 작성되어야 합니다.");
            // 
            // anime
            // 
            this.anime.Font = new System.Drawing.Font("굴림", 12F);
            this.anime.Location = new System.Drawing.Point(111, 165);
            this.anime.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.anime.Name = "anime";
            this.anime.Size = new System.Drawing.Size(247, 26);
            this.anime.TabIndex = 5;
            this.anime.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.anime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label4.Size = new System.Drawing.Size(90, 36);
            this.label4.TabIndex = 106;
            this.label4.Text = "던전";
            this.toolTip.SetToolTip(this.label4, "해당 대사가 진행된 후,\r\n반드시 해당 던전으로 이동될 때 작성합니다.\r\n대사와 던전이 아무런 관계가 없을 때엔\r\n비워둡니다. 반드시 영어로 작성" +
        "되어야 합니다.");
            // 
            // dungeon
            // 
            this.dungeon.Font = new System.Drawing.Font("굴림", 12F);
            this.dungeon.Location = new System.Drawing.Point(134, 136);
            this.dungeon.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.dungeon.Name = "dungeon";
            this.dungeon.Size = new System.Drawing.Size(224, 26);
            this.dungeon.TabIndex = 4;
            this.dungeon.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.dungeon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label3.Size = new System.Drawing.Size(90, 36);
            this.label3.TabIndex = 104;
            this.label3.Text = "화자";
            this.toolTip.SetToolTip(this.label3, "해당 대사를 이야기할 화자입니다.");
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("굴림", 12F);
            this.name.Location = new System.Drawing.Point(109, 75);
            this.name.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 26);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 100;
            this.label1.Text = "ID";
            this.toolTip.SetToolTip(this.label1, "대화의 ID입니다.\r\n반드시 영어로 작성되어야 합니다.");
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("굴림", 12F);
            this.key.Location = new System.Drawing.Point(94, 18);
            this.key.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(264, 26);
            this.key.TabIndex = 0;
            this.key.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 102;
            this.label2.Text = "Wait";
            this.toolTip.SetToolTip(this.label2, "대화창이 켜진 후,\r\n대화가 출력되기 까지 대기합니다.");
            // 
            // wait
            // 
            this.wait.Font = new System.Drawing.Font("굴림", 12F);
            this.wait.Location = new System.Drawing.Point(98, 46);
            this.wait.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.wait.MaxLength = 7;
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(260, 26);
            this.wait.TabIndex = 1;
            this.wait.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.wait.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // canexit
            // 
            this.canexit.AutoSize = true;
            this.canexit.Location = new System.Drawing.Point(134, 104);
            this.canexit.Name = "canexit";
            this.canexit.Padding = new System.Windows.Forms.Padding(10);
            this.canexit.Size = new System.Drawing.Size(35, 34);
            this.canexit.TabIndex = 3;
            this.canexit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(374, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label8.Size = new System.Drawing.Size(110, 36);
            this.label8.TabIndex = 1016;
            this.label8.Text = "Next ID";
            this.toolTip.SetToolTip(this.label8, "Type이 C일 경우에 작동되며, 다음 진행될 대사 ID를 작성합니다.\r\n현재 대사가 마지막 대사라면, CanExit을 체크해주시고, 현재 칸을 " +
        "비워둡니다. \r\n반드시 영어로 작성되어야 합니다.");
            // 
            // XmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "XmlEditor";
            this.Size = new System.Drawing.Size(1259, 544);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dungeon;
        private System.Windows.Forms.CheckBox canexit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Spec_Delete;
        private System.Windows.Forms.Button Spec_modify;
        private System.Windows.Forms.Button Spec_Add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox o_nextkey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Select;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView OptionList;
        private System.Windows.Forms.ColumnHeader SelectContent;
        private System.Windows.Forms.ColumnHeader NKey;
        private System.Windows.Forms.TextBox nextkey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Item_modify;
        private System.Windows.Forms.Button Item_delete;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button item_Add;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader 대화_ID;
        private System.Windows.Forms.ColumnHeader 화자;
        private System.Windows.Forms.ColumnHeader 내용;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ColumnHeader 다음;
        private System.Windows.Forms.ColumnHeader 대화형식;
        private System.Windows.Forms.ColumnHeader 대화종료;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox condition;
    }
}
