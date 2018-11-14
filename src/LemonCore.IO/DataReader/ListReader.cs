using LemonCore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LemonCore.IO.DataReader
{
    public class ListReader<T> : IDataReader<T>
    {
        private IEnumerator<T> _enumerator;
        public ListReader(IList<T> enumerator)
        {
            _enumerator = enumerator.GetEnumerator();
        }
        public bool Next()
        {
            return _enumerator.MoveNext();
        }

        public T Read()
        {
            return _enumerator.Current;
        }

        object IDataReader.Read()
        {
            return Read();
        }

        public void Dispose()
        {
            _enumerator.Dispose();
        }
    }
}
