using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IIB_UE1_Gruppe09_ClassLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace IIB_UE1_Gruppe09_FireDrencherGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Building> buildings;
        private BindingList<FireDrencher> availableFireDrenchers;

        public MainWindow()
        {
            InitializeComponent();
            buildings = new BindingList<Building>();
            availableFireDrenchers = new BindingList<FireDrencher>();

            //generateExamples();
            //Load existing Files
            load();
            //Add Event Handlers for the Binding Lists
            buildings.ListChanged += new ListChangedEventHandler(listChanged);
            availableFireDrenchers.ListChanged += new ListChangedEventHandler(listChanged);
            foreach(Building b in buildings)
            {
                b.Floors.ListChanged += new ListChangedEventHandler(listChanged);
                foreach(Floor f in b.Floors)
                {
                    f.Rooms.ListChanged += new ListChangedEventHandler(listChanged);
                    foreach(Room r in f.Rooms)
                    {
                        r.FireDrenchers.ListChanged += new ListChangedEventHandler(listChanged);
                    }
                }
            }


            //Fill various GUI Elements with initial Values by calling their respective filling-methods
            fillComboBoxBuildingsTabRaum();
            comboBoxBuildingTabRaum.SelectedIndex = 0;
            fillComboBoxFloors();
            comboBoxFloorTabRaum.SelectedIndex = 0;
            fillListBoxRooms();

            fillFireDrencherBoxes();
            comboBoxCapacity.SelectedIndex = 0;
            comboBoxFireClass.SelectedIndex = 0;
            fillListBoxFireDrenchers();

            fillComboBoxesTabKosten();
            comboBoxBuildingTabKosten.SelectedIndex = 0;

        }

        #region Generate Examples
        private void generateExamples()
        {
            Random randomNumberGenerator = new Random();
            //Generates Example Buildings for testing purposes
            for(int i = 0; i<5; i++)
            {
                string buildingName = "exampleBuilding " + i;
                string buildingAddress = "exampleStreet " + i;
                BindingList<Floor> floors = new BindingList<Floor>();

                int numberOfFloors = randomNumberGenerator.Next(1, 50);
                for (int j = 0; j < numberOfFloors; j++)
                {
                    int floorNumber = j;
                    BindingList<Room> rooms = new BindingList<Room>();

                    int numberOfRooms = randomNumberGenerator.Next(2, 50);
                    for(int k = 0; k < numberOfRooms; k++)
                    {
                        int roomNumber = k;
                        string roomName = "Raum: " + k;
                        int roomTypeNumber = randomNumberGenerator.Next(1, 7);
                        string roomType = "";
                        if(roomTypeNumber == 1)
                        {
                            roomType = "1-Wohnen und Aufenthalt";
                        }
                        else if(roomTypeNumber == 2)
                        {
                            roomType = "2-Büroarbeit";
                        }
                        else if(roomTypeNumber == 3)
                        {
                            roomType = "3-Produktion, Hand- und Maschinenarbeit, Experimente";
                        }
                        else if(roomTypeNumber == 4)
                        {
                            roomType = "4-Lagern, Verteilen und Verkaufen";
                        }
                        else if(roomTypeNumber == 5)
                        {
                            roomType = "5-Bildung, Unterricht und Kultur";
                        }
                        else if(roomTypeNumber == 6)
                        {
                            roomType = "6-Heilen und Pflegen";
                        }
                        else
                        {
                            roomType = "7-Sonstige Nutzungen";
                        }
                        
                        double roomArea = Math.Round(randomNumberGenerator.NextDouble() * randomNumberGenerator.Next(100, 1000),2);
                        Room room = new Room(roomNumber, roomName, roomType, 100, 10, 0, new BindingList<FireDrencher>(), roomArea);
                        rooms.Add(room);
                    }

                    Floor floor = new Floor(floorNumber, rooms);
                    floors.Add(floor);
                }
                Building building = new Building(buildingName, buildingAddress, floors);
                buildings.Add(building);
            }
        }
        #endregion

        #region Methods for the "Räume" Tab
        // Methods for the "Räume"-Tab
        private void fillComboBoxBuildingsTabRaum()
        {
            comboBoxBuildingTabRaum.ItemsSource = buildings;
        }

        private void fillComboBoxFloors()
        {
            if(comboBoxBuildingTabRaum.SelectedItem != null)
            {
                Building selectedBuilding = (Building)comboBoxBuildingTabRaum.SelectedItem;
                comboBoxFloorTabRaum.ItemsSource = selectedBuilding.Floors;
                comboBoxFloorTabRaum.SelectedIndex = 0;
            }                        
        }

        private void fillListBoxRooms()
        {
            if(comboBoxFloorTabRaum.SelectedItem != null)
            {
                Floor selectedFloor = (Floor)comboBoxFloorTabRaum.SelectedItem;
                listBoxRooms.ItemsSource = selectedFloor.Rooms;
            }            
        }

        private void fillRoomTextBoxes()
        {
            if(listBoxRooms.SelectedItem != null)
            {
                Room selectedRoom = (Room)listBoxRooms.SelectedItem;
                textBoxFlaeche.Text = selectedRoom.RoomArea + " m²";
                textBoxNUF.Text = selectedRoom.RoomType;
                textBoxBrandlast.Text = selectedRoom.RoomFireDamage + " MJ";
            }
            else
            {
                textBoxFlaeche.Text = "0 m²";
                textBoxNUF.Text = "NUF";
                textBoxBrandlast.Text = "0 MJ";
            }
        }

        private void btnChangeRoom_Click(object sender, RoutedEventArgs e)
        {
            if(listBoxRooms.SelectedItem != null)
            {
                ((Room)listBoxRooms.SelectedItem).RoomType = textBoxNUF.Text;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen gültigen Raum aus.", "Eingabefehler");
            }
                    
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            //Saves the changes manually
            save();
        }
        private void comboBoxFloorTabRaum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillListBoxRooms();
        }

        private void comboBoxBuildingTabRaum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillComboBoxFloors();
        }
        #endregion

        #region Methods for Tab "Feuerlöscher-hinzufügen"
        private void fillListBoxFireDrenchers()
        {
            listBoxFireDrenchers.ItemsSource = availableFireDrenchers;
        }        

        private void listBoxRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillRoomTextBoxes();
            fillListBoxesTabAddFireDrencher();
            fillTextBoxesTabAddFireDrencher();
        }

        public void fillFireDrencherBoxes()
        {
            //Fills the comboboxes with allowed Values
            int[] capacities = { 3, 6, 9, 12 };
            comboBoxCapacity.ItemsSource = capacities;
            string[] fireClasses = { "A", "B", "C", "D", "E", "F" };
            comboBoxFireClass.ItemsSource = fireClasses;
        }

        private void btnAddFireDrencher_Click(object sender, RoutedEventArgs e)
        {
            //Adds the desired FireDrencher to the List of unassigned FireDrenchers for later assignment
            int capacity = (int)comboBoxCapacity.SelectedValue;            
            string fireClass = (string)comboBoxFireClass.SelectedItem;
            FireDrencher fireDrencher = new FireDrencher(capacity, fireClass);
            availableFireDrenchers.Add(fireDrencher);
            fillListBoxFireDrenchers();
        }

        private void comboBoxCapacity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxPrice.Text = FireDrencher.setPrice((int)comboBoxCapacity.SelectedItem) + " € ";
        }

        private void btnRemoveFireDrencher_Click(object sender, RoutedEventArgs e)
        {
            availableFireDrenchers.Remove((FireDrencher)listBoxFireDrenchers.SelectedItem);
            fillListBoxFireDrenchers();
        }
        #endregion

        #region Methods for Tab "Feuerlöscher zuweisen"

        private void fillTextBoxesTabAddFireDrencher()
        {
            if(listBoxRooms.SelectedItem != null)
            {
                textBoxSelectedBuilding.Text = comboBoxBuildingTabRaum.SelectedItem.ToString();
                textBoxSelectedFloor.Text = comboBoxFloorTabRaum.SelectedItem.ToString();
                textBoxSelectedRoom.Text = listBoxRooms.SelectedItem.ToString();
                textBoxCurrentVolume.Text = ((Room)listBoxRooms.SelectedItem).calculateExistingFireDrencherVolume().ToString();
                textBoxNeededVolume.Text = ((Room)listBoxRooms.SelectedItem).calculateNeededFireDrencherVolume().ToString();
                if (Double.Parse(textBoxCurrentVolume.Text) < Double.Parse(textBoxNeededVolume.Text))
                {
                    textBoxCurrentVolume.Background = Brushes.Red;
                }
                else
                {
                    textBoxCurrentVolume.Background = Brushes.Green;
                }
            }
            
        }

        private void fillListBoxesTabAddFireDrencher()
        {
            if(listBoxRooms.SelectedItem != null)
            {
                listBoxUnassignedFireDrenchers.ItemsSource = availableFireDrenchers;
                listBoxFireDrenchersInRoom.ItemsSource = ((Room)listBoxRooms.SelectedItem).FireDrenchers;
            }
            
        }
        private void btnAddFireDrencherToRoom_Click(object sender, RoutedEventArgs e)
        {
            //Adds a unassigned FireDrencher to a Room
            if (listBoxUnassignedFireDrenchers.SelectedItem != null)
            {
                FireDrencher fireDrencher = (FireDrencher)listBoxUnassignedFireDrenchers.SelectedItem;
                availableFireDrenchers.Remove(fireDrencher);
                ((Room)listBoxRooms.SelectedItem).FireDrenchers.Add(fireDrencher);
                fillTextBoxesTabAddFireDrencher();
            }
            else
            {
                MessageBox.Show("Bitte eine Auswahl treffen!", "Eingabefehler");
            }
        }

        private void btnRemoveFireDrencherFromRoom_Click(object sender, RoutedEventArgs e)
        {
            //Removes an assigned FireDrencher from a room and adds it to the unassigned FireDrenchers
            if (listBoxFireDrenchersInRoom.SelectedItem != null)
            {
                FireDrencher fireDrencher = (FireDrencher)listBoxFireDrenchersInRoom.SelectedItem;
                ((Room)listBoxRooms.SelectedItem).FireDrenchers.Remove(fireDrencher);
                availableFireDrenchers.Add(fireDrencher);
                fillTextBoxesTabAddFireDrencher();
            }
            else
            {
                MessageBox.Show("Bitte eine Auswahl treffen!", "Eingabefehler");
            }

        }

        #endregion

        #region Methods for Tab "Kosten"
        public void fillComboBoxesTabKosten()
        {
            comboBoxBuildingTabKosten.ItemsSource = buildings;           
        }

        public void fillComboBoxFloorsTabKosten()
        {
            if (comboBoxBuildingTabKosten.SelectedItem != null)
            {
                comboBoxFloorTabKosten.ItemsSource = ((Building)comboBoxBuildingTabKosten.SelectedItem).Floors;
                comboBoxFloorTabKosten.SelectedIndex = 0;
            }
        }

        public void fillTextBoxBuildingTabKosten()
        {
            //Calculates the total Price of FireDrenchers for an entire selected Building and writes it into the textBox
            double totalPriceBuilding = 0.0;
            Building selectedBuilding = (Building)comboBoxBuildingTabKosten.SelectedItem;
                foreach(Floor f in selectedBuilding.Floors)
                {
                    foreach(Room r in f.Rooms)
                    {
                        foreach(FireDrencher fd in r.FireDrenchers)
                        {
                            totalPriceBuilding += fd.Price;
                        }
                    }
                }
            textBoxTotalPriceForBuilding.Text = totalPriceBuilding + " €";
        }

        public void fillTextBoxFloorTabKosten()
        {
            //Calculates the total Number and Cost of FireDrenchers for the selected Floor and writes it into the textBox
            if(comboBoxFloorTabKosten.SelectedItem != null)
            {
                double totalPriceFloor = 0.0;
                int totalFireDrenchersFloor = 0;
                Floor selectedFloor = (Floor)comboBoxFloorTabKosten.SelectedItem;
                foreach (Room r in selectedFloor.Rooms)
                {
                    foreach (FireDrencher fd in r.FireDrenchers)
                    {
                        totalPriceFloor += fd.Price;
                        totalFireDrenchersFloor++;
                    }
                }
                textBoxTotalPriceForFloor.Text = totalPriceFloor + " €";
                textBoxFireDrencherTotalFloor.Text = totalFireDrenchersFloor.ToString();
            }
                      
        }

        public void fillListViewRooms()
        {
            if(comboBoxFloorTabKosten.SelectedItem != null)
            {
                listViewRooms.ItemsSource = ((Floor)comboBoxFloorTabKosten.SelectedItem).Rooms;
            }            

        }

        private void comboBoxBuildingTabKosten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillComboBoxFloorsTabKosten();
            fillTextBoxBuildingTabKosten();
        }

        private void comboBoxFloorTabKosten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillTextBoxFloorTabKosten();
            fillListViewRooms();
        }


        #endregion

        #region Methods for Saving, Loading and events
        private void save()
        {
            //Saves the current Building and availableFireDrenchers Lists to their respective Files
            FileStream fs = new FileStream("..\\..\\..\\Buildings.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, buildings);
            fs.Close();
            fs = new FileStream("..\\..\\..\\availableFireDrenchers.bin", FileMode.Create);
            bf.Serialize(fs, availableFireDrenchers);
            fs.Close();
        }

        private void load()
        {
            //Loads the Buildings and avasilableFireDrenchers from their respective Files.
            FileStream fs = new FileStream("..\\..\\..\\Buildings.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            buildings = (BindingList<Building>)bf.Deserialize(fs);
            fs.Close();
            fs = new FileStream("..\\..\\..\\availableFireDrenchers.bin", FileMode.Open);
            availableFireDrenchers = (BindingList<FireDrencher>)bf.Deserialize(fs);
            fs.Close();
        }

        void listChanged(object sender, ListChangedEventArgs e)
        {
            // Calls the save() Method when a BindingList<> is changed
            save();
        }


        #endregion

    }
}
