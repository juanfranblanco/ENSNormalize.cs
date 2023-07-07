using System.Collections.Generic;

namespace ADRaffy.ENSNormalize
{


    public class Label
    {
        // error: [Input, Tokens?, Error ]
        // valid: [Input, Tokens, Group, Normalized ]
#if NET35
        public readonly IList<int> Input;
        public readonly IList<OutputToken>? Tokens;
        public readonly IList<int>? Normalized;
#else
        public readonly IReadOnlyList<int> Input;
        public readonly IReadOnlyList<OutputToken>? Tokens;
        public readonly IReadOnlyList<int>? Normalized;
#endif
        public readonly NormException? Error;
        public readonly Group? Group;

#if NET35
        internal Label(IList<int> input, List<OutputToken>? tokens, NormException e) {
#else
        internal Label(IReadOnlyList<int> input, List<OutputToken>? tokens, NormException e) {
#endif
            Input = input;
            Tokens = tokens;
            Error = e;
        }

#if NET35
        internal Label(IList<int> input, List<OutputToken> tokens, int[] cps, Group g)
        {
#else
        internal Label(IReadOnlyList<int> input, List<OutputToken> tokens, int[] cps, Group g)  {
#endif
            Input = input;
            Tokens = tokens;
            Normalized = cps;
            Group = g;
        }
    }
}
