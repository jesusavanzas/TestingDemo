

namespace MyLibrary
{
    public class Customer
    {
        //se llaman propiedades
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        //propiedad que me de nombre completo (uso de lambda)
        public string FuName => $"{FirstName} {Lastname}";
        
            
        
    }
}
