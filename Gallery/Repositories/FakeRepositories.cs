using Gallery.Models;
using System.Collections.Generic;

namespace Gallery.Repositories;

public class FakeRepository
{
    public static List<Art> Arts = new()
    {
        new Art() { ImageUrl = @"C:\Users\LEGION\Source\Repos\Gallery\Gallery\Images\MonaLisa.jpg", Title="Mona Lisa" },
        new Art() { ImageUrl = @"C:\\Users\\LEGION\\Source\\Repos\\Gallery\\Gallery\\Images\\Napoleon.jpg",Title="Napoleon" },
        new Art() { ImageUrl = @"C:\Users\LEGION\Source\Repos\Gallery\Gallery\Images\Scream.jpeg",Title="Scream" }
    };

}