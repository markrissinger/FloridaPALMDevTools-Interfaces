using FloridaPALMInterfaces.Helpers;

namespace FloridaPALMInterfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class InterfaceIdentification : Attribute
    {
        internal InterfaceIdentification(string interfaceId, string interfaceName, InterfaceConstants.InterfaceDirections interfaceDirection) 
        {
            Id = interfaceId;
            Name = interfaceName;
            Direction = interfaceDirection;
        }

        public string Id { get; set; } 
        public string Name { get; set; }
        public InterfaceConstants.InterfaceDirections Direction { get; set; }
    }
}
