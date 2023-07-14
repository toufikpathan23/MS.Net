namespace HrManager;
using DelegateApp;

public class HrManag:Employee{

    // List<Hr> managers=new List<Hr>();
    public double allowance;
    public double taxInPercent;

    public HrManag(int id,string name,int age,double salary,string dept,double allowance,double taxInPercent):base(id,name,age,salary,dept)
    {
        this.allowance=allowance;
        this.taxInPercent=taxInPercent;
    }

    public override double CalculateSal(TaxOperation operation)
    {
        
        return (this.salary+this.allowance)-operation(this.salary,this.taxInPercent);
    }

    public override string ToString()
    {
        
        return base.ToString()+"Allowance="+allowance;
    }

    
}