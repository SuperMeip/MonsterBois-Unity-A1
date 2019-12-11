/// <summary>
/// A tile of terrain on a gameboard
/// </summary>
public partial struct Tile {

  /// <summary>
  /// The height of this tile
  /// </summary>
  public short height;

  /// <summary>
  /// The type of tile
  /// </summary>
  public Type type;

  /// <summary>
  /// Make a new tile of the desired type
  /// </summary>
  /// <param name="type"></param>
  /// <param name="height"></param>
  public Tile(Type type = null, short height = 0) {
    this.type   = type ?? Types.Empty;
    this.height = height;
  }
}