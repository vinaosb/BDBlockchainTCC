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

namespace BDBlockchainTCC.BlockchainAPI.Events
{
    [Event("getItem")]
    public class GetItemEvent : IEventDTO
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }

        [Parameter("address", "sender", 3)]
        public string Sender { get; set; }
    }

    [Event("DataModified")]
    public class DataModifiedEvent : IEventDTO
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("uint128", "dId", 2)]
        public BigInteger Did { get; set; }

        [Parameter("address", "sender", 3)]
        public string Sender { get; set; }

        [Parameter("bytes32", "prevHash", 4)]
        public string PrevHash { get; set; }

        [Parameter("bytes32", "nextHash", 5)]
        public string NextHash { get; set; }
    }
}
