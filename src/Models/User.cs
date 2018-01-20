using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Constants.ModelConstants;

namespace Models
{
    public class User
    {
        public ObjectId _id { get; set; }
        public Personal PersonalInfo { get; set; }
        public Account AccountInfo { get; set; }
        public Fraud FraudInfo { get; set; }
        public Money Money { get; set; }        
        public int TotalPayouts { get; set; }        
        public AgeGroup AgeGroup { get; set; }
    }
}
