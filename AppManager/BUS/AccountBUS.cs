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
        public bool IsLoginSever(string username, string password) {
            AccountDAO accountDAO = new AccountDAO();
            if(!accountDAO.IsUsernameSeverExist(username)) return false;
            else {
                if(password == accountDAO.GetPassword(username)) return true;
                else return false;
            }
        }

        public bool CreateAccount(Account account, DetailAccount detail, Timer timer) {
            AccountDAO accountDAO = new AccountDAO();
            DetailAccountDAO detailDAO = new DetailAccountDAO();
            TimerDAO timerDAO = new TimerDAO();

            if(accountDAO.IsUsernameClientExist(account.username)) return false;
            else {
                accountDAO.InsertOrUpdate(account);
                detailDAO.InsertOrUpdate(detail);
                timerDAO.InsertOrUpdate(timer);
                return true;
            }
        }

        public void InsertOrUpdate(Account account) {
            new AccountDAO().InsertOrUpdate(account);
        }

        public Account[] GetListClientAccounts() {
            DataTable dt = new AccountDAO().GetClientAccounts();
            int count = dt.Rows.Count;
            Account[] accounts = new Account[count];
            for(int i = 0; i < count; ++i) {
                accounts[i] = new Account();
                accounts[i].username = dt.Rows[i]["username"].ToString();
                accounts[i].password = dt.Rows[i]["password"].ToString();
                accounts[i].group = 2;
            }
            return accounts;
        }

        public void DeleteClient(string username) {
            new AccountDAO().Delete(username);
        }
    }
}
