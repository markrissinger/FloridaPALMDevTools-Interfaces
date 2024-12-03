using FloridaPALMInterfaces.Helpers;

namespace FloridaPALMInterfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ChildRecord : Attribute
    {
        internal ChildRecord() 
        {
        }
    }
}
