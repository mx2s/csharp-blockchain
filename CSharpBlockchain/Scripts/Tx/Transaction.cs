using System;
using CSharpBlockchain.Scripts.Crypto;

namespace CSharpBlockchain.Scripts.Tx {
    public class Transaction {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        
        public string CalculateHash() => Hashing.FromString(GetRawDataString());

        public string GetRawDataString() 
            => $"{From}-{To}-{Amount}-{Date}";
    }
}