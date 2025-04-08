using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Framework4.Core
{
    public class ArticleService
    {
        public List<Article> GetListOfArticles()
        {
            var dataFaker = new Faker<Article>("fr")
                .RuleFor(p => p.Id, f => f.UniqueIndex)
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price()))
            .RuleFor(p => p.ProductDescription, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.Ean13, f => f.Commerce.Ean13());
            List<Article> data = dataFaker.Generate(50);
            return data;
        }


    }
}
