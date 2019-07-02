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

    [Function("addData")]
    public class AddDataFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("bytes32", "DataToHash", 2)]
        public string DataToHashFunc { get; set; }
    }

    [Function("updateData")]
    public class UpdateDataFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }

        [Parameter("bytes32", "DataToHash", 3)]
        public string DataToHashFunc { get; set; }

        [Parameter("bytes32", "prevHash", 4)]
        public string PrevHashFunc { get; set; }
    }

    [Function("deleteData")]
    public class DeleteDataFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }

        [Parameter("bytes32", "prevHash", 3)]
        public string PrevHashFunc { get; set; }
    }

    [Function("getCallForItem")]
    public class GetDataFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }
    }

    [Function("verify")]
    public class VerifyDataFunc : FunctionMessage
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }

        [Parameter("bytes32", "hash", 3)]
        public string Hash { get; set; }
    }
}
