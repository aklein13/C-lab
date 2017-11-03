using System;
using System.Collections.Generic;
using System.Text;


namespace KolejkaFIFO
{
    public class Queue
    {
        private string[] Kolejka;
        private int First;
        private int Last;

        public void Create(int liczbaElementow)
        {
            First = Last = -1;
            Kolejka = new string[liczbaElementow];
        }

        public bool IsFull()
        {
            return ((First == 0 && Last == Kolejka.Length - 1) || First == Last + 1);               
        }

        public void Enqueue(string os)
        {
            if (IsFull())
                throw new InvalidOperationException("Kolejka jest pe³na");
            if (Last == Kolejka.Length - 1 || Last == -1)
            {
                Kolejka[0] = os;
                Last = 0;
                if (First == -1)
                    First = 0;
            }
            else
                Kolejka[++Last] = os;
        }

        public bool IsEmpty()
        {
            return First == -1;
        }

        public string Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kolejka jest pusta");
            string tmp;
            tmp = Kolejka[First];
            if (First == Last)
                Last = First = -1;
            else
                if (First == Kolejka.Length - 1)
                    First = 0;
                else
                    First++;
            return tmp;
        }

        public void Clear()
        {
            Create(Kolejka.Length);
        }

        public string Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kolejka jest pusta");
            return Kolejka[First];
        }

        public int GetLength()
        {
            if(First == -1)
                return 0;
            if (First <= Last)
                return Last - First + 1;
            return Kolejka.Length - First + Last + 1;
        }
    }
}
