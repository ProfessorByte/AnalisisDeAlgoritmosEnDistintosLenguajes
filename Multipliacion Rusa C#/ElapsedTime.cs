using System;

namespace MultiplicacionRusa_C_
{
    public class ElapsedTime
    {
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan elapsedTime;
        public ElapsedTime() {}
        public void startTimeMeasure()
        {
            startTime = DateTime.Now;
        }
        public void endTimeMeasure()
        {
            endTime = DateTime.Now;
            elapsedTime = new TimeSpan(endTime.Ticks - startTime.Ticks);
        }
        public TimeSpan getElapsedTime()
        {
            return elapsedTime;
        }
    }
}