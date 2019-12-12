using System;
using System.Collections.Generic;

public class HexGrid {

  /// <summary>
  /// Tiles stores by hex axial coordinates.
  /// </summary>
  Dictionary<Coordinate, Tile> tiles;

  /// <summary>
  /// Get the tile at the given axial hex location
  /// </summary>
  /// <param name="location"></param>
  /// <returns></returns>
  public Tile get(Coordinate location) {
    Tile fetchedTile;
    tiles.TryGetValue(location, out fetchedTile);
    return fetchedTile;
  }

  /// <summary>
  /// Do something on each tile (in no particular order)
  /// </summary>
  /// <param name="action"></param>
  public void forEach(Action<Coordinate, Tile> action) {
    foreach (KeyValuePair<Coordinate, Tile> entry in tiles) {
      action(entry.Key, entry.Value);
    }
  }
}
