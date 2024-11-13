using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2;


//Push, Pop ,Peek, Count, IsEmpty
public class Stack<T>
{
    private List<T> _lst;

    public Stack()
    {
        _lst = new List<T>();
    }

    public void Push(T item)
    {
        _lst.Add(item);
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

        return _lst[_lst.Count - 1];
    }

    public void Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

        var elm = _lst[_lst.Count - 1];
        _lst.Remove(elm);
    }

    public int Count()
    {
        return _lst.Count;
    }

    public bool IsEmpty()
    {
        return _lst.Count == 0;
    }
}