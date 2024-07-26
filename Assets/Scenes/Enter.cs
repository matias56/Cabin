using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public FadeInOut fio;
    public AudioSource ads;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cabin"))
        {
            ads.Play();
            fio.FadeToLevel(3);
        }
        if (other.gameObject.CompareTag("Bed"))
        {
            
            fio.FadeToLevel(4);
        }
    }
}
