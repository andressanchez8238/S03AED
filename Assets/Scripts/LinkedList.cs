using UnityEngine;

public class LinkedList<T>
{
    public Node<T> Head = null;



    public virtual void Add(T value)
    {
        Head = new(value);
    }
}
