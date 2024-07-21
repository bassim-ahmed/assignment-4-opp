using Assignment_opp_.Interface;

namespace Assignment_opp_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region 1
            // The primary purpose of an interface in C# is:

            //b) To define a blueprint for a class
            #endregion
            #region 2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion
            #region 3
            //Can an interface contain fields in C#?
            //b) No
            #endregion
            #region 4
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region 5
            //Which keyword is used to implement an interface in a class in C#?
            // d) implements
            #endregion
            #region 6
            //Can an interface contain static methods in C#?
            //a) Yes


            #endregion
            #region 7
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public


            #endregion
            #region 8
            //What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members


            #endregion
            #region 9
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors


            #endregion
            #region 10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas



            #endregion
            #endregion
            #region part 2
            #region q 1
            //ICircle circle = new Circle { Radius = 10 };
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle { Length = 2, Width = 4 };
            //rectangle.DisplayShapeInfo();
            #endregion
            #region q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "bassim";
            //string password = "1234";
            //string role = "admin";

            //bool Authenticated = authService.AuthenticateUser(username, password);
            //bool Authorized = authService.AuthorizeUser(username, role);

            //Console.WriteLine($"Authenticated: {Authenticated}");
            //Console.WriteLine($"Authorized: {Authorized}");

            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("bassim@gmail.com", " Email!");
            smsService.SendNotification("0112267473", " SMS!");
            pushService.SendNotification("user123", " Push Notification!");
            #endregion 

            #endregion

        }
    }
}
