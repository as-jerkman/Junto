﻿using Junto.Data;
using Junto.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junto.Models.Team
{
    public class TeamEdit
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }

       // public virtual List<Channel> Channels { get; set; }

       // public virtual List<ApplicationUser> Users { get; set; }
    }
}
