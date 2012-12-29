﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmdbWrapper.Utilities;
using Windows.Data.Json;

namespace TmdbWrapper.Movies
{
    /// <summary>
    /// Spoken language
    /// </summary>
    public class SpokenLanguage : ITmdbObject
    {
        /// <summary>
        /// Code of the language.
        /// </summary>
        public string Iso639_1 { get; set; }
        /// <summary>
        /// Name of the language.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The english name of the language.
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// Returns of this instance the ToString
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        void ITmdbObject.ProcessJson(JsonObject jsonObject)
        {
            Iso639_1 = jsonObject.GetNamedValue("iso_639_1").GetSafeString();
            Name = jsonObject.GetNamedValue("name").GetSafeString();
            EnglishName = jsonObject.GetNamedValue("english_name").GetSafeString();
        }
    }
}