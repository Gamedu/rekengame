using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            // Check of leerling nummer voorkomt in database.
            // Nee -> "leerling nummer klopt niet"
            //Ja -> afhankelijk van de klas waar leerling nummer voorkomt, ga naar reken app. (Form 2 t/m 5)

            // - Groep 3: +/- t/m 20
            //- Groep 4: +/ -t / m 100, x5
            // - Groep 5: +/ -t / m 1000
            // - Groep 6: +/ -t / m 100.000, breuken, x10, delen
            // - Groep 7 + 8: +/ -t / m 1.000.000, breuken, schaalsommen, 

        }
    }
}
