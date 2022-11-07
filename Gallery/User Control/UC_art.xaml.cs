using Gallery.Models;
using Gallery.Views;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Gallery.User_Control;

public partial class UC_art : UserControl
{
    public UC_art(Art art,BitmapImage image)
    {
        InitializeComponent();
        ArtImage.Source=image;
        ArtTitle.Text = art.Title;
    }

    private void ArtImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        ShowWindow show = new();
        show.Show();
    }
}
