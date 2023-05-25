using System.Diagnostics.CodeAnalysis;

namespace SOLID.Principles.OCP
{
    public class FeedsMessage : Message
    {
        public FeedsMessage(string comment)
        {

        }    

        public override void Create(string longMessage)
        {
            Console.WriteLine(longMessage);
        }
    }
}
