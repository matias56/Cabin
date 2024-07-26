using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public GameObject fS;
    // Start is called before the first frame update
    void Start()
    {
        fS.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("s"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("d"))
        {
            footsteps();
        }

        if (Input.GetKeyUp("w"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("s"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("a"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("d"))
        {
            StopFootsteps();
        }

    }

    void footsteps()
    {
        fS.SetActive(true);
    }

    void StopFootsteps()
    {
        fS.SetActive(false);
    }
}
