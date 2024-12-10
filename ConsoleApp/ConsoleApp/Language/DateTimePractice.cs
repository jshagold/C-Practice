using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    internal class DateTimePractice
    {
        public void Main()
        {
            // Local, Utc, toLocal, toUtc, ToTimeStamp, ToLocal, 원하는 형식 출력, DateTime에 시간 더하기 빼기, hour, day, DateTime끼리 빼기

            // local
            Console.WriteLine($"Local: {DateTime.Now}");

            // Utc
            Console.WriteLine($"Utc: {DateTime.UtcNow}");

            // toLocal
            DateTime dateTime = DateTime.UtcNow;
            Console.WriteLine($"toLocal: {dateTime.ToLocalTime()}");

            // toUtc
            Console.WriteLine($"toUtc: {DateTime.Now.ToUniversalTime()}");

            // ToTimeStamp
            DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;
            Console.WriteLine($"ToTimeStamp: {dateTimeOffset.ToUnixTimeSeconds()}");

            // ToLocal
            Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(dateTimeOffset.ToUnixTimeSeconds()));

            // 원하는 형식 출력
            Console.WriteLine($"원하는 형식 출력: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss z")}");

            // DateTime에 시간 더하기 빼기
            Console.WriteLine(DateTime.Now.AddMinutes(30));
            Console.WriteLine(DateTime.Now.DayOfWeek);

            // DateTime끼리 빼기
            var timeSpan = DateTime.Now - DateTime.Now.AddHours(3);
            Console.WriteLine($"DateTime끼리 빼기: {timeSpan.TotalHours}");
        }
    }
}
