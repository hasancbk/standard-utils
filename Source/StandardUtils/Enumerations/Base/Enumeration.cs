using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StandardUtils.Enumerations.Base
{
    [Serializable]
    public abstract class Enumeration : IComparable
    {
        public int Value { get; }
        public Guid Uid { get; }
        public string Name { get; }
        public string Description { get; }

        protected Enumeration() { }

        protected Enumeration(int value, string name)
        {
            Uid = new Guid();
            Value = value;
            Name = name;
        }

        protected Enumeration(int value, Guid uid, string name) : this(value, name)
        {
            Uid = uid;
        }

        protected Enumeration(int value, Guid uid, string name, string description) : this(value, uid, name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<T>().ToList();
        }
        
        public static T Get<T>(long value) where T : Enumeration
        {
            var item = GetAll<T>().Find(x => x.Value == value);

            return item;
        }

        public static T Get<T>(Guid uid) where T : Enumeration
        {
            var item = GetAll<T>().Find(x => x.Uid == uid);

            return item;
        }

        public static T Get<T>(string name) where T : Enumeration
        {
            var item = GetAll<T>().Find(x => x.Name == name);

            return item;
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool IsValueNotValid<T>(int value) where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            for (var i = 0; i < fields.Length; i++)
            {
                var field = fields[i];
                if (field.GetValue(null).ToString() == FromValue<T>(value).ToString())
                {
                    return false;
                }
            }

            return true;
        }

        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Value == value);
            return matchingItem;
        }

        public static T FromName<T>(string displayName) where T : Enumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.Name == displayName);
            return matchingItem;
        }

        public static T FromUid<T>(Guid uid) where T : Enumeration
        {
            var matchingItem = Parse<T, Guid>(uid, "uid", item => item.Uid == uid);
            return matchingItem;
        }

        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            if (matchingItem == null)
            {
                var message = $"'{value}' is not a valid {description} in {typeof(T)}";
                throw new ApplicationException(message);
            }

            return matchingItem;
        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}