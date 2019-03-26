 namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type classType = typeof(HarvestingFields);

            while(true)
            {
                var command = Console.ReadLine();

                var fields = new List<FieldInfo>();

                switch(command)
                {
                    case "public":
                        fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Where(f => f.IsPublic).ToList();
                        break;
                    case "private":
                        fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsPrivate).ToList();
                        break;
                    case "protected":
                        fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsFamily).ToList();
                        break;
                    case "all":
                        fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).ToList();
                        break;

                    case "HARVEST":
                        return;
                }

                foreach (var field  in fields)
                {
                    var acessModifiers = field.IsPublic 
                        ? "public" : field.IsPrivate ? "private" : "protected";

                    Console.WriteLine($"{acessModifiers} {field.FieldType.Name} {field.Name}");
                }
            }           
        }
    }
}
