/* WAP in C# to make a calculator using switch Statement. */
using System;
public class SwitchStatement{
int a , b , result ;
public void Result(){
Console.WriteLine("Enter 1st no :");
int a = Convert.ToInt32(Console.ReadLine());
Consle.WriteLine("Enter 2nd no :");
int b = Convert.ToInt32(Console.ReadLine());

Consle.WriteLine("Enter operator + , - , * , / , % ");
char op = Convert.ToChar(Console.ReadLine());

switch(op){
    Case'+' :
    result = a + b ;
    break ;

    Case'-' :
    result = a - b ;
    break ;

    Case'*' : 
    result = a * b ;
    break;

    Case'/' :
    result = a / b ;
    break;

    case'%' :
    result = a % b ;
    break;

    default("The operator is not valid ");
}
}
}