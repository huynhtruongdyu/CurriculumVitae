using System;

namespace CurriculumViate.Core.Domain
{
    public class User:BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Displayname { get; set; }
        public DateTime Dob { get; set; }
        public string AvatartUrl { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
    }
}