﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taskling.InfrastructureContracts.TaskExecution
{
    public class TaskExecutionMetaRequest : RequestBase
    {
        public int ExecutionsToRetrieve { get; set; }
    }
}
