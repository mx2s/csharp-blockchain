using System;
using System.Collections.Generic;
using CSharpBlockchain.Scripts.Crypto;
using CSharpBlockchain.Scripts.Tx;

namespace CSharpBlockchain.Scripts.Blocks {
    public class Block {
        public uint Index;
        
        public string PrevHash { get; set; }

        public List<Transaction> Txs;
        
        public DateTime Date { get; set; }
        
        public string Data { get; set; }

        public Block() {
            Txs = new List<Transaction>();
        }
        
        public string GetPrevBlockHash() => PrevHash;

        public string CalculateHash() => Hashing.FromString(GetRawDataString());

        public string GetRawDataString() 
            => $"{Index}-{PrevHash ?? ""}-{Date}-{GetRawTxsData()}-{Txs.Count}-{Data}";

        private string GetRawTxsData() {
            var result = "";
            foreach (var tx in Txs) {
                result += tx.GetRawDataString();
            }
            return result;
        }

        public void AddTx(Transaction tx) {
            Txs.Add(tx);
        }
        
        public void SetPrevHash(Block prevBlock) {
            PrevHash = prevBlock.CalculateHash();
        }
    }
}