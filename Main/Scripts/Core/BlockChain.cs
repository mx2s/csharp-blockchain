using System;
using CSharpBlockchain.Scripts.Blocks;
using CSharpBlockchain.Scripts.Tx;

namespace CSharpBlockchain.Scripts.Core {
    public class BlockChain {
        private static BlockChain _instance;

        public BlockChain() {
            var blockPool = BlockPool.Get();

            var zeroBlock = new Block() {
                Index = 0,
                Date = DateTime.Now,
                PrevHash = ""
            };
            zeroBlock.Txs.Add( new Transaction() {
                From = "",
                To = "root",
                Amount = 10000
            });
            
            blockPool.SetGetBlock(zeroBlock);
        }

        public static BlockChain Get() => _instance ?? (_instance = new BlockChain());      
    }
}