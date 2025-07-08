using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappers;

public class EnderecoMapper : Profile
{
    public EnderecoMapper()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<EnderecoResponse, EnderecoModel>();
        CreateMap<EnderecoModel, EnderecoResponse >();
    }
}
