using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.GlobalInterfaces;

namespace StateDPDemo.Models
{
    public class YellowLightState : ITrafficLightState
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow light - Caution!!!");
            trafficLight.SetState(new RedLightState());
        }
    }
}
