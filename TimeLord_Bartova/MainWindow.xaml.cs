using System.Windows;

namespace TimeLord_Bartova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPages(Pages.Stopwatch);
        }
        public enum Pages
        {
            Stopwatch
        }
        public void OpenPages(Pages pages) { 
            if(pages == Pages.Stopwatch)
            {
                frame.Navigate(new TimeLord_Bartova.Pages.Stopwatch());
            }
        }
    }
}
