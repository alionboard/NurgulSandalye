using NurgulSandalye.Business.Abstract;
using NurgulSandalye.DataAccess.Abstract;
using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurgulSandalye.Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        private readonly IMaterialRepository _repository;

        public MaterialManager(IMaterialRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Material>> ListAllMaterialAsync()
        {
            return await _repository.ListAllAsync();
        }
    }
}
