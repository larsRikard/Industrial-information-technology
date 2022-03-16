using System;
using System.Threading;
namespace ThreadSys
{
    // The application
    class ThreadSys
    {
        //Sempahore to simulate limited resource
        private static Semaphore resource;
        /// <summary>
        /// Start of the main program
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(" Start of main program ");
            // Making sempahore that can only serve one thread at a time
            resource = new Semaphore(1, 1);
            // Making 4 threads according to the scheduler tab
            ThreadClass ct1 = new ThreadClass("Thread#1", resource, 95);
            ThreadClass ct2 = new ThreadClass("Thread#2", resource, 161);
            ThreadClass ct3 = new ThreadClass("Thread#3", resource, 227);
            ThreadClass ct5 = new ThreadClass("Thread#5", resource, 359);
            // Wait while the threads are running ...
            for (int cnt = 0; cnt < 30; cnt++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            // End of main program
            Console.WriteLine(" End of main program ");
        }
    }

    /// <summary>
    /// Threadclass
    /// </summary>
    class ThreadClass
    {
        int loopCnt, loopDelay;
        Semaphore resource;
        Thread cThread;
        public ThreadClass(string name, Semaphore resource, int delay)
        {
            loopCnt = 0;
            loopDelay = delay;
            this.resource = resource;
            cThread = new Thread(new ThreadStart(this.run));
            cThread.Name = name;
            cThread.Start();
        }
        // The main function in the ThreadClass
        void run()
        {
            Console.WriteLine(" Starting " + cThread.Name);
            do
            {
                resource.WaitOne();
                loopCnt++;
                Thread.Sleep(loopDelay);
                Console.Write(" ");
                Console.Write(cThread.Name);
                Console.Write(": ");
                Console.WriteLine("Loop=" + loopCnt);
                resource.Release();
            } while (loopCnt < 5);
            // Ending of the thread
            Console.WriteLine(" Ending " + cThread.Name);
        }
    }
}
