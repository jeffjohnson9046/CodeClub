using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeClub.TowersOfHanoi.Core.Constants;

namespace CodeClub.TowersOfHanoi.Core
{
    public class GameMove
    {
        #region Properties

        public int Disk { get; set; }
        public MoveDirection Direction { get; set; }
        public int FromTower { get; set; }
        public int ToTower { get; set; }

        #endregion


        #region Methods

        public void Move() { return; }

        #endregion
    }
}
