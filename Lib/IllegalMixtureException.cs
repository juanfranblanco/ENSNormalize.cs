﻿namespace adraffy
{
    public class IllegalMixtureException : NormException
    {
        public readonly Group Group;
        public readonly int Codepoint;
        public readonly Group OtherGroup; // nullable
        internal IllegalMixtureException(string reason, int cp, Group group, Group other) : base("illegal mixture", reason)
        {
            Codepoint = cp;
            Group = group;
            OtherGroup = other;
        }
    }
}
