using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsEven(int number)
        { return number % 2 == 0;

        }
        

        public IList<int> GetEvenNumbers (int start, int end)
        {
            //List<int> evenNumbers = new List<int>();
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenNumbers.Add(i);
            //    }
                

            //}
            //return evenNumbers;
            //comentar varias lineas control + k + c
            //esto otra manera
            return Enumerable.Range(start, end).
                Where(IsEven)
                .ToList();
            //hacer un metodo de prueba para esta clase que devuelve metodos junit. de arrays min 35
        }
    }
}       
    

