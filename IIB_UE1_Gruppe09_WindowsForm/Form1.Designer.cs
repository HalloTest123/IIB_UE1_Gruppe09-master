namespace IIB_UE1_Gruppe09_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlForm1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.textBoxNUF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBrandlast = new System.Windows.Forms.TextBox();
            this.textBoxFlaeche = new System.Windows.Forms.TextBox();
            this.comboBoxFloorTabRaum = new System.Windows.Forms.ComboBox();
            this.comboBoxBuildingTabRaum = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeRoom = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoveFireDrencher = new System.Windows.Forms.Button();
            this.btnAddFireDrencher = new System.Windows.Forms.Button();
            this.listBoxFireDrenchers = new System.Windows.Forms.ListBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxFireClass = new System.Windows.Forms.ComboBox();
            this.comboBoxCapacity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRemoveFireDrencherFromRoom = new System.Windows.Forms.Button();
            this.btnAddFireDrencherToRoom = new System.Windows.Forms.Button();
            this.textBoxNeededVolume = new System.Windows.Forms.TextBox();
            this.textBoxCurrentVolume = new System.Windows.Forms.TextBox();
            this.textBoxSelectedRoom = new System.Windows.Forms.TextBox();
            this.textBoxSelectedFloor = new System.Windows.Forms.TextBox();
            this.textBoxSelectedBuilding = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxFireDrenchersInRoom = new System.Windows.Forms.ListBox();
            this.listBoxUnassignedFireDrenchers = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxFireDrencherTotalFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalPriceForFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalPriceForBuilding = new System.Windows.Forms.TextBox();
            this.comboBoxBuildingTabKosten = new System.Windows.Forms.ComboBox();
            this.comboBoxFloorTabKosten = new System.Windows.Forms.ComboBox();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFireDrencherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPricePerRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlForm1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlForm1
            // 
            this.tabControlForm1.Controls.Add(this.tabPage1);
            this.tabControlForm1.Controls.Add(this.tabPage2);
            this.tabControlForm1.Controls.Add(this.tabPage3);
            this.tabControlForm1.Controls.Add(this.tabPage4);
            this.tabControlForm1.Location = new System.Drawing.Point(12, 12);
            this.tabControlForm1.Name = "tabControlForm1";
            this.tabControlForm1.SelectedIndex = 0;
            this.tabControlForm1.Size = new System.Drawing.Size(476, 247);
            this.tabControlForm1.TabIndex = 0;
            this.tabControlForm1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlForm1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxRooms);
            this.tabPage1.Controls.Add(this.textBoxNUF);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxBrandlast);
            this.tabPage1.Controls.Add(this.textBoxFlaeche);
            this.tabPage1.Controls.Add(this.comboBoxFloorTabRaum);
            this.tabPage1.Controls.Add(this.comboBoxBuildingTabRaum);
            this.tabPage1.Controls.Add(this.btnSaveChanges);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnChangeRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Räume";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(275, 19);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(180, 186);
            this.listBoxRooms.TabIndex = 13;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // textBoxNUF
            // 
            this.textBoxNUF.Location = new System.Drawing.Point(9, 141);
            this.textBoxNUF.Name = "textBoxNUF";
            this.textBoxNUF.Size = new System.Drawing.Size(251, 20);
            this.textBoxNUF.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nutzungsart";
            // 
            // textBoxBrandlast
            // 
            this.textBoxBrandlast.Location = new System.Drawing.Point(9, 101);
            this.textBoxBrandlast.Name = "textBoxBrandlast";
            this.textBoxBrandlast.ReadOnly = true;
            this.textBoxBrandlast.Size = new System.Drawing.Size(121, 20);
            this.textBoxBrandlast.TabIndex = 10;
            // 
            // textBoxFlaeche
            // 
            this.textBoxFlaeche.Location = new System.Drawing.Point(9, 61);
            this.textBoxFlaeche.Name = "textBoxFlaeche";
            this.textBoxFlaeche.ReadOnly = true;
            this.textBoxFlaeche.Size = new System.Drawing.Size(121, 20);
            this.textBoxFlaeche.TabIndex = 9;
            // 
            // comboBoxFloorTabRaum
            // 
            this.comboBoxFloorTabRaum.FormattingEnabled = true;
            this.comboBoxFloorTabRaum.Location = new System.Drawing.Point(139, 19);
            this.comboBoxFloorTabRaum.Name = "comboBoxFloorTabRaum";
            this.comboBoxFloorTabRaum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFloorTabRaum.TabIndex = 8;
            this.comboBoxFloorTabRaum.SelectedIndexChanged += new System.EventHandler(this.comboBoxFloorTabRaum_SelectedIndexChanged);
            // 
            // comboBoxBuildingTabRaum
            // 
            this.comboBoxBuildingTabRaum.FormattingEnabled = true;
            this.comboBoxBuildingTabRaum.Location = new System.Drawing.Point(9, 20);
            this.comboBoxBuildingTabRaum.Name = "comboBoxBuildingTabRaum";
            this.comboBoxBuildingTabRaum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuildingTabRaum.TabIndex = 7;
            this.comboBoxBuildingTabRaum.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuildingTabRaum_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(139, 167);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(121, 43);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Änderungen speichern";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stockwerk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raumliste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fläche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brandlast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebäude";
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.Location = new System.Drawing.Point(9, 167);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Size = new System.Drawing.Size(121, 43);
            this.btnChangeRoom.TabIndex = 0;
            this.btnChangeRoom.Text = "Raum ändern";
            this.btnChangeRoom.UseVisualStyleBackColor = true;
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemoveFireDrencher);
            this.tabPage2.Controls.Add(this.btnAddFireDrencher);
            this.tabPage2.Controls.Add(this.listBoxFireDrenchers);
            this.tabPage2.Controls.Add(this.textBoxPrice);
            this.tabPage2.Controls.Add(this.comboBoxFireClass);
            this.tabPage2.Controls.Add(this.comboBoxCapacity);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Feuerlöscher hinzufügen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFireDrencher
            // 
            this.btnRemoveFireDrencher.Location = new System.Drawing.Point(9, 170);
            this.btnRemoveFireDrencher.Name = "btnRemoveFireDrencher";
            this.btnRemoveFireDrencher.Size = new System.Drawing.Size(121, 40);
            this.btnRemoveFireDrencher.TabIndex = 10;
            this.btnRemoveFireDrencher.Text = "Feuerlöscher entfernen";
            this.btnRemoveFireDrencher.UseVisualStyleBackColor = true;
            this.btnRemoveFireDrencher.Click += new System.EventHandler(this.btnRemoveFireDrencher_Click);
            // 
            // btnAddFireDrencher
            // 
            this.btnAddFireDrencher.Location = new System.Drawing.Point(9, 126);
            this.btnAddFireDrencher.Name = "btnAddFireDrencher";
            this.btnAddFireDrencher.Size = new System.Drawing.Size(121, 38);
            this.btnAddFireDrencher.TabIndex = 8;
            this.btnAddFireDrencher.Text = "Feuerlöscher hinzufügen";
            this.btnAddFireDrencher.UseVisualStyleBackColor = true;
            this.btnAddFireDrencher.Click += new System.EventHandler(this.btnAddFireDrencher_Click);
            // 
            // listBoxFireDrenchers
            // 
            this.listBoxFireDrenchers.FormattingEnabled = true;
            this.listBoxFireDrenchers.Location = new System.Drawing.Point(139, 19);
            this.listBoxFireDrenchers.Name = "listBoxFireDrenchers";
            this.listBoxFireDrenchers.Size = new System.Drawing.Size(323, 199);
            this.listBoxFireDrenchers.Sorted = true;
            this.listBoxFireDrenchers.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(9, 100);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 6;
            // 
            // comboBoxFireClass
            // 
            this.comboBoxFireClass.FormattingEnabled = true;
            this.comboBoxFireClass.Location = new System.Drawing.Point(9, 59);
            this.comboBoxFireClass.Name = "comboBoxFireClass";
            this.comboBoxFireClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFireClass.TabIndex = 5;
            // 
            // comboBoxCapacity
            // 
            this.comboBoxCapacity.FormattingEnabled = true;
            this.comboBoxCapacity.Location = new System.Drawing.Point(9, 19);
            this.comboBoxCapacity.Name = "comboBoxCapacity";
            this.comboBoxCapacity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCapacity.TabIndex = 4;
            this.comboBoxCapacity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCapacity_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Kapazität";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Liste der verfugbaren Feuerlöscher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Preis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Brandklasse";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRemoveFireDrencherFromRoom);
            this.tabPage3.Controls.Add(this.btnAddFireDrencherToRoom);
            this.tabPage3.Controls.Add(this.textBoxNeededVolume);
            this.tabPage3.Controls.Add(this.textBoxCurrentVolume);
            this.tabPage3.Controls.Add(this.textBoxSelectedRoom);
            this.tabPage3.Controls.Add(this.textBoxSelectedFloor);
            this.tabPage3.Controls.Add(this.textBoxSelectedBuilding);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.listBoxFireDrenchersInRoom);
            this.tabPage3.Controls.Add(this.listBoxUnassignedFireDrenchers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(468, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Feuerlöscher zuweisen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFireDrencherFromRoom
            // 
            this.btnRemoveFireDrencherFromRoom.Location = new System.Drawing.Point(190, 137);
            this.btnRemoveFireDrencherFromRoom.Name = "btnRemoveFireDrencherFromRoom";
            this.btnRemoveFireDrencherFromRoom.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFireDrencherFromRoom.TabIndex = 15;
            this.btnRemoveFireDrencherFromRoom.Text = "<<";
            this.btnRemoveFireDrencherFromRoom.UseVisualStyleBackColor = true;
            this.btnRemoveFireDrencherFromRoom.Click += new System.EventHandler(this.btnRemoveFireDrencherFromRoom_Click);
            // 
            // btnAddFireDrencherToRoom
            // 
            this.btnAddFireDrencherToRoom.Location = new System.Drawing.Point(190, 77);
            this.btnAddFireDrencherToRoom.Name = "btnAddFireDrencherToRoom";
            this.btnAddFireDrencherToRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddFireDrencherToRoom.TabIndex = 14;
            this.btnAddFireDrencherToRoom.Text = ">>";
            this.btnAddFireDrencherToRoom.UseVisualStyleBackColor = true;
            this.btnAddFireDrencherToRoom.Click += new System.EventHandler(this.btnAddFireDrencherToRoom_Click);
            // 
            // textBoxNeededVolume
            // 
            this.textBoxNeededVolume.Location = new System.Drawing.Point(327, 194);
            this.textBoxNeededVolume.Name = "textBoxNeededVolume";
            this.textBoxNeededVolume.ReadOnly = true;
            this.textBoxNeededVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNeededVolume.TabIndex = 13;
            // 
            // textBoxCurrentVolume
            // 
            this.textBoxCurrentVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentVolume.Location = new System.Drawing.Point(327, 17);
            this.textBoxCurrentVolume.Name = "textBoxCurrentVolume";
            this.textBoxCurrentVolume.ReadOnly = true;
            this.textBoxCurrentVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentVolume.TabIndex = 12;
            // 
            // textBoxSelectedRoom
            // 
            this.textBoxSelectedRoom.Location = new System.Drawing.Point(218, 16);
            this.textBoxSelectedRoom.Name = "textBoxSelectedRoom";
            this.textBoxSelectedRoom.ReadOnly = true;
            this.textBoxSelectedRoom.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedRoom.TabIndex = 11;
            // 
            // textBoxSelectedFloor
            // 
            this.textBoxSelectedFloor.Location = new System.Drawing.Point(112, 16);
            this.textBoxSelectedFloor.Name = "textBoxSelectedFloor";
            this.textBoxSelectedFloor.ReadOnly = true;
            this.textBoxSelectedFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedFloor.TabIndex = 10;
            // 
            // textBoxSelectedBuilding
            // 
            this.textBoxSelectedBuilding.Location = new System.Drawing.Point(6, 16);
            this.textBoxSelectedBuilding.Name = "textBoxSelectedBuilding";
            this.textBoxSelectedBuilding.ReadOnly = true;
            this.textBoxSelectedBuilding.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedBuilding.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Nicht zugewiesene Feuerlöscher";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(306, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Benötigtes Löschmittelvolumen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Zum Raum zugewiesene Feuerlöscher";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Raum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Stockwerk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Gebäude";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Vorhandenes Löschmittelvolumen";
            // 
            // listBoxFireDrenchersInRoom
            // 
            this.listBoxFireDrenchersInRoom.FormattingEnabled = true;
            this.listBoxFireDrenchersInRoom.HorizontalScrollbar = true;
            this.listBoxFireDrenchersInRoom.Location = new System.Drawing.Point(285, 54);
            this.listBoxFireDrenchersInRoom.Name = "listBoxFireDrenchersInRoom";
            this.listBoxFireDrenchersInRoom.Size = new System.Drawing.Size(174, 121);
            this.listBoxFireDrenchersInRoom.Sorted = true;
            this.listBoxFireDrenchersInRoom.TabIndex = 1;
            // 
            // listBoxUnassignedFireDrenchers
            // 
            this.listBoxUnassignedFireDrenchers.FormattingEnabled = true;
            this.listBoxUnassignedFireDrenchers.HorizontalScrollbar = true;
            this.listBoxUnassignedFireDrenchers.Location = new System.Drawing.Point(6, 55);
            this.listBoxUnassignedFireDrenchers.Name = "listBoxUnassignedFireDrenchers";
            this.listBoxUnassignedFireDrenchers.Size = new System.Drawing.Size(164, 121);
            this.listBoxUnassignedFireDrenchers.Sorted = true;
            this.listBoxUnassignedFireDrenchers.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewRooms);
            this.tabPage4.Controls.Add(this.comboBoxFloorTabKosten);
            this.tabPage4.Controls.Add(this.comboBoxBuildingTabKosten);
            this.tabPage4.Controls.Add(this.textBoxTotalPriceForBuilding);
            this.tabPage4.Controls.Add(this.textBoxTotalPriceForFloor);
            this.tabPage4.Controls.Add(this.textBoxFireDrencherTotalFloor);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.menuStrip1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(468, 221);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kosten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Gebäude";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(130, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Stockwerk";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(338, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Gesamtpreis für Gebäude";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(174, 180);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Anzahl der Feuerlöscher gesamt";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(338, 180);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Preis für das Stockwerk:";
            // 
            // textBoxFireDrencherTotalFloor
            // 
            this.textBoxFireDrencherTotalFloor.Location = new System.Drawing.Point(177, 196);
            this.textBoxFireDrencherTotalFloor.Name = "textBoxFireDrencherTotalFloor";
            this.textBoxFireDrencherTotalFloor.ReadOnly = true;
            this.textBoxFireDrencherTotalFloor.Size = new System.Drawing.Size(155, 20);
            this.textBoxFireDrencherTotalFloor.TabIndex = 5;
            // 
            // textBoxTotalPriceForFloor
            // 
            this.textBoxTotalPriceForFloor.Location = new System.Drawing.Point(341, 196);
            this.textBoxTotalPriceForFloor.Name = "textBoxTotalPriceForFloor";
            this.textBoxTotalPriceForFloor.ReadOnly = true;
            this.textBoxTotalPriceForFloor.Size = new System.Drawing.Size(119, 20);
            this.textBoxTotalPriceForFloor.TabIndex = 6;
            // 
            // textBoxTotalPriceForBuilding
            // 
            this.textBoxTotalPriceForBuilding.Location = new System.Drawing.Point(341, 16);
            this.textBoxTotalPriceForBuilding.Name = "textBoxTotalPriceForBuilding";
            this.textBoxTotalPriceForBuilding.ReadOnly = true;
            this.textBoxTotalPriceForBuilding.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalPriceForBuilding.TabIndex = 7;
            this.textBoxTotalPriceForBuilding.TabStop = false;
            // 
            // comboBoxBuildingTabKosten
            // 
            this.comboBoxBuildingTabKosten.FormattingEnabled = true;
            this.comboBoxBuildingTabKosten.Location = new System.Drawing.Point(6, 16);
            this.comboBoxBuildingTabKosten.Name = "comboBoxBuildingTabKosten";
            this.comboBoxBuildingTabKosten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuildingTabKosten.TabIndex = 8;
            this.comboBoxBuildingTabKosten.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuildingTabKosten_SelectedIndexChanged);
            // 
            // comboBoxFloorTabKosten
            // 
            this.comboBoxFloorTabKosten.FormattingEnabled = true;
            this.comboBoxFloorTabKosten.Location = new System.Drawing.Point(133, 16);
            this.comboBoxFloorTabKosten.Name = "comboBoxFloorTabKosten";
            this.comboBoxFloorTabKosten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFloorTabKosten.TabIndex = 9;
            this.comboBoxFloorTabKosten.SelectedIndexChanged += new System.EventHandler(this.comboBoxFloorTabKosten_SelectedIndexChanged);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToOrderColumns = true;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
            this.dataGridViewRooms.AutoGenerateColumns = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.countFireDrencherDataGridViewTextBoxColumn,
            this.totalPricePerRoomDataGridViewTextBoxColumn});
            this.dataGridViewRooms.DataSource = this.roomBindingSource;
            this.dataGridViewRooms.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewRooms.Size = new System.Drawing.Size(454, 133);
            this.dataGridViewRooms.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Raumnummer";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Raumname";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countFireDrencherDataGridViewTextBoxColumn
            // 
            this.countFireDrencherDataGridViewTextBoxColumn.DataPropertyName = "CountFireDrencher";
            this.countFireDrencherDataGridViewTextBoxColumn.HeaderText = "Anzahl Feuerlöscher";
            this.countFireDrencherDataGridViewTextBoxColumn.Name = "countFireDrencherDataGridViewTextBoxColumn";
            this.countFireDrencherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPricePerRoomDataGridViewTextBoxColumn
            // 
            this.totalPricePerRoomDataGridViewTextBoxColumn.DataPropertyName = "TotalPricePerRoom";
            this.totalPricePerRoomDataGridViewTextBoxColumn.HeaderText = "Preis (€)";
            this.totalPricePerRoomDataGridViewTextBoxColumn.Name = "totalPricePerRoomDataGridViewTextBoxColumn";
            this.totalPricePerRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(IIB_UE1_Gruppe09_ClassLibrary.Room);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 262);
            this.Controls.Add(this.tabControlForm1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlForm1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlForm1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxBrandlast;
        private System.Windows.Forms.TextBox textBoxFlaeche;
        private System.Windows.Forms.ComboBox comboBoxFloorTabRaum;
        private System.Windows.Forms.ComboBox comboBoxBuildingTabRaum;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeRoom;
        private System.Windows.Forms.TextBox textBoxNUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxFireClass;
        private System.Windows.Forms.ComboBox comboBoxCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveFireDrencher;
        private System.Windows.Forms.Button btnAddFireDrencher;
        private System.Windows.Forms.ListBox listBoxFireDrenchers;
        private System.Windows.Forms.TextBox textBoxNeededVolume;
        private System.Windows.Forms.TextBox textBoxCurrentVolume;
        private System.Windows.Forms.TextBox textBoxSelectedRoom;
        private System.Windows.Forms.TextBox textBoxSelectedFloor;
        private System.Windows.Forms.TextBox textBoxSelectedBuilding;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxFireDrenchersInRoom;
        private System.Windows.Forms.ListBox listBoxUnassignedFireDrenchers;
        private System.Windows.Forms.Button btnRemoveFireDrencherFromRoom;
        private System.Windows.Forms.Button btnAddFireDrencherToRoom;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxFloorTabKosten;
        private System.Windows.Forms.ComboBox comboBoxBuildingTabKosten;
        private System.Windows.Forms.TextBox textBoxTotalPriceForBuilding;
        private System.Windows.Forms.TextBox textBoxTotalPriceForFloor;
        private System.Windows.Forms.TextBox textBoxFireDrencherTotalFloor;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFireDrencherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPricePerRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

