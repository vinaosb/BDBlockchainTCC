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
    public class AddTableOutput : IFunctionOutputDTO
    {
        [Parameter("uint64", "id", 1)]
        public BigInteger Id { get; set; }
    }

    public class BlkChainTable
    {
        [Parameter("uint128", "numData")]
        public BigInteger NumData { get; set; }
        [Parameter("mapping", "data", 2)]
        public LinkedList<BlkChainData> data { get; set; }
    }
}
