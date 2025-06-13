using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace CosRimAir
{
    [DefOf]
    public static class CosRimMicroCommsDefOf
    {
        static CosRimMicroCommsDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(CosRimMicroCommsDefOf));
        }

        public static ThingDef CosRim_MicroCommsConsole;
    }
}
