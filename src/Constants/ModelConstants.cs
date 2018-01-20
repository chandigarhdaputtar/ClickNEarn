using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public class ModelConstants
    {
        public enum Gender
        {
            Male,
            Female,
            Others
        }
        public enum AgeGroup
        {
            UnderAged, //0-12
            Teenager,  //13-18
            Adult,     //19-25
            Mature,    //26-40
            OverAged   //40 and above
        }
        public enum Title
        {
            Mr,
            Mrs,
            Ms,
            Master
        }
    }
}
