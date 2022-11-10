using Gallery.Models;
using Gallery.Views;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Gallery.User_Control;

public partial class UC_art : UserControl
{
    public string title;
    public Art Art { get; set; }
    public UC_art(Art art,BitmapImage image)
    {
        InitializeComponent();
        DataContext = this;
        Art = art;
        title = art.Title;
    }

    private void ArtImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        ShowWindow show = new(Art);
        show.ShowDialog();
        if (Art.IsChanged == false)
        {
            Art.Title = title;
        }

    }
}
