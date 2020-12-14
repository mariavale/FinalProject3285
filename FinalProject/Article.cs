using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Article
    {
        public static Article CreateArticle(ArticleType type, string description)
        {
            Article article = null;
            switch (type)
            {
                case ArticleType.Shirt:
                    article = new Shirt();
                    break;
                case ArticleType.Pants:
                    article = new Pants();
                    break;
                case ArticleType.Footwear:
                    article = new Footwear();
                    break;
            }
            article.Description = description;
            return article;
        }
        public virtual string Description { get; set; }

        public virtual string GetDescription()
        {
            return this.Description;
        }
    }
}
