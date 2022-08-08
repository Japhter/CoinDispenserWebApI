namespace CoinDispenserWebApI.Dto
{
    public class ChangeResponseDto
    {
        public ChangeResponseDto()
        {
            Coins = new List<CoinRequetDto>();
        }
        /// <summary>
        /// 
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CoinRequetDto> Coins { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MinimumCombination { get; set; }
    }
}
