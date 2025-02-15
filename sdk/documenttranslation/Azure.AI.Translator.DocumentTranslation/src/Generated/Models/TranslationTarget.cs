// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translator.DocumentTranslation
{
    /// <summary> Destination for the finished translated documents. </summary>
    public partial class TranslationTarget
    {
        /// <summary> Initializes a new instance of TranslationTarget. </summary>
        /// <param name="targetUri"> Location of the folder / container with your documents. </param>
        /// <param name="languageCode"> Target Language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetUri"/> or <paramref name="languageCode"/> is null. </exception>
        public TranslationTarget(Uri targetUri, string languageCode)
        {
            if (targetUri == null)
            {
                throw new ArgumentNullException(nameof(targetUri));
            }
            if (languageCode == null)
            {
                throw new ArgumentNullException(nameof(languageCode));
            }

            TargetUri = targetUri;
            LanguageCode = languageCode;
            Glossaries = new ChangeTrackingList<TranslationGlossary>();
        }
        /// <summary> List of Glossary. </summary>
        public IList<TranslationGlossary> Glossaries { get; }
    }
}
