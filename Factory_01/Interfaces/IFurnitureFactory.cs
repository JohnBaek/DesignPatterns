namespace Factory_01.Interfaces;

/// <summary>
/// For Furniture Factory Interface
/// </summary>
public interface IFurnitureFactory
{
    /// <summary>
    /// Returns IChair 
    /// </summary>
    /// <returns></returns>
    IChair CreateChair();
}