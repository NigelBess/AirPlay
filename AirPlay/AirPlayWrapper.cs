
using System;

namespace AirPlay;

public class AirPlayWrapper
{
    public Action<byte[]> OnDataReceived { get; set; }
    public AirPlayWrapper(string discoverableName)
    { 
    
    }
}
