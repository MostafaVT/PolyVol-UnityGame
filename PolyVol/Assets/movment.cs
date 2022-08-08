using UnityEngine;

public class movment : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 MovmentDirection = new Vector3(xDirection, 0.0f, zDirection);
        transform.position += MovmentDirection;
    }
}
