using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, string seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem
{
    private Ticket head;

    public TicketReservationSystem()
    {
        head = null;
    }

    public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);
        if (head == null)
        {
            head = newTicket;
            head.Next = head;
        }
        else
        {
            Ticket temp = head;
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = newTicket;
            newTicket.Next = head;
        }
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null) return;
        Ticket temp = head, prev = null;

        do
        {
            if (temp.TicketID == ticketID)
            {
                if (temp == head)
                {
                    Ticket last = head;
                    while (last.Next != head)
                        last = last.Next;
                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = head;
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string query)
    {
        if (head == null) return;
        Ticket temp = head;
        do
        {
            if (temp.CustomerName == query || temp.MovieName == query)
            {
                Console.WriteLine($"Found Ticket - ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}");
                return;
            }
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine("Ticket not found.");
    }

    public int CountTickets()
    {
        if (head == null) return 0;
        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);
        return count;
    }
}

class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();
        system.AddTicket(1, "Vishu", "Movie A", "A1");
        system.AddTicket(2, "Shrey", "Movie B", "B2");
        system.AddTicket(3, "Lakshay", "Movie A", "A3");

        system.DisplayTickets();

        Console.WriteLine("Searching for Movie A tickets:");
        system.SearchTicket("Movie A");

        Console.WriteLine("Total tickets: " + system.CountTickets());

        Console.WriteLine("Removing Ticket ID 2");
        system.RemoveTicket(2);
        system.DisplayTickets();
    }
}
