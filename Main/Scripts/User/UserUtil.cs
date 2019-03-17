using CSharpBlockchain.Scripts.Core;

namespace CSharpBlockchain.Scripts.User {
    public static class UserUtil {
        public static double GetBalance(string wallet) {
            var pool = BlockPool.Get();
            double senderBalance = 0;

            foreach (var block in pool.GetBlocks()) {
                foreach (var curTx in block.Value.Txs) {
                    if (curTx.To == wallet) {
                        senderBalance += curTx.Amount;
                    }

                    if (curTx.From == wallet) {
                        senderBalance -= curTx.Amount;
                    }
                }
            }

            return senderBalance;
        }
    }
}