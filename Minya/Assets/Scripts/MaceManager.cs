using UnityEngine;

public class MaceManager : MonoBehaviour
{
    private void Update()
    {
        Vector3 turn = new Vector3(0,0,200f);
        transform.Rotate(turn * Time.deltaTime);
    }
}
