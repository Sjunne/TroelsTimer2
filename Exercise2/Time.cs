using System;

namespace Exercise2
{
    public struct Time
    {
        public int minutes;
        public int hours;
        

        public Time(int hh, int mm)
        {
            this.minutes = mm;
            hours = hh;
        }

        public override string ToString()
        {
            return $"{hours}{":"}{minutes}";
        }

        public void AddMinutes(int minutes)
        {

            if (this.minutes + minutes >= 59)
            {
                this.minutes = this.minutes + minutes - 60;

                if (hours < 23)
                {
                    hours++;
                }
                else
                {
                    hours = 0;
                }
            }
            else
            {
                this.minutes = minutes + this.minutes;
            }
        }

        public void SubstractMinutes(int minutes)
        {
            if (this.minutes - minutes <= 0)
            {
                this.minutes = minutes - 60;

                if (hours != 0)
                {
                    hours--;
                }
                else
                {
                    hours = 23;
                }
            }
            else
            {
                this.minutes = this.minutes - minutes;
            }
        }
    }
}