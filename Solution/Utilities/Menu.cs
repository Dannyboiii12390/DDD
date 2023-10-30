using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Menu
    {
        List<string> options = new List<string>();

        public Menu() 
        { 

        }

        public int GetChoice()
        { 
            int choice = 0;
            string choiceStr;
            bool choiceSucceed;
            do
            {
                Console.WriteLine(ToString());
                choiceStr = Console.ReadLine();
                choiceSucceed = int.TryParse(choiceStr, out choice);
            } while (!choiceSucceed || choice <= 0 || choice > options.Count) ;

            return choice;
   
        }

        public void AddOption(string option)
        {
            options.Add(option);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < options.Count; i++)
            {
                sb.Append($"{i+1}. {options[i]}\n");
            }
            return sb.ToString();
        }



    }
}
