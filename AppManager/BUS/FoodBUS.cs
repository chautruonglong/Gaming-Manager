using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS {
    public class FoodBUS {
        public Food[] GetListFood() {
            FoodDAO foodDAO = new FoodDAO();
            DataTable dt = foodDAO.GetFoods();
            int count = dt.Rows.Count;
            Food[] foods = new Food[count];
            for (int i = 0; i < count; ++i) {
                foods[i] = new Food();
                foods[i].food_id = dt.Rows[i]["food_id"].ToString();
                foods[i].name = dt.Rows[i]["name"].ToString();
                foods[i].cost = float.Parse(dt.Rows[i]["cost"].ToString());
                foods[i].image = dt.Rows[i]["image"] as byte[];
            }
            return foods;
        }

        public string GetNameFoodFromFoodId(string food_id) {
            DataTable dt = DBHelper.GetTable("SELECT [name] FROM [Food] WHERE [food_id] = '" + food_id + "'");
            return dt.Rows[0][0].ToString();
        }

        public void InsertOrUpdateFood(Food food) {
            new FoodDAO().InsertOrUpdateFood(food);
        }

        public void DeleteFood(string food_id) {
            new FoodDAO().DeleteFood(food_id);
        }
    }
}
