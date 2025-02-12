using System;
using System.Reflection.Metadata.Ecma335;
class Node{
    public int Data;
    public Node Next;

    public Node (int data)
    {
        Data = data;
        Next = null;
    }
}
public class LinkedList
{
    private Node head;
    
    //insert at end
    public void Append(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }
    //insert at begining

    public void Prepend(int Data)
    {
        Node newNode = new Node(Data);
        newNode.Next = head;
        head = newNode;
    }

    //insert at a specific position

    public void InsAt(int data, int pos)
    {
        Node temp = head;
        int curr = 1;
        if (pos < 1)
        {
            Console.WriteLine("enter valid position");
        }


        if (pos == 1)
        {

            Prepend(data);
            return;
        }
        while (curr < pos - 1)
        {
            temp = temp.Next;
            curr++;

        }
        Node newNode = new Node(data);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    //searching a key

    public bool Search(int key)
    {
        Node temp = head;
        while (temp.Next != null)
        {
            if (temp.Data == key)
            {
                return true;
            }
            temp = temp.Next;
        }
        return false;
        
    }
    //delete first

public void DelFirst()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        head = head.Next;
            
    }

    // delete last
    public void DelLast()
    {
        if (head == null)
        {
            Console.WriteLine("empty list");
            return;
        }
        if (head.Next == null)
        {
            head = null;
            return;
        }
        Node temp = head;
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = null;

    }
    //deletion by a key
    public void DelKey(int key)
    {
        Node temp = head;
        if (temp != null && temp.Data == key)
        {
            head = temp.Next;
            return;
        }
        while(temp != null)
        {
            if(temp.Next.Data == key)
            {
                temp.Next = temp.Next.Next;
                return;
            }
            temp = temp.Next;
        }
    }

    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }

}
class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Append(10);
        linkedList.Append(20);
        linkedList.Append(30);
        linkedList.Append(40);

        linkedList.Prepend(50);
       // Console.WriteLine(linkedList.Search(30));

        linkedList.Display();

        //linkedList.DelLast();

        //linkedList.Display();

        //linkedList.DelKey(20);
        //linkedList.Display();

        linkedList.InsAt(55, 3);
        linkedList.Display();

    }
}

