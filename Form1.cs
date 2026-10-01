namespace cabuhatThreadPriority
{
    public partial class Form1 : Form
    {
        Thread threadA = null!;
        Thread threadB = null!;
        Thread threadC = null!;
        Thread threadD = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            label1.Text = "-Thread Starts -";

            Console.WriteLine("-Thread Starts -");

            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread1);
            threadC = new Thread(MyThreadClass.Thread2);
            threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = "-End of Thread-";

            Console.WriteLine("-End of Thread-");
        }
    }
}
        