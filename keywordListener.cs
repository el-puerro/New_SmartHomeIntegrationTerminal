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
        private boolean isActive = false;
        private boolean keywordFound;
        private string[] availableNames;


        public void initialize()
        {
            this.keywordFound = false;
            SpeechRecognizer sr = new SpeechRecognizer();
            Choices names = new Choices();
            names.Add(this.availableNames);
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(names);
            Grammar g = new Grammar(gb);

            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);
            this.isActive = true;
        }

        void sr_SpeechRecognized()
        {
            this.keywordFound = true;
        }


        public keywordListener(string[] names)
        {
            // setDevices(devices, IPs);
            setNames(names);
            initialize();
        }

        public void setNames(string[] names)
        {
            this.availableNames = names;
        }


    }
}
