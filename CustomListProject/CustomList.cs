using System;

namespace CustomListProject
{
    public class CustomList<T>
    {

        public int count { get; private set; }
        public T[] items;
        public T itemsToAdd;
        public int capacity { get; private set; }
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
           items[0] = itemsToAdd;
        }
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }
        public T this[int i]
        {
            get
            {

                return items[i];

            }

            set
            {
                items[i] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity

        {
            get
            {
                return capacity;
            }
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = items[i];
                }
                items = temporaryArray;
            }
            items[count] = itemsToAdd;
            count++;



        }
    }
}