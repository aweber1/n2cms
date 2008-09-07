﻿using System;
using System.Collections.Generic;

namespace N2.Definitions
{
    /// <summary>
    /// Disables a definition removing it from lists when choosing new items. 
    /// Existing items will not be affaceted.
    /// </summary>
    public class DisableAttribute : Attribute, IDefinitionRefiner
    {
        public void Refine(ItemDefinition currentDefinition, IList<ItemDefinition> allDefinitions)
        {
            currentDefinition.Enabled = false;
        }
    }
}