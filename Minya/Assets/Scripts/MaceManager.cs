using UnityEngine;

public class MaceManager : MonoBehaviour
{
    private void Update()
    {
        Vector3 turn = new Vector3(0,0,0.8f);
        transform.Rotate(turn);
    }
}
