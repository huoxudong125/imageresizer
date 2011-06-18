﻿//------------------------------------------------------------------------------
// <copyright file="UpdateFilter.cs" company="Brice Lambson">
//     Copyright (c) 2011 Brice Lambson. All rights reserved.
//
//     The use of this software is governed by the Microsoft Public License
//     which is included with this distribution.
// </copyright>
//------------------------------------------------------------------------------

namespace BriceLambson.ImageResizer.Model
{
    public enum UpdateFilter
    {
        None = 0,
        Stable = ReleaseStatus.Stable,
        Beta = ReleaseStatus.Stable | ReleaseStatus.Beta,
        Alpha = ReleaseStatus.Stable | ReleaseStatus.Beta | ReleaseStatus.Alpha
    }
}