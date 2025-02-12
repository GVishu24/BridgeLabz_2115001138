using System;
class User
{
    public int UserID;
    public string Name;
    public int Age;
    public int[] FriendIDs;
    public User Next;

    public User(int userID, string name, int age, int maxFriends)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new int[maxFriends];
        for (int i = 0; i < maxFriends; i++)
            FriendIDs[i] = -1;
        Next = null;
    }
}

class SocialMedia
{
    private User head;
    private int maxFriends;

    public SocialMedia(int maxFriendsPerUser)
    {
        head = null;
        maxFriends = maxFriendsPerUser;
    }

    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age, maxFriends);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            User temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newUser;
        }
    }

    public void AddFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            for (int i = 0; i < maxFriends; i++)
            {
                if (user1.FriendIDs[i] == -1)
                {
                    user1.FriendIDs[i] = userID2;
                    break;
                }
            }
            for (int i = 0; i < maxFriends; i++)
            {
                if (user2.FriendIDs[i] == -1)
                {
                    user2.FriendIDs[i] = userID1;
                    break;
                }
            }
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            for (int i = 0; i < maxFriends; i++)
            {
                if (user1.FriendIDs[i] == userID2)
                    user1.FriendIDs[i] = -1;
            }
            for (int i = 0; i < maxFriends; i++)
            {
                if (user2.FriendIDs[i] == userID1)
                    user2.FriendIDs[i] = -1;
            }
        }
    }

    public void DisplayFriends(int userID)
    {
        User user = FindUser(userID);
        if (user != null)
        {
            Console.Write($"Friends of {user.Name}: ");
            for (int i = 0; i < maxFriends; i++)
            {
                if (user.FriendIDs[i] != -1)
                    Console.Write(user.FriendIDs[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public User FindUser(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public User FindUser(string name)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia(5);
        sm.AddUser(1, "Vishu", 23);
        sm.AddUser(2, "Lakshay", 24);
        sm.AddUser(3, "Shrey", 22);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);

        sm.DisplayFriends(1);
        sm.DisplayFriends(2);

        Console.WriteLine("Removing Friend Connection between Vishu and Lakshay");
        sm.RemoveFriend(1, 2);

        sm.DisplayFriends(1);
        sm.DisplayFriends(2);
    }
}

