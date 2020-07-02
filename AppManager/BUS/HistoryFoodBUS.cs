using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class HistoryFoodBUS {
        public HistoryFood[] GetHistoryFoodsFromFoodId(string food_id) {
            HistoryFoodDAO historyFoodDAO = new HistoryFoodDAO();
            DataTable dt = historyFoodDAO.GetHistoriesFromFoodId(food_id);
            int count = dt.Rows.Count;
            HistoryFood[] historyFoods = new HistoryFood[count];
            for (int i = 0; i < count; ++i) {
                historyFoods[i] = new HistoryFood();
                historyFoods[i].history_id = dt.Rows[i]["history_id"].ToString();
                historyFoods[i].time = (DateTime)dt.Rows[i]["time"];
                historyFoods[i].food_id = dt.Rows[i]["food_id"].ToString();
                historyFoods[i].username = dt.Rows[i]["username"].ToString();
            }
            return historyFoods;
        }

        public HistoryFood[] GetHistoryFoodsFromUsername(string username) {
            HistoryFoodDAO historyFoodDAO = new HistoryFoodDAO();
            DataTable dt = historyFoodDAO.GetHistoriesFromUsername(username);
            int count = dt.Rows.Count;
            HistoryFood[] historyFoods = new HistoryFood[count];
            for (int i = 0; i < count; ++i) {
                historyFoods[i] = new HistoryFood();
                historyFoods[i].history_id = dt.Rows[i]["history_id"].ToString();
                historyFoods[i].time = (DateTime)dt.Rows[i]["time"];
                historyFoods[i].food_id = dt.Rows[i]["food_id"].ToString();
                historyFoods[i].username = dt.Rows[i]["username"].ToString();
            }
            return historyFoods;
        }
    }
}
