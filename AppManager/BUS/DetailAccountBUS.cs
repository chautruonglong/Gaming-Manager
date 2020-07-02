using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class DetailAccountBUS {
        public DetailAccount GetDetailAccount(string username) {
            DataTable dt = new DetailAccountDAO().GetDetailAccount(username);
            DetailAccount detail = new DetailAccount() {
                detail_id = dt.Rows[0]["detail_id"].ToString(),
                name = dt.Rows[0]["name"].ToString(),
                phone = dt.Rows[0]["phone"].ToString(),
                username = username
            };

            try {
                detail.age = int.Parse(dt.Rows[0]["age"].ToString());
                detail.cmnd = int.Parse(dt.Rows[0]["cmnd"].ToString());
            }
            catch (Exception e) { }

            return detail;
        }
    }
}
