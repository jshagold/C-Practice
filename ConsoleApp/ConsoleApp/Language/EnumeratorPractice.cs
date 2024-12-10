using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    internal class EnumeratorPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nEnumerator Practice");


            int[] arrValue = { 1, 2, 3 };
            MyCollection myCollection = new MyCollection(arrValue);

            foreach (int i in myCollection)
            {
                Console.WriteLine(i);
            }
        }

        public class MyCollection : IEnumerable
        {
            private int[] data;

            public MyCollection(int[] data)
            {
                this.data = data;
            }

            public IEnumerator GetEnumerator()
            {
                return new MyCollectionEnumerator(data);
            }
        }

        public class MyCollectionEnumerator : IEnumerator
        {
            private int[] data;
            private int position = -1;

            public MyCollectionEnumerator(int[] data)
            {
                this.data = data;
            }

            public object Current
            {
                get
                {
                    if (position == -1 || position >= data.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return data[position];
                }
            }

            public bool MoveNext()
            {
                position++;
                return position < data.Length;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}
