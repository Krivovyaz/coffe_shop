﻿namespace NLayerApp.DLL.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        
        public int ProductTypeId { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }
        
        public int Weight { get; set; }
        public double Price { get; set; }
        
        public string ImageURL { get; set; }
    }
}