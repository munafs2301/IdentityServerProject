// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "a9ea0f25-b964-409f-bcce-c923266249b4",
                        Username = "John",
                        Password = "JohnPassword",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "John"),
                            new Claim(JwtClaimTypes.FamilyName, "Doe")
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "c95ddb8c-79ec-488a-a485-fe57a1462340",
                        Username = "Jane",
                        Password = "JanePassword",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Jane"),
                            new Claim(JwtClaimTypes.GivenName, "Doe")
                        }
                    }
                };
            }
        }
    }
}