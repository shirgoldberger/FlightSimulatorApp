﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp.Model
{
    interface ITelnetClient
    {
        void connect();
        void write(string command);
        string read(); // blocking call 
        void disconnect();
        void setTimeOutRead(int time);
    }
}