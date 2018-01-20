using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Advertisement
    {
        public ObjectId _id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double PricePerClick { get; set; }
        public int PurchasedClicks { get; set; }
        public int RemainingClicks { get; set; }
        public string SupplierId { get; set; }
    }
}
