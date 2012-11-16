using System;

namespace CodeClub.TowersOfHanoi.Core
{
    public class HanoiPuzzle
    {
        /// <summary>
        /// Recursively solve the Towers of Hanoi (http://en.wikipedia.org/wiki/Tower_of_Hanoi) puzzle.
        /// </summary>
        /// <param name="numberOfDisks"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="spare"></param>
        /// <remarks>
        /// As much as I'd love to take credit for this solution, I can't.  I got about 80% of the way through the recursive
        /// solution for this problem.  Unfortunately, I had to "cheat" and look up the last line (i.e. line 25 in this method)
        /// in "Algorithms and Data Structures" (http://www.amazon.com/Algorithms-Data-Structures-Computing-Engineering/dp/1584502509/ref=sr_1_12?s=books&ie=UTF8&qid=1353095209&sr=1-12&keywords=algorithms+and+data+structures).
        /// Even though I had to look for help on this solution, the Towers of Hanoi puzzle is a *great* recursive exercise.
        /// </remarks>
        public void Solve(int numberOfDisks, string source, string destination, string spare)
        {
            if (numberOfDisks > 0)
            {
                int disk = numberOfDisks - 1;
                this.Solve(disk, source, spare, destination);
                this.Move(disk, source, destination);
                this.Solve(disk, spare, destination, source);
            }
        }

        /// <summary>
        /// Write the output of the current move to the console.
        /// </summary>
        /// <param name="disk">The disk that is being moved from one peg to another.</param>
        /// <param name="source">The starting tower for the disk (i.e. the tower the disk was sitting on prior to being moved).</param>
        /// <param name="destination">The destination tower, where the disk will end up during this move.</param>
        private void Move(int disk, string source, string destination)
        {
            string message = string.Format("Moved disk {2} from {0} tower to {1} tower.", source, destination, disk);
            Console.WriteLine(message);
        }
    }
}
