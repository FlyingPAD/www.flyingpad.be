﻿using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository) : IRequestHandler<UpdateModelCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);

        if (model == null)
        {
            return new BaseResponse 
            { 
                Success = false, 
                Message = "Model was not found." 
            };
        }

        _mapper.Map(request, model);

        await _modelRepository.UpdateAsync(model);

        return new BaseResponse
        {
            Success = true,
            Message = "Model successfully updated."
        };
    }
}