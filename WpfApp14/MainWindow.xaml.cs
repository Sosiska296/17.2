using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace WpfApp14;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private  DispatcherTimer timer;
    private int Light;
    public MainWindow()
    {
        InitializeComponent();
        Light = 0; 
        timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1) 
        };
        timer.Tick += (sender, args) => colorchange();
        timer.Start();
    }
    private void colorchange()
    {
        switch (Light)
        {
            case 0:
                Button1.Background = Brushes.Red;
                Button3.Background = Brushes.Gray;
                break;
            case 1:
                Button1.Background = Brushes.Gray;
                Button2.Background = Brushes.Yellow;
                break;
            case 2:
                Button2.Background =Brushes.Gray;
                Button3.Background =Brushes.Green;
                break;
        }
        Light = (Light + 1) % 3; 
    }
}