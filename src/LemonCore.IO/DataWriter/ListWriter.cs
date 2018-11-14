using LemonCore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LemonCore.IO.DataWriter
{
    public class ListWriter<T> : IDataWriter<T>
    {
        private readonly IList<T> _list;
        public ListWriter(IList<T> list)
        {
            _list = list;
        }
        public void Dispose()
        {
        }

        public void Write(IEnumerable<T> records)
        {
            foreach (var record in records)
                _list.Add(record);
        }

        public void Write(T record)
        {
            _list.Add(record);
        }
    }
}
