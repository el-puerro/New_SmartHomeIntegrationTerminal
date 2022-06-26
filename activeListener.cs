using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SmartHomeIntegrationTerminal
{
    class activeListener
    {
        private string[] availableDevices;
        private string[] deviceAddresses;

        public String setDevices(string[] deviceNames, string[] deviceAddresses)
        {
            // Black magic IP-Validation via Regular Expression begins
            Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            
            private string[] invalidDevices;
            private string[] invalidAddresses;
            for(int i = 0; i < deviceAddresses.Length)
            {
                if(regex.Matches(deviceAddresses[i])) // Black magic ends here
                {
                    this.availableDevices[i] = deviceNames[i];
                    this.deviceAddresses[i] = deviceAddresses[i];
                }
                else
                {
                    invalidDevices[i] = deviceNames[i];
                }
            }
            
            invalidDevices.Length == 0 ? return "OK" : return String.Concat(invalidDevices);
        }

        public string[] getDeviceNames() => this.availableDevices;
        public string[] getDeviceAddresses() => this.deviceAddresses;
    }
}
