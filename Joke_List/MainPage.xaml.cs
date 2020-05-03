using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joke_List.Models;
using Xamarin.Forms;

namespace Joke_List
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
 
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            jokes.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void Add_Clicked(System.Object sender, System.EventArgs e)
        {


            if (!string.IsNullOrEmpty(jokeContent.Text))
            {
                JokeItem jokeItem = new JokeItem
                {
                    JokeContent = jokeContent.Text
                };
                await App.Database.SaveItemAsync(jokeItem);
                OnAppearing();
                jokeContent.Text = null;
                
            }
            else
            {
                await DisplayAlert("Um, Hello?","Your joke makes no sense", "my bad");
            }
           
            

        }

        async void Delete_Clicked(System.Object sender, System.EventArgs e)
        {

            var button = (Button)sender;
            if(button.CommandParameter != null)
            {
                var jokeItem = (JokeItem)button.CommandParameter;
                await App.Database.DeleteItemAsync(jokeItem);
                await DisplayAlert("Success!", "Item Deleted", "OK");
                OnAppearing();
            }
           
           
        }
    }
}
