﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019_Formula1
{
    class Team
    {
        private string _title;
        private Pilot _pilot1;
        private Pilot _pilot2;

        public string Title { get => _title; set => _title = value; }
        public Pilot Pilot1 
        {
            get
            {
                return _pilot1;
            }
            set 
            { 
                _pilot1 = value;
                value.TeamName = this;
            }
        }
        public Pilot Pilot2 
        { 
            get => _pilot2;
            set
            {
                _pilot2 = value; 
                value.TeamName = this;
            }
        }

        public Team() { }
        public Team(string title)
        {
            _title = title;
        }
        public Team(string title, Pilot pilot1, Pilot pilot2)
        {
            _title = title;
            _pilot1 = pilot1;
            _pilot2 = pilot2;
        }

        public override string ToString()
        {
            return $"team {_title} ( {_pilot1.Name} / {_pilot2.Name} )";
        }
    }
}
