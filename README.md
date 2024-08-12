# Customer Dump 
Note - This program isn't optimised to huge amounts of data since it uses .any to filter unique results only.
Additionally, it does this filter base on the customers name if a customer has a name that is the same as "cordwell" and "cordwell " it will create a duplication of entry

## Supply These variables the information to connect to CgConnector
- `var appId = "";`
- `var appKey = "";`
- `var apiUrl = "";`
- `var user = "";`
- `var pass = "";`

## Filter Variables (defaults)
- `var start = new DateTime(2024, 1, 5);`
- `var end = DateTime.Now;`

## Export Location
Export should be created on the desktop.

controls the export location by modifying this piece of code:
`using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/Exported Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))`
