using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public int HealthBonus = 10; // default value
    public int ManaBonus = 10; // default value

    // All the visit functions below work like a virtual table

    public void Visit(HealthComponent healthComponenet)
    {
        Debug.Log("PowerUp.Visit(HealthComponent)");
        healthComponenet.Health += HealthBonus;
    }

    public void Visit(ManaComponent manaComponenet)
    {
        Debug.Log("PowerUp.Visit(ManaComponent)");
        manaComponenet.Mana += ManaBonus;
    }
}
