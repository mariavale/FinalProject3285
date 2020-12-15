using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Tests
{
    [TestClass()]
    public class ArticleServicesTest
    {
        private Dictionary<string, Article> articlesDictionary;

        [TestMethod()]
        public void TestArticleNameCreation()
        {
            //Arrange
            var service = new ArticleServices();
            string[] articleStuff = { "red shirt", "Shirt", "warm" };
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), articleStuff[1].ToString());
            //Act
            service.CreateArticle(articleStuff[0], type, articleStuff[2]);
            Article testObj = new Shirt("red shirt", "warm");
            articlesDictionary = service.GetArticles();
            //Assert
            Assert.AreEqual(testObj.Name, articlesDictionary.ElementAt(0).Value.Name);
        }

        [TestMethod()]
        public void TestArticleTypeCreation()
        {
            //Arrange
            var service = new ArticleServices();
            string[] articleStuff = { "red shirt", "Shirt", "warm" };
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), articleStuff[1].ToString());
            //Act
            service.CreateArticle(articleStuff[0], type, articleStuff[2]);
            articlesDictionary = service.GetArticles();
            //Assert
            Assert.AreEqual(type, articlesDictionary.ElementAt(0).Value.Type);
        }

        [TestMethod()]
        public void TestArticleDescriptionCreation()
        {
            //Arrange
            var service = new ArticleServices();
            string[] articleStuff = { "red shirt", "Shirt", "warm" };
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), articleStuff[1].ToString());
            //Act
            service.CreateArticle(articleStuff[0], type, articleStuff[2]);
            Article testObj = new Shirt("red shirt", "warm");
            articlesDictionary = service.GetArticles();
            //Assert
            Assert.AreEqual(testObj.Description, articlesDictionary.ElementAt(0).Value.Description);
        }

        [TestMethod()]
        public void TestGetWarmArticles()
        {
            //Arrange
            var service = new ArticleServices();
            ArticleType shirt = (ArticleType)Enum.Parse(typeof(ArticleType), "Shirt");
            ArticleType pants = (ArticleType)Enum.Parse(typeof(ArticleType), "Pants");

            //Act
            service.CreateArticle("red shirt", shirt, "warm");
            service.CreateArticle("blue shirt", shirt, "cold");
            service.CreateArticle("green pants", pants, "warm");
            articlesDictionary = service.GetArticles();

            List<string> articles = new List<string>();
            articles.Add("red shirt");
            articles.Add("blue shirt");
            articles.Add("green pants");
            //Assert
            Assert.AreEqual(service.getWarmArticles(articles).ElementAt(0), articles.ElementAt(0));
            Assert.AreEqual(service.getWarmArticles(articles).ElementAt(1), articles.ElementAt(2));
        }

        [TestMethod()]
        public void TestGetColdArticles()
        {
            //Arrange
            var service = new ArticleServices();
            ArticleType shirt = (ArticleType)Enum.Parse(typeof(ArticleType), "Shirt");
            ArticleType pants = (ArticleType)Enum.Parse(typeof(ArticleType), "Pants");

            //Act
            service.CreateArticle("red shirt", shirt, "warm");
            service.CreateArticle("blue shirt", shirt, "cold");
            service.CreateArticle("green pants", pants, "warm");
            articlesDictionary = service.GetArticles();

            List<string> articles = new List<string>();
            articles.Add("red shirt");
            articles.Add("blue shirt");
            articles.Add("green pants");
            //Assert
            Assert.AreEqual(service.getColdArticles(articles).ElementAt(0), articles.ElementAt(1));
        }
    }
}
