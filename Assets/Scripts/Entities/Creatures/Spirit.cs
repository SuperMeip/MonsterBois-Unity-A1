﻿
using System.Collections.Generic;

/// <summary>
/// A capturable in-game monster
/// </summary>
public partial class Spirit : Creature {

  /// <summary>
  /// A species of capturable monster in the game
  /// </summary>
  public abstract partial class Species : Creature.Type {

    /// <summary>
    /// Base for making a new species
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    protected Species(int id, string name) : base(id, name) {

      // add to monster singleton too
      Types.Add(this);
    }
  }

  /// <summary>
  /// Constant for spirit species entity types
  /// The Zoonomicon
  /// </summary>
  public static partial class Encyclopeidia {
    /// <summary>
    /// All registered types as an ordered array
    /// </summary>
    public static Type[] All {
      get {
        Type[] types = new Type[all.Count];
        all.Values.CopyTo(types, 0);
        return types;
      }
    }

    /// <summary>
    /// The dictionary of type values
    /// </summary>
    static SortedDictionary<int, Type> all = new SortedDictionary<int, Type>();

    /// <summary>
    /// Get a type by it's id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Type Get(int id) {
      return all[id];
    }

    /// <summary>
    /// Add a type to the list of all types
    /// </summary>
    /// <param name="type"></param>
    internal static void Add(Type type) {
      if (all.ContainsKey(type.Id)) {
        throw new System.Exception("Attempted to register a new Monster Species with an existing type's Id");
      } else {
        all.Add(type.Id, type);
      }
    }
  }
}