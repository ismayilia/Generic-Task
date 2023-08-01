using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Generics
{
    internal class StringList
    {
        private string[] _StringList;


        public StringList()
        {
            _StringList = Array.Empty<string>();
        }

        public void Add(string str)
        {
            Array.Resize(ref _StringList, _StringList.Length+1);
            _StringList[_StringList.Length-1] = str;
        }

        public string[] GetAll()
        {
            return _StringList;
        }







    }
}
