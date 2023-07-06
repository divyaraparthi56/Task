using ParentLib;
CompanyDetails companyDetails = new CompanyDetails();
companyDetails.GetCompDelegate = new GetComapnyNameDelegate(MyClientFunction);
companyDetails.MyEvent += CompanyDetails_MyEvent;

string CompanyDetails_MyEvent()
{
    throw new NotImplementedException();
}

string companyname = companyDetails.Caller();
Console.WriteLine(companyname);
string MyClientFunction()
{
    return "divya company";

}