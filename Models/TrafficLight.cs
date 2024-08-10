using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.GlobalInterfaces;

namespace StateDPDemo.Models
{
    public class TrafficLight
    {
        private ITrafficLightState _currentState;

        public TrafficLight(ITrafficLightState currentState)
        {
            _currentState = currentState;
        }

        public void SetState(ITrafficLightState state)
        {
            _currentState = state;
        }

        public void Change()
        {
            _currentState.Handle(this);
        }
    }
}
