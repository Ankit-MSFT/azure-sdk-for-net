// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Improve search recall by spell-correcting individual search query terms. </summary>
    internal readonly partial struct Speller : IEquatable<Speller>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Speller"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Speller(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string LexiconValue = "lexicon";

        /// <summary> Speller not enabled. </summary>
        public static Speller None { get; } = new Speller(NoneValue);
        /// <summary> Speller corrects individual query terms using a static lexicon for the language specified by the queryLanguage parameter. </summary>
        public static Speller Lexicon { get; } = new Speller(LexiconValue);
        /// <summary> Determines if two <see cref="Speller"/> values are the same. </summary>
        public static bool operator ==(Speller left, Speller right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Speller"/> values are not the same. </summary>
        public static bool operator !=(Speller left, Speller right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Speller"/>. </summary>
        public static implicit operator Speller(string value) => new Speller(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Speller other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Speller other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
