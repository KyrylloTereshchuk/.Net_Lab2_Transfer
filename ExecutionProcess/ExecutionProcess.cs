using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ExecutionProcess : IExecutionProcess
    {
          private readonly MenuDictionary _dictionary;
          private readonly XmlReaderValidator _xmlReaderValidator;
          private bool validate;

          public ExecutionProcess(MenuDictionary dictionary, XmlReaderValidator xmlReaderValidator)
          {
              _dictionary = dictionary;
              _xmlReaderValidator = xmlReaderValidator;
        }

        public void Process()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Menu\n");
            foreach (Enums.QueriesNames queryName in Enum.GetValues(typeof(Enums.QueriesNames)))
            {
                Console.WriteLine($"{(int)queryName}." + queryName);
            }

               while (true)
              {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.Write("\nEnter command number (1-22) or 0 to exit: ");
                  Console.ResetColor();

                  string? input = Console.ReadLine();
                  validate = _xmlReaderValidator.ValidateXmlCollection("Collections");

                    if (validate || (Int32.TryParse(input, out int result) && result < 6) ) 
                    {
                        var menuChoices = _dictionary.MenuCreate();

                        if (Enum.TryParse(input, out Enums.QueriesNames choice) && menuChoices.TryGetValue(choice, out var selected))
                        {
                            selected();
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                      Console.WriteLine("Invalid data in xml file!");
                    }

            }

        }

    }

}
