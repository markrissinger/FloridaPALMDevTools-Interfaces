using FloridaPALMInterfaces.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FloridaPALMInterfaces.Interfaces
{
    public abstract class PalmInterface
    {
        public override string ToString()
        {
            var journalEntry = new StringBuilder();

            journalEntry.Append(string.Join
            (
                // Header Record
                "|",
                this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(prop => Attribute.IsDefined(prop, typeof(InterfaceFieldPosition)))
                    .OrderBy(prop => prop.GetCustomAttribute<InterfaceFieldPosition>()?.FieldPosition)
                    .Select
                    (
                        prop => (prop.GetValue(this) ?? string.Empty).ToString()
                    )
            ));

            // Children Records
            var childrenRecordTypes = this.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(prop => !Attribute.IsDefined(prop, typeof(InterfaceFieldPosition)));

            var childrenLines = new StringBuilder();

            foreach (var childrenRecordType in childrenRecordTypes)
            {
                if (childrenRecordType.PropertyType.IsEnum)
                {
                    foreach (var record in (IEnumerable)childrenRecordType.GetValue(this))
                    {
                        journalEntry.Append(record.ToString());
                    }
                }
                else
                {
                    journalEntry.Append(childrenRecordType.GetValue(this)?.ToString());
                }
            }

            return journalEntry.ToString();
        }
    }
}