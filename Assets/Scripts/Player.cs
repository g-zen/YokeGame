using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text scoreUI;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");

        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;

        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        scoreUI.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit!!!");

        if(collision.tag == "Renga")
        {
            // è·äQï®Ç…Ç†ÇΩÇ¡ÇΩÇ∆Ç´ÇÃèàóù
            gameOverUI.SetActive(true);
            Destroy(gameObject);
        }

        if(collision.tag == "Coin")
        {
            // ÉRÉCÉìÇ…ìñÇΩÇ¡ÇΩÇ∆Ç´ÇÃèàóù
            Debug.Log("Get Coin!!!");

            score = score + 1;
            Debug.Log(score);
        }
    }
}
