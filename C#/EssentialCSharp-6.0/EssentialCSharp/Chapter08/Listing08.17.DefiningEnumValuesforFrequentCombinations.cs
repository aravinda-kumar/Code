﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_17
{
    using System;

    [Flags]
    enum DistributedChannel
    {
        None = 0,
        Transacted = 1,
        Queued = 2,
        Encrypted = 4,
        Persisted = 16,
        FaultTolerant =
            Transacted | Queued | Persisted
    }
}
