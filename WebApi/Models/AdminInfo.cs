﻿using System;
using System.Collections.Generic;

namespace WebApi.models;

public partial class AdminInfo
{
    public int Id { get; set; }

    public string? EmailId { get; set; }

    public string? Password { get; set; }
}
