using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerstates : MonoBehaviour
{
    
    public int coinCount = 0;
    public int Health = 3;
    public Transform RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    string nextLevel = collision.GetComponent<LevelGoal>().nextLevel;
                    
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
                    Health --;
                    if (Health <= 0)
                    {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                        break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    
                    if (Health < 3)
                    {
                        Destroy(collision.gameObject);
                        Health++;
                    }
                    
                    break;
                }
            case "Respawn":
                {
                    RespawnPoint.position = collision.transform.Find("Point").position;
                    
                    break;
                }




        }
    }
}
