using System;
using Joke_List.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Joke_List
{
    public partial class App : Application
    {
        static JokeItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static JokeItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new JokeItemDatabase();
                }


                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
