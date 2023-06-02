﻿global using AutoMapper;
global using FluentValidation;
global using Microsoft.AspNetCore.Http;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using ProductionApp.Common.Abstract;
global using ProductionApp.Common.ComplexTypes;
global using ProductionApp.Common.ResponseObjects;
global using ProductionApp.DTOs.GroupDtos;
global using ProductionApp.DTOs.StockDtos;
global using ProductionApp.Entities.Models;
global using ProductionApp.Repository.Abstract;
global using ProductionApp.Repository.Context;
global using ProductionApp.Repository.Repositories;
global using ProductionApp.Repository.UnitOfWorks;
global using ProductionApp.Service.Abstract;
global using ProductionApp.Service.Manager;
global using ProductionApp.Service.Mappings.AutoMapper;
global using ProductionApp.Service.Mappings.Helpers;
global using ProductionApp.Service.ValidationRules.GroupValidators;
global using ProductionApp.Service.ValidationRules.StockValidators;