using System;
using System.Collections.Generic;
using System.Reflection;

namespace TrafficLights
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            TrafficLight[] trafficLights = new TrafficLight[input.Length];

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            var changeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < changeCount; i++)
            {
                var currentLights = new List<string>();

                foreach (var light in trafficLights)
                {
                    light.ChangeLight();

                    var field = typeof(TrafficLight)
                        .GetField("light", BindingFlags.Instance | BindingFlags.NonPublic);

                    currentLights.Add(field.GetValue(light).ToString());
                }

                Console.WriteLine(string.Join(" ",currentLights));
            }
        }
    }
}
