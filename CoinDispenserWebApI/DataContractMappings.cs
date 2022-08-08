using AutoMapper;
using CoinDispenserWebApI.Domain;
using CoinDispenserWebApI.Dto;

namespace CoinDispenserWebApI
{
    public class DataContractMappings:Profile
    {
        public DataContractMappings()
        {
            CreateMap<Change, ResultDto>()
                .ForMember(d=>d.Id,o=>o.MapFrom(s=>s.Id));
            CreateMap<ResultDto, Change>();
        }
    }
}
