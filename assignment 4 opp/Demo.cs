using assignment_4_opp.ICloneable_Interface;
using assignment_4_opp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp
{

    internal class Demo
    {

        public static void Print10numbersserisByTwo(ISeris serisByTwo)
        {
            if (serisByTwo is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(serisByTwo.Current);
                    serisByTwo.GetNext();
                }
                serisByTwo.Reset();

            }
        }
            static void main(string[] args)
            {
                #region Interface
                //Imytype mytype = new Imytype(); //invalid
                //you cant create an object from interface
                //Imytype mytype;
                //you can create refrence from interface
                //CLR will allocate 4 byts for refeernce "mytype"
                //refernce mytype  refer to null
                //refernce mytype can refer to an object class or struct implement interface
                //mytype.Id = 20; invalid Imytype refer to null
                //mytype.MyFun(290); invalid bc Imytype refer to null
                //MyType myType = new MyType();
                //  myType.Id = 1;
                //  myType.MyFun(12);
                //myType.Print();//invalid
                //Imytype mytype=new MyType();
                //mytype.Id = 1;
                //mytype.Print();
                //mytype.MyFun(444);

                #endregion
                #region Interface ex 1
                ISeris serisByTwo = new SerisByTwo();

                Print10numbersserisByTwo(serisByTwo);

              ISeris serisBYthree= new SerisByThree();
            Print10numbersserisByTwo(serisBYthree);



            #endregion
                #region interface ex2
            Car car = new Car();
            car.Backward();
            Airplane airplane = new Airplane();
            airplane.Backward();

            IFlyable airplane2 = new Airplane();
            airplane2.Forward();
            IMoveable airplane3 = new Airplane();
            airplane3.Forward();

            #endregion
            #region shadowcopy and deepcopy
            #region array of value type 
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = new int[3];
            #region shadowcopy
            //Arr02 = Arr01;
            //Console.WriteLine($"hc of arr1  {Arr01.GetHashCode()}");
            //Console.WriteLine($"hc of arr2  {Arr02.GetHashCode()}");
            //Arr01[0] = 10;
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");

            //Console.WriteLine($"Arr02[0] = {Arr01[0]}");
            #endregion
            #region deep copy
            Arr02 = (int[])Arr01.Clone();
            Console.WriteLine($"hc of arr1  {Arr01.GetHashCode()}");
            Console.WriteLine($"hc of arr2  {Arr02.GetHashCode()}");
            Console.WriteLine($"Arr01[0] = {Arr01[0]}");

            Console.WriteLine($"Arr02[0] = {Arr01[0]}");
            Arr01[0] = 10;
            
            Console.WriteLine($"Arr01[0] = {Arr01[0]}");

            Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion

            #endregion
            #region array of refrence type
            #region Array of string [Immutuble type]

            //String[] Names01 = { "Omar" };

            //string[] Names02 = new string[1];
            //Console.WriteLine($"HC OF NAMS1{Names01.GetHashCode()}");
            //Console.WriteLine($"Hc of NAMES2 {Names02.GetHashCode()}");
            #region Shadow Copy
            //Names02 = Names01;
            //Names02[0] = "Aya";
            //Console.WriteLine($"Name01[0].Name = {Names01[0]}");
            //Console.WriteLine($"Name02[0].Name = {Names02[0]}");

            #endregion
            #region deep copy
            //Names02 = (string[])Names01.Clone();
            //Console.WriteLine("After Deep Copy ");
            //Console.WriteLine($"HC OF NAMS1 {Names01.GetHashCode()}");
            //Console.WriteLine($"Hc of NAMES2 {Names02.GetHashCode()}");
            //Names01[0] = "Aya";
            //Console.WriteLine($"Name01[0].Name = {Names01[0]}");
            //Console.WriteLine($"Name02[0].Name = {Names02[0]}");
            #endregion

            #endregion
            #region Array Of StringBuilder[Mutable type]
            #region shadow copy
            StringBuilder[] Names1 = new StringBuilder[1];
            Names1[0] = new StringBuilder("Omar");
            StringBuilder[] Names2 = new StringBuilder[1];
            Names2 = Names1;
            Names2[0].Append("Ahmed");
            Console.WriteLine($"Name01[0].Name = {Names1[0]}");
            Console.WriteLine($"Name02[0].Name = {Names2[0]}");
            #endregion
            #region deep copy
            StringBuilder[] Names01 = new StringBuilder[1];
                  Names01[0] = new StringBuilder("Omar");
            StringBuilder[] Names02 = new StringBuilder[1];
            Names02 = (StringBuilder[])Names01.Clone();
            Names02[0].Append("Ahmed");
            Console.WriteLine($"Name01[0].Name = {Names01[0]}");
            Console.WriteLine($"Name02[0].Name = {Names02[0]}");
            #endregion
            #endregion

            #endregion

            #endregion
            //Employee employee1 = new Employee()
            //{
            //    Id = 10,
            //    Name ="bassim",
            //    Salary = 9000
            //};
            //Employee employee2 = new Employee()
            //{
            //    Id = 20,
            //    Name = "ahmed",
            //    Salary = 23333

            //};
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            #region shadowcopy
            #region shadowcopy [stack]
            //employee2 = employee1;//shadow copy
            //                      //2 refrence [employee1,employee2]=>same object
            //                      //ID=10,Name:bassim,Salary=9000 has 2 refrence
            //Console.WriteLine("==========================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            //employee1.Id = 15;
            //employee1.Name = "hamada";
            //employee1.Salary = 77676;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);


            #endregion
            #region shadow copy (string builder)
            //employee2 = employee1;//shadow copy
            ////2 refrence [employee1,employee2]=>same object
            ////ID=10,Name:bassim,Salary=9000 has 2 refrence
            //Console.WriteLine("==========================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            //employee1.Id = 15;
            //employee1.Name.Append(" ali");
            //employee1.Salary = 77676;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            #endregion

            #endregion
            #region shadow copy and deep copy for userdefiend datatype
            #region DEEP copy name is string
            //employee2 = (Employee)employee1.Clone();
            //Console.WriteLine("==================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            //employee2.Id = 200;
            //employee2.Name = "ali";
            //employee2.Salary= 1000;
            //Console.WriteLine("==================");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);


            #endregion
            #region Deep copy -name is string builder
            //employee2 = (Employee)employee1.Clone();

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);
            //employee2.Id = 500;
            //employee2.Name.Append("joker");
            //employee2.Salary = 22222;
            //Console.WriteLine("After change Deep Copy");
            //Console.WriteLine($"hc of employee1 {employee1.GetHashCode()}");
            //Console.WriteLine(employee1);

            //Console.WriteLine($"hc of employee2 {employee2.GetHashCode()}");
            //Console.WriteLine(employee2);

            #endregion
            #endregion
            #region Built in interface ICompareteble
            //int[] Numbers = { 9, 6, 4, 8, 5, 3, 2, 1};
            //Array.Sort(Numbers);
            //foreach ( int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}
            Employee[] employees12 = new Employee[4]
            {
                new Employee() {Id = 1, Name="Aliaa",Salary=4000},
                new Employee() {Id = 20, Name="Mona",Salary=2000},
                new Employee() {Id = 30, Name="AHmed",Salary=3000},
                new Employee() {Id = 40, Name="ALI",Salary=5000}
            };
            Array.Sort(employees12);
            foreach(Employee employee in employees12)
            {
                Console.WriteLine(employee);
            }

            #endregion

        }

    }
    } 
