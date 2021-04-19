using Datos;

namespace Dominio
{
    public class Usermodel
    {
        private UserDao userDao = new UserDao();

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

    }
}
