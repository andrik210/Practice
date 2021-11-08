using System;

namespace Practice.Web.ViewModels
{
    public class UserViewModel
    {
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public UserViewModel()
        {

        }
    }
}
