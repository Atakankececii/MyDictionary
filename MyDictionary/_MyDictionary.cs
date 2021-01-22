using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class _MyDictionary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;

        public _MyDictionary()
        {
            _keys = new T1[0];
            _values = new T2[0];
        }

        public void Add(T1 key,T2 value)
        {
            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];

            T1[] _tempKeys = _keys;
            T2[] _tempValues = _values;

            //keys değerlerini value değerlerine erişmek için kullandığımızdan dolayı for döngüsünü _keys'in üzerine kurduk.
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _tempKeys[i] = _keys[i];
                _tempValues[i] = _values[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

            


        }





  
        public T1[] Keys
        {
            get { return _keys; }
           
        }


        public T2[] Values
        {
            get { return _values; }

        }

     

        public int Count
        {
            get { return _keys.Length; }
      
        }








    }
}
