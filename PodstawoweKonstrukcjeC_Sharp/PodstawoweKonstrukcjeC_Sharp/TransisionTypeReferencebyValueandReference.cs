using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class TransisionTypeReferencebyValueandReference
    {
        public string name;
        public int years;

        public  void changePersonvalue(TransisionTypeReferencebyValueandReference transision)
        {
            // transision.years = 22;
            //transision.name = "rafal";
            TransisionTypeReferencebyValueandReference transision1 = new TransisionTypeReferencebyValueandReference();
             transision1.years = 22;
             transision1.name = "rafal";
             transision = transision1;

        }


    }
}
