using System.Collections.Generic;

namespace ClaimsDemo.Models
{
    public class UserInfo
    {
        public UserInfo()
        {
            Roles = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Roles { get; set; }
    }
}