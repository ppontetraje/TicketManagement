using CsvHelper;
using System.Collections.Generic;
using System.IO;
using TicketManagement.Application.Contracts.Infraestructure;
using TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace TicketManagement.Infraestructure.FileExporter
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
