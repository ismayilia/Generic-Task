using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Generics
{
    internal class IntList
    {
        private int[] _intList;

        public IntList()
        {
             _intList = new int[0];
        }

        public  void Add(int num)
        {
            Array.Resize(ref _intList, 1);
            _intList[0] = num;  
        }

        public int[] GetAll()
        {
            return _intList;
        }
    }
    
}
