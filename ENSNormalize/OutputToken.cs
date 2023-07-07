using System;
using System.Collections.Generic;

namespace ADRaffy.ENSNormalize
{

    public class OutputToken
    {
#if NET35
        public readonly IList<int> Codepoints;
#else
        public readonly IReadOnlyList<int> Codepoints;
#endif
        public readonly EmojiSequence? Emoji;
        public bool IsEmoji { get => Emoji != null; }

#if NET35
        public OutputToken(IList<int> cps, EmojiSequence? emoji = null)
#else
        public OutputToken(IReadOnlyList<int> cps, EmojiSequence? emoji = null)
#endif
        {
            Emoji = emoji;
            Codepoints = cps;
        }
        public override string ToString() 
        {
            string name = IsEmoji ? "Emoji" : "Text";
            return $"{name}[{Codepoints.ToHexSequence()}]";
        }
    }
}
