using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Prev;
    public Movie Next;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
            return;
        }
        newMovie.Next = head;
        head.Prev = newMovie;
        head = newMovie;
    }

    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newMovie;
            return;
        }
        tail.Next = newMovie;
        newMovie.Prev = tail;
        tail = newMovie;
    }

    public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        if (position == 1)
        {
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }
        Movie temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }
        if (temp == null || temp.Next == null)
        {
            AddMovieAtEnd(title, director, year, rating);
            return;
        }
        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        temp.Next.Prev = newMovie;
        temp.Next = newMovie;
    }

    public void RemoveMovieByTitle(string title)
    {
        Movie temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found!");
            return;
        }
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;
    }

    public Movie SearchMovieByDirectorOrRating(string director, double rating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director == director || temp.Rating == rating)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayMoviesForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    public void DisplayMoviesReverse()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }

    public void UpdateMovieRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found!");
    }
}

class Program
{
    static void Main()
    {
        MovieList movieList = new MovieList();

        movieList.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddMovieAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
        movieList.AddMovieAtBeginning("The Matrix", "Wachowskis", 1999, 8.7);
        movieList.AddMovieAtPosition("Avatar", "James Cameron", 2009, 7.8, 2);

        Console.WriteLine("Movies in forward order:");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nMovies in reverse order:");
        movieList.DisplayMoviesReverse();

        Console.WriteLine("\nSearching for movies directed by Christopher Nolan:");
        Movie found = movieList.SearchMovieByDirectorOrRating("Christopher Nolan", -1);
        if (found != null)
            Console.WriteLine($"Found - Title: {found.Title}, Director: {found.Director}, Year: {found.Year}, Rating: {found.Rating}");
        else
            Console.WriteLine("Movie not found!");

        Console.WriteLine("\nUpdating rating of 'Inception' to 9.0");
        movieList.UpdateMovieRating("Inception", 9.0);

        Console.WriteLine("\nMovies after update:");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nRemoving 'The Matrix'");
        movieList.RemoveMovieByTitle("The Matrix");

        Console.WriteLine("\nMovies after removal:");
        movieList.DisplayMoviesForward();
    }
}

