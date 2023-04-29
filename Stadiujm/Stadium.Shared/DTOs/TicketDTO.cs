namespace Stadium.Shared.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }

        public DateTime? DateUse { get; set; }

        public bool WasUsed { get; set; } = false;

        public string? Entrance { get; set; } = null;
    }
}
