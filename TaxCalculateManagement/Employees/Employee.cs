namespace HrManager;
using   DelegateApp;
using System;
public abstract class Employee
{
    private int Id{get; set;}
    private string Name{set; get;}

    private int Age{get; set;}

    public double salary;

    private string Dept{set; get;}

   // List<Hr> hrList=new List<Hr>();

    //public double Salary{}
    public Employee(int id,string name,int age,double salary,string dept)
    {
        this.Id=id;
        this.Name=name;
        this.Age=age;
        this.salary=salary;
        this.Dept=dept;
    }

    public override string ToString()
    {
        string data=string.Format("Id={0},Name={1},Age={2},Salary={3},Dept={4}",Id,Name,Age,salary,Dept);

        return data;

    }

    public abstract double CalculateSal(TaxOperation operation);
    
}
