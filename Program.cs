using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NBitcoin;

namespace VanityGenerator
{
    class Program
    {
                for (int i = 0; i < 1000; i++)
                {
                    var k = new Key();
                    var segwit = k.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main).ToString().ToLowerInvariant();
                    var legacy = k.PubKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString();
                    var segwitp2sh = k.PubKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main).ToString();
                   
                        Console.WriteLine("Private key = " + k.GetWif(Network.Main));
                        Console.WriteLine("Legacy bitcoin address = " + legacy); // выводим строку
                        Console.WriteLine("Segwitp2sh bitcoin address = " + segwitp2sh);
                        Console.WriteLine("Segwit bitcoin address = " + segwit);
                        Console.WriteLine("\n");
                
                }
            }
        }
    }
}