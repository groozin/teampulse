using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace TeamPulseTests
{
    public class TeamPulseTests
    {
        [Fact]
        public void CurrentTeamMemberGetsProcessed()
        {
            var repo = new Mock<ITeamMemberRepository>();
            var processor = new Mock<ITeamPulseProcessor>();
            var teamMember = new TeamMember();

            TeamPulseCreator system = new TeamPulseCreator(repo.Object, processor.Object);
            system.Process(2016, 4);


        }
    }

    public class TeamPulseCreator
    {
        public TeamPulseCreator(ITeamMemberRepository repo, ITeamPulseProcessor processor)
        {
            throw new NotImplementedException();
        }

        public TeamPulse Process(int year, int week)
        {
            throw new NotImplementedException();
        }
    }

    public class TeamPulse
    {
        
    }

    public interface ITeamMemberRepository
    {

    }

    public interface ITeamPulseProcessor
    {

    }

    public class TeamMember
    {

    }
}
