using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountPage : ContentPage
    {
        int count = 0;
        public CountPage()
        {
            InitializeComponent();
        }

        private void CountButtonClicked(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
        }

    }
}