﻿using System;
using Newtonsoft.Json;

namespace CarouselView.Models
{
    public class Monkey
    {
        public string FullName => "Mister";

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("Location")] public string Location { get; set; }

        [JsonProperty("Details")] public string Details { get; set; }

        [JsonProperty("Image")] public Uri Image { get; set; }

        [JsonProperty("Population")] public long Population { get; set; }

        [JsonProperty("Latitude")] public double Latitude { get; set; }

        [JsonProperty("Longitude")] public double Longitude { get; set; }
    }
}