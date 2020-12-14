using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface IArticleServices
    {
        void CreateArticle(string articleName, ArticleType articleType, string description);

        Dictionary<string, Article> GetArticles();

        List<String> getWarmArticles(List<String> articles);

        List<String> getColdArticles(List<String> articles);
    }
}
