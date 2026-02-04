using UnityEngine;

public class PuffScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.Instance.PlaySFX(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PuffDestroy()
    {
        Destroy(gameObject);
    }
}
