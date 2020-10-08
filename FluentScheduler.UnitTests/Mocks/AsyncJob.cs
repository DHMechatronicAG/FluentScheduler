﻿using System.Threading.Tasks;

namespace FluentScheduler.UnitTests.Mocks
{
    public class AsyncJob : IAsyncJob
    {
        public static int Calls { get; private set; }

        public async Task ExecuteAsync()
        {
            ++Calls;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Executes the job, synchronously.
        /// </summary>
        void IJob.Execute()
        {
            ExecuteAsync().Wait();
        }
    }
}
