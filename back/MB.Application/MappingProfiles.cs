using AutoMapper;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Features.Artists.Queries.GetAllArtists;
using MB.Application.Features.Artists.Queries.GetArtistById;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Application.Features.Artists.Queries.GetArtistsByMood;
using MB.Application.Features.Artists.Queries.GetArtistsByStyle;
using MB.Application.Features.Artists.Queries.GetArtistsPage;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Application.Features.Franchises.Commands.UpdateFranchise;
using MB.Application.Features.Franchises.Queries.GetFranchiseById;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;
using MB.Application.Features.Franchises.Queries.GetFranchisesByModel;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMood;
using MB.Application.Features.Franchises.Queries.GetFranchisesList;
using MB.Application.Features.Images.Queries;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;
using MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Application.Features.Links.Commands.UpdateLink;
using MB.Application.Features.Links.Queries.GetAllLinks;
using MB.Application.Features.Links.Queries.GetLinkById;
using MB.Application.Features.Links.Queries.GetLinksByArtist;
using MB.Application.Features.Links.Queries.GetLinksByCategory;
using MB.Application.Features.Links.Queries.GetLinksByModel;
using MB.Application.Features.Links.Queries.GetLinksContainingAbc;
using MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;
using MB.Application.Features.Medias.Commands.DeleteMedium;
using MB.Application.Features.Medias.Commands.UpdateMedium;
using MB.Application.Features.Medias.Queries.GetAllMedia;
using MB.Application.Features.Medias.Queries.GetMediumById;
using MB.Application.Features.Models.Commands.CreateModel;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Application.Features.Models.Commands.UpdateModel;
using MB.Application.Features.Models.Queries.GetAllModels;
using MB.Application.Features.Models.Queries.GetModelById;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Application.Features.Models.Queries.GetModelsByFranchise;
using MB.Application.Features.Models.Queries.GetModelsByMood;
using MB.Application.Features.Moods.Commands.CreateMoodImage;
using MB.Application.Features.Moods.Commands.DeleteMood;
using MB.Application.Features.Moods.Commands.UpdateMood;
using MB.Application.Features.Moods.Queries.GetAllMoods;
using MB.Application.Features.Moods.Queries.GetMoodById;
using MB.Application.Features.Moods.Queries.GetMoodsByArtist;
using MB.Application.Features.Moods.Queries.GetMoodsByFranchise;
using MB.Application.Features.Moods.Queries.GetMoodsByModel;
using MB.Application.Features.Moods.Queries.GetMoodsByTag;
using MB.Application.Features.Moods.Queries.GetRandomMood;
using MB.Application.Features.Styles.Commands.DeleteStyle;
using MB.Application.Features.Styles.Commands.UpdateStyle;
using MB.Application.Features.Styles.Queries.GetAllStyles;
using MB.Application.Features.Styles.Queries.GetStyleById;
using MB.Application.Features.TagCategories.Commands.DeleteTagCategory;
using MB.Application.Features.TagCategories.Commands.UpdateTagCategory;
using MB.Application.Features.TagCategories.Queries.GetAllTagCategories;
using MB.Application.Features.TagCategories.Queries.GetTagCategoryById;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Application.Features.Tags.Commands.UpdateTag;
using MB.Application.Features.Tags.Queries.GetAllTags;
using MB.Application.Features.Tags.Queries.GetTagById;
using MB.Application.Features.Tags.Queries.GetTagsByCategory;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesList;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;
using MB.Application.Features.Tasks.Commands.CreateTask;
using MB.Application.Features.Tasks.Commands.DeleteTask;
using MB.Application.Features.Tasks.Commands.UpdateTask;
using MB.Application.Features.Tasks.Queries.GetTaskDetails;
using MB.Application.Features.Tasks.Queries.GetTasksList;
using MB.Application.Features.Users.Commands.DeleteUser;
using MB.Application.Features.Users.Commands.UpdateUser;
using MB.Application.Features.Users.Queries.GetUserById;
using MB.Application.Features.Users.Queries.GetUsersList;
using MB.Application.Features.Videos.Queries.GetOneVideoDetails;
using MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;
using MB.Domain.Entities;

namespace MB.Application;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Moods.
        CreateMap<Mood, CreateMoodImageCommandResponse>().ReverseMap();
        CreateMap<Mood, UpdateMoodCommand>().ReverseMap();
        CreateMap<Mood, DeleteMoodCommand>().ReverseMap();
        CreateMap<Mood, GetAllMoodsQueryDto>().ReverseMap();
        CreateMap<Mood, GetMoodByIdQueryDto>().ReverseMap();
        CreateMap<Mood, GetRandomMoodQueryDto>().ReverseMap();
        CreateMap<Mood, GetMoodsByTagQueryDto>().ReverseMap();
        CreateMap<Mood, GetMoodsByArtistQueryDto>().ReverseMap();
        CreateMap<Mood, GetMoodsByModelQueryDto>().ReverseMap();
        CreateMap<Mood, GetMoodsByFranchiseQueryDto>().ReverseMap();

        // Images.
        CreateMap<Image, GetOneImageDetailsQueryVm>().ReverseMap();

        // Videos.
        CreateMap<Video, GetOneVideoDetailsQueryDto>().ReverseMap();

        // Videos YouTube.
        CreateMap<VideoYouTube, GetOneVideoYTDetailsQueryDto>().ReverseMap();

        // Tag Categories.
        CreateMap<TagCategory, DeleteTagCategoryCommand>().ReverseMap();
        CreateMap<TagCategory, UpdateTagCategoryCommand>().ReverseMap();
        CreateMap<TagCategory, GetAllTagCategoriesQueryDto>().ReverseMap();
        CreateMap<TagCategory, GetTagCategoryByIdQueryDto>().ReverseMap();
        CreateMap<TagCategory, TagCategoryDto>();

        // Tags.
        CreateMap<Tag, UpdateTagCommand>().ReverseMap();
        CreateMap<Tag, DeleteTagCommand>().ReverseMap();
        CreateMap<Tag, TagDto>();
        CreateMap<Tag, GetAllTagsQueryDto>().ReverseMap();
        CreateMap<Tag, GetTagByIdQueryDto>().ReverseMap();
        CreateMap<Tag, GetTagsByMoodQueryDto>().ReverseMap();
        CreateMap<Tag, TagsCheckBoxesDto>().ReverseMap();
        CreateMap<Tag, GetTagsByCategoryQueryDto>().ReverseMap();

        // Models.
        CreateMap<Model, CreateModelCommand>().ReverseMap();
        CreateMap<Model, DeleteModelCommand>().ReverseMap();
        CreateMap<Model, UpdateModelCommand>().ReverseMap();
        CreateMap<Model, GetAllModelsQueryDto>().ReverseMap();
        CreateMap<Model, GetModelByIdQueryDto>().ReverseMap();
        CreateMap<Model, GetModelsByMoodQueryDto>().ReverseMap();
        CreateMap<Model, GetModelsByFranchiseQueryDto>().ReverseMap();
        CreateMap<Model, GFLQModelDto>().ReverseMap();
        CreateMap<Model, GetModelCheckBoxesByMoodQueryDto>().ReverseMap();

        // Styles.
        CreateMap<Style, UpdateStyleCommand>().ReverseMap();
        CreateMap<Style, DeleteStyleCommand>().ReverseMap();
        CreateMap<Style, GetAllStylesQueryDto>().ReverseMap();
        CreateMap<Style, GetStyleByIdQueryDto>().ReverseMap();

        // Artists.
        CreateMap<Artist, CreateArtistCommand>().ReverseMap();
        CreateMap<Artist, GetAllArtistsQueryDto>().ReverseMap();
        CreateMap<Artist, GetArtistByIdQueryDto>().ReverseMap();
        CreateMap<Artist, GetArtistsPageVm>().ReverseMap();
        CreateMap<Artist, GetArtistsByStyleQueryDto>().ReverseMap();
        CreateMap<Artist, GetArtistsByMoodQueryDto>().ReverseMap();
        CreateMap<Artist, GetArtistCheckBoxesByMoodQueryDto>().ReverseMap();

        // Media.
        CreateMap<Media, UpdateMediumCommand>().ReverseMap();
        CreateMap<Media, DeleteMediumCommand>().ReverseMap();
        CreateMap<Media, GetAllMediaQueryDto>().ReverseMap();
        CreateMap<Media, GetMediumByIdQueryDto>().ReverseMap();
        CreateMap<Media, GFLQMediaDto>().ReverseMap();

        // Franchises.
        CreateMap<Franchise, UpdateFranchiseCommand>().ReverseMap();
        CreateMap<Franchise, DeleteFranchiseCommand>().ReverseMap();
        CreateMap<Franchise, GetFranchiseByIdQueryDto>().ReverseMap();
        CreateMap<Franchise, GFLQFranchiseDto>().ReverseMap();
        CreateMap<Franchise, GetAllFranchisesQueryDto>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByMoodQueryDto>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByModelQueryDto>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByMediumQueryDto>().ReverseMap();

        // Link Categories.
        CreateMap<LinkCategory, UpdateLinkCategoryCommand>().ReverseMap();
        CreateMap<LinkCategory, DeleteLinkCategoryCommand>().ReverseMap();
        CreateMap<LinkCategory, GetAllLinkCategoriesQueryDto>().ReverseMap();
        CreateMap<LinkCategory, GetLinkCategoryByIdQueryDto>().ReverseMap();

        // Links.
        CreateMap<Link, GetAllLinksQueryDto>().ReverseMap();
        CreateMap<Link, GetLinkByIdQueryDto>().ReverseMap();
        CreateMap<Link, GetLinksByArtistQueryDto>().ReverseMap();
        CreateMap<Link, GetLinksByModelQueryDto>().ReverseMap();
        CreateMap<Link, GetLinksByCategoryQueryDto>().ReverseMap();
        CreateMap<Link, LinksContainingAbcVm>().ReverseMap();
        CreateMap<Link, PageLinksContainingAbcVm>().ReverseMap();
        CreateMap<Link, UpdateLinkCommand>().ReverseMap();
        CreateMap<Link, DeleteLinkCommand>().ReverseMap();

        // Task Categories.
        CreateMap<TaskCategory, TaskCategoryDto>().ReverseMap();
        CreateMap<TaskCategory, TaskCategoryListVm>().ReverseMap();
        CreateMap<TaskCategory, TaskCategoryTaskListVm>().ReverseMap();

        // Tasks.
        CreateMap<Domain.Entities.Task, CreateTaskCommand>().ReverseMap();
        CreateMap<Domain.Entities.Task, TasksListVm>().ReverseMap();
        CreateMap<Domain.Entities.Task, TaskDetailsVm>().ReverseMap();
        CreateMap<Domain.Entities.Task, UpdateTaskCommand>().ReverseMap();
        CreateMap<Domain.Entities.Task, DeleteTaskCommand>().ReverseMap();

        // Users.
        CreateMap<User, UserListVm>().ReverseMap();
        CreateMap<User, GetUserByIdVm>().ReverseMap();
        CreateMap<User, UpdateUserDto>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
    }
}