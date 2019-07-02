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

namespace BDBlockchainTCC.BlockchainAPI.Data
{
    [FunctionOutput]
    public class GetIPAddrOutput : IFunctionOutputDTO
    {
        [Parameter("bytes32", "ip", 1)]
        public string IP { get; set; }
    }

    public class BlkChainDB
    {
        [Parameter("mapping", "tablesInDB", 1)]
        public LinkedList<bool> TablesInDB { get; set; }
        [Parameter("bytes32", "ipAdd", 2)]
        public string IPAddress { get; set; }
    }
}
