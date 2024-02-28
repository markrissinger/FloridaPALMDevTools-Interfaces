using FloridaPALMInterfaces.Helpers;

namespace FloridaPALMInterfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class InterfaceDirection : Attribute
    {
        public string? InterfaceName { get; set; }

        public InterfaceConstants.InterfaceDirections Direction { get; set; }
    }
}
