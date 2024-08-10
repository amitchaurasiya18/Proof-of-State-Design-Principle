using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Models;

namespace StateDPDemo.GlobalInterfaces
{
    public interface ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight);
    }
}
