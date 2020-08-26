using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace StarshipTroopers_FOVChanger
{
    public partial class Form1 : Form
    {
        static string _GamesExecutable = "STGame.exe";
        static string _GamesExecutableBackup = "STGame.bak";
        static string PCGW_URL = "http://pcgamingwiki.com/";
        static string donationURL = "https://www.twitchalerts.com/donate/suicidemachine";
        bool VerticalMinus;

        int width = 1280;
        int height = 720;
        float fov = 90;

        byte[] FovAsArray = new byte[4];
        byte[] data;
        int address = 0x0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists(_GamesExecutable))
            {
                MessageBox.Show("No executable found. Please place the file in a folder with a game.");
                Close();
            }
            else
            {
                //3F96CBE4
                //E4CB963F
                address = FindAddressUsingPattern("C7 86 84 00 00 00 CD CC 4C 3D " +
                    "C7 86 88 00 00 00 00 60 6A 46 C7 86 8C 00 00 00 " +
                    "E4 CB 96 3F 89 86 90 00 00 00 C7 86 94 00 00 00 " +
                    "00 00 80 40"
                    , 26);

                Debug.WriteLine("Found address: " + address.ToString("X4"));


                if (address != 0x0)
                {
                    string s = BitConverter.ToString(data);

                    fov = ConvertToDegrees(BitConverter.ToSingle(data, address));
                    TB_FOV.Text = fov.ToString();
                    TB_ResX.Text = width.ToString();
                    TB_ResY.Text = height.ToString();
                    GetArray();
                }
                else
                {
                    MessageBox.Show("Not FOV was found using the pattern. Might consinder sending exe to FOV changer developer... maybe?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        /// <summary>
        /// Uses byte pattern (converted from string with white spaces seperating bytes - that's important) to find a location of a value in memory.
        /// </summary>
        /// <param name="pattern">Pattern of bytes as a string (bytes have to be white space seperated!)</param>
        /// <param name="locationOfValue">Location of looked value in the patern - this will both be calculated for calculating the address AND to skip the value if it was changed.</param>
        /// <returns>Address of found value or 0 if nothing was found.</returns>
        private int FindAddressUsingPattern(string pattern, int locationOfValue)
        {
            List<byte> convertedValues = new List<byte>();
            string[] split = pattern.Split();
            foreach(var byteAsString in split)
            {
                if (byteAsString.Length != 2)
                    return 0;

                convertedValues.Add(Convert.ToByte(byteAsString, 16));
            }

            data = GetBytesFromAFile(_GamesExecutable);
            for (int i=0; i<data.Length; i++)
            {
                for(int j=0; j<data.Length-i; j++)
                {
                    if (j == convertedValues.Count)
                        return i + locationOfValue;

                    //skip the value changed
                    if (j >= locationOfValue && j < locationOfValue + 4)
                        continue;

                    var readByte = data[i + j];
                    if (readByte != convertedValues[j])
                        break;
                }
            }

            return 0x0;

        }

        private void CB_HorizontalPlusFOV_CheckedChanged(object sender, EventArgs e)
        {
            this.VerticalMinus = !((CheckBox)sender).Checked;
            TB_ResX.Enabled = VerticalMinus;
            TB_ResY.Enabled = VerticalMinus;
            GetArray();

        }

        #region Buttons_Lables_and_Stuff
        private void TB_ResX_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(TB_ResX.Text, out int temp))
            {
                width = temp;
            }
            else
                width = 1280;

            GetArray();
        }

        private void TB_ResY_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(TB_ResY.Text, out int temp))
            {
                height = temp;
            }
            else
                height = 720;

            GetArray();
        }

        //Creates an array of bytes to be displayed and calculates FOV
        private void GetArray()
        {
            if(!VerticalMinus)
                FovAsArray = BitConverter.GetBytes(ConvertToRadians(fov));
            else
                FovAsArray = BitConverter.GetBytes(ConvertToVertMinusFOV(fov));

            L_Byte0.Text = FovAsArray[0].ToString("X2");
            L_Byte1.Text = FovAsArray[1].ToString("X2");
            L_Byte2.Text = FovAsArray[2].ToString("X2");
            L_Byte3.Text = FovAsArray[3].ToString("X2");
        }
        #endregion

        #region Load_Save
        private byte[] GetBytesFromAFile(string filename)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(filename);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private bool WriteBytesToAFile(string filename, byte[] usedData)
        {
            try
            {
                File.WriteAllBytes(filename, usedData);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }
        }

        private void B_WriteToAFile_Click(object sender, EventArgs e)
        {
            //Replacing bytes
            data[address + 0] = FovAsArray[0];
            data[address + 1] = FovAsArray[1];
            data[address + 2] = FovAsArray[2];
            data[address + 3] = FovAsArray[3];

            //Backup
            if (!File.Exists(_GamesExecutableBackup))
            {
                File.Copy(_GamesExecutable, _GamesExecutableBackup);
            }

            bool success = true;
            success = WriteBytesToAFile(_GamesExecutable, data);

            if (!success)
                MessageBox.Show("There was an error writting to a file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Successfully made the changes!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void LL_PCGW_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(PCGW_URL);
        }

        private void DonateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(donationURL);
        }

        private void TB_FOV_Changed(object sender, EventArgs e)
        {
            if(float.TryParse(TB_FOV.Text, out float parsedFOV))
            {
                if(parsedFOV > 45f && parsedFOV < 179f)
                {
                    fov = parsedFOV;
                    GetArray();
                }
                else
                    fov = 90f;
            }
            else
            {
                fov = 90f;
            }
        }

        #region Calculator_Functions
        public float ConvertToDegrees(float angle)
        {
            return (float)(angle * (180.0 / Math.PI));
        }

        private float ConvertToRadians(float angle)
        {
            return (float)(Math.PI * angle / 180.0);
        }

        public float ConvertToVertMinusFOV(float angle)
        {
            if(width == 0 || height == 0)
            {
                return 0f;
            }

            // Horizontal FOV to Horizontal Radians
            var HorizontalRadians = ConvertToRadians(angle);

            // Horizontal Radians to Vertical Radians
            var VerticalRadians = 2 * Math.Atan(Math.Tan(HorizontalRadians / 2) * (3 * 1.0 / 4 * 1.0));

            // Vertical Radian to Horizontal Radian (with aspect ratio)
            var HorizontalRadianMinus = 2 * Math.Atan(Math.Tan(VerticalRadians / 2) * (width * 1.0 / height * 1.0));

            return (float)(HorizontalRadianMinus);
        }
        #endregion
    }
}
