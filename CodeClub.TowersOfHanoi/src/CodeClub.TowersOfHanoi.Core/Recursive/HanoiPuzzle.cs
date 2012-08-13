using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeClub.TowersOfHanoi.Core.Recursive
{
    public class HanoiPuzzle
    {
        public void Solve(int numberOfDisks, string source, string destination, string spare)
        {
            int numberOfMoves = 0;

            if (numberOfDisks > 0)
            {
                int disk = numberOfDisks - 1;
                this.Solve(disk, source, spare, destination);
                this.Move(disk, source, destination, ref numberOfMoves);
                this.Solve(disk, spare, destination, source);
            }
        }

        private void Move(int disk, string source, string destination, ref int numberOfMoves)
        {
            string message = string.Format("Moved disk {2} from {0} tower to {1} tower.", source, destination, disk);
            Console.WriteLine(message);
            numberOfMoves++;
        }
    }
}
