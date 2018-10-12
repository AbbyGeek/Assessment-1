using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                try
                {
            Console.WriteLine("What number assessment are you testing for? (Enter 1-4) or enter '3*6-7+49/2*4/2' for creativity");
            int testnum = int.Parse(Console.ReadLine());
                
                    if (testnum == 1)
                    {
                        Console.WriteLine(Assessment1());
                    }
                    if (testnum == 2)
                    {
                        Assessment2();
                    }
                    if (testnum == 3)
                    {
                        Console.WriteLine(Assessment3() + " vowels in your word");
                    }
                    if (testnum == 4)
                    {
                        Console.WriteLine("Welcome home! The weather outside sucks!!!! Time to get inside and out of the rain.... \n " +
                            "Awe crap, your power is out and its pitch dark outside. At this point you probably don't care and just want to go to bed \n" +
                            "Do you know how to get through your house and to your bed in the pitch dark? \n");
                        CYOA();

                    }
                    if (testnum == 60)
                    {
                        Console.WriteLine(" attractive \n bald \n beautiful \n chubby\n clean\n dazzling\n drab\n elegant\n fancy\n fit\n flabby\n glamorous\n " +
                            "gorgeous\n handsome \n long \n magnificent \n muscular \n plain \n plump \n quaint \n scruffy \n shapely \n short \n skinny \n stocky \n ugly \n unkempt \n unsightly");
                        Console.WriteLine("I gave you adjectives. Now give me bonus points");
                    }
                }
                catch
                {
                    Console.WriteLine("Hey now. Follow the rules. Try again");
                    continue;
                }
            }
            
        }
        public static string Assessment1()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            string[] ans = name.Split(' ');
            Array.Reverse(ans);
            return string.Join(" ",ans);
        }

        public static void Assessment2()
        {
            Console.Write("Give me a number: ");

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                string ans = i + " * " + num + " = " + (i * num);
                Console.WriteLine(ans);
            }
        }
        public static int Assessment3()
        {
            Console.WriteLine("Give me a word, Smartypants");
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            int count = 0;
            foreach (char x in arr)
            {
                if ("aeiouAEIOU".Contains(x))
                {
                    count += 1;
                }
            }
            return count;
        }
        
        public static void CYOA()
        {
            string choice = "E";
            string current = "H";
            while (true)
            {
                if (choice == "E" && current == "H")
                {
                    Console.WriteLine("You know you're in your entryway. It'd be a bit weird if you lived here and didn't even know what the first room was, right? \n" +
                    "ANYWAYS! Time to figure out where everything else is. Things are still chilly from the rain outside, but the hard wood under your feet feels good.\n" +
                    "You know there's one door in front of you to the south, but can't remember where it goes, but thats totally normal. What do you do?");
                    Console.WriteLine("enter 'H' to go forward through the door, " +
                    "or enter anything else to push your life alert button and quit the game because you're a giant chicknen.\n\n\n");
                    current = choice;
                    choice = Console.ReadLine().ToUpper();
                    continue;
                }

                if (choice == "H")
                {
                    Console.WriteLine("Welcome to your.... hallway? You yelled into the darkness and heard a faint echo meaning the room is very long, but you can feel the \n" +
                    "walls on either side of you, so its also very thin.... Weird.... You'd think you'd remember that.\n" +
                    "Walking down the hall, you eventually feel the frames of two doors on either side of you. Do you want to try one of these? or keep going?");
                    Console.WriteLine("Enter 'K' to go left. Enter 'B' to go right. Enter 'R' to go forward. Enter 'E' to go back" +
                    "\n or type anything else to lay down and sleep on the floor because you don't want to play the game anymore\n\n\n");
                    current = choice;
                    choice = Console.ReadLine().ToUpper();
                    continue;
                }

                if (choice == "K" && current =="H")
                {
                    Console.WriteLine("Oh hey! Linolium under your feet!.... how do you even spell lynoleum?... Linoliem? Lynn Oh Liam? *shrug*. I'm not getting graded on spelling here.\n" +
                        "So yeah! Its your Kitchen!!! Definitely not your room, but now you know its here. Good info to have. There are no doors \n" +
                        "leading out except the one your just came through, though. So back to the hallway!! Enter 'H' to go back to the hall\n\n\n");
                    current = choice;
                    choice = Console.ReadLine().ToUpper();
                    continue;
                }
                if (choice == "B" && current == "H")
                {
                    Console.WriteLine("Right! Bahtroom! Got it. Good to know thats there. But its not the right room. I'm sure Hemory will forgive me, but I'm really\n" +
                        "not in the mood for writing stories right now. I'm in a coding mindset and it'll take a bit to get into creative storytelling mode, so this \n" +
                        "is just a bathroom. That is all. BACK TO THE HALLWAY WE GO!.... Enter 'H' or anything else to chicken out.\n\n\n");
                    current = choice;
                    choice = Console.ReadLine().ToUpper();
                    continue;
                }
                if (choice == "R")
                {
                    Console.WriteLine("You walk down the hallway and find an open door at the end of it. Is it....? Could it really be...?\n ... \n ... \n ..." +
                        "\n IT IS!!! ITS YOUR ROOM! Now get some sleep!!! Good job, old sport!\n\n\n");
                    break;
                }

                else
                {
                    Console.WriteLine("Something didn't check out. Did you want to quit, or just screw up? To quit, enter 'Q' or enter anything else to start over.");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "Q")
                    { break; }
                    else { CYOA(); }
                    
                }
            

            }
        }
            
            
            
        
    }
}
