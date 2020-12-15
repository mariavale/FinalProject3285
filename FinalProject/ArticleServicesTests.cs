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
            var service = new ArticleService();
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
        public void TestArticleDescriptionCreation()
        {
            //Arrange
            var service = new ArticleService();
            string[] articleStuff = { "red shirt", "Shirt", "warm" };
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), articleStuff[1].ToString());
            //Act
            service.CreateArticle(articleStuff[0], type, articleStuff[2]);
            Article testObj = new Shirt("red shirt", "warm");
            articlesDictionary = service.GetArticles();
            //Assert
            Assert.AreEqual(testObj.Description, articlesDictionary.ElementAt(0).Value.Description);
        }


    }
}
