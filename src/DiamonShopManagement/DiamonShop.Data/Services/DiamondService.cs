using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Core.RequestModels;
using DiamonShop.Core.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Core.ViewModels;

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
    }
}



