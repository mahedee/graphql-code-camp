using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL
{
    public record AddSpeakerInput(string Name,
        string Bio,
        string WebSite);
}
