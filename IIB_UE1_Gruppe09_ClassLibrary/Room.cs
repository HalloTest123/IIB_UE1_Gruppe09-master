using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB_UE1_Gruppe09_ClassLibrary
{
    [Serializable]
    //implements the serializable Class Room

    public class Room
    {
        private int number;
        private string roomType;
        private double roomVolume;
        private double roomArea;
        private double roomFireLoad;
        private double roomFireHazard;
        private BindingList<FireDrencher> fireDrenchers;

        // TODO: HINZUGEFÜGT: Klassenattribut roomFireDamage und roomName
        private double roomFireDamage;
        private string roomName;


        #region constructors
        public Room()
        {
            this.Number = 0;
            this.RoomType = "none";
            this.RoomVolume = 0.0;
            this.RoomFireLoad = 0.0;
            this.RoomFireHazard = 0.0;
            this.FireDrenchers = new BindingList<FireDrencher>();
            this.RoomArea = 0.0;
            this.roomFireDamage = RoomFireDamage;
        }

        public Room(int number, string roomName, string roomType, double roomVolume, double roomFireLoad, double roomFireHazard, BindingList<FireDrencher> fireDrenchers, double roomArea)
        {
            this.Number = number;
            this.RoomType = roomType;
            this.RoomVolume = roomVolume;
            this.RoomFireLoad = roomFireLoad;
            this.RoomFireHazard = roomFireHazard;
            this.FireDrenchers = fireDrenchers;
            this.RoomArea = roomArea;
            this.RoomName = roomName;
            this.roomFireDamage = RoomFireDamage;
        }

        public Room(int number, string roomName, string roomType, double roomVolume, double roomFireLoad, double roomFireHazard, double roomArea)
        {
            this.Number = number;
            this.RoomType = roomType;
            this.RoomVolume = roomVolume;
            this.RoomFireLoad = roomFireLoad;
            this.RoomFireHazard = roomFireHazard;
            this.FireDrenchers = fireDrenchers;
            this.RoomArea = roomArea;
            this.roomFireDamage = RoomFireDamage;
        }
        #endregion

        //Start of Methods
        public double calculateFireDamage()
        {
            //Calculates the total potential Fire Damage
            double fireDamage = 0.0;
            if (this.RoomType == "1-Wohnen und Aufenthalt")
            {
                fireDamage = 390 * RoomArea;
            }
            else if (this.RoomType == "2-Büroarbeit")
            {
                fireDamage = 420 * roomArea;
            }
            else if (this.RoomType == "3-Produktion, Hand- und Maschinenarbeit, Experimente")
            {
                fireDamage = 1200 * roomArea;
            }
            else if (this.RoomType == "4-Lagern, Verteilen und Verkaufen")
            {
                fireDamage = 800 * roomArea;
            }
            else if (this.RoomType == "5-Bildung, Unterricht und Kultur")
            {
                fireDamage = 285 * roomArea;
            }
            else if (this.RoomType == "6-Heilen und Pflegen")
            {
                fireDamage = 230 * roomArea;
            }
            else if (this.RoomType == "7-Sonstige Nutzungen")
            {
                fireDamage = 555 * roomArea;
            }
            else
            {
                fireDamage = 0.0;
            }
            return fireDamage;
        }

        //ADDED METHODS calculateNeededFireDrencherVolume(), calculateExistingFireDrencherVolume() and ToString()

        public int calculateNeededFireDrencherVolume()
        {
            //Calculates the needed extinguishing agent volume for this room based on the fire damage    

            int extinguishingAgentVolume = 0;

            if (roomFireDamage <= 12000)
            {
                extinguishingAgentVolume = 0;
            }
            else if (roomFireDamage > 12000 && roomFireDamage <= 20000)
            {
                extinguishingAgentVolume = 3;
            }
            else
            {
                extinguishingAgentVolume = (int)Math.Round(roomFireDamage / 10000 * 3);
            }

            return extinguishingAgentVolume;
        }

        public int calculateExistingFireDrencherVolume()
        {
            //Calculates the currently existing FireDrencherVolume in the Room
            int existingFireDrencherVolume = 0;
            foreach (FireDrencher fireDrencher in fireDrenchers)
            {
                existingFireDrencherVolume += fireDrencher.Capacity;
            }
            return existingFireDrencherVolume;
        }

        public override string ToString()
        {
            return "Raum: " + number + ": " + RoomName;
        }

        //Start of Property-Methods
        #region propertyMethods
        public int Number { get => number; set => number = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public double RoomVolume { get => roomVolume; set => roomVolume = value; }
        public double RoomFireLoad { get => roomFireLoad; set => roomFireLoad = value; }
        public double RoomFireHazard { get => roomFireHazard; set => roomFireHazard = value; }
        public BindingList<FireDrencher> FireDrenchers { get => fireDrenchers; set => fireDrenchers = value; }
        public double RoomArea { get => roomArea; set => roomArea = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public int CountFireDrencher 
        {
            get
            {
                int countFireDrencher = 0;
                foreach(FireDrencher fd in fireDrenchers)
                {
                    countFireDrencher++;
                }
                return countFireDrencher;
            }           
        }

        public double TotalPricePerRoom
        {
            get
            {
                double totalPrice = 0.0;
                foreach(FireDrencher fd in fireDrenchers)
                {
                    totalPrice += fd.Price;
                }
                return totalPrice;
            }
        }

        public double RoomFireDamage { get => calculateFireDamage(); }
        #endregion
    }
}
