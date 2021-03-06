﻿using System;

namespace Nancy.RapidCache.Tests.Fakes
{
    public class FakeModule : NancyModule
    {
        public FakeModule()
        {
            Get("/CachedResponse", _ =>
            {
                return Response
                    .AsText($"this is a cached response random number: {Guid.NewGuid()}");
            });
        }
    }
}
