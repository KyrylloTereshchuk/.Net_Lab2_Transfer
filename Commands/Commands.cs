using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Commands : ICommands
    {
        private readonly IQueries _Querys;
        public Commands(IQueries query)
        {
            _Querys = query;
        }

        public void Exit()
        {
           QueryOutputText(0);
           Environment.Exit(0);
        }

        void QueryOutputText(int a)
        {
            TextToConsole TextToConsole = new TextToConsole();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TextToConsole.QueryTexts[a]);
            Console.ResetColor();
        }

        public void Command1()
        {
            QueryOutputText(1);

            var employees = _Querys.GetEmployees();
            foreach (var e in employees)
                Console.WriteLine(e);
        }

        public void Command2()
        {
            QueryOutputText(2);

            var magazine = _Querys.GetCompaniesName();
            foreach (var m in magazine)
                Console.WriteLine(m);
        }

        public void Command3()
        {
            QueryOutputText(3);

            var authors = _Querys.GetAllEmployees();
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command4()
        {
            QueryOutputText(4);

            var count = _Querys.GetEmployeesCountWithEducation(".Net Developer");
                Console.WriteLine(count);
        }

        public void Command5()
        {
            QueryOutputText(5);

            var authors = _Querys.GetSortedEmployees("Specialty");
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command6()
        {
            QueryOutputText(6);

            var authors = _Querys.GetCompaniesStartWith("S");
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command7()
        {
            QueryOutputText(7);

            var authors = _Querys.GetEmployeesIdBiggerThan(2);
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command8()
        {
            QueryOutputText(8);

            var authors = _Querys.GetEmployeesSalariesId();
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command9()
        {
            QueryOutputText(9);

            var authors = _Querys.GetSpecificRollNumbers("AV");
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command10()
        {
            QueryOutputText(10);

            var magazine = _Querys.GetYoungestEmployee();
            Console.WriteLine(magazine);
        }

        public void Command11()
        {
            QueryOutputText(11);

            var authors = _Querys.GetEmployeesFromTo(2, 5);
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command12()
        {
            QueryOutputText(12);

            var authors = _Querys.GetEmployementEmployees();
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command13()
        {
            QueryOutputText(13);

            var authors = _Querys.GetEmployeesArray();
            foreach (var a in authors)
                Console.WriteLine(a);
        }

        public void Command14()
        {
            QueryOutputText(14);

            var magazine = _Querys.GetAllRollNumbers();
            Console.WriteLine(magazine);
        }

        public void Command15()
        {
            QueryOutputText(15);

            var magazine = _Querys.GetFirstEmployeeWithIdBiggerThan(3);
            Console.WriteLine(magazine);
        }
        public void Command16()
        {
            QueryOutputText(16);

            var authors = _Querys.GetIdByName();
            foreach (var a in authors)
                Console.WriteLine(a);
        }

    }
}
