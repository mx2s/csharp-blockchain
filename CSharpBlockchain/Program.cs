using System;
using CSharpBlockchain.Scripts.Core;
using CSharpBlockchain.Scripts.Tx;

namespace CSharpBlockchain {
    internal class Program {
        public static void Main(string[] args) {
            var chain = BlockChain.Get();
            var txPool = TxPool.Get();
            
            txPool.Push(new Transaction() {
                From = "yep",
                To = "yep2",
                Amount = 0.02
            });
            
            txPool.ProcessNewBlock();
            
            Console.WriteLine("yep");
        }
    }
}