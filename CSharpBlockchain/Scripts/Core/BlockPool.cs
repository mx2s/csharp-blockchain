using System;
using System.Collections.Generic;
using System.Linq;
using CSharpBlockchain.Scripts.Blocks;

namespace CSharpBlockchain.Scripts.Core {
    public class BlockPool {
        private static BlockPool Instance;

        public static BlockPool Get() => Instance ?? (Instance = new BlockPool());

        private Dictionary<uint, Block> Blocks;

        public BlockPool() {
            Blocks = new Dictionary<uint, Block>();
        }

        public void AddBlock(Block block) {
            var lastIndex = Blocks.Keys.Max();
            if (Blocks.ContainsKey(block.Index)) {
                Console.WriteLine("Block index already exists");
                return;
            }
            Blocks[block.Index] = block;
            Console.WriteLine("added block N: " + block.Index);
        }

        public Dictionary<uint, Block> GetBlocks() => Blocks;

        public void SetGetBlock(Block block) {
            Blocks[0] = block;
        }
    }
}