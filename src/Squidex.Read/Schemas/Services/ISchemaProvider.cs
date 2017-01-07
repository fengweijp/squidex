﻿// ==========================================================================
//  ISchemaProvider.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.Threading.Tasks;

namespace Squidex.Read.Schemas.Services
{
    public interface ISchemaProvider
    {
        Task<string> FindSchemaNameByIdAsync(Guid schemaId);

        Task<Guid?> FindSchemaIdByNameAsync(Guid appId, string name);
    }
}
