using Diamonds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds.Test
{
    public class DiamondLineServiceShould
    {
        private readonly DiamondLineService  _lineService = new DiamondLineService();
        [Fact]
        public void CreateLines()
        {
            var expected =new List<string>
            {
                "  A\n",
               " B B\n",
               " B B\n",
               "  A\n"
            };
            var lines = _lineService.CreateLines('B');
            Assert.Equal(expected, lines.Select(x => x.ToString()).ToList());
        }
    }
}
