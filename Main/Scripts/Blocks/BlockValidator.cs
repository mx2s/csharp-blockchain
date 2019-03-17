using System;
using CSharpBlockchain.Scripts.Tx;
using Newtonsoft.Json;

namespace CSharpBlockchain.Scripts.Blocks {
    public static class BlockValidator {
        public static bool IsValid(Block block) {
            if (block.Index == 0) {
                Console.WriteLine("Genesis block is always valid");
                return true;
            }
            foreach (var tx in block.Txs) {
                if (!TxValidator.ValidateTransaction(tx)) {
                    Console.WriteLine("Transaction is not valid");
                    Console.WriteLine(JsonConvert.SerializeObject(tx));
                    return false;
                }
            }
            return true;
        }
    }
}