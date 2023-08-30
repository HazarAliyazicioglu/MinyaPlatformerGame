using UnityEngine;

public class SawManager : MonoBehaviour
{
    public float damage = 10;

    private bool colliderBusy = false;

    private void Update()
    {
        Vector3 turn = new Vector3(0,0,2f);
        transform.Rotate(turn);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            other.GetComponent<PlayerManager>().GetDamage(damage);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            colliderBusy = false;
        }
    }
}
