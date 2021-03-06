﻿using System;
using System.Collections.Generic;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public class AvailableCar : Entity
    {
        public Guid DealerId { get; set; }
        public Dealer Dealer { get; set; }

        public Guid CarModelId { get; set; }
        public CarModel CarModel { get; set; }

        public List<UserOrder> UserOrders { get; set; } = new List<UserOrder>();

        public DateTime AvailableFrom { get; set; }
        public double Discount { get; set; }
        public int Count { get; set; }

    }
}
