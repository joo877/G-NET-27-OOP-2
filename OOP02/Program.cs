namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region part01
            #region Q1
            /*
             a : 
            promlem01: don't apply encapsulation, so we can access the data of the class directly and change it without any control, which can lead to unexpected behavior and bugs in the program.
            promlem02: don't check if balance  >= amount before withdraw, which can lead to negative balance and financial issues.
             

            b : public string Owner { get; set; }
                public double Balance { get; private set; }

            public void Withdraw(double amount)
                    {
                       if (Balance >= amount)
                       Balance -= amount;
             Console.WriteLine("Balance don't enough")
                    }


            c : if fields are public, we can access them directly and change their values without any control
                EX: if we have a public field for balance, we can set it to a negative value or a very large value, which can cause financial issues. 
                (applied encapsulation) : By using properties with private setters, we can control how the balance is modified and ensure that it remains within acceptable limits.

             */
            #endregion

            #region Q2
            /*
             field                                      Vs                     property
            1- can be accessed directly                        1- can be accessed through get/set methods
            2- no control over how the data is accessed        2- can control how the data is accessed and modified
            3- no encapsulation                                3- supports encapsulation
            4- no validation or logic can be applied when      4- can apply validation or logic 
             
             * ptoprety (full property or indexer)  can contain complix logic in the get and set accessors, 
             * while auto-implemented properties are a shorthand syntax for properties that do not require additional logic in the accessors. 
             

            ##    public double Balance { get; private set; } (read only outside class can setter it only in class)
            ##   public double Balance { get;  } ( always read only  )
            ##    public double Balance => _balance; ( expression-bodied property, read only and can contain logic in the expression)
             */
            #endregion

            #region Q3
            /*
             ## a : indexer is a special property that accepted parametars (always named (this))
           prupose: to allow objects to be indexed like arrays or collections

            =====================================================================================
            ## b :   private string[] names = new string[5]; 
                    register[10] = "Ali";  throw exception (out of rang execption) 
                   because don't have index 10, last index is [4] and we don't hadle the exception, so it will crash the program.

            handle the exception :
                    set {

                   if (index >= 0 && index < names.Length)
                      names[index] = value;
            }
            in this way we can prevent the program from crashing and handle the 

            =====================================================================================

            ## c : class have more than one indexer (must be with different parametars)
            EX: "As a librarian, I want a Library system where I can add books, find a book by its shelf position, or look it up by ISBN — like a real catalog."
            in this example, we can have two indexers in the Library class: 
            one that takes an integer parameter for shelf position and another that takes a string parameter for ISBN. This allows us to access books in different ways 


              */
            #endregion
            #endregion
        }
    }
}
