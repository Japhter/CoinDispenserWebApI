using System.ComponentModel.DataAnnotations;

namespace CoinDispenserWebApI.Domain
{
    public class Change
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public  virtual int Id  { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string StringOfCoins { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int MinimumChange { get; set; }
    }
}
