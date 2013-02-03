using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class BlockCrinkleRight : Block
    {
        public BlockCrinkleRight()
        {
            GenerateStructure();
        }

        protected override void GenerateStructure()
        {
            for (int x = 0; x < structure.GetLength(0); x++)
                for (int y = 0; y < structure.GetLength(1); y++)
                    structure[x, y] = false;

            structure[2, 0] = true;
            structure[2, 1] = true;
            structure[1, 1] = true;
            structure[1, 2] = true;
        }
    }
}
