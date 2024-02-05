using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace;

// Ödev
public class MyList<T>
{
    public MyList(params T[] data)
    {
        _data = data;
    }

    private T[] _data;

    public T Get(int id)
    {
        return _data[id];
    }

    public T[] GetAll()
    {
        return _data;
    }

    public void Add(T item)
    {
        T[] swap = new T[_data.Length + 1];

        for (int i = 0; i < _data.Length; i++)
        {
            swap[i] = _data[i];
        }
        swap[_data.Length] = item;

        _data = swap;
    }
}
