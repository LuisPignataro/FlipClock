using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomControl
{
    public class FlipDigit: ContentView
    {
        Image up = new Image();
        Image down = new Image();
        Grid grid = new Grid();

        public FlipDigit()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            Grid.SetRow(up, 0);
            Grid.SetRow(down, 1);

            grid.Children.Add(up);
            grid.Children.Add(down);
            up.Source = ImageSource.FromFile("up_0");
            down.Source = ImageSource.FromFile("down_0");
            Content = grid;
        }
        public static readonly BindableProperty TextProperty =
              BindableProperty.Create (nameof(Text), typeof(string), typeof(FlipDigit),  propertyChanged: OntextChange);

        private static void OntextChange(BindableObject bindable, object oldValue, object newValue)
        {
            throw new NotImplementedException();
        }

        public string Text {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}
