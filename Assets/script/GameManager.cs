using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnpoint;
    public float spawnrate;


    bool gamestarted = false;


    public GameObject taptext;
    public TextMeshProUGUI scoretext;

    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && ! gamestarted) 
        {
            spawingblocks();
            gamestarted = true;
            taptext.SetActive(false);
        }
    }

    private void spawingblocks() 
    {
        InvokeRepeating("spawnblock", 0.5f, spawnrate);
    }
    public void  spawnblock()
    {
        Vector3 spawnpos = spawnpoint.position;
        spawnpos.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnpos, Quaternion.identity);

        score++;
        scoretext.text = score.ToString();
    }
}
