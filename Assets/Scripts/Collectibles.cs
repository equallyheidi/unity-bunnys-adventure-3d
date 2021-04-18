using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
	public AudioSource collected;
	bool m_HasAudioPlayed;
	

	void Update()
	{
		
		transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
		BunnyMovement bunny = other.GetComponent<BunnyMovement>();

	
		if (bunny != null)
        {
			collected.Play();
			Destroy(gameObject);
			SaladManager.score += 1;
        }
		if (SaladManager.score == 10)
        {
			GameObject.Find("GameEnd").GetComponent<GameEnding>().Win();

		}
	}
	
}
