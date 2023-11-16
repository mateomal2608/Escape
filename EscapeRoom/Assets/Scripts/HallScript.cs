using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallScript : MonoBehaviour
{
    public ParticleSystem[] torchesHolder;
    

    public void Winner()
    {
        if (torchesHolder[0] != null && torchesHolder[1] != null)
        {
            ParticleSystem particleSystem1 = torchesHolder[0].GetComponent<ParticleSystem>();
            ParticleSystem particleSystem2 = torchesHolder[1].GetComponent<ParticleSystem>();

            if (particleSystem1 != null && particleSystem2 != null)
            {
                // Check if both particle systems are stopped
                if (!particleSystem1.isPlaying && !particleSystem2.isPlaying)
                {
                    // Call the Winner method if the conditions are met
                    Debug.Log("You win");
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
