using UnityEngine;

public class PickUp : MonoBehaviour
{
    public PowerUp PowerUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(PowerUp.HealthBonus + " " + PowerUp.ManaBonus);
            var visitables = other.GetComponents<IVisitable>();
            foreach (var visitable in visitables)
            {
                visitable.Accept(PowerUp);
                Destroy(gameObject);
            }
        }
    }
}