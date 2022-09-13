using Factory_01.Interfaces;

namespace Factory_01.Implements;

/// <summary>
/// Implements IChair
/// </summary>
public class VictorianChair : IChair
{
    /// <summary>
    /// Returns if is has legs
    /// </summary>
    /// <returns></returns>
    public bool hasLegs()
    {
        return true;
    }

    /// <summary>
    /// Sit on functinally
    /// </summary>
    public void sitOn()
    {
        throw new NotImplementedException();
    }
}