// Guids.cs
// MUST match guids.h
using System;

namespace InveniasLimited.AttachToInvenias
{
    static class GuidList
    {
        public const string guidAttachToInveniasPkgString = "a379c369-e309-4d76-85c4-628a2bcfb5a1";
        public const string guidAttachToInveniasCmdSetString = "a63e3ce3-d21d-47b5-883f-c63c17422633";

        public static readonly Guid guidAttachToInveniasCmdSet = new Guid(guidAttachToInveniasCmdSetString);
    };
}