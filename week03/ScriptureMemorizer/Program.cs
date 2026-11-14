/*This is the file you have to execute to run the ScriptureMemorizer project*/
/*To exceed the requirements for the project I decided to add the library of 3 scriptures that 
are chosen randomly when you run the program*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            // Alma 29:9
            new Scripture(
                new Reference("Alma", 29, 9).GetDisplayText(),
                "I know that which the Lord hath commanded me, and I glory in it. I do not glory of myself, but I glory in that which the Lord hath commanded me; yea, and this is my glory, that perhaps I may be an instrument in the hands of God to bring some soul to repentance; and this is my joy."
            ),

            // Moroni 10:3-5
            new Scripture(
                new Reference("Moroni", 10, 3, 5).GetDisplayText(),
                "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."
            ),

            // Mosiah 3:19
            new Scripture(
                new Reference("Mosiah", 3, 19).GetDisplayText(),
                "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."
            )
        };

        // Choose a random scripture
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);

        Scripture scripture = scriptures[randomIndex];

        // Start the memorization program
        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words have been hidden!");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}