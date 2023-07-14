namespace HrManager;
using   DelegateApp;
public class SalesManager:Employee{

    // List<Hr> managers=new List<Hr>();
    private double allowance;

    public SalesManager(int id,string name,int age,double salary,string dept,double allowance):base(id,name,age,salary,dept)
    {
        this.allowance=allowance;
    }


public override double CalculateSal(TaxOperation operation)
    {
        
        return (this.salary+this.allowance)-operation(this.salary,10);
    }

    public override string ToString()
    {
        
        return base.ToString()+"Allowance="+allowance;
    }
}