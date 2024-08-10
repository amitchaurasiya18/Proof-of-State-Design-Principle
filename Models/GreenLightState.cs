using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.GlobalInterfaces;

namespace StateDPDemo.Models
{
    public class GreenLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Green light - Go!!!");
            trafficLight.SetState(new YellowLightState());
        }
    }
}
