﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class BlockRectangle : Block
    {
        public BlockRectangle()
        {
            GenerateStructure();
        }

        protected override void GenerateStructure()
        {
            for (int x = 0; x < structure.GetLength(0); x++)
                for (int y = 0; y < structure.GetLength(1); y++)
                    structure[x, y] = false;

            structure[1, 0] = true;
            structure[1, 1] = true;
            structure[1, 2] = true;
            structure[1, 3] = true;
        }
    }
}
