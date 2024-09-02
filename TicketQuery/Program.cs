using ConcreteGo.SDK;
using CsvHelper;
using System.Globalization;
using TicketQuery;

var cgClient = new ConcreteGoClient(
    "", 
    "", 
    "", 
    "", 
    ""
);

Console.WriteLine("Starting export.");

var start = new DateTime(2024, 08, 02);
var end = DateTime.Now;

var tickets = await cgClient.GetTicketsAsync(o => {
    o.FromOrderDate = start;
    o.ToOrderDate = end;
});

if (tickets == null) {
    Console.WriteLine("No Tickets Found.");
    Console.WriteLine("Done.");
    return;
}

var runData = await Processor.ConvertCgTicketsToRunData(tickets);

await using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))
await using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(runData);
}


Console.WriteLine("Done.");
