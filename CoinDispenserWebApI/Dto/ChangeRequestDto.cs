namespace CoinDispenserWebApI.Dto
{
    public class ChangeRequestDto
    {
        public ChangeRequestDto()
        {
            Coins = new List<CoinRequetDto>();
        }
        /// <summary>
        /// 
        /// </summary>
        public List<CoinRequetDto> Coins { get; set; }   
        /// <summary>
        /// 
        /// </summary>
        public int Amount { get; set; }   
    }

    public  class CoinRequetDto
    {
        public int Value { get; set; }
    }
}
