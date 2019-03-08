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
            Blocks[lastIndex + 1] = block;
        }

        public void SetGetBlock(Block block) {
            Blocks[0] = block;
        }
    }
}