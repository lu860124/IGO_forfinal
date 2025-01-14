﻿using System;
using System.Collections.Generic;

#nullable disable

namespace IGO.Models
{
    public partial class TTestResult
    {
        public int FTestResultId { get; set; }
        public int? FCustomerId { get; set; }
        public string FTestResultType { get; set; }
        public int? FPoint { get; set; }
        public int? FTestResultTypeId { get; set; }

        public virtual TCustomer FCustomer { get; set; }
    }
}
