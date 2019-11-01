using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class ResponseStatus : Enumeration
    {
        public static readonly ResponseStatus Unknown = new ResponseStatus(1, "Unknown", "not_informed_reason");
        public static readonly ResponseStatus Success = new ResponseStatus(2, "Success", "worked_successfully");
        public static readonly ResponseStatus Failed = new ResponseStatus(3, "Failed", "request_failed");
        public static readonly ResponseStatus Invalid = new ResponseStatus(4, "Invalid", "request_not_valid");
        public static readonly ResponseStatus SuccessWithProblems = new ResponseStatus(5, "SuccessWithProblems", "worked_successfully_but_some_parts_are_missing_check_messages");

        private ResponseStatus(int value, string name, string description) : base(value, Guid.NewGuid(), name, description) { }

        public bool IsSuccess => Value == Success.Value || Value == SuccessWithProblems.Value;
        public bool IsNotSuccess => !IsSuccess;
    }
}