﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FlightSimulatorApp
{
    class SimulatorViewModel : INotifyPropertyChanged
    {
        private MySimulatorModel model;
        public SimulatorViewModel(MySimulatorModel m)
        {
            this.model = m;
            m.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e) {
                NotifyPropertyChanged("VM_" + e.PropertyName);
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


        public double VM_IndicatedHeadingDeg
        {
            get { return model.IndicatedHeadingDeg; }
        }
        public double VM_GpsIndicatedVerticalSpeed
        {
            get { return model.GpsIndicatedVerticalSpeed; }
        }
        public double VM_GpsIndicatedGroundSpeedKt
        {
            get
            { return model.GpsIndicatedGroundSpeedKt; }
        }
        public double VM_AirspeedIndicatorIndicatedSpeedKt
        {
            get { return model.AirspeedIndicatorIndicatedSpeedKt; }
        }
        public double VM_GpsIndicatedAltitudeFt { get { return model.GpsIndicatedAltitudeFt; } }
        public double VM_AttitudeIndicatorInternalRollDeg { get { return model.AttitudeIndicatorInternalRollDeg; } }
        public double VM_AttitudeIndicatorInternalPitchDeg { get { return model.AttitudeIndicatorInternalPitchDeg; } }
        public double VM_AltimeterIndicatedAltitudeFt { get { return model.AltimeterIndicatedAltitudeFt; } }
        public double MV_Rudder
        {
            get
            {
                return this.model.Rudder;
            }
            set
            {
                this.model.Rudder = value;
            }
        }
        public double MV_Elevator
        {
            get
            {
                return this.model.Elevator;
            }
            set
            {
                this.model.Elevator = value;
            }
        }
        public double MV_Aileron
        {
            get
            {
                return this.model.Aileron;
            }
            set
            {
                this.model.Aileron = value;
            }
        }
        public double MV_Throttle
        {
            get
            {
                return this.model.Throttle;
            }
            set
            {
                this.model.Throttle = value;
            }
        }

    }
}