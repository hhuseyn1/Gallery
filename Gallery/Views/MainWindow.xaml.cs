using Gallery.Models;
using Gallery.Repositories;
using Gallery.User_Control;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Gallery.Views;

public partial class MainWindow : Window
{
    public ObservableCollection<Art> Images { get; set; } = new();
    public MainWindow()
    {
        InitializeComponent();

        for (int i = 0; i < FakeRepository.Arts.Count; i++)
        {
            Images.Add(FakeRepository.Arts[i]);
        }
        for (int i = 0; i < Images.Count; i++)
        {
            BitmapImage image = new BitmapImage(new Uri($"{Images[i].ImageUrl}", UriKind.Absolute));
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.Freeze();
            UC_art art = new(Images[i],image);
            itms.Items.Add(art);
        }

    }

    private void SearchClick(object sender, RoutedEventArgs e)
    {
        foreach (var item in FakeRepository.Arts)
        {
            if (SearchBox.Text == item.Title)
            {
                BitmapImage image = new BitmapImage(new Uri($"{item.ImageUrl}", UriKind.Absolute));
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.Freeze();
                UC_art art = new(item, image);
                itms.Items.Clear();
                itms.Items.Add(art);
            }
        }
    }

    private void FileClick(object sender, RoutedEventArgs e)
    {
        if (sender is MenuItem menu)
        {
            switch (menu.Header)
            {
                case "Save":
                    MessageBox.Show("Saved Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case "New":
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Title = "Select Image";
                    openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                    if (openFileDialog1.ShowDialog() == true)
                    {

                        Images.Add(new Art()
                        {
                            Title = openFileDialog1.Title,
                            ImageUrl = openFileDialog1.FileName
                        });
                        itms.Items.Add(new Art()
                        {
                            Title = openFileDialog1.Title,
                            ImageUrl = openFileDialog1.FileName
                        });
                    }
                    break;
                default:
                    break;
            }
        }

    }
}