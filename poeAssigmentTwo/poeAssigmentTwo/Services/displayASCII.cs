using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo.Services
{
    public class displayASCII
    {
        public void TypeWrite(string message, int speedMs = 20)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(speedMs);
            }
            Console.WriteLine();
        }
        public void ShowASCIIArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ____              _ _       \ \
    .-""""""-. / \_> /\    |/
   /         \.'`  `',.--//
 -(Y2K I      I  @@\
   \         /'.____.'\___|
    '-.....-' __/ | \   (`)
jgs          /   /  /
                 \  \
Y2K bug by Joan G.Stark
        ");
            Console.ResetColor();
        }


        public void ShowTopic(responseB response)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n=== {response.Title} ===");
            Console.ResetColor();

            TypeWrite(response.Content, 10);

            if (response.FollowUps != null && response.FollowUps.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                TypeWrite("\nRelated topics you might want to explore next:", 10);
                foreach (var followUp in response.FollowUps)
                {
                    TypeWrite($"- {followUp}", 10);
                }
                Console.ResetColor();
            }
        }
    }
}