using MassTransit;
using MT.RBTMQ.MessageQueue.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT.RBTMQ.MessageQueue.Consumers
{
  public class RosterMessageConsumer : IConsumer<RosterMessage>
  {
    public async Task Consume(ConsumeContext<RosterMessage> context)
    {
      //context.Message.

      await Task.CompletedTask;
    }
  }
}