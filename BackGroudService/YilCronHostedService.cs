using BackGroudService.ServiceAdapters.SensorTransactionServices;
using Core.Utilities.DefaultValues;
using Microsoft.Extensions.Hosting;
using NCrontab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BackGroudService
{
    public class YilCronHostedService : BackgroundService
    {
        private CrontabSchedule _schedule;
        private DateTime _nextRun;
        private ISensorTransactionCheckService sensorTransactionService;

        private string Schedule => "*/10 * * * * *"; //Runs every 10 seconds

        //* * * * * *
        //- - - - - -
        //| | | | | |
        //| | | | | +--- day of week(0 - 6) (Sunday=0)
        //| | | | +----- month(1 - 12)
        //| | | +------- day of month(1 - 31)
        //| | +--------- hour(0 - 23)
        //| +----------- min(0 - 59)
        //+------------- sec(0 - 59)

        public YilCronHostedService(ISensorTransactionCheckService sensorTransactionService)
        {
            this.sensorTransactionService = sensorTransactionService;
            _schedule = CrontabSchedule.Parse(Schedule, new CrontabSchedule.ParseOptions { IncludingSeconds = true });
            _nextRun = _schedule.GetNextOccurrence(DefaultValue.Today);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(60000, stoppingToken); // 1 dk sonra calis
            int beklemeZamani = 600000; //600000 10 dk ka
            do
            {
                var now = DefaultValue.Today;
                var nextrun = _schedule.GetNextOccurrence(now);
                if (now > _nextRun)
                {
                    Process();
                    _nextRun = _schedule.GetNextOccurrence(DefaultValue.Today);
                }
                // await Task.Delay(5000, stoppingToken); //5 seconds delay
                await Task.Delay(beklemeZamani, stoppingToken); //10 dk ka delay
            }
            while (!stoppingToken.IsCancellationRequested);
        }

        private void Process()
        {
            Console.WriteLine("calisti: " + DefaultValue.Today);
            sensorTransactionService.CheckSensorTransaction(DefaultValue.Today.AddMinutes(-12), DefaultValue.Today);
            Console.WriteLine("sonuclandi: " + DefaultValue.Today);
        }
    }
}
