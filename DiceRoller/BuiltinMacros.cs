﻿using System;
using System.Collections.Generic;
using System.Text;

using Dice.Builtins;

namespace Dice
{
    /// <summary>
    /// Built-in macros which are available in every context.
    /// </summary>
    [Obsolete("If you wish to call built-in functions, please call appropriate methods in the Dice.Builtins namespace")]
    public static class BuiltinMacros
    {
        /// <summary>
        /// Macro which expands to the number of dice rolled so far.
        /// </summary>
        /// <param name="context">Macro context.</param>
        public static void NumDice(MacroContext context)
        {
            DiceMacros.NumDice(context);
        }
    }
}
