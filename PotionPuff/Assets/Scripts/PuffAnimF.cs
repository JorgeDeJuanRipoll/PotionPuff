using UnityEngine;

public class PuffAnimF : MonoBehaviour
{
    public GameObject Puff;
    public Transform PuffTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Puff, PuffTransform);
        Destroy(gameObject,0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
