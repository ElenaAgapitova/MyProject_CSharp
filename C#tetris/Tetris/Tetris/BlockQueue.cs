using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class BlockQueue // класс, который отвечает за выбор блока в игре (очередь блоков). Состоит из массива 7 блоков
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock(),
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; } // свойство для блока

        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }

        // Метод, который возвращает случайный блок
        public Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];  
        }
        
        // Метод, который возвращает следующий блок и обновляет свойство, чтобы не возвращать один и тот же блок

        public Block GetAndUpdate()
        {
            Block block = NextBlock;
            do
            {
                NextBlock = RandomBlock();
            }
            while (block.id == NextBlock.id);

            return block;

        }
    }
}
