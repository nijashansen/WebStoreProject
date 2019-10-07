﻿using System;

namespace Core.Entity
{
    public class Clothing
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public ClothesTypes ClothesTypes { get; set; }
        public string ClothingName { get; set; }
        public string ClothingInformation { get; set; }
    }
}