using System;
using CSharpBlockchain.Scripts.Core;

namespace CSharpBlockchain {
    internal class Program {
        public static void Main(string[] args) {
            var chain = BlockChain.Get();
            Console.WriteLine("yep");
        }
    }
}