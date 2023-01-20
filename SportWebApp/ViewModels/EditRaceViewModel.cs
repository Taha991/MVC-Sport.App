﻿using SportWebApp.Data.Enum;
using SportWebApp.Models;

namespace SportWebApp.ViewModels
{
    public class EditRaceViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile Image { get; set; }
        public string? URL { get; set; }
        public int AdressId { get; set; }   
        public Address Address { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}
