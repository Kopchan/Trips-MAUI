using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using AndroidX.Core.View;

namespace MyProjects
{
    [Activity(
        Theme = "@style/Maui.SplashTheme", 
        MainLauncher = true, 
        ConfigurationChanges = 
            ConfigChanges.ScreenSize
          | ConfigChanges.Orientation 
          | ConfigChanges.UiMode 
          | ConfigChanges.ScreenLayout 
          | ConfigChanges.SmallestScreenSize 
          | ConfigChanges.Density
    )] public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var configuration = Resources.Configuration;
            var currentNightMode = configuration.UiMode & UiMode.NightMask;

            ColorDrawable cd;
            if (currentNightMode == UiMode.NightYes)
            {
                cd = new(Android.Graphics.Color.Argb(255, 28, 28, 28));
            }
            else
            {
                cd = new(Android.Graphics.Color.Argb(255, 255, 255, 255));
                WindowInsetsControllerCompat windowInsetsController = new(Window, Window.DecorView);
                //Window.SetNavigationBarColor(Android.Graphics.Color.Transparent);
                Window.SetNavigationBarColor(Android.Graphics.Color.Argb(255, 238, 204, 115));
                windowInsetsController.AppearanceLightStatusBars = true;
            }
            Window.SetDecorFitsSystemWindows(false);
            Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
            Window.SetBackgroundDrawable(cd);
        }
    }
}
