using Gallery.Models;
using System.Windows;
using System.Windows.Controls;

namespace Gallery.Views;

public partial class ShowWindow : Window
{
    public Art CurrentArt { get;set; }
    public ShowWindow(Art art)
    {
        InitializeComponent();
        DataContext = this;
        CurrentArt = art;
    }

    private void PrevNext(object sender, RoutedEventArgs e)
    {
        if(sender is Button btn)
        {
            if (btn.Name == "Save")
            {
                CurrentArt.Title = ArtTitle.Text;
                CurrentArt.IsChanged= true;
            }
            else if (btn.Name == "Cancel")
            {
                CurrentArt.IsChanged= false;
            }
            Close();
        }
    }
}
