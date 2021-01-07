using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2d;

    // need to use FixedUpdate for rigidbody
    void FixedUpdate()
    {
    // only let the local player control the racket.
    // don't control other player's rackets
    if (!isLocalPlayer)
    return;

    rigidbody2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.fixedDeltaTime;
    }
}
