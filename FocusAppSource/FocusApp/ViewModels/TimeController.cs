using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusApp.ViewModels
{
    internal class TimeController
    {
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;
        public void TimeProgression(int count)
        {
            if (count == 0)
                return;

            Seconds += count;
            if (count > 0)
            {
                if (Seconds > 59)
                {
                    Minutes++;
                    Seconds = 0;
                }
                if (Minutes > 59)
                {
                    Hours++;
                    Minutes = 0;
                }

            }
            else
            {
                if (Seconds < 0)
                {
                    Seconds = 59;
                    Minutes--;
                }
                if (Minutes < 0)
                {
                    Minutes = 59;
                    Hours--;
                }
            }
        }
        public bool IsFinishTime()
        {
            return (Seconds <= 0 && Minutes <= 0 && Hours <= 0);
        }
        public (int _hour, int _minute, int _second) TimerExport()
        {
            return (Hours, Minutes, Seconds);
        }
        public void TimeSet(int _hour, int _minute)
        {
            Hours = _hour + (_minute - (_minute % 60)) / 60;
            Minutes = (_minute % 60);
            Seconds = 0;
        }
        public void TimeSet((int _hour, int _minute, int _second) _time)
        {
            Hours = _time._hour;
            Minutes = _time._minute;
            Seconds = _time._second;
        }
    }
}
