using System;

namespace DarkestDungeonTooltipAddTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBuffName;
        private System.Windows.Forms.TextBox txtBuffName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Button btnSelectBuffFile;
        private System.Windows.Forms.TextBox txtBuffFile;
        private System.Windows.Forms.Button btnSelectEffectsFile;
        private System.Windows.Forms.TextBox txtEffectsFile;
        private System.Windows.Forms.Button btnSelectLocFile;
        private System.Windows.Forms.TextBox txtLocFile;
        private System.Windows.Forms.Button btnSelectMapFile;
        private System.Windows.Forms.TextBox txtMapFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblLanguage; // **** Modified: label for language selection
        private System.Windows.Forms.ComboBox cboLanguage; // **** Modified: combo box for language selection
        private System.Windows.Forms.Button btnDevPage;              // **** Modified: Developer Page button
        private System.Windows.Forms.Button btnApplyLanguage;      // **** Modified: Apply Language button
        private System.Windows.Forms.Label lblRuleType;                   // **** Modified
        private System.Windows.Forms.ComboBox cboRuleType;               // **** Modified
        private System.Windows.Forms.Label lblRuleDataString;           // **** Modified
        private System.Windows.Forms.TextBox txtRuleDataString;         // **** Modified
        private System.Windows.Forms.Label lblStatType;             // **** Modified: custom text type label
        private System.Windows.Forms.ComboBox cboStatType;         // **** Modified: stat_type selector
        private System.Windows.Forms.Label lblStatTypeTip;        // **** Modified: tip label
        private System.Windows.Forms.Label lblAmount;                   // **** Modified: Amount label
        private System.Windows.Forms.NumericUpDown nudAmount;         // **** Modified: Amount input

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblBuffName = new System.Windows.Forms.Label();
            this.txtBuffName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.lblColors = new System.Windows.Forms.Label();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.btnSelectBuffFile = new System.Windows.Forms.Button();
            this.txtBuffFile = new System.Windows.Forms.TextBox();
            this.btnSelectEffectsFile = new System.Windows.Forms.Button();
            this.txtEffectsFile = new System.Windows.Forms.TextBox();
            this.btnSelectLocFile = new System.Windows.Forms.Button();
            this.txtLocFile = new System.Windows.Forms.TextBox();
            this.btnSelectMapFile = new System.Windows.Forms.Button();
            this.txtMapFile = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.btnDevPage = new System.Windows.Forms.Button();
            this.btnApplyLanguage = new System.Windows.Forms.Button();
            this.lblRuleType = new System.Windows.Forms.Label();
            this.cboRuleType = new System.Windows.Forms.ComboBox();
            this.lblRuleDataString = new System.Windows.Forms.Label();
            this.txtRuleDataString = new System.Windows.Forms.TextBox();
            this.lblStatType = new System.Windows.Forms.Label();
            this.cboStatType = new System.Windows.Forms.ComboBox();
            this.lblStatTypeTip = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuffName
            // 
            this.lblBuffName.AutoSize = true;
            this.lblBuffName.BackColor = System.Drawing.Color.LightGray;
            this.lblBuffName.Location = new System.Drawing.Point(10, 16);
            this.lblBuffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuffName.Name = "lblBuffName";
            this.lblBuffName.Size = new System.Drawing.Size(93, 17);
            this.lblBuffName.TabIndex = 0;
            this.lblBuffName.Text = "自定义文本ID：";
            // 
            // txtBuffName
            // 
            this.txtBuffName.Location = new System.Drawing.Point(147, 11);
            this.txtBuffName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuffName.Name = "txtBuffName";
            this.txtBuffName.Size = new System.Drawing.Size(263, 23);
            this.txtBuffName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(13, 51);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "自定义文本：";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(147, 47);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 85);
            this.txtDescription.TabIndex = 3;
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.BackColor = System.Drawing.Color.LightGray;
            this.lblColorCode.Location = new System.Drawing.Point(59, 147);
            this.lblColorCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(59, 17);
            this.lblColorCode.TabIndex = 4;
            this.lblColorCode.Text = "颜色代码:";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(147, 143);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(132, 23);
            this.txtColorCode.TabIndex = 5;
            this.txtColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtColorCode_KeyDown);
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.BackColor = System.Drawing.Color.LightGray;
            this.lblColors.Location = new System.Drawing.Point(287, 147);
            this.lblColors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(83, 17);
            this.lblColors.TabIndex = 6;
            this.lblColors.Text = "可用颜色代码:";
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 17;
            this.lstColors.Location = new System.Drawing.Point(287, 169);
            this.lstColors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(123, 106);
            this.lstColors.TabIndex = 7;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.LstColors_SelectedIndexChanged);
            this.lstColors.DoubleClick += new System.EventHandler(this.LstColors_DoubleClick);
            this.lstColors.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.LstColors_MouseWheel);
            // 
            // btnSelectBuffFile
            // 
            this.btnSelectBuffFile.Location = new System.Drawing.Point(10, 282);
            this.btnSelectBuffFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelectBuffFile.Name = "btnSelectBuffFile";
            this.btnSelectBuffFile.Size = new System.Drawing.Size(105, 51);
            this.btnSelectBuffFile.TabIndex = 8;
            this.btnSelectBuffFile.Text = "选择buff文件";
            this.btnSelectBuffFile.UseVisualStyleBackColor = true;
            this.btnSelectBuffFile.Click += new System.EventHandler(this.BtnSelectBuffFile_Click);
            // 
            // txtBuffFile
            // 
            this.txtBuffFile.Location = new System.Drawing.Point(122, 295);
            this.txtBuffFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuffFile.Name = "txtBuffFile";
            this.txtBuffFile.ReadOnly = true;
            this.txtBuffFile.Size = new System.Drawing.Size(263, 23);
            this.txtBuffFile.TabIndex = 9;
            // 
            // btnSelectEffectsFile
            // 
            this.btnSelectEffectsFile.Location = new System.Drawing.Point(10, 339);
            this.btnSelectEffectsFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelectEffectsFile.Name = "btnSelectEffectsFile";
            this.btnSelectEffectsFile.Size = new System.Drawing.Size(105, 47);
            this.btnSelectEffectsFile.TabIndex = 10;
            this.btnSelectEffectsFile.Text = "选择effect文件";
            this.btnSelectEffectsFile.UseVisualStyleBackColor = true;
            this.btnSelectEffectsFile.Click += new System.EventHandler(this.BtnSelectEffectsFile_Click);
            // 
            // txtEffectsFile
            // 
            this.txtEffectsFile.Location = new System.Drawing.Point(122, 348);
            this.txtEffectsFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEffectsFile.Name = "txtEffectsFile";
            this.txtEffectsFile.ReadOnly = true;
            this.txtEffectsFile.Size = new System.Drawing.Size(263, 23);
            this.txtEffectsFile.TabIndex = 11;
            // 
            // btnSelectLocFile
            // 
            this.btnSelectLocFile.Location = new System.Drawing.Point(10, 434);
            this.btnSelectLocFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelectLocFile.Name = "btnSelectLocFile";
            this.btnSelectLocFile.Size = new System.Drawing.Size(105, 58);
            this.btnSelectLocFile.TabIndex = 12;
            this.btnSelectLocFile.Text = "选择xml文件";
            this.btnSelectLocFile.UseVisualStyleBackColor = true;
            this.btnSelectLocFile.Click += new System.EventHandler(this.BtnSelectLocFile_Click);
            // 
            // txtLocFile
            // 
            this.txtLocFile.Location = new System.Drawing.Point(122, 442);
            this.txtLocFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLocFile.Name = "txtLocFile";
            this.txtLocFile.ReadOnly = true;
            this.txtLocFile.Size = new System.Drawing.Size(263, 23);
            this.txtLocFile.TabIndex = 13;
            // 
            // btnSelectMapFile
            // 
            this.btnSelectMapFile.Location = new System.Drawing.Point(10, 497);
            this.btnSelectMapFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelectMapFile.Name = "btnSelectMapFile";
            this.btnSelectMapFile.Size = new System.Drawing.Size(105, 45);
            this.btnSelectMapFile.TabIndex = 14;
            this.btnSelectMapFile.Text = "选择颜色代码文件";
            this.btnSelectMapFile.UseVisualStyleBackColor = true;
            this.btnSelectMapFile.Click += new System.EventHandler(this.BtnSelectMapFile_Click);
            // 
            // txtMapFile
            // 
            this.txtMapFile.Location = new System.Drawing.Point(122, 507);
            this.txtMapFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMapFile.Name = "txtMapFile";
            this.txtMapFile.ReadOnly = true;
            this.txtMapFile.Size = new System.Drawing.Size(263, 23);
            this.txtMapFile.TabIndex = 15;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(296, 564);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 31);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.LightGray;
            this.lblLanguage.Location = new System.Drawing.Point(10, 401);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(104, 17);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "本地化使用语言：";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "schinese",
            "tchinese",
            "english",
            "japanese",
            "french",
            "german",
            "spanish",
            "brazilian",
            "russian",
            "polish",
            "czech",
            "italian",
            "koreanb"});
            this.cboLanguage.Location = new System.Drawing.Point(135, 397);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(174, 25);
            this.cboLanguage.TabIndex = 9;
            // 
            // btnDevPage
            // 
            this.btnDevPage.Location = new System.Drawing.Point(122, 558);
            this.btnDevPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevPage.Name = "btnDevPage";
            this.btnDevPage.Size = new System.Drawing.Size(117, 42);
            this.btnDevPage.TabIndex = 1;
            this.btnDevPage.Text = "开发者页面";
            this.btnDevPage.UseVisualStyleBackColor = true;
            this.btnDevPage.Click += new System.EventHandler(this.BtnDevPage_Click);
            // 
            // btnApplyLanguage
            // 
            this.btnApplyLanguage.Location = new System.Drawing.Point(5, 564);
            this.btnApplyLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyLanguage.Name = "btnApplyLanguage";
            this.btnApplyLanguage.Size = new System.Drawing.Size(117, 37);
            this.btnApplyLanguage.TabIndex = 10;
            this.btnApplyLanguage.Text = "Switch Lang";
            this.btnApplyLanguage.UseVisualStyleBackColor = true;
            this.btnApplyLanguage.Click += new System.EventHandler(this.BtnApplyLanguage_Click);
            // 
            // lblRuleType
            // 
            this.lblRuleType.AutoSize = true;
            this.lblRuleType.BackColor = System.Drawing.Color.LightGray;
            this.lblRuleType.Location = new System.Drawing.Point(435, 14);
            this.lblRuleType.Name = "lblRuleType";
            this.lblRuleType.Size = new System.Drawing.Size(68, 17);
            this.lblRuleType.TabIndex = 12;
            this.lblRuleType.Text = "Rule Type:";
            // 
            // cboRuleType
            // 
            this.cboRuleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuleType.FormattingEnabled = true;
            this.cboRuleType.Items.AddRange(new object[] {
            "always",
            "skill"});
            this.cboRuleType.Location = new System.Drawing.Point(509, 10);
            this.cboRuleType.Name = "cboRuleType";
            this.cboRuleType.Size = new System.Drawing.Size(150, 25);
            this.cboRuleType.TabIndex = 13;
            this.cboRuleType.SelectedIndexChanged += new System.EventHandler(this.CboRuleType_SelectedIndexChanged);
            // 
            // lblRuleDataString
            // 
            this.lblRuleDataString.AutoSize = true;
            this.lblRuleDataString.BackColor = System.Drawing.Color.LightGray;
            this.lblRuleDataString.Enabled = false;
            this.lblRuleDataString.Location = new System.Drawing.Point(435, 50);
            this.lblRuleDataString.Name = "lblRuleDataString";
            this.lblRuleDataString.Size = new System.Drawing.Size(112, 17);
            this.lblRuleDataString.TabIndex = 14;
            this.lblRuleDataString.Text = "Rule Data (string):";
            // 
            // txtRuleDataString
            // 
            this.txtRuleDataString.Enabled = false;
            this.txtRuleDataString.Location = new System.Drawing.Point(553, 44);
            this.txtRuleDataString.Name = "txtRuleDataString";
            this.txtRuleDataString.Size = new System.Drawing.Size(290, 23);
            this.txtRuleDataString.TabIndex = 15;
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.BackColor = System.Drawing.Color.LightGray;
            this.lblStatType.Location = new System.Drawing.Point(435, 80);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Size = new System.Drawing.Size(128, 17);
            this.lblStatType.TabIndex = 5;
            this.lblStatType.Text = "选择自定义文本类型：";
            // 
            // cboStatType
            // 
            this.cboStatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatType.FormattingEnabled = true;
            this.cboStatType.Items.AddRange(new object[] {
            "upgrade_discount",
            "quirk_tag_evolution_duration"});
            this.cboStatType.Location = new System.Drawing.Point(579, 72);
            this.cboStatType.Name = "cboStatType";
            this.cboStatType.Size = new System.Drawing.Size(190, 25);
            this.cboStatType.TabIndex = 6;
            // 
            // lblStatTypeTip
            // 
            this.lblStatTypeTip.AutoSize = true;
            this.lblStatTypeTip.BackColor = System.Drawing.Color.Transparent;
            this.lblStatTypeTip.Location = new System.Drawing.Point(435, 100);
            this.lblStatTypeTip.Name = "lblStatTypeTip";
            this.lblStatTypeTip.Size = new System.Drawing.Size(430, 17);
            this.lblStatTypeTip.TabIndex = 7;
            this.lblStatTypeTip.Text = "推荐使用 upgrade_discount；需叠加文本请选 quirk_tag_evolution_duration";
            this.lblStatTypeTip.Click += new System.EventHandler(this.lblStatTypeTip_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(435, 126);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount:";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(497, 124);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            -1000,
            0,
            0,
            -2147483648});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(60, 23);
            this.nudAmount.TabIndex = 18;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 611);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMapFile);
            this.Controls.Add(this.btnSelectMapFile);
            this.Controls.Add(this.txtLocFile);
            this.Controls.Add(this.btnSelectLocFile);
            this.Controls.Add(this.txtEffectsFile);
            this.Controls.Add(this.btnSelectEffectsFile);
            this.Controls.Add(this.txtBuffFile);
            this.Controls.Add(this.btnSelectBuffFile);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.lblColorCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBuffName);
            this.Controls.Add(this.lblBuffName);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txtRuleDataString);
            this.Controls.Add(this.lblRuleDataString);
            this.Controls.Add(this.cboRuleType);
            this.Controls.Add(this.lblRuleType);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.cboStatType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblStatTypeTip);
            this.Controls.Add(this.btnDevPage);
            this.Controls.Add(this.btnApplyLanguage);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Tooltip快速录入工具";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

