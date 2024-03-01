﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace password
{
    public class PasswordHasher
    {
        // Method to Hash a Password
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Compare a password
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashedInput, hashedPassword) == 0;
        }
    }
}