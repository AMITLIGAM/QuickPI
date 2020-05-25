using Quik.Web.Curator;
using System.Web.Http;

namespace Quik.Web.API.Controllers
{
    public class TestController : ApiController
    {
        TestCurator testCurator;

        public TestController()
        {
            testCurator = new TestCurator();
        }
    }
}
