using FCode_CRUD.AppModels; // Assuming DemoUsers is defined in this namespace
using FCode_CRUD.Models;
using System.Collections.Generic;
using System.Linq;

namespace FCode_CRUD.Repository
{
    public class UsersList
    {
        private readonly UserDbContext _context;

        public UsersList(UserDbContext context)
        {
            _context = context;
        }

        public List<DemoUsers> GetList()
        {
            var userList = _context.TUsers.ToList();
            var demoUsersList = new List<DemoUsers>();

            foreach (var user in userList)
            {
                var demoUser = new DemoUsers
                {
                    Id = user.UserId, 
                    FullName = user.UserName,
                    Email=user.UserEmail,
                    Password = user.Password,
                    Phone=user.PhoneNumber,
                };
                demoUsersList.Add(demoUser);
            }

            return demoUsersList;
        }
        public Users InsertRecord(DemoUsers1 demoUser)
        {
            Users users = new Users
            {
                UserName = demoUser.FullName,
                UserEmail = demoUser.Email,
                Password = demoUser.Password,
                PhoneNumber = demoUser.Phone,
            };
            _context.TUsers.Add(users);
            _context.SaveChanges();
            return users;
        }
        public DemoUsers GetUserById(int id)
        {
            var user=_context.TUsers.Where(x=>x.UserId == id).FirstOrDefault();
            if (user != null)
            {
                DemoUsers demoUsers = new DemoUsers
                {
                    Id=user.UserId,
                    FullName=user.UserName,
                    Email=user.UserEmail,
                    Password=user.Password,
                };
                return demoUsers;
            }
            return null;
        }
        public Users UpdateRecord(DemoUsers demoUser)
        {
            var user=_context.TUsers.Where(z=>z.UserId==demoUser.Id).FirstOrDefault();
            if (user != null)
            {
                user.UserId = demoUser.Id;
                user.UserName = demoUser.FullName;
                user.UserEmail = demoUser.Email;
                user.Password = demoUser.Password;
               _context.SaveChanges();
                return user;
            }
            return null;
        }
    }
}
