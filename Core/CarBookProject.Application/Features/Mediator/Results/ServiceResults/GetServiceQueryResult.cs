﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.ServiceResults
{
    public class GetServiceQueryResult
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
