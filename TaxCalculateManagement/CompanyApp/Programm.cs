// See https://aka.ms/new-console-template for more information
using HrManager;
using DelegateApp;
using System;


Console.WriteLine("Hello, World!");

//TaxManager taxManager=new TaxManager();
//int id,string name,int age,double salary,string dept,double Allowance,double taxInPercent

Console.WriteLine("Enter Id:");
int id=int.Parse(Console.ReadLine());
Employee e=new HrManag(1,"dffd",24,20000,"HR",1200,10);

TaxOperation operation= new TaxOperation(TaxManager.PayIncomeTax);


double sal=e.CalculateSal(operation);

Console.WriteLine(sal);