using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;


namespace Blog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleAddDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
            CreateMap<ArticleAddDto, ArticleDto>().ReverseMap();
            CreateMap<ArticleSafeDeleteDto, ArticleDto>().ReverseMap();
            CreateMap<ArticleSafeDeleteDto, Article>().ReverseMap();
        }
    }
}
