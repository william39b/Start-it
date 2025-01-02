namespace FriendFace;

internal class FindFriends
{
    private User _user;
    private IEnumerable<User> _people;
    private List<User> _peopleList;
    public FindFriends(User user)
    {
        _user = user;
        NewFriends();
    }
    
    public void NewFriends()
    {
        _people = UserDatabase.Users.Where(p => _user.Friends.Contains(p) == false);
        _peopleList = _people.ToList();
        ShowPeople();
    }

    public void ShowPeople()
    {
        int index = 1;
        Console.Clear();
        Console.WriteLine($"Some people you may know: \n");
        foreach (var person in _peopleList)
        {
            Console.WriteLine($"[{index++}] {person.Username}");
        }
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;
        else AddFriend(input);
    }
    
    private void AddFriend(string input)
    {
        var num = Convert.ToInt32(input) - 1;
        foreach (var u in UserDatabase.Users.Where(u => u == _peopleList[num]))
        {
            _user.Friends.Add(u);
            u.Friends.Add(_user);
        }
        NewFriends();
    }
}