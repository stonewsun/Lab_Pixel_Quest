using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerstates : MonoBehaviour
{
    
    public int coinCount = 0;
    public int Health = 3;
    public int maxHealth = 3;
    public Transform RespawnPoint;
    private playerUIcontroller  _playerUIcontroller;
    // Start is called before the first frame update
    private void Start()
    {
        _playerUIcontroller = GetComponent<playerUIcontroller>();
        _playerUIcontroller.UpdateHealth(Health, maxHealth);
;    }

    // Update is called once per frame

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
                    _playerUIcontroller.UpdateHealth(Health,maxHealth);
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
                        Health++;
                        _playerUIcontroller.UpdateHealth(Health, maxHealth);
                        Destroy(collision.gameObject);
                        
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
