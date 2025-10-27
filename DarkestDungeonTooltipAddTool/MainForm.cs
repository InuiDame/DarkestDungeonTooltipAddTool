using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Globalization;

namespace DarkestDungeonTooltipAddTool
{
    public partial class MainForm : Form
    {
        // **** Modified: use dictionary to map display color names to codes
        private Dictionary<string, string> colorMap = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
            InitLanguage();                 // **** Modified: auto-detect system language
            lblRuleDataString.Enabled = false;
            txtRuleDataString.Enabled = false;
        }
        // **** Modified: enhanced language initialization
        private void InitLanguage()
        {
            var culture = CultureInfo.CurrentUICulture;
            string defaultLang;
            if (culture.Name.StartsWith("zh"))            // Simplified or Traditional Chinese
                defaultLang = "schinese";
            else if (culture.Name.StartsWith("ja"))       // Japanese
                defaultLang = "japanese";
            else                                            // All others default to English
                defaultLang = "english";

            cboLanguage.SelectedItem = defaultLang;
            BtnApplyLanguage_Click(this, EventArgs.Empty);
        }

        private void BtnDevPage_Click(object sender, EventArgs e)
        {
            // **** Modified: open developer page URL
            var devForm = new DeveloperPageForm();
            devForm.ShowDialog();
        }

        private void BtnApplyLanguage_Click(object sender, EventArgs e)
        {
            // **** Modified: change UI text based on selected language
            var lang = cboLanguage.SelectedItem?.ToString() ?? "schinese";
            switch (lang)
            {
                case "schinese":
                    lblBuffName.Text = "自定义文本ID：";
                    lblDescription.Text = "自定义文本：";
                    lblColorCode.Text = "颜色 代码：";
                    lblColors.Text = "颜色：";
                    lblLanguage.Text = "本地化使用语言：";
                    btnSelectBuffFile.Text = "选择Buff文件";
                    btnSelectEffectsFile.Text = "选择effects文件";
                    btnSelectLocFile.Text = "选择本地化XML文件";
                    btnSelectMapFile.Text = "选择颜色代码文件";
                    btnGenerate.Text = "生成";
                    btnDevPage.Text = "开发者页面";
                    btnApplyLanguage.Text = "切换语言";
                    lblRuleType.Text = "rule 类型："; // Example additional translation
                    lblRuleDataString.Text = "rule_data_string：";
                    lblStatType.Text = "选择自定义文本类型：";
                    lblStatTypeTip.Text = "推荐使用 upgrade_discount；需叠加文本请选 quirk_tag_evolution_duration";
                    lblAmount.Text = "Amount：";
                    break;
                case "english":
                    lblBuffName.Text = "Tooltip Buff Name:";
                    lblDescription.Text = "Description:";
                    lblColorCode.Text = "Color Code:";
                    lblColors.Text = "Map Colors:";
                    lblLanguage.Text = "Localization ID:";
                    btnSelectBuffFile.Text = "Select Buff JSON";
                    btnSelectEffectsFile.Text = "Select Effects File";
                    btnSelectLocFile.Text = "Select Loc XML";
                    btnSelectMapFile.Text = "Select Map TXT";
                    btnGenerate.Text = "Generate";
                    btnDevPage.Text = "Dev Page";
                    btnApplyLanguage.Text = "Swtich Lang";
                    lblRuleType.Text = "Rule type："; // Example additional translation
                    lblRuleDataString.Text = "Rule_data_string：";
                    lblStatType.Text = "Custom Text Type:";
                    lblStatTypeTip.Text = "Recommended: upgrade_discount; use quirk_tag_evolution_duration when stacking";
                    lblAmount.Text = "Amount：";
                    break;
                case "japanese":
                    lblBuffName.Text = "バフ名：";
                    lblDescription.Text = "説明：";
                    lblColorCode.Text = "カラーコード：";
                    lblColors.Text = "マップカラー：";
                    lblLanguage.Text = "ローカライズ ID：";
                    btnSelectBuffFile.Text = "Buff JSON を選択";
                    btnSelectEffectsFile.Text = "エフェクト ファイルを選択";
                    btnSelectLocFile.Text = "ロケール XML を選択";
                    btnSelectMapFile.Text = "マップ TXT を選択";
                    btnGenerate.Text = "生成";
                    btnDevPage.Text = "開発ページ";
                    btnApplyLanguage.Text = "言語適用";
                    lblRuleType.Text = "ルールタイプ：";
                    lblRuleDataString.Text = "ルールデータ (文字列)：";
                    lblStatType.Text = "カスタムテキストタイプ：";
                    lblStatTypeTip.Text = "推奨：upgrade_discount、重ねる場合は quirk_tag_evolution_duration を使用";
                    lblAmount.Text = "Amount：";
                    break;
            }
        }

        private void BtnSelectBuffFile_Click(object sender, EventArgs e)
        {
            OpenFile(txtBuffFile, "暗黑地牢buff文件|*.json");
        }

        private void BtnSelectEffectsFile_Click(object sender, EventArgs e)
        {
            OpenFile(txtEffectsFile, "暗黑地牢effects文件|*.darkest");
        }

        private void BtnSelectLocFile_Click(object sender, EventArgs e)
        {
            OpenFile(txtLocFile, "暗黑地牢本地化语言文件|*.xml");
        }

        // **** Modified: toggle rule data input enable
        private void CboRuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSkill = cboRuleType.SelectedItem?.ToString() == "skill";
            lblRuleDataString.Enabled = isSkill;
            txtRuleDataString.Enabled = isSkill;
        }

        private void BtnSelectMapFile_Click(object sender, EventArgs e)
        {
            if (OpenFile(txtMapFile, "打开文件根目录下的常用颜色|*.txt"))
                LoadColors(txtMapFile.Text);
        }

        private bool OpenFile(TextBox target, string filter)
        {
            using (var dlg = new OpenFileDialog { Filter = filter })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    target.Text = dlg.FileName;
                    return true;
                }
            }
            return false;
        }

        private void LoadColors(string path)
        {
            lstColors.Items.Clear();
            colorMap.Clear();
            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                var parts = line.Split('=');
                if (parts.Length == 2)
                {
                    var name = parts[0].Trim();
                    var code = parts[1].Trim();
                    colorMap[name] = code;
                    lstColors.Items.Add(name);
                }
            }
        }

        // Existing: fill code on selection
        private void LstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstColors.SelectedItem != null && colorMap.TryGetValue(lstColors.SelectedItem.ToString(), out var code))
                txtColorCode.Text = code;
        }

        // **** Modified: on double-click, insert tag into description
        private void LstColors_DoubleClick(object sender, EventArgs e)
        {
            InsertColorTag();
        }

        // **** Modified: use mouse wheel to change selection
        private void LstColors_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && lstColors.SelectedIndex > 0)
                lstColors.SelectedIndex--;
            else if (e.Delta < 0 && lstColors.SelectedIndex < lstColors.Items.Count - 1)
                lstColors.SelectedIndex++;
        }

        // **** Modified: Enter in ColorCode box inserts tag
        private void TxtColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertColorTag();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // **** Modified: helper to insert tag at caret
        private void InsertColorTag()
        {
            var code = txtColorCode.Text.Trim();
            if (string.IsNullOrEmpty(code)) return;
            var tag = $"{{colour_start|{code}}}{{colour_end}}";
            var pos = txtDescription.SelectionStart;
            txtDescription.Text = txtDescription.Text.Insert(pos, tag);
            txtDescription.SelectionStart = pos + tag.Length;
            txtDescription.Focus();
        }


        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var buffFile = txtBuffFile.Text;
            var effectsFile = txtEffectsFile.Text;
            var locFile = txtLocFile.Text;
            var buffName = txtBuffName.Text.Trim();
            var desc = txtDescription.Text.Trim();
            var color = txtColorCode.Text.Trim();
            var statType = cboStatType.SelectedItem.ToString();
            var ruleType = cboRuleType.SelectedItem?.ToString() ?? "always";
            var ruleString = txtRuleDataString.Enabled ? txtRuleDataString.Text : string.Empty;
            int amount = (statType == "upgrade_discount") ? 1 : (int)nudAmount.Value;

            try
            {
                // 备份文件
                BackupFile(buffFile);
                BackupFile(effectsFile);
                BackupFile(locFile);

                // ===== 更新 buffs.json =====
                var root = JObject.Parse(File.ReadAllText(buffFile));
                var array = (JArray)root["buffs"];
                var newObj = new JObject
                {
                    ["id"] = buffName,
                    ["stat_type"] = statType,
                    ["stat_sub_type"] = buffName,
                    ["amount"] = amount,
                    ["remove_if_not_active"] = false,
                    ["rule_type"] = ruleType,
                    ["is_false_rule"] = false,
                    ["rule_data"] = new JObject
                    {
                        ["float"] = 0,
                        ["string"] = ruleString
                    }
                };
                array.Add(newObj);
                File.WriteAllText(buffFile, root.ToString(Newtonsoft.Json.Formatting.Indented));

                // ===== 更新 effects 文件 =====
                var effectLine = $"effect: .name \"{buffName}\" .target \"performer\" .skill_instant true .buff_ids \"{buffName}\" .on_hit true .on_miss true";
                File.AppendAllText(effectsFile, Environment.NewLine + effectLine + Environment.NewLine);

                // ===== 格式化描述文字 =====
                var formattedDesc = Regex.Replace(desc, @"\[(\w+):(.+?)\]", m =>
                    $"{{colour_start|{m.Groups[1].Value}}}{m.Groups[2].Value}{{colour_end}}"
                );

                // ===== 更新本地化 XML =====
                // 1. 读取所有行，保留空行和 XML 声明
                var xmlLines = File.ReadAllLines(locFile).ToList();

                // 2. 简单校验：确认至少有 <language id="langId"
                var langId = cboLanguage.SelectedItem?.ToString() ?? "schinese";
                if (!xmlLines.Any(l => l.Contains($"<language id=\"{langId}\"")))
                    throw new InvalidDataException("不是有效的本地化 XML 文件，找不到对应的 <language> 节点。");

                // 3. 构造要插入的新 entry（与项目中其它 entry 保持相同缩进，此处示例用 4 个空格）
                string newEntryLine =
                    $"    <entry id=\"buff_stat_tooltip_{statType}_{buffName}\"><![CDATA[{formattedDesc}]]></entry>";

                // 4. 找到最后一个 </language> 的索引
                int insertIdx = xmlLines.FindLastIndex(l => l.Trim().Equals("</language>"));
                if (insertIdx < 0)
                    throw new InvalidDataException("在本地化 XML 中未找到 </language> 结束标签。");

                // 5. 在 </language> 之前插入新行
                xmlLines.Insert(insertIdx, newEntryLine);

                // 6. 写回文件，保留所有原有空行和声明
                File.WriteAllLines(locFile, xmlLines);

                MessageBox.Show("生成完成！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupFile(string path)
        {
            var bak = path + ".bak";
            if (!File.Exists(bak))
                File.Copy(path, bak);
        }

        private void lblStatTypeTip_Click(object sender, EventArgs e)
        {

        }
    }
}
