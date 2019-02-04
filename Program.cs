using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using Microsoft.Win32;

namespace _048_G29afterPC2 {
    class Program {
        //Registry valuenames
        private static readonly string OEMName = "OEMName";
        private static readonly string OEMData = "OEMData";
        //Logitech G29 values
        private static readonly string OEMNameValue = "Logitech G29 Driving Force Racing Wheel USB";
        private static readonly string OEMDataValue = "43 00 08 10 19 00 00 00 ";
        //Expected false values
        private static readonly string FalseOEMNameValue = "G29 Driving Force Racing Wheel";
        private static readonly string FalseOEMDataValue = "00 00 00 10 00 00 00 00";
        //Current values
        private static string CurrentOEMNameValue;
        private static string CurrentOEMDataValue;

        static void Main(string[] args) {
            //Opening Registrypath
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("System\\CurrentControlSet\\Control\\MediaProperties\\PrivateProperties\\Joystick\\OEM\\VID_046D&PID_C24F", true);
            //Setting current values
            CurrentOEMNameValue = Key.GetValue(OEMName).ToString();
            CurrentOEMDataValue = Key.GetValue(OEMData).ToString();
            //Check if the current values are similar to the false ones
            if (FalseOEMNameValue == CurrentOEMNameValue || FalseOEMDataValue == CurrentOEMDataValue) {
                //Setting the values to the default ones
                Key.SetValue(OEMName, OEMNameValue);
                Key.SetValue(OEMData, OEMDataValue);
            }
        }
    }
}
