using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeClub.TowersOfHanoi.Core
{
    public class GameState
    {
        #region Properties
        
        /// <summary>
        /// A collection of <c>Stack</c>s that represent the Towers containing the Disks.
        /// </summary>
        public Tower[] Towers { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Create a new <c>GameState</c> with 3 Towers (the default for the standard Towers
        /// of Hanoi puzzle).
        /// </summary>
        public GameState() : this(3) { }

        /// <summary>
        /// Create a new <c>GameState</c> with the specified number of Towers.
        /// </summary>
        /// <param name="numberOfTowers">The number of Towers to create.</param>
        public GameState(int numberOfTowers)
        {
            this.Towers = new Tower[numberOfTowers];

            for (int i = 0; i < numberOfTowers; i++)
            {
                this.Towers[i] = new Tower();
            }
        }

        #endregion


        #region Methods

        public override bool Equals(object obj)
        {
            if (null == obj)
            {
                return false;
            }

            GameState that = obj as GameState;

            if (object.ReferenceEquals(this, that))
            {
                return true;
            }

            for (int i = 0; i < this.Towers.Length; i++)
            {
                if (!this.Towers[i].Equals(that.Towers[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
