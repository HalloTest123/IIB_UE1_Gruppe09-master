using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.ComponentModel;
using IIB_UE1_Gruppe09_ClassLibrary;
using IIB_UE1_Gruppe09_FireDrencherGUI;
using System.Text.RegularExpressions;
using ClassRoom = IIB_UE1_Gruppe09_ClassLibrary.Room;
using RevitRoom = Autodesk.Revit.DB.Architecture.Room;
using ClassFloor = IIB_UE1_Gruppe09_ClassLibrary.Floor;
using RevitFloor = Autodesk.Revit.DB.Floor;




namespace IIB_UE2_Gruppe09_Revit
{
    public class RevitController 
    {

        //Get Revit Info
        private  Document revitDocument = null;
        
        public Building parseBuilding()
        {
            ProjectInfo projectInfo = revitDocument.ProjectInformation;
            Building building = new Building(projectInfo.Name);
            building.Id = projectInfo.Id.ToString();
            building.Floors = getFloors();
            return building;
        }



        public BindingList<ClassFloor> getFloors()
        {
            FilteredElementCollector collector = new FilteredElementCollector(revitDocument);
            ICollection<Element> floors = collector.OfClass(typeof(Level)).ToElements();
            BindingList<ClassFloor> cfls = new BindingList<ClassFloor>();
            foreach (Element fl in floors)
            {
                ClassFloor cfl = parseFloor((Level)fl);
                cfl.Rooms = getRooms((Level)fl);

                if (cfl.Rooms.Count != 0)
                {
                    cfls.Add(cfl);
                }
            }
            return cfls;
        }

        public  ClassFloor parseFloor(Level floor)
        {
            ClassFloor cfl = new ClassFloor(floor.Name, new BindingList<ClassRoom>());
            cfl.id = floor.Id.ToString();
            return cfl;
        }

        public  BindingList<ClassRoom> getRooms(Level floor)
        {

            IEnumerable<Element> Roomsbylevel_filcol = new FilteredElementCollector(revitDocument) //search only in this level
            .OfClass(typeof(SpatialElement)).Where(room => room.GetType() == typeof(Autodesk.Revit.DB.Architecture.Room))  //get all rooms
            .Cast<SpatialElement>()  //cast results to SpatialElements
            .Where(o => o.LevelId == floor.Id); //search by the above mentioned Level

            BindingList<ClassRoom> crooms = new BindingList<ClassRoom>();
            foreach (SpatialElement r in Roomsbylevel_filcol)
            {
                ClassRoom croom = parseRoom((RevitRoom)r);
                if (croom != null)
                {
                    crooms.Add(croom);
                }
            }
            return crooms;
        }


        public ClassRoom parseRoom(RevitRoom room)
        {
            ClassRoom raum = new ClassRoom();
            raum.RoomArea = squarefeetToMeter(room.Area);
            raum.RoomType = room.GetParameters("Nutzungsgruppe DIN 277-2")[0].AsString();

            return raum;
        }

        public static double squarefeetToMeter(double squarefeet)
        {
            double quadratmeter = (squarefeet / 10.7639);
            return Math.Round(quadratmeter, 2);
        }

        public Document RevitDocument { set { revitDocument = value; } }
    }
}
