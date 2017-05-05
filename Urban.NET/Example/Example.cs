using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Urban.NET;

namespace Urban.NET.Example
{
    public class Example
    {
        public async Task<string> ExampleTask()
        {
            UrbanService client = new UrbanService();
            var data = await client.Data("Mom");
            var heart = data.List[0].Definition;
            return heart;
        }
    }
}
