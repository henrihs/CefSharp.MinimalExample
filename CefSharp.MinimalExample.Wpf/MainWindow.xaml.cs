using System.IO;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnIsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!Browser.IsBrowserInitialized) return;
            
            var html = File.ReadAllText("./select.html");
            Browser.LoadHtml(html);
        }
    }
}
