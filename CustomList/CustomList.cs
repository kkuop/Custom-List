using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        
        //member vars
        private T[] arrayBackbone;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        //constructor
        public CustomList()
        {
            
            arrayBackbone = new T[4];
            Count = 0;
            Capacity = 4;
        }
        
        //member methods
        public void Add(T item)
        {
            if(Count < Capacity)
            {
                arrayBackbone[Count] = item;
            }
            else
            {
                T[] temporaryArray = new T[Capacity * 2];
                for (int i = 0; i < Count + 1; i++)
                {
                    if (i == Count)
                    {
                        temporaryArray[i] = item;
                    }
                    else
                    {
                        temporaryArray[i] = arrayBackbone[i];
                    }
                }
                arrayBackbone = new T[Capacity * 2];
                arrayBackbone = temporaryArray;
                Capacity = Capacity * 2;
            }
            Count++;
        }
        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Comparer<T>.Default.Compare(arrayBackbone[i],item) == 0)
                {
                    for (int j = i; j < Count; j++)
                    {
                        if (j == Count - 1)
                        {
                            arrayBackbone[j] = default;
                        }
                        else
                        {
                            arrayBackbone[i] = arrayBackbone[i + 1];
                        }
                    }
                    Count -= 1;
                    break;
                }
            }
        }
        public override string ToString()
        {
            return "";
        }
        public List<T> Zip(List<T> list, List<T> list1)
        {
            List<T> newList = new List<T>();
            return newList;
        }
        public List<T> Sort(List<T> list)
        {
            return list;
        }
        public T this[int i]
        {
            get { return arrayBackbone[i]; }
            set { arrayBackbone[i] = value; }
        }
        public readonly struct Plus
        {

        }
        public readonly struct Minus
        {

        }
    }
}
