using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string CategoryLimitExceded = "Category limit exceded";
        public static string AuthorizationDenied= "You are not authorized";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is wrong";
        public static string SuccessfulLogin = "Login successful";
        public static string UserAlreadyExists = "Username is already taken";
        public static string AccessTokenCreated = "Token created";
    }
}
