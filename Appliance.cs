﻿
namespace SwitchBoardSimulation
{
    public class Appliance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Appliance(string name, int id)
        {
            Id = id;
            Name = name; 
        }
    }
}
