using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Day2_Xamarin_ITI.Models
{
    public class Meal
    {
        [PrimaryKey, MaxLength(100)]
        public string Name { get; set; }

        public string Image { get; set; }

        [NotNull]
        public decimal Price { get; set; }

    }
}
