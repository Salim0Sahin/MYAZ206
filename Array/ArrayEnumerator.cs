using System.Collections;

namespace DataStructures.Array
{
    public class ArrayEnumerator : IEnumerator
    {
        private Object[] Innerlist;
        private int index;
        public object Current => Innerlist[index];

        public ArrayEnumerator(Object[] arr)
        {
            Innerlist = arr;
            //index = -1;  => normal hali
            index = Innerlist.Length;
        }

        public bool MoveNext()
        {
            if (index == Innerlist.Length)
            {
                index--;
                return true;
            }
            if (index > 0)
            {
                index--;
                return true;
            }
            else
            {
                index = Innerlist.Length;
                return false;
            }

            //if (index == -1)
            //{
            //    index = 0;
            //    return true;
            //}

            //if (index < Innerlist.Length-1)
            //{
            //    index++;                     ==> Normal hali bunlar
            //    return true;

            //}
            //else
            //{
            //    index = -1;
            //    return false;
            //}

        }

        public void Reset()
        {
            index = Innerlist.Length;
        }
    }
}