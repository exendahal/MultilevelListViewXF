using MultilevelListViewXF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultilevelListViewXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            createCollection();
        }
        void createCollection()
        {
            List<productClass> list = new List<productClass>() {
            new productClass("Noodles")
            {
                new ProductSubClass("Wai Wai")
                {
                    new productModel(){name="Wai Wai Quick", quantity="5"},
                    new productModel(){name="Wai Wai MG", quantity="4"},
                    new productModel(){name="Wai Wai Veg", quantity="6"},
                    new productModel(){name="Wai Wai Instant", quantity="2"}
                },
                new ProductSubClass("Rum Pum")
                {
                    new productModel(){name="Rum Pum Nooddles", quantity="4"},
                    new productModel(){name="Rum Pum Veg", quantity="5"},
                    new productModel(){name="Cookies", quantity="9"},
                }
            },new productClass("Oil")
            {
                new ProductSubClass("Dhara")
                {
                    new productModel(){name="Dhara Mustard", quantity="1"},
                    new productModel(){name="Dhara Sunflower", quantity="5"},
                   
                },
                new ProductSubClass("Cello")
                {
                    new productModel(){name="Cello Mustard", quantity="3"},
                    new productModel(){name="Cello Sunflower", quantity="4"},
                }

            }
            };
            BindableLayout.SetItemsSource(listView,list);
        }
    }
}
