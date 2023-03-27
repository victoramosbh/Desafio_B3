using Api.Core.Business.Cdb.Calcular;
using Api.Core.DTOs;
using Api.Core.Mapping;
using AutoMapper;

namespace Test
{
    public class CdbTest
    {
        public IMapper _mapper { get; set; }

        public CdbTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new UserProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public async void Cdb_DeveCalcularCorretoComPrazo6()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = 20000, Prazo = 6 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Equal(21195.113540297963, investimentoResult.ValorBruto);
        }

        [Fact]
        public async void Cdb_DeveCalcularCorretoComPrazo12()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = 20000, Prazo = 10 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Equal(22031.272482865064, investimentoResult.ValorBruto);
        }

        [Fact]
        public async void Cdb_DeveCalcularCorretoComPrazo24()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = 20000, Prazo = 18 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Equal(23803.852517865344, investimentoResult.ValorBruto);
        }

        [Fact]
        public async void Cdb_DeveCalcularCorretoComPrazoMais24()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = 20000, Prazo = 36 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Equal(28331.169734614206, investimentoResult.ValorBruto);
        }

        [Fact]
        public async void Cdb_DeveValidarValorNegativo()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = -5000, Prazo = 36 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Contains("positivo", investimentoResult.Menssagem);

        }

        [Fact]
        public async void Cdb_DeveValidarPrazoResgate()
        {
            InvestimentoDto investimentoDto = new InvestimentoDto() { ValorInicial = 8000, Prazo = 1 };
            CalcularCdbRequest request = new CalcularCdbRequest(investimentoDto);
            InvestimentoDtoValidator validator = new InvestimentoDtoValidator();

            CalcularCdbHandler handler = new CalcularCdbHandler(validator, _mapper);
            var investimentoResult = await handler.Handle(request, new CancellationToken());

            Assert.Contains("maior que 1", investimentoResult.Menssagem);

        }
    }
}