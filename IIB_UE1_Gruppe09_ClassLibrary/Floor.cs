using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB_UE1_Gruppe09_ClassLibrary
{
    [Serializable]
    //implements the serializable Class Floor
    public class Floor
    {
        private string Id;
        private string name;
        private int floorNumber;
        private double floorArea;
        private BindingList<Room> rooms;

        #region constructors


        public Floor(string name, BindingList<Room> rooms)
        {
            this.name = name;
            this.Rooms = rooms;
            this.FloorArea = calculateFloorArea();
            this.Id = id;
        }

        public Floor(int floorNumber, BindingList<Room> rooms)
        {
            this.FloorNumber = floorNumber;
            this.Rooms = rooms;
            this.FloorArea = calculateFloorArea();
        }

        public Floor(int floorNumber)
        {
            this.FloorNumber = floorNumber;
            this.Rooms = new BindingList<Room>();
            this.FloorArea = calculateFloorArea();
        }
        #endregion

        //Start of Methods
        public double calculateFloorArea()
        {
            double area = 0.0;
            foreach (Room room in Rooms)
            {
                area += room.RoomArea;
            }
            return area;
        }

        public override string ToString()
        {
            return "Floor: " + FloorNumber;
        }


        #region propertyMethods
        public string id { get; set; }
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public double FloorArea { get => floorArea; set => floorArea = value; }
        public BindingList<Room> Rooms { get => rooms; set => rooms = value; }
        #endregion
    }
}
