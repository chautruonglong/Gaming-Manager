using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class AccountBUS {
        public bool IsLogin(string username, string password) {
            AccountDAO accountDAO = new AccountDAO();
            if(!accountDAO.IsUsernameExist(username)) return false;
            else {
                if(password == accountDAO.GetPassword(username)) return true;
                else return false;
            }
        }

        public void Update(Account account) {
            new AccountDAO().Update(account);
        }
    }
}
