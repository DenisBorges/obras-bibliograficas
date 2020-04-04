using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObrasBibliograficas.Domain.Interface;
using System.Threading.Tasks;

namespace ObrasBibliograficas.DataAcess.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IAutorRepository _repository;

        public UnitTest1(IAutorRepository repository)
        {
            _repository = repository;

        }

        [TestMethod]
        [ClassInitialize]
        public async Task List()
        {
            var lst = await _repository.GetAll();

            Assert.IsNotNull(lst);
        }



    }
}
