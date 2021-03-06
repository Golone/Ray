﻿using Ray.Core;
using Ray.Core.Abstractions.Observer;
using Ray.Core.Event;
using System.Threading.Tasks;
using Transfer.Grains.Events;
using Transfer.IGrains;

namespace Transfer.Grains.Grains
{
    [Observer(DefaultGroup.second, DefaultName.Db, typeof(Account))]
    public sealed class AccountDb : ObserverGrain<long, Account>, IAccountDb
    {
        public Task EventHandle(TransferEvent evt, EventBasicInfo eventBase)
        {
            //此处更新db
            return Task.CompletedTask;
        }
        public Task EventHandle(TopupEvent evt, EventBasicInfo eventBase, EventUID fullyEvent)
        {
            //此处更新db
            return Task.CompletedTask;
        }
        public Task EventHandle(TransferArrivedEvent evt, EventBasicInfo eventBase)
        {
            //此处更新db
            return Task.CompletedTask;
        }
        public Task EventHandle(TransferRefundsEvent evt, EventBasicInfo eventBase)
        {
            //此处更新db
            return Task.CompletedTask;
        }
    }
}
