using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IIB_UE1_Gruppe09_ClassLibrary
{
    [Serializable]
    //implements the serializable Class Building
    public class Building
    {
        private string name;
        private double areaBuilding;
        private string address;
        private BindingList<Floor> floors;
        private string id;

        public Building(string name)
        {
            Name = name;
            Floors = new BindingList<Floor>();
            AreaBuilding = calculateAreaBuildung();
            Id =  id;

        }

        public Building(string name, string address)
        {
            Name = name;
            Address = address;
            Floors = new BindingList<Floor>();
            AreaBuilding = calculateAreaBuildung();
        }

        public Building(string name, string address, BindingList<Floor> floors)
        {
            Name = name;
            Address = address;
            Floors = floors;
            AreaBuilding = calculateAreaBuildung();
        }

        //Start of Methods
        public double calculateAreaBuildung()
        {
            //Calculates the area of the Building by adding the Floors together
            double area = 0.0;
            foreach (Floor floor in Floors)
            {
                area += floor.FloorArea;
            }
            return area;
        }

        //ADDED METHOD: ToString()

        public override string ToString()
        {
            return name + "Addresse: " + address;
        }

        #region propertyMethods
        public string Name { get => name; set => name = value; }
        public double AreaBuilding { get => areaBuilding; set => areaBuilding = value; }
        public string Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }
        public BindingList<Floor> Floors { get => floors; set => floors = value; }
        #endregion
    }
}
