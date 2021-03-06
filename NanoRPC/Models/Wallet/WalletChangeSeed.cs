using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletChangeSeedRequest : IRPCAction
  {
    public string Action { get; } = "wallet_change_seed";

    public string Wallet { get; set; }

    public string Seed { get; set; }

    /// <summary>
    /// Number, 0 by default. Manually set count of accounts to restore from seed
    /// </summary>
    public int? Count { get; set; }


  }

  public class WalletChangeSeedResponse
  {
    public string Success { get; set; }
  }
}
