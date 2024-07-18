using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace AppBarTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CloseBtn_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void AppBar_OnFullScreenStateChanged(object sender, bool e)
    {
        Debug.WriteLine("Full Screen State: "+e);
        Visibility = e ? Visibility.Collapsed : Visibility.Visible;
    }

    private void SelectFlag(object sender, RoutedEventArgs e)
    {
        appBar.Location = (sender as Button).Content.ToString() switch {
            "Top" => AppBarLocation.Top,
            "Bottom" => AppBarLocation.Bottom,
            "Left" => AppBarLocation.Left,
            "Right" => AppBarLocation.Right,
            "RegisterOnly"=> AppBarLocation.RegisterOnly,
            _ => AppBarLocation.None
        };
    }

    private void OneMore_Click(object sender, RoutedEventArgs e)
    {
        new MainWindow() {Title="Window AWA"}.Show();
    }
}
