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
    [Event("tableAdded")]
    public class TableAddedEvent : IEventDTO
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("address", "sender", 2)]
        public string Sender { get; set; }
    }

    [Event("tableAddedToDB")]
    public class TableAddedToDBEvent : IEventDTO
    {
        [Parameter("uint64", "tId", 1)]
        public BigInteger Tid { get; set; }

        [Parameter("address", "sender", 2)]
        public string Sender { get; set; }
    }
}
