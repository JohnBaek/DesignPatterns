namespace Factory_01.Interfaces;

/// <summary>
/// For Chair Interface
/// </summary>
public interface ICoffeeTable
{
    /// <summary>
    /// Returns if is has legs
    /// </summary>
    /// <returns></returns>
    bool hasLegs();

    /// <summary>
    /// Sit on functinally
    /// </summary>
    void sitOn();
}