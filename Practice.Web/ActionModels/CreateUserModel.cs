using Practice.Domain.Entities;

namespace Practice.Web.ActionModels
{
    public class CreateUserModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public User ToUser(string id = null)
        {
            return new User(id)
            {
                Email = Email,
                FirstName = FirstName,
                SecondName = SecondName,
                UserName = UserName,
            };
        }
    }
}
