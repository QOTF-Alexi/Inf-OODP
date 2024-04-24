public static class EmailParser
{
    public static (string recipient, string domain, string topLevelDomain) ParseEmail(string emailaddress)
    {
        if (emailaddress.Contains('@') && emailaddress.Contains('.'))
        {
            var trimmedAddress = emailaddress.Trim();
            var splitParts = trimmedAddress.Split('@');
            if (splitParts.Length == 2)
            {
                
                var recipient = splitParts[0];
                var domain = splitParts[1];
                var domainNames = domain.Split('.');
                return (recipient, domain, domainNames[^1]);
            }

        }
        return (null, null, null);
    }
}