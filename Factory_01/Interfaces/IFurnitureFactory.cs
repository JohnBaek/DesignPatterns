namespace Factory_01.Interfaces;

/// <summary>
/// For Furniture Factory Interface
/// </summary>
public interface IFurnitureFactory
{
    /// <summary>
    /// Returns Chair 
    /// </summary>
    /// <returns></returns>
    IChair CreateChair();

    /// <summary>
    /// Returns CoffeeTable 
    /// </summary>
    /// <returns></returns>
    ICoffeeTable CreateCoffeeTable();
    
    /// <summary>
    /// Returns Sofa
    /// </summary>
    /// <returns></returns>
    ISofa CreateSofa();
}