using P05_FootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P05_FootballTeamGenerator.Models
{
    public class Stat
    {
        private const int MIN_STAT_VALUE = 0;
        private const int MAX_STAT_VALUE = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int enduranse, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = enduranse;
            Spint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                ValidateStat(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }
        public int Spint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                ValidateStat(value, nameof(this.Spint));
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                ValidateStat(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                ValidateStat(value, nameof(this.Passing));
                this.passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                ValidateStat(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }
        public double OverallStat =>
            ((Endurance + Spint + Dribble + Passing + Shooting) / 5.0);




        private void ValidateStat(int value, string name)
        {
            if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatException,
                    name, MIN_STAT_VALUE, MAX_STAT_VALUE));
            }
        }


    }
}
