using CQRSAndMediatR.Models;
using MediatR;

namespace CQRSAndMediatR.Queries
{
    public record GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
