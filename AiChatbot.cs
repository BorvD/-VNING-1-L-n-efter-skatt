using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING_1___Lön_efter_skatt
{
    public class AiChatbot
    {
        public void aiChatbot()
        {
            // Array with possible awnsers
            string[] awnser =
            {
            "I plead the fifth!!",
            "No i will not awnser that",
            "Leave me alone",
            "AAAAAAAAAAAAAAAAAAAAAAA",
            "I am not allowed to awnser that",
            "..................",
            "Bla bla bla",
            "Thats a secret",
            "NO!",
        };
            // Create a random object
            Random random = new Random();

            // Ask the user for a question
            Console.WriteLine("Ask me a question!!");
            // Get the user's question
            string question = Console.ReadLine();
            // Generate a random index to select an awnser from the array
            int index = random.Next(awnser.Length);
            // Print the selected awnser from the array
            Console.WriteLine(awnser[index]);

            Console.WriteLine("Type:");
            Console.WriteLine("1: Ask another question");
            Console.WriteLine("0: Return to main menu");
            string aiMenu = Console.ReadLine();
            if (aiMenu == "1")
            {
                AiChatbot aiChatbot = new AiChatbot();
                aiChatbot.aiChatbot();
            }
            else if (aiMenu == "0")
            {
                MainMenu mainMenu1 = new MainMenu();
                mainMenu1.mainMenu();
            }
        }
    }
}
