using System;
using AutoMapper;
using Contracts.Models.Entities;
using Contracts.Models.Tables;
using Domain.Entities;
using Domain.Entities.EntitiesQueryModels;

namespace Services {
	public static class ObjectMapper {
		private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
		{
			var config = new MapperConfiguration(cfg =>
			{
				// This line ensures that internal properties are also mapped over.
				cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
				cfg.AddProfile<AspnetRunDtoMapper>();
			});
			var mapper = config.CreateMapper();
			return mapper;
		});
		public static IMapper Mapper => Lazy.Value;
	}
	public class AspnetRunDtoMapper : Profile {
		public AspnetRunDtoMapper() {

            CreateMap<Domain.TableSearch.Order, DataTableModel.DtOrder>().ReverseMap();
            CreateMap<Domain.TableSearch.Order, DataTableModel.DtOrder>().ReverseMap();
            CreateMap<Domain.TableSearch.Column, DataTableModel.DtColumn>().ReverseMap();
            CreateMap<Domain.TableSearch.Search, DataTableModel.DtSearch>().ReverseMap();
            CreateMap<Domain.TableSearch.TableQueryParams, TableQueryParams>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();


            //CreateMap<User, UserDto>().ReverseMap();
            //CreateMap<User, UserForTableDto>().ReverseMap();
            //         CreateMap<UserSelectQueryModel, UserForTableDto>().ReverseMap();

            //         CreateMap<User, UserEditDto>().ReverseMap();





            //         CreateMap<Role, RoleDto>().ReverseMap();
            //CreateMap<UserRoles, UserRolesDto>().ReverseMap();

            //CreateMap<User, LoggedUserDto>().ReverseMap();

            //CreateMap<LoggedUserWebDto, LoggedUserDto>().ReverseMap();

            //CreateMap<DataFile, DataFileDto>().ReverseMap();

            //CreateMap<DataFilePreview, DataFileDtoBase>().ReverseMap(); 

            //CreateMap<UserAccount, UserAccountDto>().ReverseMap();

            //CreateMap<SellerAccountDto, UserAccountDto>().ReverseMap();


            //CreateMap<SystemSettings, SystemSettingsDto>().ReverseMap();
            //CreateMap<SellBrandProfile, SellBrandProfileEditDto>().ReverseMap();
            //CreateMap<SellBrandProfileSearchModel, SellBrandProfileSearchQueryModel>().ReverseMap();
            //CreateMap<ProductSearchQueryModel, ProductSearchModel>().ReverseMap();

            //CreateMap<PagedQueryModel<SellBrandProfileSearchQueryModel>, BasePagedModel<SellBrandProfileSearchModel>>().ReverseMap();
            //CreateMap<PagedQueryModel<ProductSearchQueryModel>, BasePagedModel<ProductSearchModel>>().ReverseMap();
            //CreateMap<Domain.Controls.SelectViewDomain<Guid>, Contracts.Models.Controls.SelectView<Guid>>().ReverseMap();
            //CreateMap<Domain.Entities.Product, ProductEditDto>().ReverseMap();
            //CreateMap<ProductQueryModel, ProductViewDto>().ReverseMap();

            //CreateMap<UserState, UserStateDto>().ReverseMap();

            //CreateMap<ProductQuerySearchParams, ProductQuerySearchParamsModel>().ReverseMap();
            //CreateMap<ProductViewQueryModel, ProductSearchViewModel>().ReverseMap();
            //CreateMap<PagedQueryModel<ProductViewQueryModel>, BasePagedModel<ProductSearchViewModel>>().ReverseMap();

            //         CreateMap<UserBasketQueryPreview, BasketFullView>().ReverseMap();
            //         CreateMap<UserBasketItemQueryPreview, BasketItemPreview>().ReverseMap();

            //         CreateMap<PaySettings, PaySettingsParamsDto>().ReverseMap();


            //         CreateMap<PaySystemRequestModel, RobokassaRequestModel>().ReverseMap();

            //         CreateMap<PaySystemRequest, PaySystemRequestModel>().ReverseMap();

            //         CreateMap<PaySystemRequestParam, PaySystemRequestParamModel>().ReverseMap();




            //         CreateMap<Branch, BranchDto>().ReverseMap();

            //CreateMap<Plan,PlanDto>().ReverseMap();

            //         CreateMap<PayBill, PayBillDto>().ReverseMap();



            //         CreateMap<UserShortInfoQueryModel, UserShortInfoDto>().ReverseMap();
            //         CreateMap<PayBillSelectQueryModel, PayBillForTableDto>().ReverseMap();

            //         CreateMap<Season, SeasonDto>().ReverseMap();

            //         CreateMap<SeasonMember, SeasonMemberDto>().ReverseMap();


        }
    }
}