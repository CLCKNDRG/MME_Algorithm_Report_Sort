namespace MME_Algorithm_Report_Sort_01
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox_manual = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_inputBox = new System.Windows.Forms.TextBox();
            this.inputBox_min = new System.Windows.Forms.TextBox();
            this.inputBox_max = new System.Windows.Forms.TextBox();
            this.inputBox_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.grp_Insertion = new System.Windows.Forms.GroupBox();
            this.grp_Shell = new System.Windows.Forms.GroupBox();
            this.grp_Bubble = new System.Windows.Forms.GroupBox();
            this.grp_Comb = new System.Windows.Forms.GroupBox();
            this.grp_Quick = new System.Windows.Forms.GroupBox();
            this.grp_Selection = new System.Windows.Forms.GroupBox();
            this.grp_Heap = new System.Windows.Forms.GroupBox();
            this.groupBox_2Merge = new System.Windows.Forms.GroupBox();
            this.grp_Radix = new System.Windows.Forms.GroupBox();
            this.checkBox_Insertion = new System.Windows.Forms.CheckBox();
            this.checkBox_Shell = new System.Windows.Forms.CheckBox();
            this.checkBox_Comb = new System.Windows.Forms.CheckBox();
            this.checkBox_Bubble = new System.Windows.Forms.CheckBox();
            this.checkBox_Quick = new System.Windows.Forms.CheckBox();
            this.checkBox_2Merge = new System.Windows.Forms.CheckBox();
            this.checkBox_Radix = new System.Windows.Forms.CheckBox();
            this.checkBox_Heap = new System.Windows.Forms.CheckBox();
            this.checkBox_Selection = new System.Windows.Forms.CheckBox();
            this.textBox_Insertion = new System.Windows.Forms.TextBox();
            this.textBox_Shell = new System.Windows.Forms.TextBox();
            this.textBox_Comb = new System.Windows.Forms.TextBox();
            this.textBox_Bubble = new System.Windows.Forms.TextBox();
            this.textBox_Quick = new System.Windows.Forms.TextBox();
            this.textBox_2Merge = new System.Windows.Forms.TextBox();
            this.textBox_Selection = new System.Windows.Forms.TextBox();
            this.textBox_Heap = new System.Windows.Forms.TextBox();
            this.textBox_Radix = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox_TimeComplex = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ascend = new System.Windows.Forms.RadioButton();
            this.descend = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_Insertion.SuspendLayout();
            this.grp_Shell.SuspendLayout();
            this.grp_Bubble.SuspendLayout();
            this.grp_Comb.SuspendLayout();
            this.grp_Quick.SuspendLayout();
            this.grp_Selection.SuspendLayout();
            this.grp_Heap.SuspendLayout();
            this.groupBox_2Merge.SuspendLayout();
            this.grp_Radix.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox_manual
            // 
            this.inputBox_manual.Location = new System.Drawing.Point(8, 32);
            this.inputBox_manual.Name = "inputBox_manual";
            this.inputBox_manual.Size = new System.Drawing.Size(325, 21);
            this.inputBox_manual.TabIndex = 0;
            this.inputBox_manual.Text = "각 인자의 구분은 띄어쓰기로 구분합니다.";
            this.inputBox_manual.Click += new System.EventHandler(this.inputBox_manual_Click);
            this.inputBox_manual.Enter += new System.EventHandler(this.inputBox_manual_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.inputBox_num);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.inputBox_max);
            this.groupBox1.Controls.Add(this.inputBox_min);
            this.groupBox1.Controls.Add(this.textBox_inputBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputBox_manual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수 입력";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "최대값";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "최소값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "랜덤한 값 생성하기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "직접 입력하기";
            // 
            // textBox_inputBox
            // 
            this.textBox_inputBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_inputBox.Location = new System.Drawing.Point(8, 110);
            this.textBox_inputBox.Multiline = true;
            this.textBox_inputBox.Name = "textBox_inputBox";
            this.textBox_inputBox.ReadOnly = true;
            this.textBox_inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_inputBox.Size = new System.Drawing.Size(386, 69);
            this.textBox_inputBox.TabIndex = 2;
            // 
            // inputBox_min
            // 
            this.inputBox_min.Location = new System.Drawing.Point(53, 83);
            this.inputBox_min.Name = "inputBox_min";
            this.inputBox_min.Size = new System.Drawing.Size(62, 21);
            this.inputBox_min.TabIndex = 6;
            this.inputBox_min.Enter += new System.EventHandler(this.inputBox_min_Enter);
            // 
            // inputBox_max
            // 
            this.inputBox_max.Location = new System.Drawing.Point(168, 83);
            this.inputBox_max.Name = "inputBox_max";
            this.inputBox_max.Size = new System.Drawing.Size(62, 21);
            this.inputBox_max.TabIndex = 7;
            this.inputBox_max.Enter += new System.EventHandler(this.inputBox_min_Enter);
            // 
            // inputBox_num
            // 
            this.inputBox_num.Location = new System.Drawing.Point(271, 83);
            this.inputBox_num.Name = "inputBox_num";
            this.inputBox_num.Size = new System.Drawing.Size(62, 21);
            this.inputBox_num.TabIndex = 9;
            this.inputBox_num.Enter += new System.EventHandler(this.inputBox_min_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "개수";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descend);
            this.groupBox2.Controls.Add(this.ascend);
            this.groupBox2.Controls.Add(this.executeButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "실행";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(6, 42);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(388, 23);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "정렬 실행";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_Insertion
            // 
            this.grp_Insertion.Controls.Add(this.textBox_Insertion);
            this.grp_Insertion.Controls.Add(this.checkBox_Insertion);
            this.grp_Insertion.Location = new System.Drawing.Point(12, 284);
            this.grp_Insertion.Name = "grp_Insertion";
            this.grp_Insertion.Size = new System.Drawing.Size(197, 100);
            this.grp_Insertion.TabIndex = 3;
            this.grp_Insertion.TabStop = false;
            this.grp_Insertion.Text = "삽입정렬";
            // 
            // grp_Shell
            // 
            this.grp_Shell.Controls.Add(this.textBox_Shell);
            this.grp_Shell.Controls.Add(this.checkBox_Shell);
            this.grp_Shell.Location = new System.Drawing.Point(215, 284);
            this.grp_Shell.Name = "grp_Shell";
            this.grp_Shell.Size = new System.Drawing.Size(197, 100);
            this.grp_Shell.TabIndex = 4;
            this.grp_Shell.TabStop = false;
            this.grp_Shell.Text = "셸정렬";
            // 
            // grp_Bubble
            // 
            this.grp_Bubble.Controls.Add(this.textBox_Bubble);
            this.grp_Bubble.Controls.Add(this.checkBox_Bubble);
            this.grp_Bubble.Location = new System.Drawing.Point(12, 390);
            this.grp_Bubble.Name = "grp_Bubble";
            this.grp_Bubble.Size = new System.Drawing.Size(197, 100);
            this.grp_Bubble.TabIndex = 5;
            this.grp_Bubble.TabStop = false;
            this.grp_Bubble.Text = "버블정렬";
            // 
            // grp_Comb
            // 
            this.grp_Comb.Controls.Add(this.textBox_Comb);
            this.grp_Comb.Controls.Add(this.checkBox_Comb);
            this.grp_Comb.Location = new System.Drawing.Point(418, 284);
            this.grp_Comb.Name = "grp_Comb";
            this.grp_Comb.Size = new System.Drawing.Size(197, 100);
            this.grp_Comb.TabIndex = 5;
            this.grp_Comb.TabStop = false;
            this.grp_Comb.Text = "빗질정렬";
            // 
            // grp_Quick
            // 
            this.grp_Quick.Controls.Add(this.textBox_Quick);
            this.grp_Quick.Controls.Add(this.checkBox_Quick);
            this.grp_Quick.Location = new System.Drawing.Point(215, 390);
            this.grp_Quick.Name = "grp_Quick";
            this.grp_Quick.Size = new System.Drawing.Size(197, 100);
            this.grp_Quick.TabIndex = 6;
            this.grp_Quick.TabStop = false;
            this.grp_Quick.Text = "퀵정렬";
            // 
            // grp_Selection
            // 
            this.grp_Selection.Controls.Add(this.textBox_Selection);
            this.grp_Selection.Controls.Add(this.checkBox_Selection);
            this.grp_Selection.Location = new System.Drawing.Point(12, 496);
            this.grp_Selection.Name = "grp_Selection";
            this.grp_Selection.Size = new System.Drawing.Size(197, 100);
            this.grp_Selection.TabIndex = 6;
            this.grp_Selection.TabStop = false;
            this.grp_Selection.Text = "선택정렬";
            // 
            // grp_Heap
            // 
            this.grp_Heap.Controls.Add(this.textBox_Heap);
            this.grp_Heap.Controls.Add(this.checkBox_Heap);
            this.grp_Heap.Location = new System.Drawing.Point(215, 496);
            this.grp_Heap.Name = "grp_Heap";
            this.grp_Heap.Size = new System.Drawing.Size(197, 100);
            this.grp_Heap.TabIndex = 7;
            this.grp_Heap.TabStop = false;
            this.grp_Heap.Text = "힙정렬";
            // 
            // groupBox_2Merge
            // 
            this.groupBox_2Merge.Controls.Add(this.textBox_2Merge);
            this.groupBox_2Merge.Controls.Add(this.checkBox_2Merge);
            this.groupBox_2Merge.Location = new System.Drawing.Point(418, 390);
            this.groupBox_2Merge.Name = "groupBox_2Merge";
            this.groupBox_2Merge.Size = new System.Drawing.Size(197, 100);
            this.groupBox_2Merge.TabIndex = 7;
            this.groupBox_2Merge.TabStop = false;
            this.groupBox_2Merge.Text = "2-Way 병합정렬";
            // 
            // grp_Radix
            // 
            this.grp_Radix.Controls.Add(this.textBox_Radix);
            this.grp_Radix.Controls.Add(this.checkBox_Radix);
            this.grp_Radix.Location = new System.Drawing.Point(418, 496);
            this.grp_Radix.Name = "grp_Radix";
            this.grp_Radix.Size = new System.Drawing.Size(197, 100);
            this.grp_Radix.TabIndex = 8;
            this.grp_Radix.TabStop = false;
            this.grp_Radix.Text = "기수정렬";
            // 
            // checkBox_Insertion
            // 
            this.checkBox_Insertion.AutoSize = true;
            this.checkBox_Insertion.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Insertion.Name = "checkBox_Insertion";
            this.checkBox_Insertion.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Insertion.TabIndex = 9;
            this.checkBox_Insertion.UseVisualStyleBackColor = true;
            // 
            // checkBox_Shell
            // 
            this.checkBox_Shell.AutoSize = true;
            this.checkBox_Shell.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Shell.Name = "checkBox_Shell";
            this.checkBox_Shell.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Shell.TabIndex = 10;
            this.checkBox_Shell.UseVisualStyleBackColor = true;
            // 
            // checkBox_Comb
            // 
            this.checkBox_Comb.AutoSize = true;
            this.checkBox_Comb.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Comb.Name = "checkBox_Comb";
            this.checkBox_Comb.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Comb.TabIndex = 11;
            this.checkBox_Comb.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bubble
            // 
            this.checkBox_Bubble.AutoSize = true;
            this.checkBox_Bubble.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Bubble.Name = "checkBox_Bubble";
            this.checkBox_Bubble.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Bubble.TabIndex = 10;
            this.checkBox_Bubble.UseVisualStyleBackColor = true;
            // 
            // checkBox_Quick
            // 
            this.checkBox_Quick.AutoSize = true;
            this.checkBox_Quick.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Quick.Name = "checkBox_Quick";
            this.checkBox_Quick.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Quick.TabIndex = 11;
            this.checkBox_Quick.UseVisualStyleBackColor = true;
            // 
            // checkBox_2Merge
            // 
            this.checkBox_2Merge.AutoSize = true;
            this.checkBox_2Merge.Location = new System.Drawing.Point(6, 20);
            this.checkBox_2Merge.Name = "checkBox_2Merge";
            this.checkBox_2Merge.Size = new System.Drawing.Size(15, 14);
            this.checkBox_2Merge.TabIndex = 12;
            this.checkBox_2Merge.UseVisualStyleBackColor = true;
            // 
            // checkBox_Radix
            // 
            this.checkBox_Radix.AutoSize = true;
            this.checkBox_Radix.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Radix.Name = "checkBox_Radix";
            this.checkBox_Radix.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Radix.TabIndex = 13;
            this.checkBox_Radix.UseVisualStyleBackColor = true;
            // 
            // checkBox_Heap
            // 
            this.checkBox_Heap.AutoSize = true;
            this.checkBox_Heap.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Heap.Name = "checkBox_Heap";
            this.checkBox_Heap.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Heap.TabIndex = 14;
            this.checkBox_Heap.UseVisualStyleBackColor = true;
            // 
            // checkBox_Selection
            // 
            this.checkBox_Selection.AutoSize = true;
            this.checkBox_Selection.Location = new System.Drawing.Point(6, 20);
            this.checkBox_Selection.Name = "checkBox_Selection";
            this.checkBox_Selection.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Selection.TabIndex = 15;
            this.checkBox_Selection.UseVisualStyleBackColor = true;
            // 
            // textBox_Insertion
            // 
            this.textBox_Insertion.Location = new System.Drawing.Point(27, 20);
            this.textBox_Insertion.Multiline = true;
            this.textBox_Insertion.Name = "textBox_Insertion";
            this.textBox_Insertion.ReadOnly = true;
            this.textBox_Insertion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Insertion.Size = new System.Drawing.Size(164, 74);
            this.textBox_Insertion.TabIndex = 9;
            // 
            // textBox_Shell
            // 
            this.textBox_Shell.Location = new System.Drawing.Point(27, 20);
            this.textBox_Shell.Multiline = true;
            this.textBox_Shell.Name = "textBox_Shell";
            this.textBox_Shell.ReadOnly = true;
            this.textBox_Shell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Shell.Size = new System.Drawing.Size(164, 74);
            this.textBox_Shell.TabIndex = 10;
            // 
            // textBox_Comb
            // 
            this.textBox_Comb.Location = new System.Drawing.Point(27, 20);
            this.textBox_Comb.Multiline = true;
            this.textBox_Comb.Name = "textBox_Comb";
            this.textBox_Comb.ReadOnly = true;
            this.textBox_Comb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Comb.Size = new System.Drawing.Size(164, 74);
            this.textBox_Comb.TabIndex = 11;
            // 
            // textBox_Bubble
            // 
            this.textBox_Bubble.Location = new System.Drawing.Point(27, 20);
            this.textBox_Bubble.Multiline = true;
            this.textBox_Bubble.Name = "textBox_Bubble";
            this.textBox_Bubble.ReadOnly = true;
            this.textBox_Bubble.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Bubble.Size = new System.Drawing.Size(164, 74);
            this.textBox_Bubble.TabIndex = 12;
            // 
            // textBox_Quick
            // 
            this.textBox_Quick.Location = new System.Drawing.Point(27, 20);
            this.textBox_Quick.Multiline = true;
            this.textBox_Quick.Name = "textBox_Quick";
            this.textBox_Quick.ReadOnly = true;
            this.textBox_Quick.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Quick.Size = new System.Drawing.Size(164, 74);
            this.textBox_Quick.TabIndex = 13;
            // 
            // textBox_2Merge
            // 
            this.textBox_2Merge.Location = new System.Drawing.Point(27, 20);
            this.textBox_2Merge.Multiline = true;
            this.textBox_2Merge.Name = "textBox_2Merge";
            this.textBox_2Merge.ReadOnly = true;
            this.textBox_2Merge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_2Merge.Size = new System.Drawing.Size(164, 74);
            this.textBox_2Merge.TabIndex = 14;
            // 
            // textBox_Selection
            // 
            this.textBox_Selection.Location = new System.Drawing.Point(27, 20);
            this.textBox_Selection.Multiline = true;
            this.textBox_Selection.Name = "textBox_Selection";
            this.textBox_Selection.ReadOnly = true;
            this.textBox_Selection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Selection.Size = new System.Drawing.Size(164, 74);
            this.textBox_Selection.TabIndex = 15;
            // 
            // textBox_Heap
            // 
            this.textBox_Heap.Location = new System.Drawing.Point(27, 20);
            this.textBox_Heap.Multiline = true;
            this.textBox_Heap.Name = "textBox_Heap";
            this.textBox_Heap.ReadOnly = true;
            this.textBox_Heap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Heap.Size = new System.Drawing.Size(164, 74);
            this.textBox_Heap.TabIndex = 16;
            // 
            // textBox_Radix
            // 
            this.textBox_Radix.Location = new System.Drawing.Point(27, 20);
            this.textBox_Radix.Multiline = true;
            this.textBox_Radix.Name = "textBox_Radix";
            this.textBox_Radix.ReadOnly = true;
            this.textBox_Radix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Radix.Size = new System.Drawing.Size(164, 74);
            this.textBox_Radix.TabIndex = 17;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox_TimeComplex);
            this.groupBox12.Location = new System.Drawing.Point(418, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(197, 266);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "시간복잡도";
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(621, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(311, 584);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "그래프";
            // 
            // textBox_TimeComplex
            // 
            this.textBox_TimeComplex.Location = new System.Drawing.Point(6, 20);
            this.textBox_TimeComplex.Multiline = true;
            this.textBox_TimeComplex.Name = "textBox_TimeComplex";
            this.textBox_TimeComplex.ReadOnly = true;
            this.textBox_TimeComplex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TimeComplex.Size = new System.Drawing.Size(185, 240);
            this.textBox_TimeComplex.TabIndex = 0;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 602);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(920, 23);
            this.progress.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "입력";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ascend
            // 
            this.ascend.AutoSize = true;
            this.ascend.Checked = true;
            this.ascend.Location = new System.Drawing.Point(6, 20);
            this.ascend.Name = "ascend";
            this.ascend.Size = new System.Drawing.Size(99, 16);
            this.ascend.TabIndex = 6;
            this.ascend.TabStop = true;
            this.ascend.Text = "오름차순 정렬";
            this.ascend.UseVisualStyleBackColor = true;
            // 
            // descend
            // 
            this.descend.AutoSize = true;
            this.descend.Location = new System.Drawing.Point(111, 20);
            this.descend.Name = "descend";
            this.descend.Size = new System.Drawing.Size(99, 16);
            this.descend.TabIndex = 7;
            this.descend.TabStop = true;
            this.descend.Text = "내림차순 정렬";
            this.descend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 631);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.grp_Radix);
            this.Controls.Add(this.groupBox_2Merge);
            this.Controls.Add(this.grp_Comb);
            this.Controls.Add(this.grp_Heap);
            this.Controls.Add(this.grp_Selection);
            this.Controls.Add(this.grp_Quick);
            this.Controls.Add(this.grp_Bubble);
            this.Controls.Add(this.grp_Shell);
            this.Controls.Add(this.grp_Insertion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "2014110173 김선욱";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_Insertion.ResumeLayout(false);
            this.grp_Insertion.PerformLayout();
            this.grp_Shell.ResumeLayout(false);
            this.grp_Shell.PerformLayout();
            this.grp_Bubble.ResumeLayout(false);
            this.grp_Bubble.PerformLayout();
            this.grp_Comb.ResumeLayout(false);
            this.grp_Comb.PerformLayout();
            this.grp_Quick.ResumeLayout(false);
            this.grp_Quick.PerformLayout();
            this.grp_Selection.ResumeLayout(false);
            this.grp_Selection.PerformLayout();
            this.grp_Heap.ResumeLayout(false);
            this.grp_Heap.PerformLayout();
            this.groupBox_2Merge.ResumeLayout(false);
            this.groupBox_2Merge.PerformLayout();
            this.grp_Radix.ResumeLayout(false);
            this.grp_Radix.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox_manual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputBox_max;
        private System.Windows.Forms.TextBox inputBox_min;
        private System.Windows.Forms.TextBox textBox_inputBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.GroupBox grp_Insertion;
        private System.Windows.Forms.GroupBox grp_Shell;
        private System.Windows.Forms.GroupBox grp_Bubble;
        private System.Windows.Forms.GroupBox grp_Comb;
        private System.Windows.Forms.GroupBox grp_Quick;
        private System.Windows.Forms.GroupBox grp_Selection;
        private System.Windows.Forms.GroupBox grp_Heap;
        private System.Windows.Forms.TextBox textBox_Insertion;
        private System.Windows.Forms.CheckBox checkBox_Insertion;
        private System.Windows.Forms.TextBox textBox_Shell;
        private System.Windows.Forms.CheckBox checkBox_Shell;
        private System.Windows.Forms.TextBox textBox_Bubble;
        private System.Windows.Forms.CheckBox checkBox_Bubble;
        private System.Windows.Forms.TextBox textBox_Comb;
        private System.Windows.Forms.CheckBox checkBox_Comb;
        private System.Windows.Forms.TextBox textBox_Quick;
        private System.Windows.Forms.CheckBox checkBox_Quick;
        private System.Windows.Forms.TextBox textBox_Selection;
        private System.Windows.Forms.CheckBox checkBox_Selection;
        private System.Windows.Forms.TextBox textBox_Heap;
        private System.Windows.Forms.CheckBox checkBox_Heap;
        private System.Windows.Forms.GroupBox groupBox_2Merge;
        private System.Windows.Forms.TextBox textBox_2Merge;
        private System.Windows.Forms.CheckBox checkBox_2Merge;
        private System.Windows.Forms.GroupBox grp_Radix;
        private System.Windows.Forms.TextBox textBox_Radix;
        private System.Windows.Forms.CheckBox checkBox_Radix;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox textBox_TimeComplex;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton descend;
        private System.Windows.Forms.RadioButton ascend;
    }
}

