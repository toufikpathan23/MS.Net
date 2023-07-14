namespace DelegateApp;


public class TaxManager{

    public static double PayIncomeTax(double salary,double per)
    {
       return (salary*per)/100;
    }
}