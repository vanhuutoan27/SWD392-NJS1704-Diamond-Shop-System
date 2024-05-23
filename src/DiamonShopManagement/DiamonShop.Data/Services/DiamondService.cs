using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Core.RequestModels;
using DiamonShop.Core.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Core.Shared.Enum;
using DiamonShop.Core.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Data.Services
{
    public class DiamondService : IDiamondService
    {
        private readonly IRepositoryManager _repositoryManager;

        private readonly IMapper _mapper;
        public DiamondService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;

        }

        public async Task<DiamondRespone> AddDiamond(CreateDiamondRequest createDiamondRequest)
        {

            var createDiamond = _mapper.Map<Diamond>(createDiamondRequest);
            var productID = Guid.NewGuid();
            var model = new Diamond()
            {

                DiamondId = productID,
                Shape = createDiamond.Shape,
                Weight = createDiamond.Weight,
                ColorLevel = createDiamond.ColorLevel,
                Clarity = createDiamond.Clarity,
                Certification = createDiamond.Certification,
                Size = createDiamond.Size,
                Fluorescence =  createDiamond.Fluorescence,
                QualityOfCut =  createDiamond.QualityOfCut,
                Price = createDiamond.Price,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            _repositoryManager.Diamond.Add(model);
            var product = new Product()
            {
                ProductId = productID,
                Name = "dai",
                Description = "sdfsdfdsfsdf",
                Price = 100000,
                CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                Status = EnumStatus.Status.Active,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            _repositoryManager.Product.Add(product);
            await _repositoryManager.Save();
            return new DiamondRespone
            {
                Message = "Create Diamond Successfully",
                Status = true,
                Data = model,
            };
        }


        public async Task<IEnumerable<Diamond>> GetAllDiamond()
        {
            var diamonds = await _repositoryManager.Diamond.GetAllAsync();
            if (diamonds == null)
            {
                return Enumerable.Empty<Diamond>();
            }
            return diamonds;

        }

        public async Task<Diamond> GetDiamondbyId(Guid id)
        {
            var diamondId = await _repositoryManager.Diamond.GetByIdAsync(id);

            if (diamondId == null)
            {
                return null;
            }
            return diamondId;

        }

        public async Task<DiamondRespone> UpdateById(Guid id, UpdateDiamondRequest updateadiamond)
        {

            var existingDiamond = await _repositoryManager.Diamond.GetByIdAsync(id);

            if (existingDiamond != null)
            {
                existingDiamond.Shape = updateadiamond.Shape;
                existingDiamond.Weight =   updateadiamond.Weight;
                existingDiamond.ColorLevel = updateadiamond.ColorLevel;
                existingDiamond.Clarity = updateadiamond.Clarity;
                existingDiamond.Certification   = updateadiamond.Certification;
                existingDiamond.Size = updateadiamond.Size;
                existingDiamond.Fluorescence = updateadiamond.Fluorescence;
                existingDiamond.QualityOfCut = updateadiamond.QualityOfCut;
                existingDiamond.Price =  updateadiamond.Price;
                existingDiamond.DateCreated = DateTime.Now;
                existingDiamond.DateModified= DateTime.Now;
            }
            else
            {
                return new DiamondRespone
                {
                    Message = "Id not found!",
                    Status = false,
                };
            }

            _repositoryManager.Diamond.Update(existingDiamond);
            await _repositoryManager.Save();
            return new DiamondRespone
            {
                Message = "Update Successfully!",
                Status  = true,
                Data = existingDiamond,
            };
        }




        public async Task RemoveDiamondById(Guid id)
        {
            var diamondid = _repositoryManager.Diamond.Findid(id);

            if (diamondid == null)
            {
                throw new KeyNotFoundException($"Diamond with ID {id} not found.");
            }

            _repositoryManager.Diamond.Remove(diamondid);
            await _repositoryManager.Save();
        }
    }
}



