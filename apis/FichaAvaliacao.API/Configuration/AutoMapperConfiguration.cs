
using AutoMapper;
using FichaAvaliacao.API.Application.Command;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {

            //CreateMap<AddADMCommand, ADM>();
            //CreateMap<UpdADMCommand, ADM>();
            //CreateMap<ADM, ADMDTO>();

            //CreateMap<AddAnamneseCommand, Anamnese>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdAnamneseCommand, Anamnese>()


            //CreateMap<Anamnese, AnamneseDTO>();

            CreateMap<AddCadastroCommand, Cadastro>();
            CreateMap<UpdCadastroCommand, Cadastro>();
            CreateMap<Cadastro, CadastroDTO>();

            //CreateMap<AddFichaCommand, Ficha>();
            //CreateMap<UpdFichaCommand, Ficha>();
            //CreateMap<Ficha, FichaDTO>();

            //CreateMap<AddEnderecoCommand, Endereco>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdEnderecoCommand, Endereco>()


            //CreateMap<Endereco, EnderecoDTO>();

            //CreateMap<AddObjetivosCondutasCommand, ObjetivosCondutas>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdObjetivosCondutasCommand, ObjetivosCondutas>()


            //CreateMap<ObjetivosCondutas, ObjetivosCondutasDTO>();

            //CreateMap<AddEvolucaoCommand, Evolucao>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdEvolucaoCommand, Evolucao>()


            //CreateMap<Evolucao, EvolucaoDTO>();

            //CreateMap<AddEstadoCommand, Estado>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.Status, m => m.MapFrom(e => 1))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdEstadoCommand, Estado>()


            //CreateMap<Estado, EstadoDTO>();

            //CreateMap<AddPaisCommand, Pais>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdPaisCommand, Pais>()


            //CreateMap<Pais, PaisDTO>();

            //CreateMap<AddExameFisicoCommand, ExameFisico>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdExameFisicoCommand, ExameFisico>()


            //CreateMap<ExameFisico, ExameFisicoDTO>();

            //CreateMap<AddMedicamentoCommand, Medicamento>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdMedicamentoCommand, Medicamento>()


            //CreateMap<Medicamento, MedicamentoDTO>();

            //CreateMap<AddProfissaoCommand, Profissao>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdProfissaoCommand, Profissao>()


            //CreateMap<Profissao, ProfissaoDTO>();

            //CreateMap<AddMusculoCommand, Musculo>()
            //    .ForMember(d => d.Id, m => m.MapFrom(e => Guid.NewGuid()))
            //    .ForMember(d => d.IdNumerico, m => m.MapFrom(e => (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond)));
            //CreateMap<UpdMusculoCommand, Musculo>()


            //CreateMap<Musculo, MusculoDTO>();

            CreateMap<AddAntecedentesFamiliaresCommand, AntecedentesFamiliares>();
            CreateMap<UpdAntecedentesFamiliaresCommand, AntecedentesFamiliares>();
            CreateMap<AntecedentesFamiliares, AntecedentesFamiliaresDTO>();

            CreateMap<AddAntecedentesPessoaisCommand, AntecedentesPessoais>();
            CreateMap<UpdAntecedentesPessoaisCommand, AntecedentesPessoais>();
            CreateMap<AntecedentesPessoais, AntecedentesPessoaisDTO>();

            CreateMap<AddAvaliacaoSubjetivaDorCommand, AvaliacaoSubjetivaDor>();
            CreateMap<UpdAvaliacaoSubjetivaDorCommand, AvaliacaoSubjetivaDor>();
            CreateMap<AvaliacaoSubjetivaDor, AvaliacaoSubjetivaDorDTO>();
        }
    }
}
