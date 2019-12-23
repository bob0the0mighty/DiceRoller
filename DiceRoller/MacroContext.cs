﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    /// <summary>
    /// Contains the context of a macro execution, to be filled out
    /// by the function which is responsible for executing the macro.
    /// </summary>
    public class MacroContext
    {
        /// <summary>
        /// The overall value of the macro.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// What sort of value the macro returns.
        /// </summary>
        public ResultType ValueType { get; set; }

        /// <summary>
        /// If the macro rolls any dice, it should add their results to this list.
        /// If the macro does not roll dice, this need not be touched. If null or empty,
        /// a Literal DieResult will be inserted with its value set to Value.
        /// </summary>
        public IEnumerable<DieResult>? Values { get; set; }

        /// <summary>
        /// The parameter passed to the macro. The function is responsible for
        /// parsing this into something usable.
        /// </summary>
        public string Param { get; private set; }

        /// <summary>
        /// The name of the macro, if using the recommended method of separating arguments with colons.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The arguments of the macro (including the name), if using the recommended method of separating
        /// arguments with colons.
        /// </summary>
        public IReadOnlyList<string> Arguments { get; private set; }

        /// <summary>
        /// RollData attached to this macro execution
        /// </summary>
        public RollData Data { get; private set; }

        internal MacroContext(string param, RollData data)
        {
            Value = Decimal.MinValue;
            Values = null;
            ValueType = ResultType.Total;
            Param = param;
            Data = data;

            // parse Param
            Param = Param.Trim();
            string[] args = Param.Split(':');

            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].Trim();
            }

            Name = args[0];
            Arguments = args;
        }
    }
}
