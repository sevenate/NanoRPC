using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountInfoRequest : IRPCAction
  {
    public string Action { get; } = "account_info";

    public string Account { get; set; }
    public bool? Representative { get; set; }
    public bool? Weight { get; set; }
    public bool? Pending { get; set; }
  }

  public class AccountInfoResponse
  {
    public string Frontier { get; set; }
    public string Open_Block { get; set; }
    public string Representative_Block { get; set; }
    public string Balance { get; set; }
    public string Modified_timestamp { get; set; }
    public string Block_Count { get; set; }
    public string Representative { get; set; }
    public string Weight { get; set; }
    public string Pending { get; set; }
  }
}