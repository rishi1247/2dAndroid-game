using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{

    public float movespeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchpos.x < 0)
            {
                rb.linearVelocity = Vector2.left * movespeed;
            }
            else 
            {
                rb.linearVelocity =Vector2.right * movespeed;
            }
        }
        else 
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block") 
        {
            SceneManager.LoadScene("Game");
        }
    }
}

