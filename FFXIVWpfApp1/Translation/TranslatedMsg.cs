﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIITataruHelper.Translation
{
    public class TranslatedMsg
    {
        public string OriginalText;
        public string TranslatedText;

        public bool IsTranslated
        {
            get
            {
                if (TranslatedText == String.Empty)
                    return true;

                return false;
            }
        }

        public TranslatedMsg(string originalText, string translatedText)
        {
            OriginalText = originalText;
            translatedText = TranslatedText;
        }

        public TranslatedMsg()
        {
            OriginalText = String.Empty;
            TranslatedText = String.Empty;
        }
    }
}
