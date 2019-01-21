using UnityEngine;

public class ParaCube : MonoBehaviour
{
    public int _band;
    public float scaleMultiplier;
    public float startScale;
    public bool useBuffer;

	void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (NewAudioPeer._bandBuffer[_band] * scaleMultiplier) + startScale, transform.localScale.z);
    }
}


