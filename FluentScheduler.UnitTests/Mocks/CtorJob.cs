﻿namespace FluentScheduler.UnitTests.Mocks
{
    public class CtorJob : IJob
    {
        public CtorJob() => ++Calls;

        public static int Calls { get; private set; }

        public void Execute() { }
    }
}
