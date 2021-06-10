using GraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL
{
    public class AddSpeakerPayload
    {
        public Speaker Speaker { get; }
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }
    }
}
