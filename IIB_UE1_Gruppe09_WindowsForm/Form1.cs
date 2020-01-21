using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IIB_UE1_Gruppe09_ClassLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace IIB_UE1_Gruppe09_WindowsForm
{
    public partial class Form1 : Form
    {

        private BindingList<Building> buildings;
        private BindingList<FireDrencher> availableFireDrenchers;

        public Form1()
        {
            InitializeComponent();
            buildings = new BindingList<Building>();
            availableFireDrenchers = new BindingList<FireDrencher>();
            
            //generate a new example List and save it.
            //generateExamples();
            //save();
            
            //Load existing Files
            load();
            //Add Event Handlers for the Binding Lists
            buildings.ListChanged += new ListChangedEventHandler(listChanged);
            availableFireDrenchers.ListChanged += new ListChangedEventHandler(listChanged);
            foreach (Building b in buildings)
            {
                b.Floors.ListChanged += new ListChangedEventHandler(listChanged);
                foreach (Floor f in b.Floors)
                {
                    f.Rooms.ListChanged += new ListChangedEventHandler(listChanged);
                    foreach (Room r in f.Rooms)
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
            for (int i = 0; i < 5; i++)
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
                    for (int k = 0; k < numberOfRooms; k++)
                    {
                        int roomNumber = k;
                        string roomName = "Raum: " + k;
                        int roomTypeNumber = randomNumberGenerator.Next(1, 7);
                        string roomType = "";
                        if (roomTypeNumber == 1)
                        {
                            roomType = "1-Wohnen und Aufenthalt";
                        }
                        else if (roomTypeNumber == 2)
                        {
                            roomType = "2-Büroarbeit";
                        }
                        else if (roomTypeNumber == 3)
                        {
                            roomType = "3-Produktion, Hand- und Maschinenarbeit, Experimente";
                        }
                        else if (roomTypeNumber == 4)
                        {
                            roomType = "4-Lagern, Verteilen und Verkaufen";
                        }
                        else if (roomTypeNumber == 5)
                        {
                            roomType = "5-Bildung, Unterricht und Kultur";
                        }
                        else if (roomTypeNumber == 6)
                        {
                            roomType = "6-Heilen und Pflegen";
                        }
                        else
                        {
                            roomType = "7-Sonstige Nutzungen";
                        }

                        double roomArea = Math.Round(randomNumberGenerator.NextDouble() * randomNumberGenerator.Next(100, 1000), 2);
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

        #region Methods for Räume-Tab

        private void fillComboBoxBuildingsTabRaum()
        {
            comboBoxBuildingTabRaum.DataSource = buildings;
        }

        private void fillComboBoxFloors()
        {
            if (comboBoxBuildingTabRaum.SelectedItem != null)
            {
                Building selectedBuilding = (Building)comboBoxBuildingTabRaum.SelectedItem;
                comboBoxFloorTabRaum.DataSource = selectedBuilding.Floors;
                comboBoxFloorTabRaum.SelectedIndex = 0;
            }
        }

        private void fillListBoxRooms()
        {
            if (comboBoxFloorTabRaum.SelectedItem != null)
            {
                Floor selectedFloor = (Floor)comboBoxFloorTabRaum.SelectedItem;
                listBoxRooms.DataSource = selectedFloor.Rooms;
            }
        }

        private void fillRoomTextBoxes()
        {
            if (listBoxRooms.SelectedItem != null)
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

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (listBoxRooms.SelectedItem != null)
            {
                ((Room)listBoxRooms.SelectedItem).RoomType = textBoxNUF.Text;
                save();
                fillRoomTextBoxes();
                MessageBox.Show("Raum geändert.", "Raumänderung");

            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen gültigen Raum aus.", "Eingabefehler");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            save();
        }

        private void comboBoxFloorTabRaum_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListBoxRooms();
        }

        private void comboBoxBuildingTabRaum_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxFloors();
        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillRoomTextBoxes();
            fillListBoxesTabAddFireDrencher();
            fillTextBoxesTabAddFireDrencher();
        }

        #endregion

        #region Methods for Feuerlöscher hinzufügen-Tab

        private void fillListBoxFireDrenchers()
        {
            listBoxFireDrenchers.DataSource = availableFireDrenchers;
        }

        public void fillFireDrencherBoxes()
        {
            //Fills the comboboxes with allowed Values
            int[] capacities = { 3, 6, 9, 12 };
            comboBoxCapacity.DataSource = capacities;
            string[] fireClasses = { "A", "B", "C", "D", "E", "F" };
            comboBoxFireClass.DataSource = fireClasses;
        }

        private void comboBoxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = FireDrencher.setPrice((int)comboBoxCapacity.SelectedItem) + " € ";
        }

        private void btnAddFireDrencher_Click(object sender, EventArgs e)
        {
            //Adds the desired FireDrencher to the List of unassigned FireDrenchers for later assignment
            int capacity = (int)comboBoxCapacity.SelectedValue;
            string fireClass = (string)comboBoxFireClass.SelectedItem;
            FireDrencher fireDrencher = new FireDrencher(capacity, fireClass);
            availableFireDrenchers.Add(fireDrencher);
            fillListBoxFireDrenchers();
        }

        private void btnRemoveFireDrencher_Click(object sender, EventArgs e)
        {
            availableFireDrenchers.Remove((FireDrencher)listBoxFireDrenchers.SelectedItem);
            fillListBoxFireDrenchers();
        }
        #endregion

        #region Methods for Tab Feuerlöscher zuweisen

        private void fillTextBoxesTabAddFireDrencher()
        {
            if (listBoxRooms.SelectedItem != null)
            {
                textBoxSelectedBuilding.Text = comboBoxBuildingTabRaum.SelectedItem.ToString();
                textBoxSelectedFloor.Text = comboBoxFloorTabRaum.SelectedItem.ToString();
                textBoxSelectedRoom.Text = listBoxRooms.SelectedItem.ToString();
                textBoxCurrentVolume.Text = ((Room)listBoxRooms.SelectedItem).calculateExistingFireDrencherVolume().ToString();
                textBoxNeededVolume.Text = ((Room)listBoxRooms.SelectedItem).calculateNeededFireDrencherVolume().ToString();
                if (Double.Parse(textBoxCurrentVolume.Text) < Double.Parse(textBoxNeededVolume.Text))
                {
                    textBoxCurrentVolume.BackColor = Color.Red;
                }
                else
                {
                    textBoxCurrentVolume.BackColor = Color.Green;
                }
            }
        }

        private void fillListBoxesTabAddFireDrencher()
        {
            if (listBoxRooms.SelectedItem != null)
            {
                listBoxUnassignedFireDrenchers.DataSource = availableFireDrenchers;
                listBoxFireDrenchersInRoom.DataSource = ((Room)listBoxRooms.SelectedItem).FireDrenchers;
            }
        }

        private void btnAddFireDrencherToRoom_Click(object sender, EventArgs e)
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

        private void btnRemoveFireDrencherFromRoom_Click(object sender, EventArgs e)
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

        #region Methods for Tab Kosten

        public void fillComboBoxesTabKosten()
        {
            comboBoxBuildingTabKosten.DataSource = buildings;
        }

        public void fillComboBoxFloorsTabKosten()
        {
            if (comboBoxBuildingTabKosten.SelectedItem != null)
            {
                comboBoxFloorTabKosten.DataSource = ((Building)comboBoxBuildingTabKosten.SelectedItem).Floors;
                comboBoxFloorTabKosten.SelectedIndex = 0;
            }
        }

        public void fillTextBoxBuildingTabKosten()
        {
            //Calculates the total Price of FireDrenchers for an entire selected Building and writes it into the textBox
            double totalPriceBuilding = 0.0;
            Building selectedBuilding = (Building)comboBoxBuildingTabKosten.SelectedItem;
            foreach (Floor f in selectedBuilding.Floors)
            {
                foreach (Room r in f.Rooms)
                {
                    foreach (FireDrencher fd in r.FireDrenchers)
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
            if (comboBoxFloorTabKosten.SelectedItem != null)
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

        public void fillDataGridViewRooms()
        {
            if (comboBoxFloorTabKosten.SelectedItem != null)
            {
                //TODO Fill the List View with data from Roomlist
                dataGridViewRooms.DataSource = ((Floor)comboBoxFloorTabKosten.SelectedItem).Rooms;
            }
        }


        private void comboBoxBuildingTabKosten_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxFloorsTabKosten();
            fillTextBoxBuildingTabKosten();
        }

        private void comboBoxFloorTabKosten_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTextBoxFloorTabKosten();
            fillDataGridViewRooms();
        }
        #endregion

        #region Methods for Saving and Loading
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
            fillTextBoxBuildingTabKosten();
            fillTextBoxFloorTabKosten();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControlForm1_Selected(object sender, TabControlEventArgs e)
        {

        }
    }
}
