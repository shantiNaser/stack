using System;

namespace task1
{
    public class Stack<T>
    {
        // Automatic-Proparety
        public T[] st { get; set; }
        public int Top { get; set; }
        public int Max { get; set; }

        // Constructer
        public Stack(int size)
        {
            st = new T[size];
            Top = 0;
            Max = size - 1;
        }

        public void push(T element)
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

        public T pop()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The Stack is Empty!");
                return st[0];
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

        public T peek()
        {
            if (Top == 0)
            {
                System.Console.WriteLine("The Stack is Empty!");
                return st[0];
            }
            else
            {
                T x = st[Top - 1];
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
            // ----> Number Stack <-----

            Stack<int> st = new Stack<int>(5);
            st.push(1);
            st.push(2);
            st.push(3);
            System.Console.WriteLine("The fully stack before any opeater is");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            int elepeek = st.peek();
            System.Console.WriteLine($"The elemant was peek is ---> {elepeek}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            int elepop = st.pop();
            System.Console.WriteLine($"The elemant was pop is ---> {elepop}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            st.push(4);
            st.push(6);
            st.Print();



            /* // ----> String Stack <-----

            Stack<String> st = new Stack<string>(4);
            st.push("Naser");
            st.push("Sudqi");
            st.push("Mohammad");
            st.push("Ahmad");
            System.Console.WriteLine("The fully stack before any opeater is");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            string elepeek = st.peek();
            System.Console.WriteLine($"The elemant was peek is ---> {elepeek}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            string elepop = st.pop();
            System.Console.WriteLine($"The elemant was pop is ---> {elepop}");
            st.Print();
            System.Console.WriteLine("-----------------------------------");
            st.push("Amjad");
            st.push("hala");
            st.Print();
            */


        }
    }
}
