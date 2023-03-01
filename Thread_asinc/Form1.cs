using static System.Formats.Asn1.AsnWriter;

namespace Thread_asinc
{
    public partial class Form1 : Form
    {
        public Thread Prime_Thread { get; set;}
        public Thread Fibonacci_Thread { get; set;}

        private bool Prime_Paused;
        private bool Fibonacci_Pause;
        public bool PrimePaused
        {
            get { return Prime_Paused; }
            set {
                Prime_Paused = value;
                if (!value)
                    Prime_pause_button.Text = "Pause";
                else
                    Prime_pause_button.Text = "Resume";
            }
        }
        
        // Поток не остоновится пока не закончит свое дело даже если закрыть окно
        
        /*
          warning SYSLIB0006: "Thread.Abort()" ÿâëÿåòñÿ óñòàðåâøèì: 
        'Thread.Abort is not supported and throws PlatformNotSupportedException.'
1>C:\Users\Dato\source\repos\Thread_asinc\Thread_asinc\Form1.cs(153,17,153,39):
        warning CS0618: "Thread.Suspend()" ÿâëÿåòñÿ óñòàðåâøèì: 
        'Thread.Suspend has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.'
1>C:\Users\Dato\source\repos\Thread_asinc\Thread_asinc\Form1.cs(158,17,158,38): warning CS0618: "Thread.Resume()" ÿâëÿåòñÿ óñòàðåâøèì: 
        'Thread.Resume has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.'
         
         */
        public bool FibonacciPause
        {
            get { return Fibonacci_Pause; }
            set {
                Fibonacci_Pause = value;
                if (!value)
                    Fibonacci_pause_button.Text = "Pause";
                else
                    Fibonacci_pause_button.Text = "Resume";
            }
        }

        public Form1()
        {
            InitializeComponent();
            Prime_Thread = new Thread(view_prime);
            Fibonacci_Thread = new(view_Fibonacci);
            PrimePaused = false;
        }

        public bool Is_Prime(int num)
        {
            if (num == 0 || num == 1)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public void view_prime()
        {
            if (Prime_start_numericUpDown.Value < Prime_end_numericUpDown.Value)
            {
                for (int i = (int)Prime_start_numericUpDown.Value; i < (int)Prime_end_numericUpDown.Value; i++)
                {
                    if (Is_Prime(i))
                        Prime_listBox.Items.Add(i);
                }
            }
            else
            {
                for (int i = (int)Prime_start_numericUpDown.Value; true; i++)
                {
                    if (Is_Prime(i))
                        Prime_listBox.Items.Add(i);
                }
            }
        }

        

        public int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            int fst = 0;
            int scnd = 1;

            for (int i = 2; i <= num; i++)
            {
                int next = fst + scnd;
                fst = scnd;
                scnd = next;
            }

            return scnd;
        }
        public void view_Fibonacci()
        {
            Fibonacci_listBox.Items.Clear();
            if (Fibonacci_end_numericUpDown.Value != 0)
            {
                for (int i = 0; i < Fibonacci_end_numericUpDown.Value; i++)
                {
                    Fibonacci_listBox.Items.Add(Fibonacci(i));
                }
            }
            else
            {
                for (int i = 0; true; i++)
                {
                    Fibonacci_listBox.Items.Add(Fibonacci(i));
                }
            }
        }
        private void Prime_button_Click(object sender, EventArgs e)
        {
            Prime_listBox.Items.Clear();
            PrimePaused = false;
            if (!Prime_Thread.IsAlive)
                Prime_Thread.Start();
        }
        private void Fibonacci_view_button_Click(object sender, EventArgs e)
        {
            Fibonacci_listBox.Items.Clear();
            FibonacciPause = false;
            if (!Fibonacci_Thread.IsAlive)
                Fibonacci_Thread.Start();
        }
        private void Stop_Prime_Click(object sender, EventArgs e)
        {
            PrimePaused = false;
            Thread.Sleep(2000);
            Prime_Thread.Interrupt();

            //Prime_Thread.Join();
            //Prime_Thread.Abort();
        }
        private void Fibonacci_stop_button_Click(object sender, EventArgs e)
        {
            FibonacciPause = false;
            //Fibonacci_Thread.Interrupt();
            //Fibonacci_Thread.Join();
            Thread.Sleep(2000);
            Fibonacci_Thread.Abort();
        }

        private void Prime_pause_button_Click(object sender, EventArgs e)
        {
            if (!PrimePaused)
            {
                PrimePaused = true;
                Prime_Thread.Suspend();
            }
            else
            {
                PrimePaused = false;
                Prime_Thread.Resume();
            }
        }

        private void Fibonacci_pause_button_Click(object sender, EventArgs e)
        {
            if (!FibonacciPause)
            {
                FibonacciPause = true;
                //Thread.Sleep(10000);
                Fibonacci_Thread.Suspend();
            }
            else
            {
                FibonacciPause = false;
                Fibonacci_Thread.Resume();
            }
        }
        private void stop_all_button_Click(object sender, EventArgs e)
        {
            Stop_Prime_Click(sender, e);
            Fibonacci_stop_button_Click(sender, e);
        }

        private void View_all_button_Click(object sender, EventArgs e)
        {
            Prime_button_Click(sender, e);
            Fibonacci_view_button_Click(sender, e);
        }
    }
}
