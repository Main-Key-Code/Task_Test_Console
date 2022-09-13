using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Test_Console
{
    public partial class Form1 : Form
    {

        public class Win32
        {
            [DllImport("kernel32.dll")]
            public static extern Boolean AllocConsole();

            [DllImport("kernel32.dll")]
            public static extern Boolean FreeConsole();
        }

        public Form1()
        {
            InitializeComponent();

#if DEBUG
            Win32.AllocConsole();
#else
            Win32.FreeConsole();
#endif
        }

        private bool isTimeTask = true;

        private void btn_TimeRun_Click(object sender, EventArgs e)
        {
            var TimeTask = Task.Run(() =>
            {
                while (isTimeTask)
                {
                    txtBox_TimeTask.Invoke(new Action(() =>
                    {
                        txtBox_TimeTask.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ff")}");
                        txtBox_TimeTask.AppendText(Environment.NewLine);
                        txtBox_TimeTask.ScrollToCaret();
                    }));

                    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ff")}");

                    Task.Delay(1000).Wait();
                }
            });
        }

        private void btn_TaskStart_Click(object sender, EventArgs e)
        {
            if (!isTimeTask)
            {
                isTimeTask = true;
                btn_TimeRun_Click(this, null);
            }
        }

        private void btn_TaskStop_Click(object sender, EventArgs e)
        {
            if (isTimeTask)
            {
                isTimeTask = false;
            }
        }

        private bool isNumberTask = true;

        private void btn_NumberRun_Click(object sender, EventArgs e)
        {
            var NumberTask = Task.Run(() =>
            {
                int nCount = 1;

                while (isNumberTask)
                {
                    txtBox_NumberTask.Invoke(new Action(() =>
                    {
                        txtBox_NumberTask.AppendText($"{nCount}");
                        txtBox_NumberTask.AppendText(Environment.NewLine);
                        txtBox_NumberTask.ScrollToCaret();
                    }));

                    Console.WriteLine($"{nCount}");

                    nCount++;

                    Task.Delay(10).Wait();
                }
            });
        }

        private void btn_NumberStart_Click(object sender, EventArgs e)
        {
            if (!isNumberTask)
            {
                isNumberTask = true;
                btn_NumberRun_Click(this, null);
            }
        }

        private void btn_NumberStop_Click(object sender, EventArgs e)
        {
            if (isNumberTask)
            {
                isNumberTask = false;
            }
        }

        private bool isRandomTask = true;

        private void btn_RandomRun_Click(object sender, EventArgs e)
        {
            var RandomTask = Task.Run(() =>
            {
                while (isRandomTask)
                {
                    Random ran = new Random(DateTime.Now.Millisecond + DateTime.Now.Minute + DateTime.Now.Hour);

                    var vRandom = ran.Next(100);

                    txtBox_RandomTask.Invoke(new Action(() => {
                        txtBox_RandomTask.AppendText($"{vRandom}");
                        txtBox_RandomTask.AppendText(Environment.NewLine);
                        txtBox_RandomTask.ScrollToCaret();
                    }));

                    Console.WriteLine($"{vRandom}");

                    Task.Delay(10).Wait();
                }
            });
        }

        private void btn_RandomStart_Click(object sender, EventArgs e)
        {
            if (!isRandomTask)
            {
                isRandomTask = true;
                btn_RandomRun_Click(this, null);
            }
        }

        private void btn_RandomStop_Click(object sender, EventArgs e)
        {
            if (isRandomTask)
            {
                isRandomTask = false;
            }
        }
    }
}
