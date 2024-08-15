using Cordwell.ConcreteGo.ExportTicketsUtility;
using Cordwell.EmailService.API.Connector;
using CsvHelper;
using System.Globalization;

var appId = "";
var appKey = "";
var apiUrl = "";
var user = "";
var pass = "";

Console.WriteLine("Starting export.");

var start = new DateTime(2024, 1, 5);
var end = DateTime.Now;

var cgConnector = new CGAPIConnector(appId, appKey, user, pass, apiUrl);
await cgConnector.LoginAsync();

var customers = await cgConnector.ListOrdersByOrderDateAsync(start, end);

var runData = await Processor.ConvertCgOrderToOrderData(customers, cgConnector);

using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/Exported Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(runData);
}

await cgConnector.LogoutAsync();

Console.WriteLine("Done.");
