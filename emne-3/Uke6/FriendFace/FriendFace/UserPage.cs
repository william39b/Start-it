using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class UserPage
    {
        private User _user;

        public UserPage(User user)
        {
            _user = user;
        }
        
        public void ShowUserPage()
        {
            Console.Clear();
            Console.WriteLine(
                $"{_user.Pfp}\n" +
                $"{_user.Username}\n" +
                $"Bio: {_user.Bio}\n" +
                $"Friends: {_user.Friends.Count}\n");
            Console.WriteLine("[1] See all friends \n[2] Go back to main menu");
            var input = Console.ReadLine();
            if (input == "1") ShowFriends();
        }

        private void ShowFriends()
        {
            int num = 1;
            Console.Clear();
            Console.WriteLine($"{_user.Username}'s friends: ");
            foreach (var f in _user.Friends)
            {
                Console.WriteLine($"[{num++}] {f.Username}");
            }
            var input  = Convert.ToInt32(Console.ReadLine()) - 1;
            var friendProfile = new UserPage(_user.Friends[input]);
            ShowFriendProfile(friendProfile);
            Console.ReadKey();
            
        }

        private void ShowFriendProfile(UserPage friend)
        {
            Console.Clear();
            Console.WriteLine(
                $"{friend._user.Pfp}\n" +
                $"{friend._user.Username}\n" +
                $"Bio: {friend._user.Bio}\n" +
                $"Friends: {friend._user.Friends.Count}\n");
            Console.WriteLine("[1] Remove friend");
            Console.WriteLine("[2] Go back");
            var input = Console.ReadLine();
            if (input == "2") return;
            RemoveFriend(friend);
        }

        private void RemoveFriend(UserPage friend)
        {
            Console.WriteLine($"You have removed {friend._user.Username} from your friends list.");
            _user.Friends.Remove(friend._user);
            friend._user.Friends.Remove(_user);
        }
    }
}
