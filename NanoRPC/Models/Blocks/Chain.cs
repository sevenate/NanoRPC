using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ChainRequest : IRPCAction
  {
    public string Action { get; } = "chain";

    public string Block { get; set; }
    public string Count { get; set; }
  }

  public class ChainResponse
  {
    public List<string> Blocks { get; set; }
  }
}
