using SAIMS.Model;
using SAIMS.BusinessLogic.Repository;

namespace SAIMS.BusinessLogic.Controller
{
    internal class UserController
    {
        private readonly UserRepository repo = new UserRepository();

        public UserModel Login(string username, string password)
        {
            return repo.ValidateUser(username, password);
        }
    }
}
