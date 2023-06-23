namespace Game.Domain.Dto
{
    internal class GameReportDto 
    {
        public string? GameName { get; set; }
        public string? ConsoleName { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string? Category { get; set; }
        public List<FriendDto> Friends { get; set; }
    }
}
