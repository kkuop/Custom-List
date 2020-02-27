using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
        public IEnumerator GetEnumerator() 
        {
            for (int i = 0; i < Count; i++)
            {
                yield return arrayBackbone[i];
            }
        }
        public void Add(T item)
        {
            if(Count < Capacity)
            {
                arrayBackbone[Count] = item;
            }
            else
            {
                //As a developer, I want to use single responsibility on the 
                // add method so the logic for increasing the capacity is in
                // another method
                IncreaseCapacity(item);                
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
        public void RemoveAt(int index)
        {
            for (int i = 0; i < Count; i++)
            {
                if(index == i)
                {
                    Remove(arrayBackbone[i]);
                }
            }
        }
        public void RemoveRange(int index, int count)
        {
            for (int i = 0; i < Count; i++)
            {
                if (index == i)
                {
                    for (int j = 0; j < count; j++)
                    {
                        Remove(arrayBackbone[i]);
                    }
                }
            }
        }
        public bool Exists(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Comparer<T>.Default.Compare(arrayBackbone[i], item) == 0)
                {
                    return true;
                }
            }
            return false;
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
        public CustomList<T> Sort( string direction)
        {
            // As a developer, I want to use Single Responsiblity on the Sort method
            //  so the logic is broken up into individual methods 
            if(direction == "ascending")
            {
                this.SortListAscending();
            }
            else if (direction == "descending")
            {
                this.SortListDescending();
            }
            else
            {
                throw new System.ArgumentException("that is not a valid sort command", direction);
            }
            return this;
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
            
            for (int i = 0; i <customList1.Count; i++)
            {
                for (int j = 0; j < customList.Count; j++)
                {
                    if(Comparer<T>.Default.Compare(customList1[i], customList[j]) == 0)
                    {
                        customList.Remove(customList[j]);
                        break;
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
        private void SortListAscending()
        {
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i; j < this.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(this[i], this[j]) > 0)
                    {
                        this.Add(this[i]);
                        this[i] = this[j];
                        this.RemoveAt(j);
                        i = -1;
                        break;
                    }
                }
            }
        }
        private void SortListDescending()
        {
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i; j < this.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(this[i], this[j]) < 0)
                    {
                        this.Add(this[i]);
                        this[i] = this[j];
                        this.RemoveAt(j);
                        i = -1;
                        break;
                    }
                }
            }
        }
        private void IncreaseCapacity(T item)
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
    }
}
