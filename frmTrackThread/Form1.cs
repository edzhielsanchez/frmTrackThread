using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart Start1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart Start2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(Start1);
            ThreadA.Name = "Thread A process ";
            Thread ThreadB = new Thread(Start2);
            ThreadB.Name = "Thread B Process ";
            Thread ThreadC = new Thread(Start1);
            ThreadC.Name = "Thread C process ";
            Thread ThreadD = new Thread(Start2);
            ThreadD.Name = "Thread D process ";

            Console.WriteLine(label1.Text.ToString());

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();
            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            label1.Text = "- End of Thread -";
            Console.WriteLine(label1.Text.ToString());
        } 
    }
}
