using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BEL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>().ForMember(x => x.Role, rol => rol.Ignore());
            CreateMap<Post, PostModel>();
            CreateMap<PostModel, Post>().ForMember(x => x.Subject, sub => sub.Ignore()).ForMember(x => x.User, u => u.Ignore()).ForMember(x => x.Status, sts => sts.Ignore());
            CreateMap<User, LoginModel>().ReverseMap();
            CreateMap<Subject, SubjectModel>();
            CreateMap<SubjectModel, Subject>().ForMember(x=>x.User, u => u.Ignore());
        }
    }
}
