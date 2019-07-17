using P05_BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P05_BorderControl.Models
{
    public class Robot : IIdentible
    {
        public string Id { get; private set; }
        public string Model { get; private set; }

        public Robot(string id,string model)
        {
            Id = id;
            Model = model;
        }
    }
}
