using System;
using System.Drawing;
using System.Windows.Forms;

namespace gasolina_por_vuelta
{
    public partial class fuelControl : Form
    {

        public fuelControl()
        {
            InitializeComponent();

            /*
             * At startup select GT3 category, ACC profile by default and load all Tracks.
             */

            comboBoxProfile.SelectedIndex = 0; /*ACC*/
            comboBoxCategory.SelectedIndex = 0; /*GT3*/

            string[] track = ACCInfo.tracks();
            for (int i = 0; i < track.Length; i++)
            {
                comboBoxTrack.Items.Add(track[i]);
            }
        }

        ACC ACCInfo = new ACC();

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int session = hoursInMinutes() * 60;
            string tl = remplacePoint(textBoxTimeLap.Text), fl = remplacePoint(textBoxFuelLap.Text);

            /*
             * if session and t and fl dosen't have value return label at color red 
             * else calule result an change label result with result
             */
            if (session != 0 && tl != "" && fl != "")
            {

                allDataOk();
                
                    /*
                     * Calcule (time sesion / time per lap) * fuel + extra fuel
                     * to get liters
                     */
                    double time = toSeconds(tl), fuel = double.Parse(fl), extra = 0;
                    if (checkBoxExtra.Checked.ToString().Equals("True"))
                    {
                        extra = fuel;
                    }

                    // TODO mirar en redondear las vueltas y mirar el calculo para redondearlo
                    Console.WriteLine(session);
                    Console.WriteLine(time);
                    Console.WriteLine(session / time);
                    double laps = Math.Ceiling(session / time);
                    double liters = (laps * fuel) + extra;

                    labelLiters.Text = "Liters:  " + Math.Round(liters, 2);
                    labelLaps.Text = "Laps:   " + laps;

                    /*
                     * show the mesage to the capacity of tank is full
                     */
                    if (!textBoxTank.Text.Equals("") && liters > /*tank*/ double.Parse(textBoxTank.Text)) { labelTankFull.Show(); } else { labelTankFull.Hide(); }

                

            }
            else
            {
                labelLiters.Text = "Liters:  0";
                labelLaps.Text = "Laps:   0";

                labelError.Text = "Enter all data";
                labelError.Show();

                if (session == 0)
                {
                    labelSession.ForeColor = Color.Red;
                }
                else { labelSession.ForeColor = Color.White; }

                if (tl == "")
                {
                    labelTimeLap.ForeColor = Color.Red;
                    labelTrack.ForeColor = Color.Red;
                }
                else { labelTimeLap.ForeColor = Color.White; labelTrack.ForeColor = Color.White; }

                if (fl == "" && comboBoxCars.Text.Equals(""))
                {
                    labelFuelLap.ForeColor = Color.Red;
                    labelCar.ForeColor = Color.Red;
                }
                else { labelFuelLap.ForeColor = Color.White; labelCar.ForeColor = Color.White; }
            }
        }

        /*
         * time per lap this data is extract from best times
         */
        public int toSeconds(string time)
        {

            if (time.Contains(","))
            {
                string[] ms = time.Split(',');
                int minutes = int.Parse(ms[0]), seconds = int.Parse(ms[1]);
                return seconds + (60 * minutes);
            }
            return 0;
        }

        private string remplacePoint(string value)
        {
            if (value.Contains("."))
            {
                value = value.Replace(".", ",");
            }
            value = containsError(value);
            return value;
        }

        private void allDataOk()
        {
            labelSession.ForeColor = Color.White;
            labelTimeLap.ForeColor = Color.White; labelTrack.ForeColor = Color.White;
            labelFuelLap.ForeColor = Color.White; labelCar.ForeColor = Color.White;
            labelError.Hide();
        }

        /*
         * When changing the category, delete and add the new cars of the respective category.
         */
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Delete text when changing the category.
            comboBoxCars.Items.Clear();
            comboBoxCars.Text = "";
            textBoxFuelLap.Text = "";
            textBoxTank.Text = "";
            string[] cars = null;

            switch (comboBoxCategory.SelectedIndex)
            {
                case 0:
                    cars = ACCInfo.GT3Cars();
                    break;

                case 1:
                    cars = ACCInfo.GT4Cars();
                    break;

                case 2:
                    cars = ACCInfo.GTCCars();
                    break;

                default:
                    labelError.Text = "Error: Loading Cars";
                    break;
            }

            for (int i = 0; i < cars.Length; i++)
            {
                comboBoxCars.Items.Add(cars[i]);
            }

        }

        /*
         * When the circuit or car is changed, it returns in textBoxFuelLap the fuel used by the car in that circuit.
         */
        private void comboBoxCarsTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            int car = comboBoxCars.SelectedIndex, track = comboBoxTrack.SelectedIndex;
            if (!car.Equals(-1) && !track.Equals(-1))
            {
                string[,] fuel = null;
                string[] tank = null;

                switch (comboBoxCategory.SelectedIndex)
                {
                    case 0:
                        fuel = ACCInfo.GT3FuelLap();
                        tank = ACCInfo.GT3Tank();
                        break;

                    case 1:
                        fuel = ACCInfo.GT4FuelLap();
                        tank = ACCInfo.GT4Tank();
                        break;

                    case 2:
                        fuel = ACCInfo.GTCFuelLap();
                        tank = ACCInfo.GTCTank();
                        break;

                    default:
                        labelError.Text = "Error: Select Category";
                        break;
                }
                textBoxFuelLap.Text = /*fuelLap*/ fuel[car, track];
                textBoxTank.Text = tank[car];

            }

        }

        /*
         * Return time per lap in selected comboBoxTrack.
         */
        private void comboBoxTrack_SelectedValueChanged(object sender, EventArgs e)
        {

            int track = comboBoxTrack.SelectedIndex;
            if (!track.Equals(-1))
            {
                textBoxTimeLap.Text = ACCInfo.timesTrack(track);
            }

        }

        /*
         * Validate in textBox to use only numeric values and ".".
         */
        private void keyPress(object sender, KeyPressEventArgs e, bool point)
        {
            if (point)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
                if (((e.KeyChar == '.') || (e.KeyChar == ',')) && (((sender as TextBox).Text.IndexOf('.') > -1) || (sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            } 
        }

        /*
         * true for alow '.' and ','
         * false for only numeric values.
         */
        private void textBoxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e, true);
        }
        private void textBoxSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e, false);
        }

        /*
         * Opens a new window of information about the application.
         */
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            about info = new about();

            if ((Application.OpenForms["about"] as about) != null)
            {
                // about is already open
                Application.OpenForms[info.Name].Focus();
            }
            else
            {
                // about is not open
                info.Show();
            }
        }

        /*
         * When you change the profile they are hidden and other options appear.
         */
        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = comboBoxProfile.SelectedIndex;
            if (mode.Equals(0)/*ACC*/)
            {
                labelCategory.Show();
                comboBoxCategory.Show();
                labelTrack.Show(); labelTrack.ForeColor = Color.White;
                comboBoxTrack.Show();
                labelCar.Show(); labelCar.ForeColor = Color.White;
                comboBoxCars.Show();

                labelSession.ForeColor = Color.White;
                labelTimeLap.Hide();
                textBoxTimeLap.Hide();
                labelFuelLap.Hide();
                textBoxFuelLap.Hide();
                labelTank.Hide();
                textBoxTank.Hide();

            }
            if (mode.Equals(1)/*Custom*/)
            {
                labelCategory.Hide();
                comboBoxCategory.Hide();
                labelTrack.Hide();
                comboBoxTrack.Hide();
                labelCar.Hide();
                comboBoxCars.Hide();

                labelSession.ForeColor = Color.White;
                labelTimeLap.Show(); labelTimeLap.ForeColor = Color.White;
                textBoxTimeLap.Show();
                labelFuelLap.Show(); labelFuelLap.ForeColor = Color.White;
                textBoxFuelLap.Show();
                labelTank.Show();
                textBoxTank.Show();
            }
        }

        public string containsError(string value)
        {
            if (value.StartsWith(","))
            {
                return value.TrimStart(',');
            }

            if (value.EndsWith(","))
            {
                return value.TrimEnd(',');
            }
            return value;
        }

        /*
        * Convert hours in minutes
        * and sum with minutes
        */
        public int hoursInMinutes()
        {
            int minutes = 0, minutesHour = 0;

            if (!textBoxSessionH.Text.Equals(""))
            {
                int hours = int.Parse(textBoxSessionH.Text);
                minutesHour = 60 * hours;
            }
            if (!textBoxSessionM.Text.Equals(""))
            {
                minutes = int.Parse(textBoxSessionM.Text);
            }
            return minutesHour + minutes;
        }

        private void textBoxSessionM_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSessionM.Text != "" && Int32.Parse(textBoxSessionM.Text) > 59)
            {
                //int sum = Int32.Parse(textBoxSessionH.Text) + 1;
                //textBoxSessionH.Text = sum.ToString();
                textBoxSessionM.Text = "59";
            }
        }

        private void textBoxSessionH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSessionH.Text != "" && Int32.Parse(textBoxSessionH.Text) >= 24)
            {
                textBoxSessionH.Text = "24";
            }
        }

        private void textBoxTimeLap_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTimeLap.Text != "" && (textBoxTimeLap.Text.Contains(".") || textBoxTimeLap.Text.Contains(",")))
            {
                string[] timelap;
                string p;
                if (textBoxTimeLap.Text.Contains(".")) 
                {
                    timelap = textBoxTimeLap.Text.Split('.');
                    p = ".";
                }
                else 
                { 
                    timelap = textBoxTimeLap.Text.Split(',');
                    p = ",";
                }
                
                if (timelap[0] != "" && timelap[1] != "")
                {
                    if (Int32.Parse(timelap[0]) > 59) 
                    { 
                        timelap[0] = "59";
                    }
                    if (Int32.Parse(timelap[1]) > 59)
                    {
                        timelap[1] = "59";
                    }
                    textBoxTimeLap.Text = timelap[0] + p + timelap[1];
                }
            }
        }
    }
}