using MediatR;

namespace CQRSAndMediatR.Commands
{
    public record DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
