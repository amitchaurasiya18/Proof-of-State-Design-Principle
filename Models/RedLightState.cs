using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.GlobalInterfaces;

namespace StateDPDemo.Models
{
    public class RedLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Red light - Stop!!!");
            trafficLight.SetState(new GreenLightState());
        }
    }
}
