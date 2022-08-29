using System;

namespace Q_OutPut
{
    class Quiz
    {
        public int q1;
        public int q2;

        public Quiz() { }
        public Quiz(int q1, int q2) 
        {
            this.q1 = q1;
            this.q2 = q2;
        }
        public void Add(int i)
        {
            q1 = q2 + i;
            q2 = q1 - 1 + i;
        }
        public void Show()
        {
            Console.WriteLine("q1: " + q1);
            Console.WriteLine("q2: " + q2);
        }

    }
    class Program
    {
        public static void Main()
        {
            Quiz q = new Quiz();

            q.Show();
            q.Add(1);
            q.Show();

            Quiz qq = new Quiz(2,4);
            qq.Show();
            qq.Add(2);
            qq.Add(4);

            Quiz qqq = new Quiz();
            qqq.Show();
            qqq.Add(2);
            qqq.Show();

            q.Show();
            q.Show();
            qqq.Show();

            Console.ReadKey();

        }
    }
}
