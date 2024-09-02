# Customer Dump 
Note - This program isn't optimised to huge amounts of data since it uses .any to filter unique results only.
Additionally, it does this filter base on the customers name if a customer has a name that is the same as "cordwell" and "cordwell " it will create a duplication of entry


# ConcreteGo.SDK

Please note - this is an unofficial SDK.

To connect to the concrete Go API, you will need to request an AppID / AppKey from Sysdyne.

Basic usage:

//Setup
```
var cgClient = new ConcreteGoClient("user@domain.com", "password", "AppId", "AppKey", "Slug");
```

//Get specific tickets based on ticket codes example:
```
var tickets = await cgClient.GetTicketsAsync(options =>
{
    options.TicketCodes.Add("12345");
    options.TicketCodes.Add("67891");
});
```
//Get Tickets between order dates example:
```
var tickets = await cgClient.GetTicketsAsync(options =>
{
    options.FromOrderDate = new DateTime(2024, 6, 1);
    options.ToOrderDate = new DateTime(2024, 6, 1);
});
```

## Export Location
Export should be created on the desktop.

controls the export location by modifying this piece of code:
`using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/Exported Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))`



# For Updating to latest SDK

```
To pull new hotness from the public repo:
cd solution-location
git remote add public https://github.com/dev-dave-s/ConcreteGo.SDK.git
git pull public github-branch # Creates a merge commit
Push the Update.

```
