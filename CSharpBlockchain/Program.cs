using System;
using CSharpBlockchain.Scripts.Core;
using CSharpBlockchain.Scripts.Tx;
using CSharpBlockchain.Scripts.User;

namespace CSharpBlockchain {
    internal class Program {
        public static void Main(string[] args) {
            var chain = BlockChain.Get();
            var txPool = TxPool.Get();
            
            txPool.Push(new Transaction() {
                From = "yep",
                To = "yep2",
                Amount = 0.025
            });
            
            txPool.Push(new Transaction() {
                From = "yep",
                To = "yep2",
                Amount = 0.025
            });
            
            txPool.ProcessNewBlock();
               
            Console.WriteLine(UserUtil.GetBalance("yep2"));
        }
    }
}