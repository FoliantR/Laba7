using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Laba7
{
    class MyClassEnumer : IEnumerator, IEnumerable
    {
        string[] name;
        int position = -1;
        public MyClassEnumer(string[] _name)
        {
            this.name = _name;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= name.Length)
                {
                    throw new InvalidOperationException();
                }
                return name[position];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return name.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (position < name.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
