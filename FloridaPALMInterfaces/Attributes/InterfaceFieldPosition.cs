using FloridaPALMInterfaces.Helpers;

namespace FloridaPALMInterfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class InterfaceFieldPosition : Attribute
    {
        internal InterfaceFieldPosition(int fieldPosition) 
        {
            FieldPosition = fieldPosition;
        }
        public int FieldPosition { get; set; }
    }
}
