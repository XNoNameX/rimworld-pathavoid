﻿using System.Collections.Generic;
using Verse;

namespace PathAvoid
{
    internal class PathDesignationCategoryDef : DesignationCategoryDef
    {
        public override void ResolveReferences()
        {
            LongEventHandler.ExecuteWhenFinished(delegate
            {
                List<Designator> list = base.AllResolvedDesignators;
                foreach (PathAvoidDef current in DefDatabase<PathAvoidDef>.AllDefs)
                {
                    list.Add(new Designator_PathAvoid(current));
                }
            });
        }
    }
}
