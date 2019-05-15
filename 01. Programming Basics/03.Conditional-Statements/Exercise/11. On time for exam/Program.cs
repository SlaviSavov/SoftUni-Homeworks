using System;

namespace _11._On_time_for_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputExamTimeHour = int.Parse(Console.ReadLine());
            var inputExamTimeMinute = int.Parse(Console.ReadLine());
            var inputArrivalHour = int.Parse(Console.ReadLine());
            var inputArrivalMinute = int.Parse(Console.ReadLine());

            var timeExam = inputExamTimeHour * 60 + inputExamTimeMinute;
            var timeArrival = inputArrivalHour * 60 + inputArrivalMinute;

            if (timeArrival > timeExam)
            {
                var timeLate = timeArrival - timeExam;
                if (timeLate < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", timeLate);
                }
                else if (timeLate >= 60)
                {
                    var hoursLate = timeLate / 60;
                    var minutesLate = timeLate % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} {1:00} hours after the start", hoursLate, minutesLate);
                }
            }
            else if ((timeArrival + 30 >= timeExam) && (timeArrival <= (timeExam + 30)))
            {
                var timeOnTime = timeExam - timeArrival;
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeOnTime);
            }
            else if (timeArrival < timeExam)
            {
                var timeEarly = timeExam - timeArrival;
                if (timeEarly < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", timeEarly);
                }
                else if (timeEarly >= 60)
                {
                    var hoursEarly = timeEarly / 60;
                    var minutesEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} {1:00} hours before the start", hoursEarly, minutesEarly);
                }
            }
        }
    }
}
