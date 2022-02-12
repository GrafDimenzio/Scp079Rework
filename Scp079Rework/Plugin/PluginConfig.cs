﻿using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Scp079Rework
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("The Mappoint where the Scp079Robot should spawn")]
        public SerializedMapPoint RobotSpawn = new SerializedMapPoint("HCZ_079", 9.3f, -2.4f, 0f);

        [Description("The Health with which Scp079Robot spwans")]
        public int Health = 50;

        [Description("If set to true Scp070Robot can harm Scp's and even activate his own generator")]
        public bool RobotFF = false;

        [Description("The Items with which Scp079-robot spawns")]
        public SerializedPlayerInventory Inventory { get; set; } = new SerializedPlayerInventory
        {
            Items = new List<SerializedPlayerItem>
            {
                new SerializedPlayerItem((int)ItemType.GunCOM18, 15, 0, Vector3.one, 100, true),
                new SerializedPlayerItem((int)ItemType.Medkit, 0, 0, Vector3.one, 100, false),
            },
            Ammo = new SerializedAmmo
            {
                Ammo12 = 30,
                Ammo44 = 30,
                Ammo5 = 30,
                Ammo7 = 30,
                Ammo9 = 30
            }
        };

        [Description("The Amount of D-Personnel Robots Scp-079 can use")]
        public int Scp079DRobot = 1;

        [Description("The Amount of Scientist Robots Scp-079 can use")]
        public int Scp079SRobot = 1;

        [Description("The Amount of Guard Robots Scp-079 can use")]
        public int Scp079GRobot = 1;

        [Description("The Amount of Chaos Robots Scp-079 can use")]
        public int Scp079CRobot = 1;

        [Description("The Amount of MTF Robots Scp-079 can use")]
        public int Scp079MRobot = 1;

        [Description("Here can you setup the configuration of the existing Commands. You cant create Commands with this")]
        public List<CommandConfiguration> CommandConfigurations = new List<CommandConfiguration>
        {
            new CommandConfiguration
            {
                Name = "ExampleThatYouCanDelete",
                Cooldown = 30,
                Energy = 50,
                Exp = 5,
                RequiredLevel = 2
            }
        };
    }

    public class CommandConfiguration
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public float Energy { get; set; }
        public float Exp { get; set; }
        public float Cooldown { get; set; }
    }
}
