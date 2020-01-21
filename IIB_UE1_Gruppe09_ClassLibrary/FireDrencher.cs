using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB_UE1_Gruppe09_ClassLibrary
{
    [Serializable]
    //implements the serializable Class FireDrencher
    public class FireDrencher
    {
        double price;
        int capacity;
        string fireClass;

        public FireDrencher(int capacity, string fireClass)
        {
            Capacity = capacity;
            FireClass = fireClass;
            this.price = Price;
        }

        //ADDED METHOD setPrice() and ToString()

        public static double setPrice(int capacity)
        {
            if (capacity == 3)
            {
                return 33.99;
            }
            else if (capacity == 6)
            {
                return 42.99;
            }
            else if (capacity == 9)
            {
                return 49.99;
            }
            else if (capacity == 12)
            {
                return 59.99;
            }
            else
            {
                return 0.0;
            }
        }

        public override string ToString()
        {
            return "Brandklasse: " + fireClass + " Kapazität: " + capacity + "L" + " Preis: " + price +"€";
        }


        #region propertyMethods
        public double Price { get => setPrice(Capacity); }
        public int Capacity { get => capacity; set => capacity = value; }
        public string FireClass { get => fireClass; set => fireClass = value; }
        #endregion
    }
}
