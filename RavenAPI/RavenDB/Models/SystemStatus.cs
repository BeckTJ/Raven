﻿using System;
using System.Collections.Generic;

namespace RavenDB.Models;

public partial class SystemStatus
{
    public string StatusCode { get; set; } = null!;

    public string StatusName { get; set; } = null!;
}
