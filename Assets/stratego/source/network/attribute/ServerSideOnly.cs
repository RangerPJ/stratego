﻿using System;

/// <summary>
/// Marks a field or method that should only be used on the server side.
/// This is not inforced, but problems may heppen if these are used on
/// the wrong side.
/// </summary>
[AttributeUsage(
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property)
]
public class ServerSideOnly : Attribute {

    public ServerSideOnly() { }
}
