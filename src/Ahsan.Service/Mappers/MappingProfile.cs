﻿using Ahsan.Domain.Entities;
using Ahsan.Service.DTOs.Companies;
using Ahsan.Service.DTOs.CompanyEmployees;
using Ahsan.Service.DTOs.Issues;
using Ahsan.Service.DTOs.Positions;
using Ahsan.Service.DTOs.Users;
using AutoMapper;

namespace Ahsan.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<UserForCreationDto, UserForUpdateDto>().ReverseMap();
        CreateMap<UserImage, UserImageForResultDto>().ReverseMap();

        // Position
        CreateMap<Position, PositionForCreationDto>().ReverseMap();
        CreateMap<Position, PositionForResultDto>().ReverseMap();

        // Company
        CreateMap<Company, CompanyForCreationDto>().ReverseMap();
        CreateMap<Company, CompanyForResultDto>().ReverseMap();
        CreateMap<Company, CompanyForUpdateDto>().ReverseMap();

        // IssueCategory
        CreateMap<IssueCategory, IssueCategoryForCreationDto>().ReverseMap();
        CreateMap<IssueCategory, IssueCategoryForResultDto>().ReverseMap();

        // Issue
        CreateMap<Issue, IssueForCreationDto>().ReverseMap();
        CreateMap<Issue, IssueForResultDto>().ReverseMap();
        CreateMap<Issue, IssueForUpdateDto>().ReverseMap();
        CreateMap<Issue, IssueForEmployeeDto>().ReverseMap();

        // Employee
        CreateMap<CompanyEmployee, CompanyEmployeeForCreationDto>().ReverseMap();
        CreateMap<CompanyEmployee, CompanyEmployeeForResultDto>().ReverseMap();
        CreateMap<CompanyEmployee, CompanyEmployeeForUpdateDto>().ReverseMap();
            
    }
}
