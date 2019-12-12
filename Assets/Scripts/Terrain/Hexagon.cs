using UnityEngine;

public static class Hexagon {

  /// <summary>
  /// The sides of the hexigon in order
  /// Named by cardinal directions
  /// </summary>
  public enum Sides { N, NE, SE, S, SW, NW}

  /// <summary>
  /// The vertexes of the hexigons in order
  /// Named by carinal direction
  /// </summary>
  public enum Vertexes { NW, NE, E, SE, SW, W}

  /// <summary>
  /// How many sides does a hexagon have
  /// </summary>
  public const int SideCount = 6;

  /// <summary>
  /// The legth of a hexagon side
  /// </summary>
  public const float SideLength = 0.25f;

  /// <summary>
  /// The diameter of the hexagons
  /// </summary>
  public const float Diameter = SideLength * 2;

  /// <summary>
  /// The offset values for axial coordinat hexagon neighbors
  /// </summary>
  public static Coordinate[] AxialOffests = {
    (0, -1),
    (1, -1),
    (1 , 0),
    (0, 1),
    (-1, 1),
    (-1, 0)
  };

  /// <summary>
  /// Get the opposite side of the hexagon
  /// </summary>
  /// <param name="side"></param>
  /// <returns></returns>
  public static Sides Opposite(Sides side) {
    switch (side) {
      case Sides.N:  return Sides.S;
      case Sides.NE: return Sides.SW;
      case Sides.SE: return Sides.NW;
      case Sides.S:  return Sides.N;
      case Sides.SW: return Sides.NE;
      case Sides.NW: return Sides.SE;
      default: throw new System.Exception("Invalid side");
    }
  }

  /// <summary>
  /// Get the neighnoring hexagon's location
  /// </summary>
  /// <param name="initlalLocation">the starting hexagon's location</param>
  /// <param name="direction">the side direction to move in</param>
  /// <param name="magnitude">how many hexagons to move in the given side direction</param>
  /// <returns></returns>
  public static Coordinate Move(Coordinate initlalLocation, Sides direction, int magnitude = 1) {
    return initlalLocation + AxialOffests[(int)direction] * magnitude;
  }

  /// <summary>
  /// Get the location of the given vertex for a hexagon centered on the given location
  /// </summary>
  /// <param name="hexagonCenterLocation"></param>
  /// <param name="vertex"></param>
  /// <returns></returns>
  public static Vector2 VertexLocation(Coordinate hexagonCenterLocation, Vertexes vertex) {
    switch (vertex) {
      case Vertexes.NW: return hexagonCenterLocation.Vec2 + new Vector2(-(SideLength / 2), SideLength);
      case Vertexes.NE: return hexagonCenterLocation.Vec2 + new Vector2(SideLength / 2, SideLength);
      case Vertexes.E:  return hexagonCenterLocation.Vec2 + new Vector2(SideLength, 0);
      case Vertexes.SE: return hexagonCenterLocation.Vec2 + new Vector2(SideLength / 2, -SideLength);
      case Vertexes.SW: return hexagonCenterLocation.Vec2 + new Vector2(-(SideLength / 2), -SideLength);
      case Vertexes.W:  return hexagonCenterLocation.Vec2 + new Vector2(-SideLength, 0);
      default: throw new System.Exception("Invalid vertex");
    }
  }
}