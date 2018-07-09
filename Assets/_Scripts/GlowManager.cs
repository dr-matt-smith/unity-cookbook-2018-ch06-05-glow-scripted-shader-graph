using UnityEngine;

public class GlowManager : MonoBehaviour
{
	private bool glow = false;
	private string powerId = "Vector1_AA07C639";
	void Update () 
	{			
		if (Input.GetKeyDown("1"))
			glow = true;

		if (Input.GetKeyDown("2"))
			glow = false;

		UpdateGlow(glow);
	}

	private void UpdateGlow(bool isGlowing)
	{
		// default - not glowing
		float power = 0;

		if (isGlowing)
			power = 5;
		
		GetComponent<Renderer>().material.SetFloat(powerId, power);
	}
}
