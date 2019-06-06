using UnityEngine;

public class DuckFollow : MonoBehaviour
{

    public Transform player;
    // Vector3 stores 3 floats
    // offset will give us oppurtunity to change camera position (not first person view)
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {

        // camera will only follow the position of the player (not rotate with him)
        // camera transform("movement", scale, x, y, z) will follow the player position
        // + offset, because then it will still follow the player on the new position
        transform.position = player.position + offset;
    }
}