using System;
using System.Collections.Generic;
using UnityEngine;

class TerrainMeshGenerator {

  HexGrid tiles;

  List<int> triangles;

  public Mesh generate(HexGrid tiles) {
    // Hexes are generated in 'HexBlocks' six sided blocks.
    // Since many blocks will share sides, we determine the 
    // side tris and vers once (checking for collisions)
    // and them squash them all.
    var allHexagonSides = Enum.GetValues(typeof(Hexagon.Sides));

    // Generate each tile
    tiles.forEach((location, tile) => {
      byte hexBlockHeight = tile.height;

      // generate the sides of each tile
      foreach(Hexagon.Sides side in allHexagonSides) {
        Tile neighboringTile = tiles.get(Hexagon.Move(location, side));

        // we only need to generate a mesh for this side if the neighbor is shorter or empty
        if (neighboringTile.type == Tile.Types.Empty || neighboringTile.height < tile.height) {

        }
      }
    });
  }

  static Vector3[] GenerateVertsForHexBlockSide(Coordinate hexBlockCenter, Hexagon.Sides side, int bottomHeight, int topHeight) {
    Vector3[] verticies = new Vector3[4];
  }
}
