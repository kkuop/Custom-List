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
        private T[] arrayBackbone = new T[10];
        public int Count { get; }
        public int Capacity { get; }
        //constructor
        public CustomList()
        {

        }
        //member methods
        public void Add(T item)
        {

        }
        public void Remove(T item)
        {

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
