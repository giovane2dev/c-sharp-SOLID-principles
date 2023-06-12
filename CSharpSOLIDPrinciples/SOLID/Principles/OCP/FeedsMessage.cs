using System.Diagnostics.CodeAnalysis;
using SOLID.Principles.OCP;

namespace SOLID.Principles.OCP
{
    public class FeedsMessage : Message
    {
        public FeedsMessage()
        {

        }    

        // applies concept of Extension Method for Open-Closed Principle
        public override void Create(string longMessage)
        {
            Console.WriteLine(longMessage.ToLowerCase());
        }
    }
}
