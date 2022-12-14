using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public int? Price { get; set; }

    public string? Publisher { get; set; }
}
