using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        public string Username {  get; private set; }
        public string Pfp { get; private set; } 
        public string Bio { get; private set; } 
        public List<User> Friends { get; private set; } 
        
        public User(string username)
        {
            Username = username;
            Pfp = "（ ^_^）";
            Bio = "Default bio...";
            Friends = [];
        }
    }
}
