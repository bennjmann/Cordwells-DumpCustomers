using Cordwell.EmailService.API.Connector;
using CsvHelper;
using System.Globalization;
using TicketQuery;

var appId = "";
var appKey = "";
var apiUrl = ""; 
var user = "";
var pass = "";

Console.WriteLine("Starting export.");

var start = new DateTime(2024, 07, 01);
var end = DateTime.Now;

var cgConnector = new CGAPIConnector(appId, appKey, user, pass, apiUrl);
await cgConnector.LoginAsync();

var tickets = await cgConnector.ListTicketsByOrderDateAsync(start, end);

var runData = await Processor.ConvertCgTicketsToRunData(tickets);

using (var writer = new StreamWriter(@"godata.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(runData);
}

await cgConnector.LogoutAsync();

Console.WriteLine("Done.");
