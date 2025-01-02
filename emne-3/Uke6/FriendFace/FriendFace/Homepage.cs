using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class Homepage
    {
        private User _user;
        
        public Homepage(User user)
        {
            _user = user;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to Friend Face    {_user.Username}\n");
                Console.WriteLine(
                    $"[1] Your profile\n" +
                    $"[2] Find friends\n" +
                    $"[3] Quit\n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        var userPage = new UserPage(_user);
                        userPage.ShowUserPage();
                        break;
                    case "2":
                        var findFriends = new FindFriends(_user);
                        findFriends.ShowPeople();
                        break;
                    case "3":
                        break;
                }
            }
        }
    }
}
