using Agenda.ApplicationCore.Services;
using Agenda.ApplicationCore.Interfaces.Services;
using Moq;
using Xunit;
using System.Linq;

namespace UnitTests.ApplicationCore.Services.ContatoServiceTests
{
    public class SetName
    {
        
        private readonly IContatoService _contatoService;

        public SetName(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [Fact]
        public void SetandoNomeContato()
        {
            // Get contato
            var firstContato = _contatoService.GetAll().FirstOrDefault();
            // save value in variables
            var beforeName = firstContato.Nome;
            var idContato = firstContato.ContatoId;
            // Set Name
            firstContato.Nome = "Outro Nome";
            // save edited contact
            _contatoService.Update(firstContato);
            // 
            Assert.True(!beforeName.Equals(_contatoService.Get(idContato)));
        }
    }
}
