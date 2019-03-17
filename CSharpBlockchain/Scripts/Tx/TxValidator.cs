using CSharpBlockchain.Scripts.User;

namespace CSharpBlockchain.Scripts.Tx {
    public static class TxValidator {
        public static bool ValidateTransaction(Transaction tx) {
            if (UserUtil.GetBalance(tx.From) < tx.Amount) {
                return false;
            }
            return true;
        }
    }
}