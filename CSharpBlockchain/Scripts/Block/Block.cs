using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpBlockchain.Scripts.Block {
    public class Block {
        public uint Index;
        
        public uint PrevBlockId { get; set; }
        public string PrevHash { get; set; }

        public DateTime TimeStamp { get; set; }
        
        public string Data { get; set; }

        public Block() {
        }
        
        public string GetPrevBlockHash() => PrevHash;

        public string CalculateHash() {
            SHA1 sha1 = SHA1.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(
                $"{TimeStamp}-{PrevHash ?? ""}-{Data}"
            );
            return sha1.ComputeHash(inputBytes).ToString();
        }
    }
}