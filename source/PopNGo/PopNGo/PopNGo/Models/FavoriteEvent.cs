﻿using System;
using System.Collections.Generic;

namespace PopNGo.Models;

public partial class FavoriteEvent
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public virtual Event Event { get; set; }

    public virtual PgUser User { get; set; }
}
