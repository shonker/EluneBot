﻿using KrycessBot.Enums;
using System;

namespace KrycessBot.Game.Models
{
    public class WoWUnit : WoWObject
    {
        public WoWUnit(ulong guid, IntPtr pointer, WoWObjectType type)
            : base(guid, pointer, type) { }
    }
}
