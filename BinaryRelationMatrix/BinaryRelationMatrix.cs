using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRelationMatrix
{
    public class BinaryRelationMatrix
    {
        public bool[,]? R { get; private set; }
        public BinaryRelationMatrix(int[] A, int[] B)
        {
            Set(A, B);
        }

        public void Set(int[] A, int[] B)
        {
            R = new bool[A.Length, B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if ((2 * A[i] - B[j]) % 3 == 0)
                    {
                        R[i, j] = true;
                    }
                }
            }
        }

        public string GetString()
        {
            string output = "";
            for (int i = 0; i < R!.GetLength(0); i++)
            {
                for (int j = 0; j < R!.GetLength(1); j++)
                {
                    if (R[i, j])
                        output += "1 ";
                    else
                        output += "0 ";
                }
                output += Environment.NewLine;
            }
            return output;
        }
    }
}
