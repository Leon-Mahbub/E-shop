﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Hard Candy", CategoryDesctiption="Awsome and Delicious Hard Candy"},
            new Category{CategoryId=2, CategoryName="Chocolate Candy", CategoryDesctiption="Scuptious Chocolate Candy"},
            new Category{CategoryId=3, CategoryName="Fruit", CategoryDesctiption="Sweet and Sour Frout Candy"}
        };
    }
}
