using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using Android.Graphics;


namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private TextView textView1;
        private int number = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            textView1 = FindViewById<TextView>(Resource.Id.textView2);
            
            FindViewById<Button>(Resource.Id.buttonIncrease).Click += (o, e) =>
            {
                number += 1;
                textView1.Text = number.ToString();

                if (number < 0)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.White);
                }
                else if (number >= 0 && number <= 10)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Yellow);
                }
                else if (number > 10 && number <= 20)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Green);
                }
                else
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Red);
                }
            };

            FindViewById<Button>(Resource.Id.button2).Click += (o, e) =>
            {
                number -= 1;
                textView1.Text = number.ToString();

                if (number < 0)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.White);
                }
                else if (number >= 0 && number <= 10)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Yellow);
                }
                else if (number > 10 && number <= 20)
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Green);
                }
                else
                {
                    textView1.SetBackgroundColor(Android.Graphics.Color.Red);
                }
            };
        }
    }
}