﻿using Gallery.Models;
using System.Collections.Generic;

namespace Gallery.Repositories;

public class FakeRepository
{
    public static List<Art> Arts = new()
    {
        new Art() { ImageUrl = @"C:\Users\Hemi_bk15\Source\Repos\Gallery\Gallery\Images\MonaLisa.jpg", Title="Mona Lisa" }
        //new Art() { ImageUrl = "Images/Napoleon.jpeg",Title="Napoleon" },
        //new Art() { ImageUrl = "Images/Scream.jpeg",Title="Scream" }
    };

}