using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NumberTranslator.Exceptions;

[Serializable]
internal class InvalidSymbolException : ApplicationException
{
    public InvalidSymbolException(int count) : base("Некорректный символ: " + count) { }
    public InvalidSymbolException() : base() { }
    public InvalidSymbolException(string message) : base(message) { }
    public InvalidSymbolException(string message, Exception exception) : base(message, exception) { }
    protected InvalidSymbolException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
}
