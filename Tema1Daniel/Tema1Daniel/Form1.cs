using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1Daniel
{
    
    public partial class Form1 : Form
    {
        public static List<Apartment> listOfApartments;
        public Form1()
        {
            InitializeComponent();
            listOfApartments = new List<Apartment>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addApartment_button_Click(object sender, EventArgs e)
        {
            if(idApartment_textbox.Text =="")
            {
                errorProvider1.SetError(idApartment_textbox, "Required field");
              
            } else if(numberOfRooms_textbox.Text=="")
            {
                errorProvider1.SetError(numberOfRooms_textbox, "Required field");
            } else if(floor_textBox.Text=="")
            {
                errorProvider1.SetError(floor_textBox, "Required field");
            }

            else
            {
                var apartment = new Apartment
                {
                    ApartmentId = Convert.ToInt32(idApartment_textbox.Text),
                    NumberOfRooms = Convert.ToInt32(numberOfRooms_textbox.Text),
                    Floor = Convert.ToInt32(floor_textBox.Text)
                    

                };

                for(int i=0;i<apartment.NumberOfRooms;i++)
                {
                    using (Form2 addRoomsForms = new Form2())
                    {
                        if (addRoomsForms.ShowDialog() == DialogResult.OK)
                        {
                            var room = new Room
                            {
                                RoomId = Convert.ToInt32(addRoomsForms.idRoom_textBox.Text),
                                Width = Convert.ToInt32(addRoomsForms.width_textBox.Text),
                                Height = Convert.ToInt32(addRoomsForms.height_textBox.Text),
                            };

                            string cardinalPoint = "E";
                            switch (cardinalPoint)
                            {
                                case "N":
                                    room.Orientation = CardinalPoints.N;
                                    break;
                                case "S":
                                    room.orientation = CardinalPoints.S;
                                    break;
                                case "V":
                                    room.orientation = CardinalPoints.V;
                                    break;
                                default:
                                    room.orientation = CardinalPoints.E;
                                    break;
                            }
                            apartment.listOfRooms.Add(room);
                        }
                    }
                    listOfApartments.Add(apartment);
                }
                      
            }
            listView1.Items.Clear();
            foreach (Apartment apartament in listOfApartments)
            {
                ListViewItem item = new ListViewItem(apartament.ApartmentId.ToString());
                item.SubItems.Add(apartament.NumberOfRooms.ToString());
                listView1.Items.Add(item);
            }

            idApartment_textbox.Clear();
            floor_textBox.Clear();
            numberOfRooms_textbox.Clear();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItemIndex = listView1.SelectedIndices[0];
            foreach(Apartment apartament in listOfApartments)
            {
                if (apartament.ApartmentId == Convert.ToInt32(listView1.Items[selectedItemIndex].Text))
                {
                    MessageBox.Show(apartament.ToString());
                }
            }
            

        }
    }
}
