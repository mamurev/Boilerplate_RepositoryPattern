using System;
using System.Collections.Generic;
using System.Text;
using Company.Core.Entity.Concrete;

namespace Company.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductUpdated = "Product updated.";
        public static string ProductDeleted = "Product deleted.";

        public static string UserNotFound = "User not found";
        public static string PasswordError = "Invalid password";
        public static string SuccessfulLogin = "Logged In";
        public static string UserAlreadyExists = "User already exists";

        public static string UserRegistered = "User registered";

        public static string AccessTokenCreated = "Access token created.";
    }
}
