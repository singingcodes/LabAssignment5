using System;
// abstract class Bank
// {

// }
// public class BankA : Bank
// {

// }
// C# program to calculate the area
// of a Square using abstract class
// and abstract method

// declare class 'AreaClass'
// as abstract
public abstract class Bank
{
	
	abstract public void getBalance();
}


class BankA : Bank
{	
    int depositA = 100;
    public override void getBalance()
	{
		Console.WriteLine("Your balance is $" + depositA);
	}
}
class BankB : Bank
{
    int depositB = 150;
    	public override void getBalance()
	{
		Console.WriteLine("Your balance is $" + depositB);
	}
}
class BankC : Bank
{	
    int depositC = 200;
    public override void getBalance()
	{
		Console.WriteLine("Your balance is $" + depositC);
	}
}

// class gfg {

// 	// Main Method
// 	public static void Main()
// 	{
// 		Square s = new Square(6);
// 		Console.WriteLine("Area = " + s.Area());
// 	}
// }
