using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO {
    public class FoodDAO {
        public DataTable GetFoods() {
            string query = "SELECT * FROM [Food]";
            return DBHelper.GetTable(query);
        }

        public DataTable GetFoodFromFoodId(string food_id) {
            string query = "SELECT * FROM [Food] WHERE [food_id] = '" + food_id + "'";
            return DBHelper.GetTable(query);
        }

    }
}
