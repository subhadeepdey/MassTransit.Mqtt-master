﻿using MT.RBTMQ.MessageQueue.Serialisation;
using System;
using System.Collections.Generic;

namespace MT.RBTMQ.MessageQueue.Messages
{
  public class RosterMessage : IRawJsonArrayMessage<RosterItem>
  {
    public IEnumerable<RosterItem> Items { get; set; }
  }

  public class RosterItem
    {
    public DateTimeOffset? Timestamp { get; set; }
    public string Type { get; set; }
    public string Mac { get; set; }
    public int GatewayFree { get; set; }
    public double GatewayLoad { get; set; }
    public string BleName { get; set; }
    public string IbeaconUuid { get; set; }
    public double IbeaconMajor { get; set; }
    public double IbeaconMinor { get; set; }
    public double IbeaconTxPower { get; set; }
    public double Battery { get; set; }

    public string Rssi { get; set; }
    public string RawData { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }

  }
}