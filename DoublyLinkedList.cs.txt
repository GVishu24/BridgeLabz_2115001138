using System;

public class DoubleLinkedList 
{
    public class Node
    {
        public string title;
        public string director;
        public DateTime yearOfRelease;
        public float rating;
        public Node next;
        public Node prev;

        public Node(string title, string director, DateTime yearOfRelease, float rating)
        {
            this.title = title;
            this.director = director;
            this.yearOfRelease = yearOfRelease;
            this.rating = rating;
            next = null;
            prev = null;
        }
    }
    private Node head;
    private Node tail;
    //public DoubleLinkedList() 
    //{
    //    head = null;
    //    tail = null;
    //}

    public void Append(string title, string director, DateTime yearOfRelease, float rating) 
    {
        Node node = new Node(title, director, yearOfRelease, rating);       
        if(head == null) 
        {
            head = node;
            tail = node;
        }
        //Node temp = head;
        //while(temp.next != null) 
        //{
        //    temp = temp.next;
        //}
        //Node tempnode = temp;
        tail.next = node;
        node.prev = tail;
        tail = node;

    }

    public void Prepend(string title, string director, DateTime yearOfRelease, float rating) 
    {
        Node node = new Node(title, director, yearOfRelease, rating);
        if(head == null) 
        {
            head = node;
            tail = node;
            return;
        }
        node.next = head;
        head.prev = node;
        head = node;
    }

    public void InsertAt(int index, string title, string director, DateTime yearOfRelease, float rating) 
    {
        Node node = new Node(title, director, yearOfRelease, rating);
        if (head == null)
        {
            head = node;
            tail = node;
            return;
        }
        if(index == 1) 
        {
            Prepend(title, director, yearOfRelease, rating);
            return;
        }
        int count = 1;
        Node current = head;
        while(count < index) 
        {
            //Console.WriteLine(current.title);
            current = current.next;
            count++;
        }
        Node previour = current.prev;
        Node forward = current;
        previour.next = node;
        node.next = forward;
        node.prev = previour;
        forward.prev = node;
    }

    public void TitleDelete(string title)
    {
        if (head == null)
        {
            return;
        }
        if (head.title == title)
        {
            Node node = head;
            head = head.next;
            head.prev = null;
            node.next = null;
            return;
        }
        Node current = head;
        while (current != null)
        {
            if (current.next.title == title)
            {
                current.next = current.next.next;
                current.next.next.prev = current;
                return;
            }
            current = current.next;
        }
    }
    public void SearchDR(string director) 
    {
        if (head == null) 
        {
            return;
        }
        Node temp = head;
        while(temp != null)
        {
            if(temp.director == director) 
            {
                Console.WriteLine(temp.title + ", " + temp.director + ", " + temp.yearOfRelease.ToString("yyyy,MM,dd") + ", " + temp.rating);
            
            }
            temp = temp.next;
            //if (temp.next != null) { temp = temp.next; }
        }
    }
    public void SearchDR(float rating)
    {
        if (head == null)
        {
            return;
        }
        Node temp = head;
        while (temp != null)
        {
            if (temp.rating == rating)
            {
                Console.WriteLine(temp.title + ", " + temp.director + ", " + temp.yearOfRelease.ToString("yyyy,MM,dd") + ", " + temp.rating);
                
            }
            //if(temp.next != null) {}
            temp = temp.next;
        }
    }
    public void DisplayOrders() 
    {
        Node temp1 = head;
        while( temp1 != null) 
        {
            Console.WriteLine(temp1.title + ", " + temp1.director + ", " + temp1.yearOfRelease.ToString("yyyy,MM,dd") + ", " + temp1.rating);
            temp1 = temp1.next;
        }
        Console.WriteLine("ORDER CHANGED");
        Node temp2 = tail;
        while( temp2 != null) 
        {
            Console.WriteLine(temp2.title + ", " + temp2.director + ", " + temp2.yearOfRelease.ToString("yyyy,MM,dd") + ", " + temp2.rating);
            temp2 = temp2.prev;
        }
    }

    public void Display() 
    {
        Node temp = head;
        while(temp != null ) 
        {
            Console.WriteLine(temp.title + ", " + temp.director + ", " + temp.yearOfRelease.ToString("yyyy,MM,dd") + ", " + temp.rating);
            temp = temp.next;
        }
    }


}

public class Program 
{
    public static void Main(string[] args) 
    {
        DoubleLinkedList list = new DoubleLinkedList();
        list.Append("6 UnderGround", "Michael Bay", new DateTime(2019, 12, 10), 6.1f);
        list.Append("Interstellar", "Christopher Nolan", new DateTime(2014, 11, 07), 8.7f);
        list.Prepend("Tenet", "Christopher Nolan", new DateTime(2020, 12, 04), 7.3f);
        list.Prepend("Bay Watch", "Seth Gordon", new DateTime(2017, 05, 29), 5.5f);
        list.Display();
        Console.WriteLine("Displaying after inserting at index");
        list.InsertAt(2, "abcxyz", "Lakshay", new DateTime(2003, 06, 25), 9.7f);
        list.Display();
        Console.WriteLine("After deliting based on title");
        list.TitleDelete("abcxyz");
        list.Display();
        Console.WriteLine("Saerching by director");
        list.SearchDR("Christopher Nolan");
        Console.WriteLine("Searching by rating");
        list.SearchDR(7.3f);
        Console.WriteLine("Displaying in both reverse and forward order");
        list.DisplayOrders();
        
        Console.ReadKey();
    }
}


