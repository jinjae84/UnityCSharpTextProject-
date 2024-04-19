using System;  // ~ System을 사용하겠다. System namespace 사용하겠다.
using A;
using B;
using System.Collections.Generic;

namespace UnityCSharplearn
{

	internal class Program
	{
        static void Main(string[] args)
        {
            // 기본 자료형 (Primitive Types) : 정수형, 실수형, 문자열, boolean형
            
            // 변수의 선언
            int myInt;
            
            // 변수의 할당
            myInt = 10;
                     
            // 실수형
            float myFloat = 3.14f;

            // 문자열
            string myString = "Hello World";

            // +, -, x, /

            int number1 = 10;
            int number2 = 20;

            int sum;
            sum = number1 + number2;
            string result = "두 수를 더한 값" + " ";

            Console.WriteLine(result + (number1 + number2));
            Console.WriteLine(result + number1);
            Console.WriteLine(result + number1 + number2);

            int sub;
            sub = number1 - number2;
            //Console.WriteLine(result + number1 - number2);

            int multi;
            multi = number1 * number2;
            Console.WriteLine(multi);

            int divide;
            divide = number1 / number2;
            Console.WriteLine(divide);


            // Quiz 1.  int a에 10을 넣고 int b에 20을 넣은 값을 더한 후 c로 나누는 결과를 콘솔창에 출력하는 코드를 작성해보세요.
            int a = 10;
            int b = 20;
            int c = 3;
            int resultA = (a + b) / c;

            Console.WriteLine("a와 b를 더한 값을 c로 나눈 값" + " " + resultA);
        }


    }
}