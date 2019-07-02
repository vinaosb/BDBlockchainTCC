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
    public class AddDataOutput : IFunctionOutputDTO
    {
        [Parameter("bytes32", "hash", 1)]
        public string Hash { get; set; }

        [Parameter("uint128", "Id", 2)]
        public BigInteger Id { get; set; }
    }

    [FunctionOutput]
    public class UpdateDataOutput : IFunctionOutputDTO
    {
        [Parameter("bytes32", "hash", 1)]
        public string Hash { get; set; }
    }

    [FunctionOutput]
    public class DeleteDataOutput : IFunctionOutputDTO
    {
        [Parameter("bool", "deleted", 1)]
        public bool Deleted { get; set; }
    }

    [FunctionOutput]
    public class GetDataOutput : IFunctionOutputDTO
    {
        [Parameter("bytes32", "hash", 1)]
        public string Hash { get; set; }
    }

    [FunctionOutput]
    public class VerifyDataOutput : IFunctionOutputDTO
    {
        [Parameter("bool", "check", 1)]
        public bool Check { get; set; }
    }

    public class BlkChainData
    {
        [Parameter("bytes32", "hash", 1)]
        public string Hash { get; set; }

        [Parameter("bool", "deleted", 2)]
        public bool Deleted { get; set; }
    }
}
