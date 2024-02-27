using AutoMapper;
using FilmesApi.Data.DTOS;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

 public class FillmeProfile : Profile
 {
        public FillmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme> ();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, UpdateFilmeDto>();
            CreateMap<Filme, ReadFilmeDto>();
        }
 }
 