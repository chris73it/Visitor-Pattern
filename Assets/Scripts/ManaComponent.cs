using UnityEngine;

public class ManaComponent : MonoBehaviour, IVisitable
{
    public int Mana = 100;

    public void Accept(IVisitor visitor)
    {
        Debug.Log("ManaComponent.Accept");
        visitor.Visit(this);
    }
}