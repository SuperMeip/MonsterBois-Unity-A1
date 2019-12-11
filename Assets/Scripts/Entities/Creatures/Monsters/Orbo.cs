public partial struct Entity {
  public partial class Monster {

    /// <summary>
    /// Add this monster to the proper entity types
    /// </summary>
    public partial class Types {
      public static Type Orbo = new Orbo();
    }

    /// <summary>
    /// A basic orb shaped monster
    /// </summary>
    public class Orbo : Monster {
      internal Orbo() : base(1, "Orbo") { }
    }
  }
}