using Nethereum.Web3;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Geth;
using Nethereum.Contracts.CQS;
using Nethereum.Util;
using Nethereum.Web3.Accounts;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Hex.HexTypes;
using Nethereum.Contracts;
using Nethereum.Contracts.Extensions;
using System.Numerics;
using System.Collections.Generic;

namespace BDBlockchainTCC.BlockchainAPI.Functions
{

    [Function("addTableToDB")]
    public class AddTableToDBFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }
    }

    [Function("addDB")]
    public class AddDBFunc : FunctionMessage
    {
        [Parameter("bytes32", "IPAddress", 1)]
        public string Tid { get; set; }
    }

    [Function("getIPAddr")]
    public class GetIPAddrFunc : FunctionMessage
    {
        [Parameter("address", "locate", 1)]
        public string Tid { get; set; }
    }
}
