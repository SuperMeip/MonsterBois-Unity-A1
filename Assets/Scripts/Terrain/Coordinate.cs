/// <summary>
/// A tile position in a level
/// </summary>
public struct Coordinate {

  /// <summary>
  /// 0, 0 coordinate constant
  /// </summary>
  public static Coordinate Zero = (0, 0);

  /// <summary>
  /// east west
  /// </summary>
  public int x;

  /// <summary>
  /// north south
  /// </summary>
  public int y;

  /// <summary>
  /// If this coordinate is valid and was properly initialized
  /// </summary>
  public bool isInitialized {
    get;
    private set;
  }

  /// <summary>
  /// Create a 3d coordinate
  /// </summary>
  /// <param name="x"></param>
  /// <param name="y"></param>
  /// <param name="z"></param>
  public Coordinate(int x, int y) {
    this.x = x;
    this.y = y;
    isInitialized = true;
  }

  /// <summary>
  /// Create a coordinate from a touple.
  /// </summary>
  /// <param name="coordinates">(X, Z)</param>
  public static implicit operator Coordinate((int, int) coordinates) {
    return new Coordinate(coordinates.Item1, coordinates.Item2);
  }
}
