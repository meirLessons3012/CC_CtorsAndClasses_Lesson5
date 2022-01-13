using System;

namespace CC_CtorsAndClasses_Lesson5
{
    public class Program  :object
    {
        static void Main(string[] args)
        {
            #region Constructors

            #region Ctors

            //CreditCard cc1 = new CreditCard();Error
            CreditCard cc2 = new CreditCard(652673523123, 2022, 742);
            CreditCard cc3 = new CreditCard("moshe", 23414523254132, 2025, 713);
            CreditCard cc4 = new CreditCard("yoni", 46512435234124, 2026, 614,"green");
            
            #endregion

            //Copy By Value
            int x = 10;
            int y = x;
            x = 3;

            //Cpy By Reference
            CreditCard cc5 = cc3;
            cc3.cvv = 123;//cvv of "cc5" = 123
            cc5.validToYear = 2030;//year of "cc3" = 2030

            //Copy Constructor
            CreditCard cc6 = new CreditCard(cc3);
            cc3.validToYear = 2026;

            PrintCardDetails("moshe", 23414523254132, DateTime.Now.AddYears(3), 713);

            #region Exr Ctors

            Animal parameterlessA1 = new Animal();
            Animal parameterlessA2 = new Animal();
            Animal twoParamsA1 = new Animal("cow", 5);
            Animal twoParamsA2 = new Animal("DOG", 11);

            Animal[] children = { parameterlessA1, twoParamsA1 };
            Animal[] children1 = null;
            Animal[] children2 = new Animal[0];
            Animal withArray1 = new Animal(children);
            Animal withArray2 = new Animal(children1);

            #endregion
            
            #endregion

            #region Classes

            #region object methods

            Console.WriteLine($"ReferenceEquals(cc5, cc3): {object.ReferenceEquals(cc5, cc3)}");//true
            cc3.Equals(cc2);//false
            Console.WriteLine(children.GetType());//Array[Animal]
            Console.WriteLine(parameterlessA2.GetType());//Animal

            #endregion

            #region Exr

            Plane[] planes = new Plane[3];
            for (int i = 0; i < 3; i++)
            {
                string companyName = Console.ReadLine();
                int numbOfSeats = int.Parse(Console.ReadLine());
                Plane plane = new Plane(companyName, numbOfSeats);
                planes[i] = plane;

                //SHORT AND HARD WAY
                //planes[i] = new Plane(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }

            Plane p = new Plane();

            Plane pOI = new Plane()
            {
                company = "Elal",
                seats = 130,
                pilotName = "yussuf"
            };

            #endregion

            #endregion
        }

        public static void PrintCardDetails(string ownerName, long cardNumber, DateTime validTo, int cvv)
        {
            Console.WriteLine($"ownerName: {ownerName}. Card Number: {cardNumber}. Valid To: {validTo}. Cvv: ***");
        }
    }

    public class CreditCard
    {
        public string _ownerName;
        public long cardNumber;
        public int validToYear;
        public int cvv;
        public string _backgroundColor;
        public string image;

        public CreditCard()
        {
            //Encode Card...
            //Encode Card...
            //Encode Card...
            //Encode Card...
            //Encrypt...
            //Encrypt...
            //Encrypt...
            //Encrypt...
            //Encrypt...
            //Encrypt...
            //
        }

        public CreditCard(long cardNumber, int validToYear, int cvv) : this()
        {
            this.cardNumber = cardNumber;
            this.validToYear = validToYear;
            this.cvv = cvv;
        }

        public CreditCard(string ownerName, long cardNumber, int validToYear, int cvv) : this(cardNumber,validToYear,cvv)
        {
            _ownerName = ownerName;
            //_cardNumber = cardNumber;
            //_validToYear = validToYear;
            //_cvv = cvv;
        }

        public CreditCard(string ownerName, long cardNumber, int validToYear, int cvv, string backColor) : 
            this(ownerName, cardNumber, validToYear, cvv)
        {
            //_ownerName = ownerName;
            //_cardNumber = cardNumber;
            //_validToYear = validToYear;
            //_cvv = cvv;
            _backgroundColor = backColor;
        }
        public CreditCard(string ownerName, long cardNumber, int validToYear, int cvv, string backColor, string image) :
            this(ownerName, cardNumber, validToYear, cvv, backColor)
        {
            this.image = image;
        }

        public CreditCard(CreditCard copyCC) :
            this(copyCC._ownerName, copyCC.cardNumber,copyCC.validToYear, copyCC.cvv, copyCC._backgroundColor, copyCC.image)
        {

            //_ownerName = copyCC._ownerName;
            //_cardNumber = copyCC._cardNumber;
            //_validToYear = copyCC._validToYear;
            //_cvv = copyCC._cvv;
            //_backgroundColor = copyCC._backgroundColor;
        }

        public void MakeTransaction()
        {
            //
            //
            //
        }
    }

    public class Animal
    {
        public string type;
        public int age;
        public bool withChildren;

        public Animal()
        {
            Console.WriteLine("new animal created....");
        }

        public Animal(string type, int age)
        {
            this.type = type;
            this.age = age;
        }

        public Animal(Animal[] children)
        {
            if(children == null || children.Length == 0)
            {
                Console.WriteLine("array is null or length = 0");
                withChildren = false;
            }
            else
            {
                withChildren = true;
            }
        }
    }

    public class Cat : Animal
    {

    }

    public class Plane
    {
        public string company;
        public int seats;
        public string pilotName;

        public Plane()
        {

        }

        public Plane(string company, int seats)
        {
            this.company = company;
            this.seats = seats;
        }
    }
}
