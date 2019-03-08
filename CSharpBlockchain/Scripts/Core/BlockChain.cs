using System;
using CSharpBlockchain.Scripts.Blocks;

namespace CSharpBlockchain.Scripts.Core {
    public class BlockChain {
        private static BlockChain _instance;

        private BlockPool _blockPool;

        public BlockChain() {
            _blockPool = BlockPool.Get();
            _blockPool.SetGetBlock(new Block() {
                Index = 0,
                Date = DateTime.Now,
                PrevHash = ""
            });
        }

        public static BlockChain Get() => _instance ?? (_instance = new BlockChain());
    }
}