using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;

namespace CMSPlus.Presentation.AutoMapperProfiles;

public class CommentProfile:Profile
{
    public CommentProfile()
    {
        CreateMap<CommentEntity,CommentModel>();
        CreateMap<CommentModel,CommentEntity>();
        CreateMap<CommentEntity, CommentDetailsModel>();
        CreateMap<CommentEntity, CommentCreateModel>();
        CreateMap<CommentCreateModel,CommentEntity>();
        CreateMap<CommentEntity, CommentEditModel>();
        CreateMap<CommentEditModel,CommentEntity>();
    }
}