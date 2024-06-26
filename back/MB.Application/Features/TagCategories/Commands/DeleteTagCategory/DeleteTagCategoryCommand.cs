﻿using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommand : IRequest<DeleteTagCategoryCommandResponse>
{
    public Guid Id { get; set; }
}
