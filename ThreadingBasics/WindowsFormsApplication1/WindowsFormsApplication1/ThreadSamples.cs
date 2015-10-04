using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ThreadSamples : Form
    {
        public ThreadSamples()
        {
            InitializeComponent();
        }

        //Common Collection: Shared between Threads
        List<string> lstStrings = null;
        long Counter;

        //Every Thread a Separate Copy of the collection. This is done by using ThreadStaticAttribute on a static field.
        [ThreadStatic]
        static List<string> lstThreadSpecificStrings = null;


        private void btnStartThread_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Thread th = new Thread(new ParameterizedThreadStart(PerformAction));
            th.Start(r);
        }

        private void btnBreakExecution_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debugger.Break();

            //Now Think, why lstThreadSpecificStrings = null for the UI Thread?

            // Add breakpoint on switch statement in PerformAction method. In this case, lstThreadSpecificStrings 
            // should have data for one thread only. 
        }

        public void PerformAction(object state)
        {
            if (lstStrings == null)
            {
                lstStrings = new List<string>();
            }

            if (lstThreadSpecificStrings == null)
            {
                lstThreadSpecificStrings = new List<string>();
            }
            Random r = state as Random;
            string message = null;
            if (r != null)
            {
                for (int i = 0; i < 10000; i++)
                {
                    switch (r.Next(1, 15))
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            message = Addition(r.Next(1000), r.Next(1000));
                            break;

                        case 5:
                        case 6:
                        case 7:
                            message = Substraction(r.Next(1000), r.Next(1000));
                            break;

                        case 8:
                        case 9:
                        case 10:
                            message = Multiply(r.Next(1000), r.Next(1000));
                            break;
                        default:
                            //Sleep(0) will Request the OS to Allocate the remaining time slice to some other thread.
                            Thread.Sleep(0);
                            break;
                    }
                    if (message != null)
                    {
                        Interlocked.Increment(ref Counter);
                        lstStrings.Add(message);
                        lstThreadSpecificStrings.Add(message);
                        message = null;
                        Thread.Sleep(500);
                    }
                }
            }
        }

        private string Addition(int v1, int v2)
        {
            return string.Format("Thread {3} {4}:\t{0} + {1} = {2}", v1, v2, v1 + v2, Thread.CurrentThread.ManagedThreadId, DateTime.Now.Ticks);
        }

        private string Substraction(int v1, int v2)
        {
            return string.Format("Thread {3} {4}:\t{0} - {1} = {2}", v1, v2, v1 - v2, Thread.CurrentThread.ManagedThreadId, DateTime.Now.Ticks);
        }

        private string Multiply(int v1, int v2)
        {
            return string.Format("Thread {3} {4}:\t{0} * {1} = {2}", v1, v2, v1 * v2, Thread.CurrentThread.ManagedThreadId, DateTime.Now.Ticks);
        }
    }
}
