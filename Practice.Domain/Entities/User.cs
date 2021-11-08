using System;

namespace Practice.Domain.Entities
{
    public class User : BaseEntity
    {
        public DateTime CreatedDate { get; protected set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool IsDeleted { get; set; }

        public User()
        {
            CreatedDate = DateTime.UtcNow;
            IsDeleted = false;
        }

        public User(string id) : this()
        {
            Id = id;
        }
    }
}
