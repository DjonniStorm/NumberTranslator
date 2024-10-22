using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NumberTranslator.Exceptions;

[Serializable]
internal class IncorrectNumberSystem : ApplicationException
{
    public IncorrectNumberSystem(int count) : base("Некорректная система счисления: " + count) { }
    public IncorrectNumberSystem() : base() { }
    public IncorrectNumberSystem(string message) : base(message) { }
    public IncorrectNumberSystem(string message, Exception exception) : base(message, exception) { }
    protected IncorrectNumberSystem(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
}
