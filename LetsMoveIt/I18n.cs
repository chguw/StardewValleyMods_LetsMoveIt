using System;
using StardewModdingAPI;

namespace LetsMoveIt
{
    /// <summary>I18n Translation Manager</summary>
    internal static class I18n
    {
        private static ITranslationHelper? Translations;

        /// <summary>Reading Translation</summary>
        /// <param name="translations">Reading Translation</param>
        public static void Init(ITranslationHelper translations)
        {
            Translations = translations;
        }

        /// <summary>Translation of Config</summary>
        /// <param name="key">Translation key: config.{key}</param>
        public static string Config(string key)
        {
            return Get("config." + key);
        }

        /// <summary>Get the Translation</summary>
        /// <param name="key">Translation key</param>
        /// <param name="tokens">Translation tokens</param>
        public static Translation Get(string key, object? tokens = null)
        {
            if (Translations == null)
            {
                throw new InvalidOperationException("You must call I18n.Init from the mod's entry method before reading translations.");
            }
            return Translations.Get(key, tokens);
        }
    }
}
