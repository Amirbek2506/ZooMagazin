﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooMag.ViewModels;

namespace ZooMag.Models.ViewModels.Products
{
    public class OutProductModel
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
        public string DiscriptionEn { get; set; }
        public string DiscriptionRu { get; set; }
        public string ShortDiscriptionEn { get; set; }
        public string ShortDiscriptionRu { get; set; }
        public string ColorEn { get; set; }
        public string ColorRu { get; set; }
        public int CategoryId { get; set; }
        public int MeasureId { get; set; }
        public double Weight { get; set; }
        public bool IsNew { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsSale { get; set; }
        public DateTime SaleStartDate { get; set; }
        public DateTime SaleEndDate { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public List<ProductImagesModel> Images { get; set; }
        public List<SizeModel> Sizes { get; set; }
    }
}
