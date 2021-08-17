﻿using BusinessLayer.Abstract;
using DataLayer.Abstract;
using Mappers;
using Mappers.Abstract;
using Mappers.Factories;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Services
{
    public class SystemUnitService : ISystemUnitService
    {
        private IUnitOfWork unitOfWork;
        private IEntityMapper<Entities.SystemUnit, SystemUnit> mapper;
        private IMapperFactory mapperFactory;
        
        public SystemUnitService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = new SystemUnitMapper();
            this.mapperFactory = new MapperFactory();
        }

        public async Task<IList<SystemUnit>> GetSystemUnitsAsync()
        {
            IList<Entities.SystemUnit> systemUnits = await unitOfWork.SystemUnitRepository.GetAllFullSystemUnit();
            IList<SystemUnit> answer = new List<SystemUnit>();

            foreach (Entities.SystemUnit systemBlock in systemUnits)
            {
                SystemUnit systemUnit = new SystemUnit
                {
                    Name = systemBlock.Name,
                };

                foreach (Entities.SystemUnitDetail detail in systemBlock.SystemUnitDetails)
                {
                    var mapper = mapperFactory.SellectMapper<Detail>((DetailType)detail.Detail.TypeId);

                    systemUnit.Details.Add(mapper.ToModel(detail.Detail));
                }

                answer.Add(systemUnit);
            }

            return answer;
        }

        public void Save(SystemUnit SystemUnit)
        {
            unitOfWork.SystemUnitRepository.AddAsync(mapper.ToEntity(SystemUnit));
            unitOfWork.SaveChangesAsync();
        }

       
    }
}
