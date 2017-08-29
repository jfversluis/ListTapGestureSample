using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListTapGetureSample
{
    public class Foo 
    {
        public string Bar { get; set; }
    }

    public partial class ListTapGetureSamplePage : ContentPage
    {
        public ObservableCollection<Foo> Items { get; set; } = new ObservableCollection<Foo>();

        public Command TapCommand => new Command<Foo>((fooObject) => Tapped(fooObject));

        private void Tapped(Foo fooObject)
        {
            DisplayAlert("Tapped!", fooObject.Bar, "Gotcha");
        }

        public ListTapGetureSamplePage()
        {
            InitializeComponent();

            Items.Add(new Foo
            {
                Bar = "1"
            });

			Items.Add(new Foo
			{
				Bar = "2"
			});

			Items.Add(new Foo
			{
				Bar = "3"
			});

			Items.Add(new Foo
			{
				Bar = "4"
			});

			Items.Add(new Foo
			{
				Bar = "5"
			});

            BindingContext = this;
        }
    }
}
