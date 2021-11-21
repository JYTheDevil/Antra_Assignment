using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Exercise4
{
    public class Solution
    {
        // top row and right column, thus top right
        public void tr(ref int[,] a, int x1, int y1, int x2, int y2, ref IList<int> res)
        {
            int x = 0, y = 0;

            for (x = x1; x <= x2; x++) res.Add(a[y1, x]);                          // process the row in this range
            for (y = y1 + 1; y <= y2; y++) res.Add(a[y, x2]);                          // process the column in this range
            if (x2 - x1 > 0 && y1 != y2) bl(ref a, x1, y1 + 1, x2 - 1, y2, ref res); // if there's more, process bottom left (again?)
        }

        // bottom row and left column, thus bottom left
        public void bl(ref int[,] a, int x1, int y1, int x2, int y2, ref IList<int> res)
        {
            int x = 0, y = 0;

            for (x = x2; x >= x1; x--) res.Add(a[y2, x]);                          // process the row in this range, from right to left
            for (y = y2 - 1; y >= y1; y--) res.Add(a[y, x1]);                          // process the column in this range, from bottom to top
            if (x2 - x1 > 0 && y1 != y2) tr(ref a, x1 + 1, y1, x2, y2 - 1, ref res); // if there's more, process top right (again?)
        }

        public IList<int> SpiralOrder(int[,] matrix)
        {
            // matrix is empty, return an empty list
            if (matrix.GetLength(0) == 0)
                return new List<int>();

            // only one row, return it. This is a bit clumsy in C#
            if (matrix.GetLength(0) == 1)
                return Enumerable.Range(0, matrix.GetLength(1))
                                 .Select(n => matrix[0, n])
                                 .ToList();

            var maxY = matrix.GetLength(0) - 1;
            var maxX = matrix.GetLength(1) - 1;

            // create result list and reserve enough space to prevent repeated reallocations / moves
            IList<int> result = new List<int>((maxX + 1) * (maxY + 1));

            // start on the top right of the matrix
            tr(ref matrix, 0, 0, maxX, maxY, ref result);

            return result;
        }
    }
}
