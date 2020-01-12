using System;

using Xamarin.Forms;

namespace LayoutExample
{
    public class StatcklayouEx1 : ContentPage
    {
        public StatcklayouEx1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

