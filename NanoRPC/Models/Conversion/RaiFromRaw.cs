using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class RaiFromRawRequest : IRPCAction
  {
    public string Action { get; } = "rai_from_raw";

    public string Amount { get; set; }
  }
}