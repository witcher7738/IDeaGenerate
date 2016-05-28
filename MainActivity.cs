using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using WordGenerator;

namespace WeatherApp
{
    [Activity(Label = "WeatherApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        WordGenerator Words;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            var words = new List<string>(){ "word", "anotherword", "test", "testest"};
            Words = new WordGenerator(words);
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0}", Words.GenerateWord()); };
        }
    }
}

