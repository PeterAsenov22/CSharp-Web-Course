﻿namespace SIS.HTTP.Extensions
{
    using System;

    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} cannot be null");
            }
            return Char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        public static string ToCamelCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} cannot be null");
            }

            return Char.ToLower(input[0]) + input.Substring(1);
        }
    }
}
