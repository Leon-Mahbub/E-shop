using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
        
            new Candy {CandyId = 1, Name = "Assoeted Hard Candy", Price = 4.9M, Description= "sugar-free assorted chocolate hard candy includes chocolate, chocolate raspberry, chocolate mint and chocolate almond flavors. " +
                "Individually wrapped hard candies suitable for snacking or display. Sugar-free chocolate hard candies are a tasty treat for anyone watching their weight or sugar intake.",
            Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl ="https://upload.wikimedia.org/wikipedia/commons/1/13/HardCandy.jpg",
            IsInstock= true, IsOnSale= false, ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/1231px-HardCandy.jpg"},

            new Candy {CandyId = 2, Name = "Assoeted Chocolate Candy", Price = 5.9M, Description= "Chocolate is a food product made from roasted and ground cacao pods, that is available as a liquid, solid or paste, on its own or as a flavoring agent in other foods. Cacao has been consumed in some form since at least the Olmec civilization (19th-11th century BCE),[1][2] and the majority of Mesoamerican people - " +
                "including the Maya and Aztecs - made chocolate beverages.",
            Category = _categoryRepository.GetAllCategories.ToList()[1], ImageUrl ="https://en.wikipedia.org/wiki/File:Chocolate_(blue_background).jpg",
            IsInstock= true, IsOnSale= false, ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg"},

            new Candy {CandyId = 3, Name = "Assoeted Fruit Candy", Price = 6.9M, Description= "Top-selling chocolates and sweets. Reese's Peanut Butter Cups are the No. 1 selling candy brand in the United States, consisting of white fudge, milk," +
                " or dark chocolate cups filled with peanut butter",
            Category = _categoryRepository.GetAllCategories.ToList()[2], ImageUrl ="https://en.wikipedia.org/wiki/Candy#/media/File:Candy_in_Damascus.jpg",
            IsInstock= true, IsOnSale= true, ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Candy_in_Damascus.jpg/250px-Candy_in_Damascus.jpg"}

        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
