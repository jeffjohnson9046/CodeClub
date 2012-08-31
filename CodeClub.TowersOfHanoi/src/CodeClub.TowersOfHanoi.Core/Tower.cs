using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeClub.TowersOfHanoi.Core
{
    public class Tower
    {
        #region Properties

        /// <summary>
        /// Represents the stack of Disks on this <c>Tower</c>.
        /// </summary>
        public LinkedList<int> Disks { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Initialize the <c>Tower</c>.
        /// </summary>
        public Tower()
        {
            this.Disks = new LinkedList<int>();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Identify the Disk that is currently on top of the <c>Tower</c>.
        /// </summary>
        /// <returns>An <c>int</c> representing the top Disk.  If there are no Disks currently stacked on the
        /// <c>Tower</c>, 0 will be returned.</returns>
        public int GetTopDisk()
        {
            return this.Disks.Last == null ? 0 : this.Disks.Last.Value;
        }

        /// <summary>
        /// Put a new Disk on top of the Tower.
        /// </summary>
        /// <param name="diskToAdd">An <c>int</c> representing the Disk to add.</param>
        /// <exception cref="InvalidOperationException">Thrown if the Disk to put on top of the <c>Tower</c> is 
        /// larger than the Disk that is already on top.</exception>
        public void AddDiskToTop(int diskToAdd)
        {
            if (!this.CanAddDisk(diskToAdd))
            {
                throw new InvalidOperationException(string.Format("Cannot stack disk {0} on top of a smaller disk {1}.", diskToAdd, this.GetTopDisk()));
            }

            this.Disks.AddLast(diskToAdd);
        }

        /// <summary>
        /// Pull the top Disk off the Tower.
        /// </summary>
        /// <returns>An <c>int</c> representing the Disk that has been removed from the top of the tower.</returns>
        public int RemoveTopDisk()
        {
            int topDisk = this.Disks.Last.Value;

            this.Disks.RemoveLast();

            return topDisk;
        }

        /// <summary>
        /// Compare two <c>Tower</c>s.
        /// </summary>
        /// <param name="obj">The other <c>Tower</c> that should be compared to this one.</param>
        /// <returns><c>True</c> if both <c>Tower</c>s are the same size and have the same sequence of Disks;
        /// otherwise <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (null == obj)
            {
                return false;
            }

            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            Tower that = obj as Tower;

            // RULE:  the Towers must be of equal size.
            if (this.Disks.Count != that.Disks.Count)
            {
                return false;
            }

            // RULE:  the Towers must contain the same Disks.
            // NOTE:  This doesn't check the SEQUENCE of the Disks, only that both Towers contain the 
            // same Disks.
            // TODO:  Verify that the disks are in the same order in both Towers.
            var diff = this.Disks.Where(x => !that.Disks.Any(x1 => x1 == x))
                                                        .Union(that.Disks.Where(y => !this.Disks.Any(y1 => y1 == y)))
                                                        .FirstOrDefault();

            if (diff != 0)
            {
                return false;
            }

            return true;
        }

        #endregion


        #region Utility Methods

        /// <summary>
        /// Verify that a Disk can be added to the <c>Tower</c>.
        /// </summary>
        /// <param name="diskToAdd">An <c>int</c> representing the Disk being added.</param>
        /// <returns><c>True</c> if the Disk can be added to the top of the <c>Tower</c>; otherwise <c>false</c>.</returns>
        /// <remarks>
        /// A Disk can be added to the top of the <c>Tower</c> under the following conditions:
        /// 1.  The <c>Tower</c> has no Disks.
        /// 2.  The Disk being placed on top of the <c>Tower</c> is "smaller" (i.e. a lower number) than the Disk that is
        /// currently on top of the stack.
        /// </remarks>
        private bool CanAddDisk(int diskToAdd)
        {
            return this.Disks.Count == 0 || diskToAdd < this.GetTopDisk();
        }

        #endregion
    }
}
