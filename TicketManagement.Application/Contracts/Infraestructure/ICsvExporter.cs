using System.Collections.Generic;
using TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace TicketManagement.Application.Contracts.Infraestructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
