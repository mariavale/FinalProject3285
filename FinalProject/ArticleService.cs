using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ArticleService : IArticleServices
    {
        private Dictionary<string, Article> articlesDictionary;

        public ArticleService()
        {
            //instantiate the dictionary for articles
            articlesDictionary = new Dictionary<string, Article>();
        }

        public void CreateArticle(string articleName, ArticleType articleType, string description)
        // create a new article
        {
            ArticleType type = articleType;
            Article newArticle;
            newArticle = Article.CreateArticle(articleType, description);
            newArticle.Description = description;
            articlesDictionary.Add(articleName, newArticle);
        }

        public Dictionary<string, Article> GetArticles()
        {
            return articlesDictionary;
        }

        public List<String> getWarmArticles(List<String> articles)
        {
            List<String> warmList = new List<string>();
            for(int i = 0; i < articlesDictionary.Count; i++)
            {
                if(articles.Contains(articlesDictionary.ElementAt(i).Key) && articlesDictionary.ElementAt(i).Value.Description == "warm")
                {
                    warmList.Add(articlesDictionary.ElementAt(i).Key);
                }
            }

            return warmList;
        }

        public List<String> getColdArticles(List<String> articles)
        {
            List<String> coldList = new List<string>();
            for (int i = 0; i < articlesDictionary.Count; i++)
            {
                if (articles.Contains(articlesDictionary.ElementAt(i).Key) && articlesDictionary.ElementAt(i).Value.Description == "cold")
                {
                    coldList.Add(articlesDictionary.ElementAt(i).Key);
                }
            }

            return coldList;
        }

    }
}
