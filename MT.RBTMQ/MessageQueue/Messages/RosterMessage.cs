using MT.RBTMQ.MessageQueue.Serialisation;
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

        public string ProviderId { get; set; }
        public int Npi { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }

    }
}