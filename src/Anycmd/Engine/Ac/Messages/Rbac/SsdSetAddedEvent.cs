﻿
namespace Anycmd.Engine.Ac.Messages.Rbac
{
    using Abstractions.Rbac;
    using InOuts;

    public class SsdSetAddedEvent: EntityAddedEvent<ISsdSetCreateIo>
    {
        public SsdSetAddedEvent(IUserSession userSession, SsdSetBase source, ISsdSetCreateIo output)
            : base(userSession, source, output)
        {
        }
    }
}