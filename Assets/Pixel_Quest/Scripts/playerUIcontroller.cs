using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerUIcontroller : MonoBehaviour
{
    public Image heartImage;

    // Start is called before the first frame update
    public void Start()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    public void UpdateHealth(float currentHealth,float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
