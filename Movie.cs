using System;
using System.Collections.Generic;

namespace DbFirstApproach.models;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime ReleasedDate { get; set; }

    public string Genre { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Desciption { get; set; }
}
