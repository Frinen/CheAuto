using System;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public  class UserOrder : Entity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }

        public AvailableCar AvailableCar { get; set; }
        public Guid AvailableCarId { get; set; }

        public int Count { get; set; }
    }
}
