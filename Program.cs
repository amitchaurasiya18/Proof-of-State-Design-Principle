using StateDPDemo.Models;

public class Program
{
    public static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight(new RedLightState());

        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
    }
}