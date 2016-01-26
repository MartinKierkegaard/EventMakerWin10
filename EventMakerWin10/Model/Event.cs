﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerWin10.Model
{
    /// <summary>
    /// klasse som holder en nybegivenhed(Event)
    /// </summary>
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string  Place { get; set; }
        public DateTime DateTime { get; set; }


        public Event()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Description: {1}, Place: {2}, Date: {3} ", Id,Name,Description,Place,DateTime.Date) ;
        }

    }
}
