using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Ticket_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYolcu_Click(object sender, EventArgs e)
        {
            PassengerScreen passengerScreen = new PassengerScreen();
            passengerScreen.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
        }

        private void buttonFirma_Click(object sender, EventArgs e)
        {
            FirmScreen firmScreen = new FirmScreen();
            firmScreen.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
