﻿namespace MeetingScheduler.Domain.Common;

public class DomainException : Exception
{
    public string BusinessMessage { get; private set; }

    public DomainException(string businessMessage)
    {
        BusinessMessage = businessMessage;
    }
}