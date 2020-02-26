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
            int incrementer = 0;
            for (int i = 0; i < Count; i++)
            {
                if(index == i)
                {
                    for (int j = 0; j < Count; j++)
                    {
                        if(j == Count - i - 1)
                        {
                            arrayBackbone[i+incrementer] = default;
                            break;
                        }
                        else
                        {
                            arrayBackbone[i + incrementer] = arrayBackbone[i + 1 + incrementer];
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
        public CustomList<T> Sort( string direction)
        {
            
            if(direction == "ascending")
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
                            i = 0;
                            break;
                        }
                    }
                }
            }
            else if (direction == "descending")
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
                            i = 0;
                            break;
                        }
                    }
                }
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
        private CustomList<T> SortListOfTypeNumber()
        {
            if(this.GetType()==typeof(byte))
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < this.Count; j++)
                    {
                        if (Comparer<T>.Default.Compare(this[i], this[i + 1]) > 0)
                        {
                            this[i] = this[i+1];
                        }
                    }                    
                }
            }
            else if(this.GetType()==typeof(decimal))
            {
                CustomList<decimal> customList = new CustomList<decimal>();
            }
            else if(this.GetType()==typeof(double))
            {
                CustomList<double> customList = new CustomList<double>();
            }
            else if (this.GetType() == typeof(float))
            {
                CustomList<float> customList = new CustomList<float>();
            }
            else if (this.GetType() == typeof(int))
            {
                CustomList<int> customList = new CustomList<int>();
            }
            else if (this.GetType() == typeof(long))
            {
                CustomList<long> customList = new CustomList<long>();
            }
            else if (this.GetType() == typeof(short))
            {
                CustomList<short> customList = new CustomList<short>();
            }
            else if (this.GetType() == typeof(sbyte))
            {
                CustomList<sbyte> customList = new CustomList<sbyte>();
            }
            return this;
        }
        private CustomList<T> SortListOfTypeNonNumber()
        {
            if (this.GetType() == typeof(string))
            {
                CustomList<string> customList = new CustomList<string>();
            }
            else if(this.GetType() == typeof(char))
            {
                CustomList<char> customList = new CustomList<char>();
            }
            return this;
        }
    }
}
