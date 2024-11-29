using AutoMapper;
using Moq;
using Shouldly;
using Study.CleanArchitecture.Application.Contracts.Persistence;
using Study.CleanArchitecture.Application.Features.LeaveType.Commands.CreateLeaveType;
using Study.CleanArchitecture.Application.MappingProfiles;
using Study.CleanArchitecture.Application.UnitTests.Mocks;

namespace Study.CleanArchitecture.Application.UnitTests.Features.LeaveTypes.Commands;

public class CreateleaveTypeCommandTests
{
    private readonly IMapper _mapper;
    private Mock<ILeaveTypeRepository> _mockRepo;

    public CreateleaveTypeCommandTests()
    {
        _mockRepo = MockLeaveTypeRepository.GetMockLeaveTypeRepository();

        var mapperConfig = new MapperConfiguration(c =>
        {
            c.AddProfile<LeaveTypeProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
    }

    [Fact]
    public async Task Handle_ValidLeaveType()
    {
        var handler = new CreateLeaveTypeCommandHandler(_mapper, _mockRepo.Object);

        await handler.Handle(new CreateLeaveTypeCommand()
        {
            Name = "Test1",
            DefaultDays = 1
        }, CancellationToken.None);

        var leaveTypes = await _mockRepo.Object.GetAsync();
        leaveTypes.Count.ShouldBe(4);
    }
}
