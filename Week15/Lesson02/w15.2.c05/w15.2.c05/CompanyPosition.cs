using System.ComponentModel;

public enum CompanyPosition
{
    [Description("CEO")]ChiefExecutiveOfficer,
    [Description("CTO")]ChiefTechnologyOfficer,
    [Description("CFO")]ChiefFinancialOfficer,
    Manager,
    Employee
}

/*
  In CompanyPosition.cs, create enum CompanyPosition. Add the following members and descriptions (if any):
   
       ChiefExecutiveOfficer (description: CEO)
       ChiefTechnologyOfficer (description: CTO)
       ChiefFinancialOfficer (description: CFO)
       Manager
       Employee
   
   Descriptions are added like this:
   
   public enum enumName
   {
       [Description("a nice description for member1")]
       member1,
       [Description("a super nice description for member2")]
       member2
   }
   
   For descriptions to work, you need to be using the System.ComponentModel.
*/