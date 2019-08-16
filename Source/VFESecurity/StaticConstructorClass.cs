﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using UnityEngine;
using Verse;
using Verse.AI;
using Verse.AI.Group;
using RimWorld;
using Harmony;

namespace VFESecurity
{

    [StaticConstructorOnStartup]
    public static class StaticConstructorClass
    {

        static StaticConstructorClass()
        {
            LongRangeArtilleryUtility.SetCache();
        }

    }

}
