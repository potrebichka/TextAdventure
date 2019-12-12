using System;
using System.Collections.Generic;
using TextAdventure.Models;

namespace TextAdventure
{
    public class Program
    {
        private static string[] AnswerA = {"A", "a"};
        private static string[] AnswerB = {"B", "b"};
        private static string[] AnswerC = {"C", "c"};
        private static string[] yes = {"Y", "y", "yes", "Yes"};
        private static string[] no = {"N", "n,", "no", "No"};
        
        private static string required = ("Use only A, B, or C");
        
        private static Player player;
        public static void Main()
        {
            Console.WriteLine("Welcome to the text adventure game!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            player = new Player(name);
            Console.WriteLine();
            Console.WriteLine("Hello {0}!", player.PlayerName);
            Console.WriteLine();
            Intro();
        }

        public static void Intro()
        {
            Console.WriteLine("After a drunken night out with friends, you awaken the \n next morning in a thick, dank forest. Head spinning and  \n fighting the urge to vomit, you stand and marvel at your new, \n unfamiliar setting. The peace quickly fades when you hear a \n grotesque sound emitting behind you. A slobbering orc is \n running towards you. You will:");
            Console.WriteLine();
            Console.WriteLine("  A. Grab a nearby rock and throw it at the orc \n B. Lie down and wait to be mauled \n C. Run");
            Console.WriteLine();
            String ChoiceOne = Console.ReadLine();
            if (Array.Exists(AnswerA, element => element == ChoiceOne)) {
                Rock();
            } else if (Array.Exists(AnswerB, element => element == ChoiceOne)){
                Console.WriteLine("That was quick! You died!");
            } else if (Array.Exists(AnswerC, element => element == ChoiceOne)){
                Run();
            } else {
                Console.WriteLine(required);
                Intro();
            }
            Console.WriteLine();
        }
        public static void Rock()
        {
            Console.WriteLine("The orc is stunned, but regains control. He begins \n running towards you again. Will you:");
            Console.WriteLine();
            Console.WriteLine("A. Run \n B. Throw another rock \n C. Run towards a nearby cave");
            Console.WriteLine();
            String ChoiceTwo = Console.ReadLine();
             if (Array.Exists(AnswerA, element => element == ChoiceTwo)) {
                Run();
            } else if (Array.Exists(AnswerB, element => element == ChoiceTwo)){
                Console.WriteLine("You decided to throw another rock, as if the first \nrock thrown did much damage. The rock flew well over the \n orcs head. You missed. You died!");
            } else if (Array.Exists(AnswerC, element => element == ChoiceTwo)){
                Cave();

            } else {
                Console.WriteLine(required);
                Rock();
            }
            Console.WriteLine();
        }

        public static void Cave()
        {
            Console.WriteLine("You were hesitant, since the cave was dark and \n ominous. Before you fully enter, you notice a shiny sword on \n the ground. Do you pick up a sword. Y/N?");
            Console.WriteLine();
            String ChoiceThree = Console.ReadLine();
             if (Array.Exists(yes, element => element == ChoiceThree)) {
                player.Sword = 1;
            } else {
                player.Sword = 0; 
            }
            Console.WriteLine();
            Console.WriteLine("What do you do next?");
            Console.WriteLine();
            Console.WriteLine("A. Hide in silence \n B. Fight \n C. Run");
            Console.WriteLine();
            String ChoiceFour = Console.ReadLine();
            if (Array.Exists(AnswerA, element => element == ChoiceFour)) {
               Console.WriteLine("Really? You're going to hide in the dark? I think \n orcs can see very well in the dark, right? Not sure, but \n I'm going with YES, so...\nYou died!");
            } else if (Array.Exists(AnswerB, element => element == ChoiceFour)){
                if (player.Sword > 0) {
                    Console.WriteLine("You laid in wait. The shimmering sword attracted \n the orc, which thought you were no match. As he walked \n closer and closer, your heart beat rapidly. As the orc \n reached out to grab the sword, you pierced the blade into \n its chest. \n You survived!");
                } else {
                    Console.WriteLine("You should've picked up that sword! You're defenseless. \n You died!");
                } 
            } else if (Array.Exists(AnswerC, element => element == ChoiceFour)){
                Console.WriteLine("As the orc enters the dark cave, you sliently \n sneak out. You're several feet away, but the orc turns \n around and sees you running.");

            } else {
                Console.WriteLine(required);
                Cave();
            }
            Console.WriteLine();
        }

        public static void Run()
        {
            Console.WriteLine("You run as quickly as possible, but the orc's \n speed is too great. You will:");
            Console.WriteLine();
            Console.WriteLine("A. Hide behind boulder \n B. Trapped, so you fight \n C. Run towards an abandoned town");
            Console.WriteLine();
            String ChoiceFive = Console.ReadLine();
            if (Array.Exists(AnswerA, element => element == ChoiceFive)) {
               Console.WriteLine("You're easily spotted... \nYou died!");
            } else if (Array.Exists(AnswerB, element => element == ChoiceFive)){
               Console.WriteLine("\nYou're no match for an orc. \nYou died!");
            } else if (Array.Exists(AnswerC, element => element == ChoiceFive)){
              Town();
            } else {
                Console.WriteLine(required);
                Run();
            }
            Console.WriteLine();
        }

        public static void Town()
        {
            Console.WriteLine("\nWhile frantically running, you notice a rusted \n sword lying in the mud. You quickly reach down and grab it, \n but miss. You try to calm your heavy breathing as you hide \n behind a delapitated building, waiting for the orc to come \n charging around the corner. You notice a purple flower \n near your foot. Do you pick it up? Y/N");
            Console.WriteLine();
            String ChoiceSix = Console.ReadLine();
            if (Array.Exists(yes, element => element == ChoiceSix)) {
                player.Flower = 1;
            } else {
                player.Flower = 0; 
            }
            Console.WriteLine("You hear its heavy footsteps and ready yourself for \n the impending orc.");
            Console.WriteLine();
            if (player.Flower > 0) {
                Console.WriteLine("\n  You quickly hold out the purple flower, somehow \n hoping it will stop the orc. It does! The orc was looking \n for love. \n This got weird, but you survived!");
            } else {
                Console.WriteLine("Maybe you should've grabbed the flower! \n You died!");
            }
            Console.WriteLine();
        }
    }
}