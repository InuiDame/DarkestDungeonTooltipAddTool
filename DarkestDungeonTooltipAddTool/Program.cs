// Program.cs
using System;
using System.Windows.Forms;
using DarkestDungeonTooltipAddTool;

namespace BuffTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}