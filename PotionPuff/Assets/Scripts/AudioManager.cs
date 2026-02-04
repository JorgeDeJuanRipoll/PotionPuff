using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager Instance;

	[Header("Audio Clip Arrays")]
	public AudioClip[] musicList;
	public AudioClip[] sfxList;

	[Header("Audio Source References")]
	[SerializeField] AudioSource musicSource;
	[SerializeField] AudioSource sfxSource;

	private void Awake()
	{

		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}

		else
		{
			Destroy(gameObject);
		}
	}


	public void PlayMusic(int musicIndex)
	{
		musicSource.clip = musicList[musicIndex];
		musicSource.Play();
	}
	//Este es para la música

	public void PlaySFX(int sfxIndex)
	{
		sfxSource.PlayOneShot(sfxList[sfxIndex]);
	}
    //Este es para los sonidos

    void Start()
    {
		AudioManager.Instance.PlayMusic(0); 
    }
}
	