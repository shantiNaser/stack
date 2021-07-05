using System;

namespace task1
{
    public class Stack
    {
        // Automatic-Proparety
        public int[] st { get; set; }
        public int Top { get; set; }
        public int Max { get; set; }

        // Constructer
        public Stack(int size)
        {
            st = new int[size];
            Top = 0;
            Max = size - 1;
        }

        public void push(int element)
        {
            if (Top <= Max)
            {
                st[Top] = element;
                Top++;
                return;
            }
            else
            {
                System.Console.WriteLine("The Stack was Full , Try to remove some Data");
                return;
            }
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public int pop()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The Stack is Empty!");
                return 0;
            }
            else
            {
                return st[--Top];
            }

        }

        public void Print()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The stack was Empty!");
            }
            int i = Top;
            while (i != 0)
            {
                System.Console.WriteLine(st[--i]);
            }
        }

        public int peek()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The Stack is Empty!");
                return 0;
            }
            else
            {
                int x = st[Top - 1];
                return x;
            }
        }

        public void Clear()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The stack was Empty!");
            }
            while (Top != 0)
            {
                pop();
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Stack st = new Stack(5);
            st.push(1);
            st.push(2);
            st.push(3);
            System.Console.WriteLine("The fully stack before any opeater is");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            int elepeek = st.peek();
            System.Console.WriteLine($"The elemant was peek is {elepeek}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            int elepop = st.pop();
            System.Console.WriteLine($"The elemant was pop is {elepop}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            st.push(4);
            st.push(6);
            st.Print();


            //st.Display();


        }
    }
}
