using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace PlebAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character c = new("Vladimir", "Frite Sauce", CharacterClass.Bard);

            //c.Equipment.Boots = new()
            //{
            //    ItemStats = new()
            //    {
            //        Defense = 3
            //    }
            //};

            ExpandoObject a = new ExpandoObject();
            
            dynamic b = a;

            b.Defense = 3;
            b.Damage = 133;

            foreach (var item in a)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        static ExpandoObject Merge(ExpandoObject a, ExpandoObject b)
        {
            static T Merge<T>(T a, T b)
            {

            }

            ExpandoObject result = new ExpandoObject();

            foreach (var item in a)
            {
                result.TryAdd(item.Key, item.Value);
            }

            foreach (var item in b)
            {
                if (!result.TryAdd(item.Key, item.Value))
                {
                    result[item.Key] = Merge(result[item.Key], item.Value);
                }
            }
        }
    }
}


namespace Testing
{
    //public class Item : PropertyCollection
    //{

    //}
}