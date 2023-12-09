using UnityEngine;

public class HealthComponent : MonoBehaviour, IVisitable
{
    public int Health = 100;

    public void Accept(IVisitor visitor)
    {
        Debug.Log("HealthComponent.Accept");
        visitor.Visit(this);
    }
}
