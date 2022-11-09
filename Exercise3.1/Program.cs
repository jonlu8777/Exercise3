using System.Diagnostics.Metrics;

namespace Exercise3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  I Program.cs Main-metod: Skapa en lista med UserErrorsoch populera den med instanser av NumericInputError och TextInputError.
          List<UserError> errors = new List<UserError>();
            {
                errors.Add(new NumericInputError());
                errors.Add(new NumericInputError());
                errors.Add(new TextInputError());
                errors.Add(new TextInputError());
                errors.Add(new TextInputError());
                errors.Add(new WhiteSpaceInputError());
                errors.Add(new MouseClickError());
                errors.Add(new FileNameError());
                    
                    }
            //Skriv ut samtliga UserErrors UEMessage()genom enforeach loop.
          
            foreach(UserError uError in errors)
            {
               Console.WriteLine(uError.UEMessage());
            }

        }
    }
}