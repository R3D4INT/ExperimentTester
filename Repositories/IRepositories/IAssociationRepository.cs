using ExperimentTester.Models.Dto;

namespace ExperimentTester.Repositories.IRepositories
{
    public interface IAssociationRepository
    {
        Task<bool> InsertAssociation(Guid participantId, Guid experimentId);
        Task<List<ExperimentParticipantAssociationDto>> RetrieveAllAsync();
        Task<List<ExperimentParticipantAssociationDto>> RetrieveByParticipantAsync(Guid participantID);
        Task<ExperimentParticipantAssociationDto> RetrieveByExperimentAsync(Guid experimentID);
    }
}
