using ConcreteGo.SDK;
using Cordwell.ConcreteGo.ExportTicketsUtility;
using CsvHelper;
using System.Globalization;


var cgClient = new ConcreteGoClient(
    "", 
    "", 
    "", 
    "", 
    ""
    );

Console.WriteLine("Starting export.");
var start = new DateTime(2024, 9, 1); // month max
var end = DateTime.Now;


var customers = await cgClient.GetOrdersAsync(o => {
    o.IncludeRetElements = ["USERDEFINEDFIELD"];
    o.FromOrderDate = start;
    o.ToOrderDate = end;
});


var customersData = await Processor.ConvertCgOrderToOrderData(customers);

await using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/Exported Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))
await using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
    csv.WriteRecords(customersData);
}

Console.WriteLine("Done.");
