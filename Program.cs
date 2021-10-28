using System;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            _ArrayList arrayList = new _ArrayList();
           
            int count = arrayList.Count;
            int capacity = arrayList.Capacity;
            arrayList.Add(12);
            arrayList.Insert(1,12);
            arrayList.EnsureCapacity(1);
            
            Console.ReadLine();
        }
    }
}
