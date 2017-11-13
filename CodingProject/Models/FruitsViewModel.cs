using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingProject.Models
{
    public class FruitsViewModel
    {
        private readonly List<string> _fruitList = new List<string>
                                {
                                    "orange","mango","orange","mango","mango","mango","mango","mango","mango",
                                    "apple","grapes","banana","banana","mango","mango","mango","mango","mango",
                                    "grapes","watermelon","watermelon","mango","mango","mango","mango","mango",
                                    "apple","watermelon","watermelon","pomegranate","pomegranate","pomegranate",
                                    "red apples","red apples","red apples","pomegranate","pomegranate","pomegranate",
                                    "apple","pomegranate","pomegranate","pomegranate","pomegranate","pomegranate",
                                    "pineapple","pineapple","pineapple","pineapple","pineapple","pineapple",
                                    "apple","banana","banana","banana","watermelon","watermelon","watermelon",
                                    "grapes","grapes","grapes","banana","watermelon","watermelon","watermelon",
                                    "kiwi","kiwi","kiwi","kiwi","banana","watermelon","watermelon","watermelon",
                                    "pomegranate","strawberries","strawberries","strawberries","strawberries",
                                    "watermelon","apple","apple","apple","apple","apple","apple","apple"
                                };
        /// <summary>
        /// Gets fruit collection including top 10 with their count
        /// </summary>
        /// <returns>Fruits Model</returns>
        public FruitsModel GetFruits()
        {
            var fruits = new FruitsModel();
            var fruitsLookup = _fruitList.ToLookup(x => x);
            fruits.TotalFruits = _fruitList.Count;
            fruits.FruitsCollection = fruitsLookup.ToDictionary(fruit => fruit.Key, fruit => fruit.Select(x => x).Count());
            return fruits;
        }
    }
}