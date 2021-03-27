﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public DateTime ModelYear { get; set; }
        public string Description { get; set; }
        public Double DailyPrice { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
    }
}