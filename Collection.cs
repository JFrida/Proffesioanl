using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    delegate void addtriger<T>(T a);
    delegate void removetriger<T>(T a);
    public class CustomCollection<T> :ICollection<T>

    {
        event addtriger<T> addtrigger;
        event removetriger<T> removetrigger;

        private List<T> list;// or ICollection<T> list;

        public int Count
        {
            get { return list.Count; }
            private set { }
        }
        public void TriggerEventForAdd(T item)
        {
            Console.WriteLine($"{item} was added");
        }
        public void TriggerEventForRemove(T item)
        {
            Console.WriteLine($"{item} was removed");
        }

        public bool IsReadOnly
        {  get { return false; } }

        public CustomCollection()
        {
            list = new List<T>();
            Count = list.Count; // not neccesary
        }
        public void Add(T item)
        {
            list.Add(item);
            addtrigger += TriggerEventForAdd;
            addtrigger.Invoke(item);

        }

        public void Clear()
        {
            list.Clear();
            
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator(); // or this.GetEnumerator();
        }

        public bool Remove(T item)
        {
            removetrigger += TriggerEventForRemove;
            removetrigger.Invoke(item);
            return (list.Remove(item));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
