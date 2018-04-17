using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Logger;
using InstaSharper.Examples;


namespace Mark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static IInstaApi _instaApi;

        public MainWindow()
        {
            InitializeComponent();
        }

        //public static async Task<bool> MainAsync()
        //{
        //    try
        //    {
        //        Console.WriteLine(@"Starting demo of InstaSharper project");
        //        // create user session data and provide login details
        //        var userSession = new UserSessionData
        //        {
        //            UserName = "username",
        //            Password = "password"
        //        };

        //        var delay = RequestDelay.FromSeconds(2, 2);
        //        // create new InstaApi instance using Builder
        //        _instaApi = InstaApiBuilder.CreateBuilder()
        //            .SetUser(userSession)
        //            .UseLogger(new DebugLogger(LogLevel.All)) // use logger for requests and debug messages
        //            .SetRequestDelay(delay)
        //            .Build();

        //        const string stateFile = "state.bin";
        //        try
        //        {
        //            if (File.Exists(stateFile))
        //            {
        //                Console.WriteLine(@"Loading state from file");
        //                using (var fs = File.OpenRead(stateFile))
        //                {
        //                    _instaApi.LoadStateDataFromStream(fs);
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    finally
        //    {
        //        // perform that if user needs to logged out
        //        // var logoutResult = Task.Run(() => _instaApi.LogoutAsync()).GetAwaiter().GetResult();
        //        // if (logoutResult.Succeeded) Console.WriteLine("Logout succeed");
        //    }
        //    return false;
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await InstaSharper.Examples.Program.MainAsync();
        }
    }
}
