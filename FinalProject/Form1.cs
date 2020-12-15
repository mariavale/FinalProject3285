using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        IArticleServices aService = new ArticleServices();

        List<string> shirts = new List<string>();
        List<string> pants = new List<string>();
        List<string> footwears = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string articleName = ArticleTextBox.Text;
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), TypeComboBox.SelectedItem.ToString());
            ClosetListBox.Items.Add(articleName);
            string description = " ";

            if (warmCheckBox.Checked)
            {
                description = "warm";
            } else if(coldCheckBox.Checked)
            {
                description = "cold";
            } 
            aService.CreateArticle(articleName, type, description);
            DescriptionListBox.Items.Add(description);
            TypeListBox.Items.Add(type);


            switch (type)
            {
                case ArticleType.Shirt:
                    shirts.Add(articleName);
                    break;
                case ArticleType.Pants:
                    pants.Add(articleName);
                    break;
                case ArticleType.Footwear:
                    footwears.Add(articleName);
                    break;
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {

            if (tempComboBox.SelectedIndex == 2)
            {
                findArticles(aService.getWarmArticles(shirts), aService.getWarmArticles(pants), aService.getWarmArticles(footwears));
            }
            else if (tempComboBox.SelectedIndex == 1)
            {
                findArticles(aService.getColdArticles(shirts), aService.getColdArticles(pants), aService.getColdArticles(footwears));
            }
            else
            {
                findArticles(shirts, pants, footwears);
            }
        }

        public void findArticles(List<string> shirts, List<string> pants, List<string> footwears)
        {
            if (shirts.Count == 0)
            {
                ShirtTextBox.Text = "You have no shirts";
            }
            else
            {
                Random r = new Random();
                int rInt = r.Next(0, shirts.Count);
                ShirtTextBox.Text = shirts.ElementAt(rInt);
            }
            if (pants.Count == 0)
            {
                PantsTextBox.Text = "You have no pants";
            }
            else
            {
                Random r = new Random();
                int rInt = r.Next(0, pants.Count);
                PantsTextBox.Text = pants.ElementAt(rInt);
            }
            if (footwears.Count == 0)
            {
                FootwearTextBox.Text = "You have no footwear";
            }
            else
            {
                Random r = new Random();
                int rInt = r.Next(0, footwears.Count);
                FootwearTextBox.Text = footwears.ElementAt(rInt);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
