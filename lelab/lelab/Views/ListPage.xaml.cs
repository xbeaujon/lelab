using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    public class Article
    {
        public string Nom { get; set; }
        public string Prix { get; set; }
        public string Description { get; set; }

    }
    public partial class ListPage : ContentPage
    {
        List<Article> articles;
        public ListPage()
        {
            InitializeComponent();
            articles = new List<Article>();
            articles.Add(new Article { Nom = "Lait", Prix = "4€", Description = "Pack de lait" });
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.5€", Description = "70% de cacao" });
            articles.Add(new Article { Nom = "Pain", Prix = "2€", Description = "Des baguettes" });
            articles.Add(new Article { Nom = "Beurre", Prix = "1.2€", Description = "Demi-sel" });

            maListView.ItemsSource = articles;

            maListView.ItemSelected += (sender, e) =>
            {
                if (maListView.SelectedItem != null)
                {
                    Article item = maListView.SelectedItem as Article;
                    DisplayAlert(item.Nom, item.Description, "OK");
                    maListView.SelectedItem = null;
                }
            };
        }
    }
}