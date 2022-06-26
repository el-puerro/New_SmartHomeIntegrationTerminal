using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//documentation for the following: https://docs.microsoft.com/en-us/previous-versions/office/developer/speech-technologies/hh361683(v=office.14)
using System.Speech.Recognition;
//documentation for the following: https://docs.microsoft.com/en-us/previous-versions/office/developer/speech-technologies/hh361644(v=office.14)
using System.Speech.Synthesis;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace SmartHomeIntegrationTerminal
{
    class keywordListener
    {
        private boolean keywordFound;


        public keywordListener(string[] devices, string[] IPs)
        {
            setDevices(devices, IPs);
            SpeechRecognizer sr = new SpeechRecognizer();
        }
    }
}
