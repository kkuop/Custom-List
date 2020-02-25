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
        private CustomList(int capacity)
        {
            arrayBackbone = new T[capacity];
            Count = 0;
            Capacity = capacity;
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
            int incrementer = 0;
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
                            arrayBackbone[i + incrementer] = arrayBackbone[i + 1 + incrementer] ;
                            incrementer++;
                        }
                    }
                    incrementer = 0;
                    Count -= 1;
                    break;
                }
            }
        }
        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < Count; i++)
            {
                newString = newString + this[i].ToString();
            }
            return newString;
        }
        public CustomList<T> Zip(CustomList<T> list)
        {
            int higherCountForLoop = SetMaxForZipperLoop(this, list);
            
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < higherCountForLoop ; i++)
            {
                if(i < this.Count)
                {
                    newList.Add(this[i]);
                }
                if(i < list.Count)
                {
                    newList.Add(list[i]);
                }
                
            }
            return newList;
        }
        public CustomList<T> Sort(CustomList<T> list)
        {
            return list;
        }
        public T this[int i]
        {
            get { if (i < Count) { return arrayBackbone[i]; } else { throw new System.ArgumentException("Index out of range", "i"); } }
            set { arrayBackbone[i] = value; }
        }
        public static CustomList<T> operator+ (CustomList<T> customList, CustomList<T> customList1)
        {
            CustomList<T> result = new CustomList<T>();
            result.AddListToList(customList);
            result.AddListToList(customList1);
            return result;
        }
        public static CustomList<T> operator- (CustomList<T> customList, CustomList<T> customList1)
        {
            
            for (int i = 0; i <customList.Count; i++)
            {
                for (int j = 0; j < customList1.Count; j++)
                {
                    if(Comparer<T>.Default.Compare(customList[i], customList1[j]) == 0)
                    {
                        customList.Remove(customList[i]);
                    }
                }
            }
            return customList;
        }
        private CustomList<T> AddListToList(CustomList<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.Add(list[i]);
            }
            return this;
        }
        private int SetMaxForZipperLoop(CustomList<T> list, CustomList<T> list1) 
        {
            if (list.Count > list1.Count)
            {
                return list.Count;
            }
            else
            {
                return list1.Count;
            }
        }
    }
}
