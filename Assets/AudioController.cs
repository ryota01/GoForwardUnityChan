using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    // 鳴らすSE
    public AudioClip block;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
            {
                // cubeとgroundに接触したら一回音を鳴らす
                AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.PlayOneShot(block);
            }
        }
    }
