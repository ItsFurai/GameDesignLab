using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip coin1;
    public AudioClip coin2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.Score++;
            AudioManager.instance.PlayMusicSFX(coin1);
            Debug.Log("Score: " + PlayerStats.Score);
            Destroy(gameObject);

        }
    }
}
