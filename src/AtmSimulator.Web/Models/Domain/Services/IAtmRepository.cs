﻿using System;
using CSharpFunctionalExtensions;

namespace AtmSimulator.Web.Models.Domain
{
    public interface IAtmRepository
    {
        Result Register(Atm atm);

        Maybe<Atm> Get(Guid id);

        Result Update(Atm atm);
    }
}
