using System;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState current;
    private int maxHistory;
    private int historyCount;

    public TextEditor(int historySize)
    {
        current = null;
        maxHistory = historySize;
        historyCount = 0;
    }

    public void AddState(string content)
    {
        TextState newState = new TextState(content);
        if (current != null)
        {
            newState.Prev = current;
            current.Next = newState;
        }
        current = newState;
        historyCount++;

        if (historyCount > maxHistory)
        {
            RemoveOldestState();
        }
    }

    private void RemoveOldestState()
    {
        TextState temp = current;
        while (temp.Prev != null)
        {
            temp = temp.Prev;
        }
        if (temp.Next != null)
        {
            temp.Next.Prev = null;
        }
        historyCount--;
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more undo available.");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more redo available.");
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current Text: " + current.Content);
        }
        else
        {
            Console.WriteLine("Text editor is empty.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor(10);
        editor.AddState("Hello");
        editor.AddState("Hello, World");
        editor.AddState("Hello, World!");

        editor.DisplayCurrentState();
        editor.Undo();
        editor.Undo();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}