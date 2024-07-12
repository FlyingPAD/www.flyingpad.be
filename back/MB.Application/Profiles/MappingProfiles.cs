using AutoMapper;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Features.Artists.Queries.GetArtist;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Application.Features.Artists.Queries.GetArtistDetails;
using MB.Application.Features.Artists.Queries.GetArtists;
using MB.Application.Features.Artists.Queries.GetArtistsByMood;
using MB.Application.Features.Artists.Queries.GetArtistsByStyle;
using MB.Application.Features.Artists.Queries.GetArtistsPage;
using MB.Application.Features.Franchises.Commands.CreateFranchise;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Application.Features.Franchises.Commands.UpdateFranchise;
using MB.Application.Features.Franchises.Queries.GetFranchiseById;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMedia;
using MB.Application.Features.Franchises.Queries.GetFranchisesByModel;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMood;
using MB.Application.Features.Franchises.Queries.GetFranchisesList;
using MB.Application.Features.Images.Queries;
using MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;
using MB.Application.Features.Links.Commands.CreateLink;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Application.Features.Links.Commands.UpdateLink;
using MB.Application.Features.Links.Queries.GetLinkById;
using MB.Application.Features.Links.Queries.GetLinksContainingAbc;
using MB.Application.Features.Links.Queries.GetLinksList;
using MB.Application.Features.Links.Queries.GetLinksListByCategory;
using MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;
using MB.Application.Features.Medias.Commands.CreateMedia;
using MB.Application.Features.Medias.Commands.DeleteMedia;
using MB.Application.Features.Medias.Commands.UpdateMedia;
using MB.Application.Features.Medias.Queries.GetMediaById;
using MB.Application.Features.Medias.Queries.GetMediasList;
using MB.Application.Features.Models.Commands.CreateModel;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Application.Features.Models.Commands.UpdateModel;
using MB.Application.Features.Models.Queries.GetModelById;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Application.Features.Models.Queries.GetModelsByFranchise;
using MB.Application.Features.Models.Queries.GetModelsByMood;
using MB.Application.Features.Models.Queries.GetModelsList;
using MB.Application.Features.Moods.Commands.CreateMood;
using MB.Application.Features.Moods.Commands.CreateMoodImage;
using MB.Application.Features.Moods.Commands.DeleteMood;
using MB.Application.Features.Moods.Commands.UpdateMood;
using MB.Application.Features.Moods.Queries.GetMoodById;
using MB.Application.Features.Moods.Queries.GetMoodsByArtist;
using MB.Application.Features.Moods.Queries.GetMoodsByFranchise;
using MB.Application.Features.Moods.Queries.GetMoodsByModel;
using MB.Application.Features.Moods.Queries.GetMoodsByTag;
using MB.Application.Features.Moods.Queries.GetMoodsList;
using MB.Application.Features.Moods.Queries.GetRandomMoodQuery;
using MB.Application.Features.Styles.Commands.CreateStyle;
using MB.Application.Features.Styles.Commands.DeleteStyle;
using MB.Application.Features.Styles.Commands.UpdateStyle;
using MB.Application.Features.Styles.Queries.GetStyleById;
using MB.Application.Features.Styles.Queries.GetStylesList;
using MB.Application.Features.TagCategories.Commands.CreateTagCategory;
using MB.Application.Features.TagCategories.Commands.DeleteTagCategory;
using MB.Application.Features.TagCategories.Commands.UpdateTagCategory;
using MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;
using MB.Application.Features.TagCategories.Queries.GetTagCategoryById;
using MB.Application.Features.Tags.Commands.CreateTag;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Application.Features.Tags.Commands.UpdateTag;
using MB.Application.Features.Tags.Queries.GetTagById;
using MB.Application.Features.Tags.Queries.GetTagsByCategory;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Application.Features.Tags.Queries.GetTagsList;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesList;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;
using MB.Application.Features.Tasks.Commands.CreateTask;
using MB.Application.Features.Tasks.Commands.DeleteTask;
using MB.Application.Features.Tasks.Commands.UpdateTask;
using MB.Application.Features.Tasks.Queries.GetTaskDetails;
using MB.Application.Features.Tasks.Queries.GetTasksList;
using MB.Application.Features.Users.Commands.CreateUser;
using MB.Application.Features.Users.Commands.DeleteUser;
using MB.Application.Features.Users.Commands.UpdateUser;
using MB.Application.Features.Users.Queries.GetUserById;
using MB.Application.Features.Users.Queries.GetUsersList;
using MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery;
using MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetailsQuery;
using MB.Domain.Entities;

namespace MB.Application.Profiles;

public class MappingProfiles : Profile
{
   public MappingProfiles()
   {
        // Artists :

        CreateMap<Artist, CreateArtistDto>().ReverseMap();

        CreateMap<Artist, GetArtistsVm>().ReverseMap();
        CreateMap<Artist, GetArtistVm>().ReverseMap();
        CreateMap<Artist, GetArtistDetailsVm>().ReverseMap();
        CreateMap<Artist, GetArtistsPageVm>().ReverseMap();
        CreateMap<Artist, GetArtistsByStyleVm>().ReverseMap();
        CreateMap<Artist, GetArtistsByMoodQueryVm>().ReverseMap();
        CreateMap<Artist, GetArtistCheckBoxesByMoodQueryDto>().ReverseMap();

        // Styles : 

        CreateMap<Style, StyleListVm>().ReverseMap();
        CreateMap<Style, GetStyleByIdVm>().ReverseMap();
        CreateMap<Style, CreateStyleDto>().ReverseMap();
        CreateMap<Style, UpdateStyleCommand>().ReverseMap();
        CreateMap<Style, DeleteStyleCommand>().ReverseMap();

        // Franchises :

        CreateMap<Franchise, CreateFranchiseDto>().ReverseMap();
        CreateMap<Franchise, UpdateFranchiseCommand>().ReverseMap();
        CreateMap<Franchise, UpdateFranchiseDto>().ReverseMap();
        CreateMap<Franchise, DeleteFranchiseCommand>().ReverseMap();

        CreateMap<Franchise, GetFranchiseByIdVm>().ReverseMap();
        CreateMap<Franchise, GFLQFranchiseDto>().ReverseMap();
        CreateMap<Franchise, GetAllFranchisesQueryVm>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByMoodQueryVm>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByModelQueryVm>().ReverseMap();
        CreateMap<Franchise, GetFranchisesByMediaQueryVm>().ReverseMap();
        
        // Medias :

        CreateMap<Media, MediaListVm>().ReverseMap();
        CreateMap<Media, GetMediaByIdVm>().ReverseMap();
        CreateMap<Media, CreateMediaDto>().ReverseMap();
        CreateMap<Media, UpdateMediaCommand>().ReverseMap();
        CreateMap<Media, UpdateMediaDto>().ReverseMap();
        CreateMap<Media, DeleteMediaCommand>().ReverseMap();
        CreateMap<Media, GFLQMediaDto>().ReverseMap();

        // Links :

        CreateMap<Link, LinkListVm>().ReverseMap();
        CreateMap<Link, GetLinkByIdVm>().ReverseMap();
        CreateMap<Link, CreateLinkDto>().ReverseMap();
        CreateMap<Link, UpdateLinkCommand>().ReverseMap();
        CreateMap<Link, DeleteLinkCommand>().ReverseMap();
        CreateMap<Link, LinksListByCategoryVm>().ReverseMap();
        CreateMap<Link, LinksContainingAbcVm>().ReverseMap();
        CreateMap<Link, PageLinksContainingAbcVm>().ReverseMap();

        // Link Categories :

        CreateMap<LinkCategory, LinkCategoryListVm>().ReverseMap();
        CreateMap<LinkCategory, GetLinkCategoryByIdVm>().ReverseMap();
        CreateMap<LinkCategory, CreateLinkCategoryDto>().ReverseMap();
        CreateMap<LinkCategory, UpdateLinkCategoryCommand>().ReverseMap();
        CreateMap<LinkCategory, UpdateLinkCategoryDto>().ReverseMap();
        CreateMap<LinkCategory, DeleteLinkCategoryCommand>().ReverseMap();

        // Models :

        CreateMap<Model, CreateModelDto>().ReverseMap();
        CreateMap<Model, UpdateModelCommand>().ReverseMap();
        CreateMap<Model, UpdateModelDto>().ReverseMap();
        CreateMap<Model, DeleteModelCommand>().ReverseMap();

        CreateMap<Model, ModelListVm>().ReverseMap();
        CreateMap<Model, GetModelByIdVm>().ReverseMap();
        CreateMap<Model, GetModelsByMoodQueryVm>().ReverseMap();
        CreateMap<Model, GetModelsByFranchiseQueryVm>().ReverseMap();
        CreateMap<Model, GFLQModelDto>().ReverseMap();
        CreateMap<Model, GetModelCheckBoxesByMoodQueryDto>().ReverseMap();

        // Moods :

        CreateMap<Mood, CreateMoodDto>().ReverseMap();
        CreateMap<Mood, CreateMoodImageCommandDto>().ReverseMap();
        CreateMap<Mood, UpdateMoodCommand>().ReverseMap();
        CreateMap<Mood, UpdateMoodDto>().ReverseMap();
        CreateMap<Mood, DeleteMoodCommand>().ReverseMap();

        CreateMap<Mood, MoodListVm>().ReverseMap();
        CreateMap<Mood, GetMoodByIdVm>().ReverseMap();
        CreateMap<Mood, GetRandomMoodQueryVm>().ReverseMap();
        CreateMap<Mood, GetMoodsByTagQueryVm>().ReverseMap();
        CreateMap<Mood, GetMoodsByArtistQueryVm>().ReverseMap();
        CreateMap<Mood, GetMoodsByModelQueryVm>().ReverseMap();
        CreateMap<Mood, GetMoodsByFranchiseQueryVm>().ReverseMap();

        // Images :

        CreateMap<Image, GetOneImageDetailsQueryVm>().ReverseMap();

        // Videos :

        CreateMap<Video, GetOneVideoDetailsQueryVm>().ReverseMap();

        // Videos YouTube:

        CreateMap<VideoYouTube, GetOneVideoYTDetailsQueryVm>().ReverseMap();

        // Tags :

        CreateMap<Tag, CreateTagDto>().ReverseMap();
        CreateMap<Tag, UpdateTagCommand>().ReverseMap();
        CreateMap<Tag, UpdateTagDto>().ReverseMap();
        CreateMap<Tag, DeleteTagCommand>().ReverseMap();
        
        CreateMap<Tag, TagDto>();
        CreateMap<Tag, TagListVm>().ReverseMap();
        CreateMap<Tag, GetTagByIdVm>().ReverseMap();
        CreateMap<Tag, GetTagsByMoodQueryVm>().ReverseMap();
        CreateMap<Tag, GetTagsCheckBoxesDto>().ReverseMap();
        CreateMap<Tag, GetTagsByCategoryQueryDto>().ReverseMap();

        // Tag Categories :

        CreateMap<TagCategory, DeleteTagCategoryCommand>().ReverseMap();
        CreateMap<TagCategory, UpdateTagCategoryCommand>().ReverseMap();
        CreateMap<TagCategory, CreateTagCategoryDto>().ReverseMap();
        CreateMap<TagCategory, TagCategoryListVm>().ReverseMap();
        CreateMap<TagCategory, GetTagCategoryByIdVm>().ReverseMap();
        CreateMap<TagCategory, UpdateTagCategoryDto>().ReverseMap();
        CreateMap<TagCategory, TagCategoryDto>();

        // Tasks :

        CreateMap<Domain.Entities.Task, CreateTaskCommand>().ReverseMap(); 
        CreateMap<Domain.Entities.Task, TasksListVm>().ReverseMap(); 
        CreateMap<Domain.Entities.Task, TaskDetailsVm>().ReverseMap(); 
        CreateMap<Domain.Entities.Task, UpdateTaskCommand>().ReverseMap(); 
        CreateMap<Domain.Entities.Task, DeleteTaskCommand>().ReverseMap(); 

        // Task Categories :

        CreateMap<TaskCategory, TaskCategoryDto>().ReverseMap(); 
        CreateMap<TaskCategory, TaskCategoryListVm>().ReverseMap(); 
        CreateMap<TaskCategory, TaskCategoryTaskListVm>().ReverseMap();

        // Users :

        CreateMap<User, UserListVm>().ReverseMap();
        CreateMap<User, GetUserByIdVm>().ReverseMap();
        CreateMap<User, CreateUserDto>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        CreateMap<User, UpdateUserDto>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
    }
}