using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace csgo_simple_glow
{
    public partial class Form1 : Form
    {
        public static int bClient;
        public static int bEngine;
        public static IntPtr csgoHandle;
        public static Process csgoProcess;
        public static uint PROCESS_ALL_ACCESS = 0x1f0fff;
        private static Thread thread_glow = new Thread(new ThreadStart(Glow.Glow2));
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr OpenProcess(uint dwDesiredAcess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, ref int lpNumberOfBytesRead);
        public Form1()
        {
            InitializeComponent();
            Run();
        }
        private void Run()
        {
            IEnumerator enumerator;
            try
            {
                csgoProcess = Process.GetProcessesByName("csgo")[0];
                csgoHandle = OpenProcess(PROCESS_ALL_ACCESS, false, csgoProcess.Id);
            }
            catch (Exception)
            {
                MessageBox.Show("Open Counter-Strike: Global Offensive");
            }
            enumerator = csgoProcess.Modules.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ProcessModule current = (ProcessModule)enumerator.Current;
                if (current.ModuleName == "engine.dll")
                {
                    bEngine = (int)current.BaseAddress;
                }
                if (current.ModuleName == "client.dll")
                {
                    bClient = (int)current.BaseAddress;
                }
            }
            thread_glow.Start();
        }
        private void chkTeamGlow_CheckedChanged(object sender, EventArgs e)
        {
            Config.glowteamenabled = chkTeamGlow.Checked;
        }
        private void chkEnemyGlow_CheckedChanged(object sender, EventArgs e)
        {
            Config.glowenemyenabled = chkEnemyGlow.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
