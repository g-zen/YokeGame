using UnityEngine;

public class Renga : MonoBehaviour
{
    public Rigidbody2D rb;
    public float fallSpeed = 5f;

    void Update()
    {
        rb.velocity = Vector2.down * fallSpeed;
        if (transform.position.y < -8f)
        {
            Debug.Log("Falled!!");

            float pos_x = Random.Range(-6f, 6f);
            transform.position = new Vector2(pos_x, 8f);
        }
    }
}
