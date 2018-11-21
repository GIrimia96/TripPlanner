using AutoMapper;
using Cqrs.Service.Command;
using Cqrs.Service.CommandContracts;
using EnsureThat;
using Entity.Models;
using Repositories.Contracts;

namespace Cqrs.Service.CommandHandlers
{
    public class AddLocationCommandHandler : ICommandHandler<AddLocationCommand>
    {
        private readonly IBaseRepository<Location> _baseRepo;
        private readonly IMapper _mapper;

        public AddLocationCommandHandler(IBaseRepository<Location> baseRepository, IMapper mapper)
        {
            _baseRepo = baseRepository;
            _mapper = mapper;
        }

        public void Execute(AddLocationCommand command)
        {
            EnsureArg.IsNotNull(command);
            var location = new Location
            {
                Id = command.Location.Id,
                Country = command.Location.Country,
                Name = command.Location.Name
                //Trips = command.Location.Trips
            };

            _mapper.Map(command.Location, location);
            _baseRepo.Add(location);
            _baseRepo.Save();
        }
    }
}
