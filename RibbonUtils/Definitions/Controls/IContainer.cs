﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Interface for all controls with inner elements
    /// </summary>
    public interface IContainer
    {
        IEnumerable<ControlDefinition> Controls { get; set; }
    }
}