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

        public void InsertOrUpdateFood(Food food) {
            SqlCommand cmd = new SqlCommand();
            int rows = DBHelper.GetTable("SELECT * FROM [Food] WHERE [food_id] = '" + food.food_id + "'").Rows.Count;

            if (rows > 0) cmd.CommandText = "UPDATE [Food] SET name = @name, image = @image, cost = @cost WHERE food_id = @food_id";
            else {
                cmd.CommandText = "INSERT INTO [Food] Values(@food_id, @name, @image, @cost)";
                food.food_id = GenerateFoodId();
            }

            cmd.Parameters.AddWithValue("@food_id", food.food_id);
            cmd.Parameters.AddWithValue("@name", food.name);
            cmd.Parameters.AddWithValue("@image", food.image);
            cmd.Parameters.AddWithValue("@cost", food.cost);

            DBHelper.ExecuteNonQuery(cmd);
        }

        public void DeleteFood(string food_id) {
            string query = "DELETE FROM [Food] WHERE food_id = '" + food_id + "'";
            DBHelper.ExecuteNonQuery(query);
        }

        public string GenerateFoodId() {
            int count = Count - 1;
            string food_id = "Food" + count.ToString();
            int rows = DBHelper.GetTable("SELECT * FROM [Food] WHERE [food_id] = '" + food_id + "'").Rows.Count;
            while (rows > 0) {
                count++;
                food_id = "Food" + count.ToString();
                rows = DBHelper.GetTable("SELECT * FROM [Food] WHERE [food_id] = '" + food_id + "'").Rows.Count;
            }
            return food_id;
        }

        public int Count {
            get {
                return DBHelper.GetTable("SELECT * FROM [FOOD]").Rows.Count;
            }
        }
    }
}
