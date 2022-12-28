using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1:Claas2
{
	public Class1()
	{
		global::System.Console.WriteLine("Chintu");
	}
	static void Main()
	{
		Class1 obj=new Class1();
		obj.Show();
	}
}
public class Claas2
{
	public void Show()
	{
		global::System.Console.WriteLine("Called");
	}
}
