using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // �����_���Ȉʒu�ɃR�C�����ړ�������
            transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        }
    }
}
