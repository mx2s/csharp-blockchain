using System.Collections.Generic;
using System.Linq;
using CSharpBlockchain.Scripts.Blocks;
using CSharpBlockchain.Scripts.Core;

namespace CSharpBlockchain.Scripts.Tx {
    public class TxPool {
        private const uint BlockTxLimit = 10;
        
        private static TxPool _instance;

        public List<Transaction> pool;

        public TxPool() {
            pool = new List<Transaction>();
        }
        
        public static TxPool Get() => _instance ?? (_instance = new TxPool());

        public void Push(Transaction tx) {
            pool.Add(tx);
            if (pool.Count > BlockTxLimit) {
                ProcessNewBlock();
            }
        }

        public Transaction GetNext() {
            if (pool.Count == 0) {
                return null;
            }
            var obj = pool.First();
            pool.RemoveAt(0);
            return obj;
        }

        public void ProcessNewBlock() {
            var TxsSize = 0;
            var block = new Block();
            
            while (pool.Count > 0 && TxsSize < BlockTxLimit) {
                var next = GetNext();
                block.AddTx(next);
            }

            BlockPool.Get().AddBlock(block);
        }
    }
}