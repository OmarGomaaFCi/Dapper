﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Dapper.Context
{
    public partial interface INorthwindContextProcedures
    {
        Task<List<GetTopIDsResult>> GetTopIDsAsync(int? top, OutputParameter<int?> overallcount, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
