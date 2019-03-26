using System;

namespace CreateCustomClassAttribute
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var classType = typeof(Weapon);
            var attributes = classType.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                var classAttribute = attribute as ClassAttribute;

                if(classAttribute != null)
                {
                    while(true)
                    {
                        var command = Console.ReadLine();

                        switch(command)
                        {
                            case "Author":
                                Console.WriteLine($"Author: {classAttribute.Author}");
                                break;
                            case "Revision":
                                Console.WriteLine($"Revision: {classAttribute.Revision}");
                                break;
                            case "Description":
                                Console.WriteLine($"Class description: {classAttribute.Description}");
                                break;
                            case "Reviewers":
                                Console.WriteLine($"Reviewers: {string.Join(", ",classAttribute.Reviewers)}");
                                break;
                            case "END":
                                return;
                        }
                    }
                }
            }
        }
    }
}
