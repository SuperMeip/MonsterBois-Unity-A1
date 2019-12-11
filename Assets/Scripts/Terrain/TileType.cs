/// <summary>
/// Extentions for tile type singletons
/// </summary>
public partial struct Tile {

  /// <summary>
  /// Tile type singleton constants
  /// </summary>
  public static partial class Types {}

  /// <summary>
  /// The class pattern for a tile type
  /// </summary>
  public abstract class Type {

    /// <summary>
    /// The id of this tile type
    /// </summary>
    public short Id {
      get;
    }

    /// <summary>
    /// For making new types
    /// </summary>
    /// <param name="id"></param>
    protected Type(short id) {
      Id = id;
    }
  }
}
