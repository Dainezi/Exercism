using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Introduction
//Implement a doubly linked list.
//
//Like an array, a linked list is a simple linear data structure.Several common data types can be implemented using linked 
//lists, like queues, stacks, and associative arrays.
//
//A linked list is a collection of data elements called nodes.In a singly linked list each node holds a value and a link to 
//the next node.In a doubly linked list each node also holds a link to the previous node.
//
//You will write an implementation of a doubly linked list. Implement a Node to hold a value and pointers to the next and 
//previous nodes.Then implement a List which holds references to the first and last node and offers an array-like interface 
//for adding and removing items:
//
//push(insert value at back);
//pop(remove value at back);
//shift(remove value at front).
//unshift(insert value at front);
//To keep your implementation simple, the tests will not cover error conditions.Specifically: pop or shift will never be called 
//on an empty list.
//
//If you want to know more about linked lists, check Wikipedia.
/// 
/// </summary>
/// <typeparam name="T"></typeparam>



public class Deque<T>
{
    /*public List<T> Lista1 = new List<T>();

    public void Push(T value)
    {
        var ultimo = Lista1.Count;
        Lista1.Add(value);
    }

    public T Pop()
    {
        int valor = Lista1.Count;
        T value = Lista1[valor - 1];
        Lista1.Remove(value);
        return value;
    }

    public void Unshift(T value)
    {
        Lista1.Insert(0, value);
    }

    public T Shift()
    {
        if (Lista1.Count > 0)
        {
            T valor = default(T);
            for (int i = 0; i < Lista1.Count; i++)
            {
                if (i==0)
                {

                    valor = Lista1[i];
                    Lista1.RemoveAt(i);
                }
            }
            return valor;
        }
        else
        {
            throw new ArgumentException("Invalido");
        }
    }
    */




    public LinkedList<T> _list { get; set; } = new LinkedList<T>();

    public void Push(T value)
    {
        _list.AddLast(value);
    }

    public T Pop()
    {
        T value = _list.Last();
        _list.RemoveLast();
        return value;
    }

    public void Unshift(T value)
    {
        _list.AddFirst(value);
    }

    public T Shift()
    {
        T value = _list.First();
        _list.RemoveFirst();
        return value;
    }
}