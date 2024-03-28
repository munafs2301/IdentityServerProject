﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace Qualee.IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids => new IdentityResource[]
            {
                new IdentityResources.OpenId(), // Allows support for subject id 
                new IdentityResources.Profile() // Allows support for family_name, given_name
            };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
            { };

        public static IEnumerable<ApiResource> Apis => new ApiResource[] { };

        public static IEnumerable<Client> Clients => new Client[]
            { };
    }
}