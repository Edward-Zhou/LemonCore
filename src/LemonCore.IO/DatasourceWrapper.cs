﻿using LemonCore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LemonCore.IO
{
    public class DatasourceWrapper<T> : IDataReader<T>
    {
        private IEnumerator<T> _enumerator;

        public DatasourceWrapper(IEnumerable<T> enumerable)
        {
            _enumerator = enumerable.GetEnumerator();
        }


        public DatasourceWrapper(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
        }

        public void Dispose()
        {
            _enumerator.Dispose();
        }

        public T Read()
        {
            return _enumerator.Current;
        }

        object IDataReader.Read()
        {
            return Read();
        }

        public bool Next()
        {
            return _enumerator.MoveNext();
        }
    }
}
