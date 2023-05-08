using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // ***************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // ***************************************
    public static class AliBabaAssembleTeam
    {
        #region YOUR CODE IS HERE
        //Your Code is Here:
        //==================
        /// <summary>
        /// Find the minimum cost for any team that can be assembled 
        /// </summary>
        /// <param name="N">size of the array</param>
        /// <param name="array">contains the cost of each theif (+ve, -ve or 0) </param>
        /// <returns>min total cost of a team</returns>
        static public long AssembleTeam(int N, short[] array)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            long MSF = 1000000000000000;
            long CSUM = 0;
            for (int i = 0; i < N; i++)
            {
                if (CSUM > 0)
                {
                    CSUM = array[i];
                    MSF = Math.Min(MSF, CSUM);
                }
                else
                {
                    CSUM += array[i];
                    MSF = Math.Min(MSF, CSUM);
                }
                //CSUM = Math.Min(0, CSUM);
            }
            return MSF;
        }

        #endregion
    }
}
