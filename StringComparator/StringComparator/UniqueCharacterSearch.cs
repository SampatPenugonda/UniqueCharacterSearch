using System;
using System.Collections.Generic;
using System.Linq;

namespace StringComparator
{
    class UniqueCharacterSearch
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter String To get First Unique Letter");
            string userInput = Console.ReadLine();
            char uniqueValue = userValue.findUniqueValue(userInput);
            Console.WriteLine("First Unique Letter is {0}",uniqueValue);
            Console.ReadLine();
        }

    }
    class userValue
    {
        public static char findUniqueValue(string userGivenValue)
        {
            char[] userCharArray = userGivenValue.ToUpper().ToCharArray();
            Dictionary<char, int> userStringValues = new Dictionary<char, int>();
            for (int i = 0; i < userCharArray.Length; i++)
            {
                char keyCharacter = userCharArray[i];
                if (userStringValues.ContainsKey(keyCharacter))
                {
                    userStringValues[keyCharacter]++;
                }
                else
                {
                    userStringValues.Add(keyCharacter, 1);
                }
            }
           var data = userStringValues.Where(x => x.Value == 1).FirstOrDefault();
           return data.Key;
        }
    }
    
}
