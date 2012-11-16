using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeClub.ChangeForADollar
{
    public class Combination
    {
        public int HalfDollars { get; set; }
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }

        public static Combination operator + (Combination first, Combination second)
        {
            return new Combination
                       {
                           HalfDollars = first.HalfDollars + second.HalfDollars,
                           Quarters = first.Quarters + second.Quarters,
                           Dimes = first.Dimes + second.Dimes,
                           Nickels = first.Nickels + second.Nickels,
                           Pennies = first.Pennies + second.Pennies
                       };
        }

        public int Total()
        {
            return (HalfDollars*CoinValues.HALF_DOLLAR) + 
                   (Quarters*CoinValues.QUARTER) + 
                   (Dimes*CoinValues.DIME) +
                   (Nickels*CoinValues.NICKEL) + 
                   (Pennies*CoinValues.PENNY);
        }
    }
}
