using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    private AudioSource music;

    public bool isNotPlay;
    
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.volume = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNotPlay)
        {
            if (music.volume <= 0.1f)
            {
                Destroy(this.gameObject);
                isNotPlay = false;
            }
            else
            {
                float newVolume = music.volume - (1f * Time.deltaTime);  //change 0.01f to something else to adjust the rate of the volume dropping
                if (newVolume < 0f)
                {
                    newVolume = 0f;
                    
                }
                music.volume = newVolume;
            }
        }
    }

    public void PlayerMusic()
    {
        isNotPlay = false;
        music.volume = 1f;
        music.Play();
    }

    public void FadeOutMusic()
    {
        isNotPlay = true;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerMusic();
               
                
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            FadeOutMusic();

            
            
        }
    }
}
