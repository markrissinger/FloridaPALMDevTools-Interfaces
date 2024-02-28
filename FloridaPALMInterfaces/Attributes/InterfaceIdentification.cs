using FloridaPALMInterfaces.Helpers;

namespace FloridaPALMInterfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class InterfaceIdentification : Attribute
    {
        public string? Id { get; set; } 
        public string? Name { get; set; }
    }
}
