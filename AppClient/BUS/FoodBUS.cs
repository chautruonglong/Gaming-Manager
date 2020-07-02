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

        public Food GetFoodFromFoodId(string food_id) {
            DataTable dt = new FoodDAO().GetFoodFromFoodId(food_id);
            return new Food() {
                food_id = food_id,
                image = dt.Rows[0]["image"] as byte[],
                name = dt.Rows[0]["name"].ToString()
            };
        }
    }
}
